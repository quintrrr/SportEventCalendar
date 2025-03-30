using System.Data;
using System.Windows.Forms;
using Npgsql;
using SportEventCalendar.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace SportEventCalendar
{
    public partial class NewEventCreationWindow : Form
    {

        public NewEventCreationWindow()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.tif)|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

        }

        private void NewEventCreationWindow_Load(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            DataTable sports = databaseHelper.ExecuteQuery("SELECT * FROM sports");
            sportSelector.DataSource = sports;
            sportSelector.DisplayMember = "name";
            sportSelector.ValueMember = "id";
        }

        private void cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            if (newEventName.Text == string.Empty || NewEventDescription.Text == string.Empty || sportSelector.SelectedValue == null || openFileDialog1.FileName == "openFileDialog1")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DatabaseHelper db = new DatabaseHelper();
            int selectedSportId;
            if (!int.TryParse(sportSelector.SelectedValue.ToString(), out selectedSportId))
                return;
            string insertQuery = "INSERT INTO events (name,description, start_date, end_date,sport_id, time,image_url) VALUES (@name,@description, @start_date, @end_date,@sport_id, @time,@image_url)";
            db.ExecuteNonQuery(insertQuery,
                new NpgsqlParameter("@name", newEventName.Text),
                new NpgsqlParameter("@description", NewEventDescription.Text),
                new NpgsqlParameter("@start_date", startDate.Value),
                new NpgsqlParameter("@end_date", finishDate.Value),
                new NpgsqlParameter("@sport_id", selectedSportId),
                new NpgsqlParameter("@time", timePicker.Value),
                new NpgsqlParameter("@image_url", openFileDialog1.FileName)
            );
           
            this.Close();
        }

        private void sportSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sportSelector.SelectedValue == null) return;

            int selectedSportId;
            if (!int.TryParse(sportSelector.SelectedValue.ToString(), out selectedSportId))
                return;

            DatabaseHelper databaseHelper = new DatabaseHelper();
            DataTable teams = databaseHelper.ExecuteQuery("SELECT id, name FROM teams WHERE sport_id = @sport_id",
                new NpgsqlParameter("@sport_id", selectedSportId));

            checkedListBox1.Items.Clear();

            foreach (DataRow row in teams.Rows)
            {
                checkedListBox1.Items.Add(row["name"]);
            }
        }
    }
}
