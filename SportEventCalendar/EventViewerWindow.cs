using System;
using System.Data;
using System.Diagnostics.Tracing;
using SportEventCalendar.Classes;
using SportEventCalendar.Properties;


namespace SportEventCalendar
{
    public partial class EventViewerWindow : Form
    {

        private Event currentEvent;
        public EventViewerWindow(Event selectedEvent)
        {
            InitializeComponent();

            this.currentEvent = selectedEvent;

            sportSelector.DataSource = GetSports();
            sportSelector.DisplayMember = "name";
            sportSelector.ValueMember = "sport_number";

            openFileDialog.FileName = string.Empty;

            SetViewMode();
            SetEventFields(currentEvent);

            foreach (var eventTeam in GetEventTeams())
            {
                var team = GetTeams().FirstOrDefault(Team => Team.Id == eventTeam.Team_id);
                if (team != null)
                {
                    teamsView.Nodes.Add(team.Name);
                }
            }
        }
        private void SetEditMode()
        {
            EventName.ReadOnly = false;
            EventDescription.ReadOnly = false;
            EventName.Enabled = true;
            EventDescription.Enabled = true;
            startDate.Enabled = true;
            finishDate.Enabled = true;
            timePicker.Enabled = true;
            sportSelector.Enabled = true;

            editButton.Visible = false;
            deleteButton.Visible = false;
            saveButton.Visible = true;
            cancel2Button.Visible = true;
            teamViewerGroupBox.Visible = false;
            teamSelectorGroupBox.Visible = true;
            imageButton.Visible = true;
        }

        private void SetViewMode()
        {
            EventName.ReadOnly = true;
            EventDescription.ReadOnly = true;
            EventName.Enabled = false;
            EventDescription.Enabled = false;
            startDate.Enabled = false;
            finishDate.Enabled = false;
            timePicker.Enabled = false;
            sportSelector.Enabled = false;

            editButton.Visible = true;
            deleteButton.Visible = true;
            saveButton.Visible = false;
            cancel2Button.Visible = false;
            teamViewerGroupBox.Visible = true;
            teamSelectorGroupBox.Visible = false;
            imageButton.Visible = false;
        }

        private void SetEventFields(Event selectedEvent)
        {
            EventName.Text = selectedEvent.Name;
            EventDescription.Text = selectedEvent.Description;
            startDate.Text = selectedEvent.Start_date.ToString("yyyy-MM-dd HH:mm");
            finishDate.Text = selectedEvent.End_date.ToString("yyyy-MM-dd HH:mm");
            timePicker.Text = selectedEvent.Time.ToString(@"hh\:mm");
            sportSelector.SelectedValue = selectedEvent.Sport_number;

            if (!string.IsNullOrEmpty(selectedEvent.Image_url))
            {
                pictureBox.Image = Image.FromStream(
                    new MemoryStream(Convert.FromBase64String(selectedEvent.Image_url)));
            }
        }


        public List<EventTeam> GetEventTeams()
        {
            using (var context = new DatabaseHelper())
            {
                return context.EventTeams
                    .Where(eventTeam => eventTeam.Event_id == currentEvent.Id)
                    .ToList();
            }
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
            var teams = GetTeams();
            var eventTeams = GetEventTeams();
            teamSelectorCheckBox.Items.Clear();
            teamSelectorCheckBox.DisplayMember = "name";
            teamSelectorCheckBox.ValueMember = "sport_id";

            if (!TryGetSelectedSportId(out var selectedSportId))
            {
                return;
            }

            foreach (var team in teams.Where(team => team.Sport_number == selectedSportId))
            {
                teamSelectorCheckBox.Items.Add(team);
            }
            for (var index = 0; index < teamSelectorCheckBox.Items.Count; index++)
            {
                if (teamSelectorCheckBox.Items[index] is Team team &&
                    eventTeams.Any(eventTeam => eventTeam.Team_id == team.Id))
                {
                    teamSelectorCheckBox.SetItemChecked(index, true);
                }
            }
        }

        private bool TryGetSelectedSportId(out int sportId)
        {
            sportId = 0;
            if (sportSelector.SelectedValue == null)
                return false;

            return int.TryParse(sportSelector.SelectedValue.ToString(), out sportId);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SetEditMode();
        }
        private void cancel2Button_Click(object sender, EventArgs e)
        {
            SetEventFields(currentEvent);
            var eventTeams = GetEventTeams();

            teamSelectorCheckBox.SelectedItems.Clear();
            for (var index = 0; index < teamSelectorCheckBox.Items.Count; index++)
            {
                if (teamSelectorCheckBox.Items[index] is Team team &&
                    eventTeams.Any(eventTeam => eventTeam.Team_id == team.Id))
                {
                    teamSelectorCheckBox.SetItemChecked(index, true);
                }
            }
            SetViewMode();
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(Resources.deletingmessage, string.Empty,
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                using (var context = new DatabaseHelper())
                {
                    foreach (var eventTeam in GetEventTeams())
                    {
                        context.EventTeams.Remove(eventTeam);
                    }
                    context.Events.Remove(currentEvent);
                    context.SaveChanges();
                    this.Close();
                }
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

            if (!TryGetSelectedSportId(out var selectedSportId))
            {
                return;
            }

            var teams = GetTeams();
            teamSelectorCheckBox.Items.Clear();
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
                var eventToUpdate = context.Events.FirstOrDefault(@event => @event.Id == currentEvent.Id);

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
                if (!TryGetSelectedSportId(out var selectedSportId))
                {
                    return;
                }
                if (openFileDialog.FileName != string.Empty)
                {
                    var base64 = Convert.ToBase64String(System.IO.File.ReadAllBytes(openFileDialog.FileName));
                    eventToUpdate.Image_url = base64;
                    currentEvent.Image_url = base64;
                }
                

                currentEvent.Name = EventName.Text;
                eventToUpdate.Name = EventName.Text;
                currentEvent.Description = EventDescription.Text;
                eventToUpdate.Description = EventDescription.Text;
                eventToUpdate.Start_date = startDate.Value.ToUniversalTime();
                currentEvent.Start_date = startDate.Value.ToUniversalTime();
                eventToUpdate.End_date = finishDate.Value.ToUniversalTime();
                currentEvent.End_date = finishDate.Value.ToUniversalTime();
                eventToUpdate.Time = TimeSpan.Parse(timePicker.Value.TimeOfDay.ToString(@"hh\:mm"));
                currentEvent.Time = TimeSpan.Parse(timePicker.Value.TimeOfDay.ToString(@"hh\:mm"));
                eventToUpdate.Sport_number = selectedSportId;
                currentEvent.Sport_number = selectedSportId;
                currentEvent.Sport_name = sportSelector.Text;
                foreach (var eventTeam in GetEventTeams())
                {
                    context.EventTeams.Remove(eventTeam);
                }
                var eventTeams = new List<EventTeam>();
                teamsView.Nodes.Clear();
                foreach (Team selectedTeam in teamSelectorCheckBox.CheckedItems)
                {
                    var eventTeam = new EventTeam(currentEvent.Id, selectedTeam.Id);
                    eventTeams.Add(eventTeam);
                    teamsView.Nodes.Add(selectedTeam.Name);
                }
                context.EventTeams.AddRange(eventTeams);
                context.SaveChanges();


                SetViewMode();
            }
        }
    }
}
