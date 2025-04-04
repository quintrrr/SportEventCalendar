using System;
using SportEventCalendar.Classes;
using System.Data;
using System.Windows.Forms;
using SportEventCalendar.Properties;
using static System.ComponentModel.Design.ObjectSelectorEditor;


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
            noSport.Name = string.Empty;
            noSport.Sport_number = 0;
            var sportList = GetSports();
            sportList.Add(noSport);
            sportList = sportList.OrderBy(s => s.Sport_number).ToList();

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
            var events = GetSportEvents();

            dataGridView.DataSource = events;
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
            List<Event> sortedSportEvents = GetSportEvents();
            var selectedSportNumber = ((Sport)sportSelector.SelectedItem).Sport_number;
            if (selectedSportNumber != 0)
            {
                 sortedSportEvents = sortedSportEvents
                    .Where(sportEvent => sportEvent.Sport_number == selectedSportNumber)
                    .ToList();
            }

            sortedSportEvents = sortedSportEvents
                   .Where(sportEvent => sportEvent.End_date <= finishDate.Value.ToUniversalTime().AddDays(1))
                   .Where(sportEvent => sportEvent.Start_date >= startDate.Value.ToUniversalTime().AddDays(-1))
                   .ToList();


            dataGridView.DataSource = sortedSportEvents;
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

        private void AddButtom_Click(object sender, EventArgs e)
        {
            var creationWindow = new NewEventCreationWindow();
            creationWindow.ShowDialog();
            Refresh_Click();
        }

    }
}
