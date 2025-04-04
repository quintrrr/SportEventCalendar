using System;
using System.Data;
using SportEventCalendar.Classes;
using static System.Net.WebRequestMethods;


namespace SportEventCalendar
{
    public partial class EventViewerWindow : Form
    {

        private Event currentEvent;
        public EventViewerWindow(Event selectedEvent)
        {
            InitializeComponent();
            this.currentEvent = selectedEvent;
            EventName.Text = currentEvent.Name;
            EventDescription.Text = currentEvent.Description;
            startDate.Text = currentEvent.Start_date.ToString("yyyy-MM-dd HH:mm");
            finishDate.Text = currentEvent.End_date.ToString("yyyy-MM-dd HH:mm");
            timePicker.Text = currentEvent.Time.ToString(@"hh\:mm");
            sportName.Text = currentEvent.Sport_name;
            pictureBox.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(
                currentEvent.Image_url)));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<Sport> GetSports()
        {
            using (var context = new DatabaseHelper())
            {
                return context.Sports.ToList();
            }
        }
        private void EventViewerWindow_Load(object sender, EventArgs e)
        {
            sportSelector.DataSource = GetSports();
            sportSelector.DisplayMember = "name";
            sportSelector.ValueMember = "sport_number";
            teamSelectorCheckBox.Items.Clear();
            var teams = GetTeams();

            foreach (var row in teams.Where(team => team.sport_number ==
                ((Sport)sportSelector.Items[0]).Sport_number))
            {
                teamSelectorCheckBox.Items.Add(row.name);
            }

        }


        private void editButton_Click(object sender, EventArgs e)
        {
            
            imageButton.Visible = true;
            panel2.Visible = true;
            panel1.Visible = false;
            cancel2Button.Visible = true;
            saveButton.Visible = true;
            editButton.Visible = false;
            EventDescription.ReadOnly = false;
            EventName.ReadOnly = false;

        }

        private void cancel2Button_Click(object sender, EventArgs e)
        {
            imageButton.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            cancel2Button.Visible = false;
            editButton.Visible = true;
            saveButton.Visible = false;
            EventDescription.ReadOnly = true;
            EventName.ReadOnly = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cancel1Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseHelper())
            {
                context.Events.Remove(currentEvent);
                context.SaveChanges();
                this.Close();
            }
        }

        public List<Team> GetTeams()
        {
            using (var context = new DatabaseHelper())
            {
                return context.Teams.ToList();
            }
        }
        private void sportSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sportSelector.SelectedValue == null)
            {
                return;
            }

            if (!int.TryParse(sportSelector.SelectedValue.ToString(), out int selectedSportId))
            {
                return;
            }

            var teams = GetTeams();
            teamSelectorCheckBox.Items.Clear();
            teamSelectorCheckBox.DisplayMember = "name";
            teamSelectorCheckBox.ValueMember = "sport_id";
            foreach (var row in teams.Where(team => team.sport_number == selectedSportId))
            {
                teamSelectorCheckBox.Items.Add(row);
            }
        }
    }
}
