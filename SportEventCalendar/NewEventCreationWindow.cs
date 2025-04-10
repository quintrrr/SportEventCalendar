using System.Buffers.Text;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;
using SportEventCalendar.Classes;
using SportEventCalendar.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SportEventCalendar
{
    public partial class NewEventCreationWindow : Form
    {

        public NewEventCreationWindow()
        {
            InitializeComponent();
        }

        public List<Sport> GetSports()
        {
            using (var context = new DatabaseHelper())
            {
                return context.Sports.ToList();
            }
        }
        private void NewEventCreationWindow_Load(object sender, EventArgs e)
        {
            sportSelector.DataSource = GetSports();
            sportSelector.DisplayMember = "name";
            sportSelector.ValueMember = "sport_number";
            teamSelectorCheckBox.DisplayMember = "name";
            teamSelectorCheckBox.ValueMember = "id";
            teamSelectorCheckBox.Items.Clear();
            var teams = GetTeams();

            foreach (var team in teams.Where(team => team.Sport_number ==
                ((Sport)sportSelector.Items[0]).Sport_number))
            {
                teamSelectorCheckBox.Items.Add(team);
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
                MessageBox.Show(Resources.imageError,Resources.errorTitle, 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                openFileDialog.FileName = string.Empty;
            }
            
        }

        public void AddSportEvent(Event sportEvent)
        {
            using (var context = new DatabaseHelper())
            {
                context.Events.Add(sportEvent);
                context.SaveChanges();
            }
        }
        private void create_button_Click(object sender, EventArgs e)
        {
            if (newEventName.Text == string.Empty)
            {
                MessageBox.Show(Resources.fillName, Resources.errorTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (openFileDialog.FileName == string.Empty)
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
            string base64 = Convert.ToBase64String(File.ReadAllBytes(openFileDialog.FileName));
            var newSportEvent = new Event(
                Guid.NewGuid(), 
                newEventName.Text, 
                NewEventDescription.Text, 
                startDate.Value.ToUniversalTime(), 
                finishDate.Value.ToUniversalTime(), 
                selectedSportId,
                TimeSpan.Parse(timePicker.Value.TimeOfDay.ToString(@"hh\:mm\:ss")), 
                base64,
                sportSelector.Text
                );
            var eventTeams = new List<EventTeam>();
           
            foreach (Team selectedTeam in teamSelectorCheckBox.CheckedItems) 
            {
                var eventTeam = new EventTeam(newSportEvent.Id, selectedTeam.Id);
                eventTeams.Add(eventTeam);
            }
            
            AddSportEvent(newSportEvent);
            AddEventTeam(eventTeams);
            this.Close();
        }

        public List<Team> GetTeams()
        {
            using (var context = new DatabaseHelper())
            {
                return context.Teams.ToList();
            }
        }

        public void AddEventTeam(List<EventTeam> EventTeamList)
        {
            using (var context = new DatabaseHelper())
            {
                context.EventTeams.AddRange(EventTeamList);
                context.SaveChanges();
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

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
