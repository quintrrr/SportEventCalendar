using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using SportEventCalendar.Properties;

namespace SportEventCalendar.Classes
{
    /// <summary>
    /// Класс-помощник для работы с базой данных приложения SportEventCalendar.
    /// Обеспечивает взаимодействие с PostgreSQL через Entity Framework Core.
    /// </summary>
    /// <remarks>
    /// Реализует следующие функции:
    /// - Управление подключением к базе данных
    /// - Инициализацию контекста данных
    /// - Определение структуры таблиц и связей между ними
    /// - Централизованное хранение конфигурации подключения
    /// </remarks>
    public class DatabaseHelper : DbContext
    {
        /// <summary>
        /// Содержит строку подключения к PostgreSQL базе данных.
        /// Формируется из переменных окружения в конструкторе класса.
        /// </summary>
        private string connectionString;

        /// <summary>
        /// Представляет таблицу событий (Events) в базе данных.
        /// Содержит коллекцию всех сущностей типа Event.
        /// </summary>
        public DbSet<Event> Events { get; set; }

        /// <summary>
        /// Представляет таблицу видов спорта (Sports) в базе данных.
        /// Содержит коллекцию всех сущностей типа Sport.
        /// </summary>
        public DbSet<Sport> Sports { get; set; }

        /// <summary>
        /// Представляет таблицу команд (Teams) в базе данных.
        /// Содержит коллекцию всех сущностей типа Team.
        /// </summary>
        public DbSet<Team> Teams { get; set; }

        /// <summary>
        /// Представляет таблицу (EventTeams) в базе данных.
        /// Содержит коллекцию всех сущностей типа EventTeams.
        /// </summary>

        public DbSet<EventTeam> EventTeams { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр DatabaseHelper.
        /// Загружает переменные окружения из файла .env и формирует строку подключения к БД.
        /// Показывает сообщение об ошибке, если обязательные переменные окружения отсутствуют.
        /// </summary>
        public DatabaseHelper()
        {
            EnvReader.Load("../../../../.env");
            if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("DB_HOST")))
            {
                MessageBox.Show(Resources.conString, Resources.errorTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Process.GetCurrentProcess().Kill();
            }
            var host = Environment.GetEnvironmentVariable("DB_HOST");
            var port = Environment.GetEnvironmentVariable("DB_PORT");
            var username = Environment.GetEnvironmentVariable("DB_USER");
            var password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            var database = Environment.GetEnvironmentVariable("DB_NAME");
           
            connectionString = $"Host={host};Port={port};Username={username};" +
                    $"Password={password};Database={database}";
            
        }

        /// <summary>
        /// Настраивает провайдер базы данных и строку подключения для DbContext.
        /// </summary>
        /// <param name="optionsBuilder">Построитель опций для конфигурации DbContext</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseNpgsql(connectionString);
        }

        /// <summary>
        /// Определяет отношения между сущностями и ограничения в модели базы данных.
        /// Устанавливает составной ключ и уникальное ограничение для связующей таблицы EventTeam.
        /// </summary>
        /// <param name="modelBuilder">Построитель модели для конфигурации отношений</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventTeam>()
            .HasKey(eventTeam => new { eventTeam.Event_id, eventTeam.Team_id });

            modelBuilder.Entity<EventTeam>()
                        .HasIndex(eventTeam => new { eventTeam.Event_id, eventTeam.Team_id })
                        .IsUnique(true);
        }

    }
}
