using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportEventCalendar.Classes
{
    /// <summary>
    /// Класс, представляющий спортивную команду в системе
    /// </summary>
    /// <remarks>
    /// Содержит информацию о команде и её принадлежности к виду спорта.
    /// Соответствует таблице "teams" в базе данных.
    /// </remarks>
    [Table("teams")]
    public class Team
    {
        /// <summary>
        /// Уникальный идентификатор команды
        /// </summary>
        /// <value>
        /// Целое число, являющееся первичным ключом
        /// </value>
        [Key]
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Название команды
        /// </summary>
        /// <value>
        /// Строка с наименованием команды (обязательное поле)
        /// </value>
        [Required]
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// Идентификатор вида спорта, к которому относится команда
        /// </summary>
        /// <value>
        /// Целое число, соответствующее SportNumber в таблице sports
        /// </value>
        [Column("sport_number")]
        public int Sport_number { get; set; }

    }
}
