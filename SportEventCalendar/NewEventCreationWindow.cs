using System.Data;
using SportEventCalendar.Classes;
using SportEventCalendar.Properties;

namespace SportEventCalendar
{
    /// <summary>
    /// Окно создания нового спортивного события
    /// </summary>
    /// <remarks>
    /// Предоставляет интерфейс для создания новых спортивных событий с возможностью:
    /// - Указания названия и описания
    /// - Выбора дат и времени проведения
    /// - Выбора вида спорта
    /// - Добавления команд-участников
    /// - Загрузки изображения
    /// </remarks>
    public partial class NewEventCreationWindow : Form
    {
        /// <summary>
        /// Конструктор окна создания события
        /// </summary>
        public NewEventCreationWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Получает список видов спорта из базы данных
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
        /// Обработчик загрузки окна создания события
        /// </summary>
        private void NewEventCreationWindow_Load(object sender, EventArgs e)
        {
            var noSport = new Sport();
            noSport.Name = "Выберите вид спорта";
            noSport.Sport_number = 0;
            var sportList = GetSports();
            sportList.Add(noSport);
            sportList = sportList.OrderBy(sport => sport.Sport_number).ToList();

            sportSelector.DataSource = sportList;
            sportSelector.DisplayMember = "name";
            sportSelector.ValueMember = "sport_number";
            teamSelectorCheckBox.DisplayMember = "name";
            teamSelectorCheckBox.ValueMember = "id";
            teamSelectorCheckBox.Items.Clear();
        }

        /// <summary>
        /// Проверяет валидность файла изображения
        /// </summary>
        /// <param name="filePath">Путь к файлу изображения</param>
        /// <returns>True если изображение валидно</returns>
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
                MessageBox.Show(Resources.imageError,Resources.errorTitle, 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                openFileDialog.FileName = string.Empty;
            }
            
        }

        /// <summary>
        /// Добавляет новое событие в базу данных
        /// </summary>
        /// <param name="sportEvent">Объект события для добавления</param>
        public void AddSportEvent(Event sportEvent)
        {
            using (var context = new DatabaseHelper())
            {
                context.Events.Add(sportEvent);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки создания события
        /// </summary>
        private void create_button_Click(object sender, EventArgs e)
        {
            if (newEventName.Text == string.Empty)
            {
                MessageBox.Show(Resources.fillName, Resources.errorTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!TryGetSelectedSportId(out var selectedSportId))
            {
                return;
            }
            if ((int)sportSelector.SelectedValue == 0)
            {
                MessageBox.Show(Resources.selectSport, Resources.errorTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (teamSelectorCheckBox.CheckedItems.Count == 0)
            {
                MessageBox.Show(Resources.selectTeams, Resources.errorTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var startDateTime = startDate.Value.AddHours(10).ToUniversalTime();
            if (finishDate.Value.ToUniversalTime() < startDate.Value.ToUniversalTime())
            {
                MessageBox.Show(Resources.dateError, Resources.errorTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var base64 = string.Empty;
            if (openFileDialog.FileName != string.Empty)
            {
                base64 = Convert.ToBase64String(File.ReadAllBytes(openFileDialog.FileName));

            }
            else
            {
                base64 = Convert.ToBase64String(File.ReadAllBytes("../../../Properties/DataSources/defaultPicture.png"));

            }
            var newSportEvent = new Event(
                Guid.NewGuid(), 
                newEventName.Text, 
                NewEventDescription.Text, 
                startDate.Value.ToUniversalTime(), 
                finishDate.Value.ToUniversalTime(), 
                selectedSportId,
                TimeSpan.Parse(timePicker.Value.TimeOfDay.ToString(@"hh\:mm")), 
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

        /// <summary>
        /// Получает список команд из базы данных
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
        /// Добавляет связи событие-команда в базу данных
        /// </summary>
        /// <param name="EventTeamList">Список связей для добавления</param>
        public void AddEventTeam(List<EventTeam> EventTeamList)
        {
            using (var context = new DatabaseHelper())
            {
                context.EventTeams.AddRange(EventTeamList);
                context.SaveChanges();
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
            teamSelectorCheckBox.DisplayMember = "name";
            teamSelectorCheckBox.ValueMember = "sport_id";
            foreach (var row in teams.Where(team => team.Sport_number == selectedSportId))
            {
                teamSelectorCheckBox.Items.Add(row);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки отмены
        /// </summary>
        private void cancel_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(Resources.cancelCreating, string.Empty,
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Пытается получить ID выбранного вида спорта
        /// </summary>
        /// <param name="sportId">Выходной параметр с ID вида спорта</param>
        /// <returns>True если ID успешно получен</returns>
        private bool TryGetSelectedSportId(out int sportId)
        {
            sportId = 0;
            if (sportSelector.SelectedValue == null)
                return false;

            return int.TryParse(sportSelector.SelectedValue.ToString(), out sportId);
        }

    }
}
 