using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SportEventCalendar.Models;

public partial class SporteventcalendarContext : DbContext
{
    public SporteventcalendarContext()
    {
    }

    public SporteventcalendarContext(DbContextOptions<SporteventcalendarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventTeam> EventTeams { get; set; }

    public virtual DbSet<Sport> Sports { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=45.133.251.252;Port=5432;Username=salavat;Password=salavat;Database=sporteventcalendar");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("events_new_pkey");

            entity.ToTable("events");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.ImageUrl)
                .HasColumnType("character varying")
                .HasColumnName("image_url");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.SportNumber).HasColumnName("sport_number");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<EventTeam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("event_team");

            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.TeamId).HasColumnName("team_id");
        });

        modelBuilder.Entity<Sport>(entity =>
        {
            entity.HasKey(e => e.SportNumber).HasName("sports_pkey");

            entity.ToTable("sports");

            entity.Property(e => e.SportNumber)
                .UseIdentityAlwaysColumn()
                .HasColumnName("sport_number");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teams_pkey");

            entity.ToTable("teams");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.SportNumber).HasColumnName("sport_number");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
