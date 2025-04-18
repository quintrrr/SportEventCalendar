using System.Data;
using SportEventCalendar.Classes;
using SportEventCalendar.Properties;


namespace SportEventCalendar
{
    /// <summary>
    /// Форма для просмотра и редактирования событий
    /// </summary>
    public partial class EventViewerWindow : Form
    {
        /// <summary>
        /// Текущее событие, которое просматривается или редактируется в форме.
        /// Хранит все данные о событии, включая название, описание, даты, 
        /// связанные команды и изображение.
        /// </summary>
        private Event currentEvent;

        /// <summary>
        /// Конструктор формы просмотра события
        /// </summary>
        /// <param name="selectedEvent">Выбранное событие для просмотра/редактирования</param>
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

        /// <summary>
        /// Активирует режим редактирования события
        /// </summary>
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
            cancelButton.Visible = true;
            teamViewerGroupBox.Visible = false;
            teamSelectorGroupBox.Visible = true;
            imageButton.Visible = true;
        }

        /// <summary>
        /// Активирует режим просмотра события (только чтение)
        /// </summary>
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
            cancelButton.Visible = false;
            teamViewerGroupBox.Visible = true;
            teamSelectorGroupBox.Visible = false;
            imageButton.Visible = false;
        }

        /// <summary>
        /// Заполняет поля формы данными из выбранного события
        /// </summary>
        /// <param name="selectedEvent">Событие, данные которого нужно отобразить</param>

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

        /// <summary>
        /// Получает список связей между текущим событием и командами
        /// </summary>
        /// <returns>Список объектов EventTeam</returns>

        public List<EventTeam> GetEventTeams()
        {
            using (var context = new DatabaseHelper())
            {
                return context.EventTeams
                    .Where(eventTeam => eventTeam.Event_id == currentEvent.Id)
                    .ToList();
            }
        }

        /// <summary>
        /// Получает список всех видов спорта из базы данных
        /// </summary>
        /// <returns>Список объектов Sport</returns>

        public List<Sport> GetSports()
        {
            using (var context = new DatabaseHelper())
            {
                return context.Sports.ToList();
            }
        }

        /// <summary>
        /// Обработчик загрузки формы
        /// </summary>

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

        /// <summary>
        /// Пытается получить ID выбранного вида спорта
        /// </summary>
        /// <param name="sportId">Выходной параметр с ID вида спорта</param>
        /// <returns>True, если ID успешно получен</returns>

        private bool TryGetSelectedSportId(out int sportId)
        {
            sportId = 0;
            if (sportSelector.SelectedValue == null)
                return false;

            return int.TryParse(sportSelector.SelectedValue.ToString(), out sportId);
        }

        /// <summary>
        /// Обработчик нажатия кнопки редактирования
        /// </summary>
        private void editButton_Click(object sender, EventArgs e)
        {
            SetEditMode();
        }

        /// <summary>
        /// Обработчик нажатия кнопки отмены
        /// </summary>

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
                else
                {
                    teamSelectorCheckBox.SetItemChecked(index, false);
                }
            }
            SetViewMode();
        }

        /// <summary>
        /// Обработчик нажатия кнопки удаления
        /// </summary>

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

        /// <summary>
        /// Получает список всех команд из базы данных
        /// </summary>
        /// <returns>Список объектов Team</returns>
        public List<Team> GetTeams()
        {
            using (var context = new DatabaseHelper())
            {
                return context.Teams.ToList();
            }
        }

        /// <summary>
        /// Обработчик изменения выбранного вида спорта
        /// </summary>
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

        /// <summary>
        /// Проверяет валидность файла изображения
        /// </summary>
        /// <param name="filePath">Путь к файлу изображения</param>
        /// <returns>True, если изображение валидно</returns>
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
        /// <summary>
        /// Обработчик нажатия кнопки выбора изображения
        /// </summary>
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

        /// <summary>
        /// Обработчик нажатия кнопки сохранения
        /// </summary>
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
