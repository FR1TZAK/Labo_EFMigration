using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.Models;

#nullable disable

namespace Repositories
{
    public partial class WickedAirSourceContextDupe : DbContext
    {
        public WickedAirSourceContextDupe()
        {
        }

        public WickedAirSourceContextDupe(DbContextOptions<WickedAirSourceContextDupe> options) : base(options)
        {
        }

        public virtual DbSet<AircraftType> AircraftTypes { get; set; }
        public virtual DbSet<AircraftTypeDetail> AircraftTypeDetails { get; set; }
        public virtual DbSet<Airline> Airlines { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Catering> Caterings { get; set; }
        public virtual DbSet<DepartureGrouping> DepartureGroupings { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Persondetail> Persondetails { get; set; }
        public virtual DbSet<VDepartureStatistic> VDepartureStatistics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                
                optionsBuilder.UseSqlServer("Server=(local)\\SUNGLOSTRIE; Initial Catalog=wickedair; Trusted_Connection=true; MultipleActiveResultSets=true");
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("syntra");

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => new { e.FlightNo, e.PassengerId });
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.Property(e => e.FlightNo).ValueGeneratedNever();

                entity.Property(e => e.Departure).HasDefaultValueSql("(N'(not set)')");

                entity.Property(e => e.Destination).HasDefaultValueSql("(N'(not set)')");

                entity.Property(e => e.FlightDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Price).HasDefaultValueSql("((123.45))");

                entity.Property(e => e.Timestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Utilization).HasComputedColumnSql("((100.0)-(([FreeSeats]*(1.0))/[Seats])*(100.0))", false);

                entity.HasOne(d => d.Pilot)
                    .WithMany(p => p.FlightPilots)
                    .HasForeignKey(d => d.PilotId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
