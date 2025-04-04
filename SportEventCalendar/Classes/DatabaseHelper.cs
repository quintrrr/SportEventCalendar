using System;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
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
            try
            {
                EnvReader.Load("../../../../.env");
            }
            catch(FileNotFoundException) 
            {
                MessageBox.Show(Resources.fillInAllFields, Resources.errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }

            var host = Environment.GetEnvironmentVariable("DB_HOST");
            var port = Environment.GetEnvironmentVariable("DB_PORT");
            var username = Environment.GetEnvironmentVariable("DB_USER");
            var password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            var database = Environment.GetEnvironmentVariable("DB_NAME");

            connectionString = $"Host={host};Port={port};Username={username};Password={password};Database={database}";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }
        
    }
}
