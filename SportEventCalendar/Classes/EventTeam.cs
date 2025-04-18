using System.ComponentModel.DataAnnotations.Schema;

namespace SportEventCalendar.Classes
{
    /// <summary>
    /// Класс, представляющий связь между событием и командой (связующая таблица)
    /// </summary>
    /// <remarks>
    /// Реализует отношение многие-ко-многим между сущностями Event и Team.
    /// Соответствует таблице "event_team" в базе данных.
    /// </remarks>
    [Table("event_team")]
    public class EventTeam
    {
        /// <summary>
        /// Уникальный идентификатор связанного события
        /// </summary>
        /// <value>
        /// Guid, представляющий идентификатор события из таблицы events
        /// </value>
        [Column("event_id")]
        public Guid Event_id { get; set; }

        /// <summary>
        /// Уникальный идентификатор связанной команды
        /// </summary>
        /// <value>
        /// Целое число, представляющее идентификатор команды из таблицы teams
        /// </value>

        [Column("team_id")]
        public int Team_id { get; set; }

        /// <summary>
        /// Основной конструктор для создания связи между событием и командой
        /// </summary>
        /// <param name="eventId">Идентификатор события</param>
        /// <param name="teamId">Идентификатор команды</param>
        public EventTeam(Guid event_id, int team_id) 
        {
            Event_id = event_id;
            Team_id = team_id;
        }
    }
}
