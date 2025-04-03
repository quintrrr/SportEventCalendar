using System;
using SportEventCalendar.Classes;
using System.Data;
using System.Windows.Forms;
using SportEventCalendar.Properties;


namespace SportEventCalendar
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            
            if (dataGridView1.Columns["Actions"] == null)
            {
                var actionsColumn = new DataGridViewButtonColumn();
                actionsColumn.Name = "Actions";
                actionsColumn.HeaderText = string.Empty;
                actionsColumn.Text = "⋮";
                actionsColumn.UseColumnTextForButtonValue = true;
                actionsColumn.Width = 50;
                dataGridView1.Columns.Add(actionsColumn);
            }
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Refresh_Click();
        }
        

        public List<Event> GetSportEvents()
        {
            using (var context = new DatabaseHelper())
            {
                return context.Events.ToList();
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
            var sports = GetSports();
            dataGridView1.DataSource = events + sports;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["description"].Visible = false;
            dataGridView1.Columns["image_url"].Visible = false;

            dataGridView1.Columns["name"].HeaderText = "Название";
            dataGridView1.Columns["name"].DisplayIndex = 0;

            dataGridView1.Columns["start_date"].DisplayIndex = 1;
            dataGridView1.Columns["start_date"].HeaderText = "Дата начала";

            dataGridView1.Columns["end_date"].DisplayIndex = 2;
            dataGridView1.Columns["end_date"].HeaderText = "Дата конца";

            dataGridView1.Columns["time"].DisplayIndex = 3;
            dataGridView1.Columns["time"].HeaderText = "Время";

            dataGridView1.Columns["sport_number"].DisplayIndex = 4;
            //dataGridView1.Columns["sport_number"].
            dataGridView1.Columns["sport_number"].HeaderText = "Категория";




        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Actions"].Index)
            {
                var selectedEvent = (Event)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                var viewerWindow = new EventViewerWindow(selectedEvent);
                viewerWindow.ShowDialog();

            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {

        }

        private void AddButtom_Click(object sender, EventArgs e)
        {
            var creationWindow = new NewEventCreationWindow();
            creationWindow.ShowDialog();
            Refresh_Click();
        }

    }
}
