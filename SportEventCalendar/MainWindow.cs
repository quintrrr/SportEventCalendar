using System;
using SportEventCalendar.Classes;
using System.Data;


namespace SportEventCalendar
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {

            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            refreshFunc();
        }

        private void сОЗДАТЬToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEventCreationWindow create = new NewEventCreationWindow();
            create.ShowDialog();
            refreshFunc();
        }

        private void пОСМОТРЕТЬToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventViewerWindow view = new EventViewerWindow();
            view.ShowDialog();
            refreshFunc();

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            refreshFunc();
        }

        private void refreshFunc()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            DataTable events = databaseHelper.ExecuteQuery(@"
        SELECT events.id, events.name, events.description, 
               events.start_date, events.end_date, 
               sports.name AS sport_name, 
               events.time, events.image_url
        FROM events
        JOIN sports ON events.sport_id = sports.id");
            dataGridView1.DataSource = events;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["description"].Visible = false;
            dataGridView1.Columns["image_url"].Visible = false;

            dataGridView1.Columns["name"].DisplayIndex = 0;          
            dataGridView1.Columns["start_date"].DisplayIndex = 1;    
            dataGridView1.Columns["end_date"].DisplayIndex = 2;      
            dataGridView1.Columns["time"].DisplayIndex = 3;
            dataGridView1.Columns["sport_name"].DisplayIndex = 4;


            if (dataGridView1.Columns["Actions"] == null)
            {
                DataGridViewButtonColumn actionsColumn = new DataGridViewButtonColumn();
                actionsColumn.Name = "Actions";
                actionsColumn.HeaderText = "";
                actionsColumn.Text = "...";
                actionsColumn.UseColumnTextForButtonValue = true;
                actionsColumn.Width = 50;
                dataGridView1.Columns.Add(actionsColumn);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EventViewerWindow detailsWindow = new EventViewerWindow();
            detailsWindow.ShowDialog();
           
        }

    }
}
