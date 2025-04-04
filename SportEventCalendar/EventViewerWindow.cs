using System;
using System.Data;
using SportEventCalendar.Classes;
using SportEventCalendar.Properties;
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

            openFileDialog.FileName = string.Empty;
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
            sportSelector.SelectedValue = currentEvent.Sport_number;
            sportName.Text = sportSelector.Text;
            teamSelectorCheckBox.Items.Clear();
            var teams = GetTeams();

            if (!int.TryParse(sportSelector.SelectedValue.ToString(), out int selectedSportId))
            {
                return;
            }
            foreach (var row in teams.Where(team => team.Sport_number == selectedSportId))
            {
                teamSelectorCheckBox.Items.Add(row.Name);
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
            deleteButton.Visible = false;
            cancel1Button.Visible = false;

            startDate.Enabled = true;
            finishDate.Enabled = true;
            timePicker.Enabled = true;

        }

        private void cancel2Button_Click(object sender, EventArgs e)
        {
            EventName.Text = currentEvent.Name;
            EventDescription.Text = currentEvent.Description;
            startDate.Text = currentEvent.Start_date.ToString("yyyy-MM-dd HH:mm");
            finishDate.Text = currentEvent.End_date.ToString("yyyy-MM-dd HH:mm");
            timePicker.Text = currentEvent.Time.ToString(@"hh\:mm");
            sportName.Text = currentEvent.Sport_name;
            sportSelector.SelectedValue = currentEvent.Sport_number;
            pictureBox.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(
                currentEvent.Image_url)));

            imageButton.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            cancel2Button.Visible = false;
            editButton.Visible = true;
            saveButton.Visible = false;
            EventDescription.ReadOnly = true;
            EventName.ReadOnly = true;
            deleteButton.Visible = true;
            cancel1Button.Visible = true;
            startDate.Enabled = false;
            finishDate.Enabled = false;
            timePicker.Enabled = false;
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
            foreach (var row in teams.Where(team => team.Sport_number == selectedSportId))
            {
                teamSelectorCheckBox.Items.Add(row);
            }
        }

        private bool IsImageValid(string filePath)
        {
            try
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    var img = Image.FromStream(stream);
                    return img.Width > 0 && img.Height > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.tif)" +
                "|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            if (IsImageValid(openFileDialog.FileName))
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show(Resources.imageError, Resources.errorTitle,
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                openFileDialog.FileName = string.Empty;
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseHelper())
            {
                var eventToUpdate = context.Events.FirstOrDefault(ev => ev.Id == currentEvent.Id);

                if (EventName.Text == string.Empty)
                {
                    MessageBox.Show(Resources.fillName, Resources.errorTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (openFileDialog.FileName == string.Empty && currentEvent.Image_url == string.Empty)
                {
                    MessageBox.Show(Resources.addImage, Resources.errorTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (teamSelectorCheckBox.CheckedItems.Count == 0)
                {
                    MessageBox.Show(Resources.selectTeams, Resources.errorTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (finishDate.Value.ToUniversalTime() < startDate.Value.ToUniversalTime())
                {
                    MessageBox.Show(Resources.dateError, Resources.errorTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(sportSelector.SelectedValue.ToString(), out int selectedSportId))
                {
                    return;
                }
                if (openFileDialog.FileName != string.Empty)
                {
                    string base64 = Convert.ToBase64String(System.IO.File.ReadAllBytes(openFileDialog.FileName));
                    eventToUpdate.Image_url = base64;
                }


                eventToUpdate.Name = EventName.Text;
                eventToUpdate.Description = EventDescription.Text;
                eventToUpdate.Start_date = startDate.Value.ToUniversalTime();
                eventToUpdate.End_date = finishDate.Value.ToUniversalTime();
                eventToUpdate.Time = TimeSpan.Parse(timePicker.Value.TimeOfDay.ToString(@"hh\:mm\:ss"));
                eventToUpdate.Sport_number = selectedSportId;

                context.SaveChanges();
                imageButton.Visible = false;
                panel1.Visible = true;
                panel2.Visible = false;
                cancel2Button.Visible = false;
                editButton.Visible = true;
                saveButton.Visible = false;
                EventDescription.ReadOnly = true;
                EventName.ReadOnly = true;
                deleteButton.Visible = true;
                cancel1Button.Visible = true;
                startDate.Enabled = false;
                finishDate.Enabled = false;
                timePicker.Enabled = false;
                sportName.Text = sportSelector.Text;
            }
        }
    }
}
