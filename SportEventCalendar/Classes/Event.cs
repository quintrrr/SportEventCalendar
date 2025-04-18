using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportEventCalendar.Classes
{
    /// <summary>
    /// Класс, представляющий сущность "Событие" в системе.
    /// Соответствует таблице "events" в базе данных.
    /// </summary>
    /// <remarks>
    /// Содержит информацию о спортивных событиях:
    /// - Название и описание события
    /// - Даты и время проведения
    /// - Связанный вид спорта
    /// - Изображение события
    /// </remarks>
    [Table("events")]
    public class Event
    {
        /// <summary>
        /// Уникальный идентификатор события
        /// </summary>
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Название события (обязательное поле)
        /// </summary>
        [Required]
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// Описание события
        /// </summary>
        [Column("description")]
        public string Description { get; set; }

        /// <summary>
        /// Дата и время начала события
        /// </summary>
        [Column("start_date")]
        public DateTime Start_date { get; set; }

        /// <summary>
        /// Дата и время окончания события
        /// </summary>
        [Column("end_date")]
        public DateTime End_date { get; set; }

        /// <summary>
        /// Время проведения события
        /// </summary>
        [Column("time")]
        public TimeSpan Time { get; set; }

        /// <summary>
        /// Изображение в виде base64 события
        /// </summary>
        [Column("image_url")]
        public string Image_url { get; set; }

        /// <summary>
        /// Идентификатор связанного вида спорта
        /// </summary>
        [Column("sport_number")]
        public int Sport_number { get; set; }

        /// <summary>
        /// Название вида спорта (не сохраняется в БД)
        /// </summary>
        [NotMapped]
        public string Sport_name { get; set; }

        /// <summary>
        /// Конструктор для создания события со всеми полями
        /// </summary>
        /// <param name="id">Уникальный идентификатор</param>
        /// <param name="name">Название события</param>
        /// <param name="description">Описание</param>
        /// <param name="start_date">Дата начала</param>
        /// <param name="end_date">Дата окончания</param>
        /// <param name="sport_number">ID вида спорта</param>
        /// <param name="time">Время проведения</param>
        /// <param name="image_url">Изображение в виде base64</param>
        /// <param name="sport_name">Название вида спорта</param>
        public Event(Guid id, string name, string description, DateTime start_date,
            DateTime end_date, int sport_number, TimeSpan time, string image_url, string sport_name)
        {
            Id = id;
            Name = name;
            Description = description;
            Start_date = start_date;
            End_date = end_date;
            Sport_number = sport_number;
            Time = time;
            Image_url = image_url;
            Sport_name = sport_name;
        }

        /// <summary>
        /// Конструктор для создания события без названия вида спорта
        /// </summary>
        /// <param name="id">Уникальный идентификатор</param>
        /// <param name="name">Название события</param>
        /// <param name="description">Описание</param>
        /// <param name="start_date">Дата начала</param>
        /// <param name="end_date">Дата окончания</param>
        /// <param name="sport_number">ID вида спорта</param>
        /// <param name="time">Время проведения</param>
        /// <param name="image_url">Изображение в виде base64</param>
        public Event(Guid id, string name, string description, DateTime start_date,
            DateTime end_date, int sport_number, TimeSpan time, string image_url)
        {
            Id = id;
            Name = name;
            Description = description;
            Start_date = start_date;
            End_date = end_date;
            Sport_number = sport_number;
            Time = time;
            Image_url = image_url;
        }
    }
}