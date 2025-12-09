using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;

namespace SolutionReact.Server.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingParticipant> BookingsParticipant { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Destination> Destination { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourActivity> TourActivities { get; set; }
        public DbSet<TourSchedule> ToursSchedule { get; set; }
        public DbSet<StatusOfEntity> StatusOfEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ActivityName).HasMaxLength(50);

                entity.HasMany(a => a.TourActivities)
                      .WithOne(ta => ta.Activity)
                      .HasForeignKey(ta => ta.ActivityId);
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(10,2)");

                entity.HasOne(b => b.Customer)
                      .WithMany(c => c.Bookings)
                      .HasForeignKey(b => b.CustomerId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(b => b.TourSchedule)
                      .WithMany(ts => ts.Bookings)
                      .HasForeignKey(b => b.CustomTourScheduleId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(b => b.BookingParticipants)
                      .WithOne(bp => bp.Booking)
                      .HasForeignKey(bp => bp.BookingId);

                entity.HasOne(b => b.StatusOfEntity)       // navigation property in Booking
                        .WithMany(s => s.Bookings)          // collection in StatusOfEntity
                        .HasForeignKey(b => b.BookingStatusId) // FK property in Booking
                        .OnDelete(DeleteBehavior.Restrict);

            });

            modelBuilder.Entity<BookingParticipant>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(bp => bp.Booking)
                      .WithMany(b => b.BookingParticipants)
                      .HasForeignKey(bp => bp.BookingId);


                entity.HasOne(bp => bp.Customer)
                      .WithMany(c => c.BookingParticipants)
                      .HasForeignKey(bp => bp.CustomerId);

            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(100);
                entity.Property(e => e.HomeAddress).HasMaxLength(250);
                entity.Property(e => e.PostCode).HasMaxLength(20);
                entity.Property(e => e.Country).HasMaxLength(50);
                entity.Property(e => e.City).HasMaxLength(100);
                entity.Property(e => e.PhoneNumber).HasMaxLength(30);
                entity.Property(e => e.PhoneNumberExtra).HasMaxLength(30);
                entity.Property(e => e.EmailAddress).HasMaxLength(250);

                entity.HasMany(c => c.Bookings)
                      .WithOne(b => b.Customer)
                      .HasForeignKey(b => b.CustomerId);


                entity.HasMany(c => c.BookingParticipants)
                      .WithOne(bp => bp.Customer)
                      .HasForeignKey(bp => bp.CustomerId);

            });

            modelBuilder.Entity<Destination>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Country).HasMaxLength(50);
                entity.Property(e => e.City).HasMaxLength(100);
                entity.Property(e => e.Region).HasMaxLength(100);

                entity.HasMany(d => d.Tours)
                      .WithOne(t => t.Destination)
                      .HasForeignKey(t => t.DestinationId);

            });


            modelBuilder.Entity<Tour>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Price).HasColumnType("decimal(10,2)");
                entity.Property(e => e.TourCode).HasMaxLength(20);

                entity.HasOne(t => t.Destination)
                      .WithMany(d => d.Tours)
                      .HasForeignKey(t => t.DestinationId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(t => t.TourActivities)
                      .WithOne(ta => ta.Tour)
                      .HasForeignKey(ta => ta.TourId);


                entity.HasMany(t => t.TourSchedules)
                      .WithOne(ts => ts.Tour)
                      .HasForeignKey(ts => ts.TourId);

            });

            modelBuilder.Entity<TourActivity>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(ta => ta.Tour)
                      .WithMany(t => t.TourActivities)
                      .HasForeignKey(ta => ta.TourId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(ta => ta.Activity)
                      .WithMany(a => a.TourActivities)
                      .HasForeignKey(ta => ta.ActivityId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<TourSchedule>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(ts => ts.Tour)
                      .WithMany(t => t.TourSchedules)
                      .HasForeignKey(ts => ts.TourId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(b => b.StatusOfEntity)       // navigation property in Booking
                       .WithMany(s => s.TourSchedules)          // collection in StatusOfEntity
                       .HasForeignKey(b => b.TourStatusId) // FK property in Booking
                       .OnDelete(DeleteBehavior.Restrict);

            });


            modelBuilder.Entity<StatusOfEntity>(entity =>
            {
                // Primary Key
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                // Properties
                entity.Property(e => e.StatusName)
                      .IsRequired()
                      .HasMaxLength(20);

                // Relationships
                entity.HasMany(s => s.Bookings)
                      .WithOne(b => b.StatusOfEntity)
                      .HasForeignKey(b => b.BookingStatusId);


                entity.HasMany(s => s.TourSchedules)
                      .WithOne(ts => ts.StatusOfEntity)
                      .HasForeignKey(ts => ts.TourStatusId);

            });


            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {

            // Entity statuses (for bookings / tour schedules)
            modelBuilder.Entity<StatusOfEntity>().HasData(
                new StatusOfEntity { Id = 1, StatusName = "Pending", StatusDescription = "Pending confirmation", IsActive = true, AddedBy = "System", AddedDate = DateTime.Now },
                new StatusOfEntity { Id = 2, StatusName = "Confirmed", StatusDescription = "Confirmed", IsActive = true, AddedBy = "System", AddedDate = DateTime.Now },
                new StatusOfEntity { Id = 3, StatusName = "Cancelled", StatusDescription = "Cancelled", IsActive = true, AddedBy = "System", AddedDate = DateTime.Now },
                new StatusOfEntity { Id = 4, StatusName = "Completed", StatusDescription = "Completed", IsActive = true, AddedBy = "System", AddedDate = DateTime.Now }
            );

            // Destinations
            modelBuilder.Entity<Destination>().HasData(
                new Destination { Id = 1, Country = "France", Region = "Ile-de-France", City = "Paris", IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now },
                new Destination { Id = 2, Country = "Italy", Region = "Tuscany", City = "Florence", IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now }
            );

            // Tours
            modelBuilder.Entity<Tour>().HasData(
                new Tour { Id = 1, DestinationId = 1, LengthInDays = 7, Price = 1500m, MaxParticipants = 20, IsActive = true, TourCode = "ADV-001", AddedBy = "Admin", AddedDate = DateTime.Now },
                new Tour { Id = 2, DestinationId = 2, LengthInDays = 5, Price = 1200m, MaxParticipants = 15, IsActive = true, TourCode = "CUL-001", AddedBy = "Admin", AddedDate = DateTime.Now }
            );

            // Activities
            modelBuilder.Entity<Activity>().HasData(
                new Activity { Id = 1, ActivityName = "Sightseeing", Description = "Visit famous landmarks", AdditionalRequirements = "Swimming Certificate", DurationInMinutes = 120, IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now },
                new Activity { Id = 2, ActivityName = "Hiking", Description = "Mountain trek", AdditionalRequirements = "None", DurationInMinutes = 180, IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now }
            );

            // TourSchedules (referencing Tour and StatusOfEntity)
            modelBuilder.Entity<TourSchedule>().HasData(
                new TourSchedule { Id = 1, TourId = 1, TourStartDate = DateTime.Now.AddDays(10), IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now, TourStatusId = 2 },
                new TourSchedule { Id = 2, TourId = 2, TourStartDate = DateTime.Now.AddDays(20), IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now, TourStatusId = 1 }
            );

            // Customers
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, FirstName = "Alice", LastName = "Johnson", DateOfBirth = new DateTime(1990, 7, 20), HomeAddress = "789 Elm St", PostCode = "12345", City = "Paris", Country = "France", PhoneNumber = "555-1234", EmailAddress = "alice.johnson@example.com", IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now },
                new Customer { Id = 2, FirstName = "Bob", LastName = "Williams", DateOfBirth = new DateTime(1988, 11, 15), HomeAddress = "456 Oak Ave", PostCode = "67890", City = "Florence", Country = "Italy", PhoneNumber = "555-5678", EmailAddress = "bob.williams@example.com", IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now }
            );

            // Bookings (referencing Customer, TourSchedule and StatusOfEntity)
            modelBuilder.Entity<Booking>().HasData(
                new Booking { Id = 1, CustomerId = 1, CustomTourScheduleId = 1, NoPax = 2, TotalPrice = 3000m, BookingStatusId = 2, BookingDate = DateTime.Now, IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now },
                new Booking { Id = 2, CustomerId = 2, CustomTourScheduleId = 2, NoPax = 1, TotalPrice = 1200m, BookingStatusId = 1, BookingDate = DateTime.Now.AddDays(-1), IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now }
            );


            // TourActivities (linking tours to activities)
            modelBuilder.Entity<TourActivity>().HasData(
                new TourActivity { Id = 1, TourId = 1, ActivityId = 1, IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now },
                new TourActivity { Id = 2, TourId = 1, ActivityId = 2, IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now }
            );

            // BookingParticipants
            modelBuilder.Entity<BookingParticipant>().HasData(
                new BookingParticipant { Id = 1, BookingId = 1, CustomerId = 1, IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now },
                new BookingParticipant { Id = 2, BookingId = 1, CustomerId = 2, IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now }
            );

        }
    }
}
