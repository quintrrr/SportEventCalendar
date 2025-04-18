using SportEventCalendar.Classes;
using System.Data;
using SportEventCalendar.Properties;

namespace SportEventCalendar
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            if (dataGridView.Columns["Actions"] == null)
            {
                var actionsColumn = new DataGridViewButtonColumn();
                actionsColumn.Name = "Actions";
                actionsColumn.HeaderText = string.Empty;
                actionsColumn.Text = "⋮";
                actionsColumn.UseColumnTextForButtonValue = true;
                actionsColumn.Width = 50;
                

                dataGridView.Columns.Add(actionsColumn);
            }
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Refresh_Click();
            var noSport = new Sport();
            noSport.Name = "Все виды спорта";
            noSport.Sport_number = 0;
            var sportList = GetSports();
            sportList.Add(noSport);
            sportList = sportList.OrderBy(sport => sport.Sport_number).ToList();

            sportSelector.DataSource = sportList;
            sportSelector.DisplayMember = "name";
            sportSelector.ValueMember = "sport_number";
        }


        public List<Event> GetSportEvents()
        {
            using (var context = new DatabaseHelper())
            {
                return context.Events
                .Join(context.Sports,
                    sportEvent => sportEvent.Sport_number,
                    sport => sport.Sport_number,
                    (sportEvent, sport) => new Event(
                        sportEvent.Id,
                        sportEvent.Name,
                        sportEvent.Description,
                        sportEvent.Start_date,
                        sportEvent.End_date,
                        sportEvent.Sport_number,
                        sportEvent.Time,
                        sportEvent.Image_url,
                        sport.Name)
                ).ToList();
            }
        }
        public List<Sport> GetSports()
        {
            using (var context = new DatabaseHelper())
            {
                return context.Sports.ToList();
            }
        }
        private void Refresh_Click()
        {
            this.Cursor = Cursors.WaitCursor;
            this.Enabled = false;
            var events = GetSportEvents();

            dataGridView.DataSource = events;
            ConfigureDataGridViewColumns();
            this.Cursor = Cursors.Default;
            this.Enabled = true;

        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns["Actions"].Index)
            {
                var selectedEvent = (Event)dataGridView.Rows[e.RowIndex].DataBoundItem;

                var viewerWindow = new EventViewerWindow(selectedEvent);
                viewerWindow.ShowDialog();
                Refresh_Click();

            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.Enabled = false;
            var sortedSportEvents = GetSportEvents();
            sortedSportEvents = sortedSportEvents
                   .Where(sportEvent => sportEvent.End_date <= finishDate.Value.ToUniversalTime().AddDays(1)
                   && sportEvent.Start_date >= startDate.Value.ToUniversalTime().AddDays(-1))
                   .ToList();


            dataGridView.DataSource = sortedSportEvents;
            ConfigureDataGridViewColumns();
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void AddButtom_Click(object sender, EventArgs e)
        {
            var creationWindow = new NewEventCreationWindow();
            creationWindow.ShowDialog();
            sportSelector.SelectedIndex = 0;
            startDate.Value = DateTime.Now;
            finishDate.Value = DateTime.Now;
            Refresh_Click();
        }

        private void reportButtom_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "Отчет.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("События");

                            var row = 1;
                            var actualCol = 1;

                            for (var column = 0; column < dataGridView.Columns.Count; column++)
                            {
                                var columnName = dataGridView.Columns[column].Name;
                                if (columnName != "Actions" && columnName != "Sport_number")
                                {
                                    if (columnName == "Image_url")
                                    {
                                        columnName = "Изображение";
                                    }
                                    else if (columnName == "Id")
                                    {
                                        columnName = "Идентификатор";
                                    }
                                    else if(columnName == "Description")
                                    {
                                        columnName = "Описание";
                                    }
                                    else
                                    {
                                        columnName = dataGridView.Columns[column].HeaderText;
                                    }
                                        worksheet.Cell(row, actualCol).Value = columnName;
                                    actualCol++;
                                }
                            }

                            foreach (DataGridViewRow dataGridViewRow in dataGridView.Rows)
                            {
                                if (!dataGridViewRow.IsNewRow)
                                {
                                    row++;
                                    var id = dataGridViewRow.Cells["Id"].Value?.ToString() ?? string.Empty;
                                    var name = dataGridViewRow.Cells["Name"].Value?.ToString() ?? string.Empty;
                                    var description = dataGridViewRow.Cells["Description"].Value?.ToString() ?? string.Empty;
                                    var startDate = dataGridViewRow.Cells["Start_date"].Value?.ToString() ?? string.Empty;
                                    var endDate = dataGridViewRow.Cells["End_date"].Value?.ToString() ?? string.Empty;
                                    var time = dataGridViewRow.Cells["Time"].Value?.ToString() ?? string.Empty;
                                    var imageUrl = dataGridViewRow.Cells["Image_url"].Value?.ToString();
                                    var sportName = dataGridViewRow.Cells["Sport_name"].Value?.ToString() ?? string.Empty;

                                    worksheet.Cell(row, 1).Value = id;           
                                    worksheet.Cell(row, 2).Value = name;         
                                    worksheet.Cell(row, 3).Value = description;  
                                    worksheet.Cell(row, 4).Value = startDate;    
                                    worksheet.Cell(row, 5).Value = endDate;      
                                    worksheet.Cell(row, 6).Value = time;         
                                    if (!string.IsNullOrEmpty(imageUrl))
                                    {
                                        try
                                        {
                                            var imageBytes = Convert.FromBase64String(imageUrl);

                                            using (var ms = new MemoryStream(imageBytes))
                                            {
                                                var cell = worksheet.Cell(row, 7);
                                                worksheet.Row(row).Height = 75;
                                                worksheet.Column(7).Width = 18;

                                                var picture = worksheet.AddPicture(ms, $"Image_{row}_{7}.png")
                                                                       .MoveTo(cell)
                                                                       .WithSize(100, 100);
                                            }
                                        }
                                        catch (FormatException)
                                        {
                                            worksheet.Cell(row, 7).Value = "[Неверный формат Base64]";
                                        }
                                        catch (IOException)
                                        {
                                            worksheet.Cell(row, 7).Value = "[Ошибка вставки изображения]";
                                        }
                                        catch (Exception)
                                        {
                                            worksheet.Cell(row, 7).Value = "[Ошибка изображения]";
                                        }
                                    }
                                    worksheet.Cell(row, 8).Value = sportName;
                                }
                            }


                            worksheet.Columns().AdjustToContents();

                            workbook.SaveAs(saveFileDialog.FileName);
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show(Resources.reportCreatingError,
                            Resources.errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void sportSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.Enabled = false;
            var sortedSportEvents = GetSportEvents();
            var selectedSportNumber = ((Sport)sportSelector.SelectedItem).Sport_number;
            if (selectedSportNumber != 0)
            {
                sortedSportEvents = sortedSportEvents
                   .Where(sportEvent => sportEvent.Sport_number == selectedSportNumber)
                   .ToList();
            }
            dataGridView.DataSource = sortedSportEvents;
            ConfigureDataGridViewColumns();
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void ConfigureDataGridViewColumns()
        {
            dataGridView.AutoGenerateColumns = false;

            dataGridView.Columns["id"].Visible = false;
            dataGridView.Columns["description"].Visible = false;
            dataGridView.Columns["image_url"].Visible = false;
            dataGridView.Columns["sport_number"].Visible = false;

            dataGridView.Columns["name"].HeaderText = "Название";
            dataGridView.Columns["name"].DisplayIndex = 0;

            dataGridView.Columns["start_date"].DisplayIndex = 1;
            dataGridView.Columns["start_date"].HeaderText = "Дата начала";

            dataGridView.Columns["end_date"].DisplayIndex = 2;
            
            dataGridView.Columns["end_date"].HeaderText = "Дата конца";

            dataGridView.Columns["time"].DisplayIndex = 3;
            dataGridView.Columns["time"].HeaderText = "Время";

            dataGridView.Columns["sport_name"].DisplayIndex = 4;
            dataGridView.Columns["sport_name"].HeaderText = "Вид спорта";
        }


        private void reportButtom_Click_1(object sender, EventArgs e)
        {
            sportSelector.SelectedIndex = 0;
            startDate.Value = DateTime.Now;
            finishDate.Value = DateTime.Now;
            Refresh_Click();

        }
    }
}
