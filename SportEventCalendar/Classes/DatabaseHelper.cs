using Microsoft.EntityFrameworkCore;
using SportEventCalendar.Properties;

namespace SportEventCalendar.Classes
{
    public class DatabaseHelper : DbContext
    {
        private string connectionString;

        public DbSet<Event> Events { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<EventTeam> EventTeams { get; set; }


        public DatabaseHelper()
        {
            EnvReader.Load("../../../../.env");
            if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("DB_HOST")))
            {
                MessageBox.Show(Resources.conString, Resources.errorTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var host = Environment.GetEnvironmentVariable("DB_HOST");
            var port = Environment.GetEnvironmentVariable("DB_PORT");
            var username = Environment.GetEnvironmentVariable("DB_USER");
            var password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            var database = Environment.GetEnvironmentVariable("DB_NAME");
           
            connectionString = $"Host={host};Port={port};Username={username};" +
                    $"Password={password};Database={database}";
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseNpgsql(connectionString);
        }

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
