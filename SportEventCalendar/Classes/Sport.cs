using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportEventCalendar.Classes
{
    /// <summary>
    /// Класс, представляющий вид спорта в системе
    /// </summary>
    /// <remarks>
    /// Содержит базовую информацию о виде спорта.
    /// Соответствует таблице "sports" в базе данных.
    /// </remarks>
    [Table("sports")]
    public class Sport
    {
        /// <summary>
        /// Уникальный числовой идентификатор вида спорта
        /// </summary>
        /// <value>
        /// Целое число, являющееся первичным ключом в таблице
        /// </value>
        [Key]
        [Column("sport_number")]
        public int Sport_number { get; set; }

        /// <summary>
        /// Название вида спорта
        /// </summary>
        /// <value>
        /// Строка с наименованием вида спорта (обязательное поле)
        /// </value>
        [Required]
        [Column("name")]
        public string Name { get; set; }
    }
}
