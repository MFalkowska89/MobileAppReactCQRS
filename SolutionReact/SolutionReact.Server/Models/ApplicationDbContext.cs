using Microsoft.EntityFrameworkCore;

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
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourActivity> TourActivities { get; set; }
        public DbSet<TourSchedule> ToursSchedule { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ActivityName).HasMaxLength(50);
                entity.Property(e => e.FitnessLevel).HasMaxLength(20);

                entity.HasMany(a => a.TourActivities)
                      .WithOne(ta => ta.Activity)
                      .HasForeignKey(ta => ta.ActivityId);
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.BookingStatus).HasMaxLength(20);
                entity.Property(e => e.TotalPrice).HasColumnType("decimal(10,2)");

                entity.HasOne(b => b.Customer)
                      .WithMany(c => c.Bookings)
                      .HasForeignKey(b => b.CustomerId);

                entity.HasOne(b => b.TourSchedule)
                      .WithMany(ts => ts.Bookings)
                      .HasForeignKey(b => b.CustomTourScheduleId);

                entity.HasMany(b => b.BookingParticipants)
                      .WithOne(bp => bp.Booking)
                      .HasForeignKey(bp => bp.BookingId);

                entity.HasMany(b => b.Payments)
                      .WithOne(p => p.Booking)
                      .HasForeignKey(p => p.BookingId);
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
                      .HasForeignKey(bp => bp.CustomerId)
                      .OnDelete(DeleteBehavior.Restrict); ;
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
                entity.Property(e => e.TimeZone).HasMaxLength(10);

                entity.HasMany(d => d.Tours)
                      .WithOne(t => t.Destination)
                      .HasForeignKey(t => t.DestinationId);
            });

            modelBuilder.Entity<Guide>(entity =>
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

                entity.HasMany(g => g.TourSchedules)
                      .WithOne(ts => ts.Guide)
                      .HasForeignKey(ts => ts.GuideId);
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(100);
                entity.Property(e => e.Address).HasMaxLength(250);
                entity.Property(e => e.PostCode).HasMaxLength(20);
                entity.Property(e => e.Country).HasMaxLength(50);
                entity.Property(e => e.City).HasMaxLength(100);
                entity.Property(e => e.PhoneNumber).HasMaxLength(30);
                entity.Property(e => e.EMailAddress).HasMaxLength(250);
                entity.Property(e => e.HotelType).HasMaxLength(20);

                entity.HasMany(h => h.TourSchedules)
                      .WithOne(ts => ts.Hotel)
                      .HasForeignKey(ts => ts.HotelId);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AmountInvoice).HasColumnType("decimal(10,2)");
                entity.Property(e => e.AmountPaid).HasColumnType("decimal(10,2)");
                entity.Property(e => e.PaymentMethod).HasMaxLength(20);
                entity.Property(e => e.TransactionReference).HasMaxLength(100);

                entity.HasOne(p => p.Booking)
                      .WithMany(b => b.Payments)
                      .HasForeignKey(p => p.BookingId);
            });

            modelBuilder.Entity<Tour>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Price).HasColumnType("decimal(10,2)");
                entity.Property(e => e.TourType).HasMaxLength(20);
                entity.Property(e => e.TourCode).HasMaxLength(20);

                entity.HasOne(t => t.Destination)
                      .WithMany(d => d.Tours)
                      .HasForeignKey(t => t.DestinationId);

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
                      .HasForeignKey(ta => ta.TourId);

                entity.HasOne(ta => ta.Activity)
                      .WithMany(a => a.TourActivities)
                      .HasForeignKey(ta => ta.ActivityId);
            });

            modelBuilder.Entity<TourSchedule>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TourStatus).HasMaxLength(20);

                entity.HasOne(ts => ts.Tour)
                      .WithMany(t => t.TourSchedules)
                      .HasForeignKey(ts => ts.TourId);

                entity.HasOne(ts => ts.Guide)
                      .WithMany(g => g.TourSchedules)
                      .HasForeignKey(ts => ts.GuideId);

                entity.HasOne(ts => ts.Hotel)
                      .WithMany(h => h.TourSchedules)
                      .HasForeignKey(ts => ts.HotelId);
            });


            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Destination>().HasData(
            new Destination { Id = 1, Country = "France", Region = "Ile-de-France", City = "Paris", IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now },
            new Destination { Id = 2, Country = "Italy", Region = "Tuscany", City = "Florence", IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now }
            );

            // Seed Tour data
            modelBuilder.Entity<Tour>().HasData(
                new Tour { Id = 1, DestinationId = 1, LengthInDays = 7, Price = 1500, MaxParticipants = 20, IsActive = true, TourType = "Adventure", TourCode = "ADV-001", AddedBy = "Admin", AddedDate = DateTime.Now },
                new Tour { Id = 2, DestinationId = 2, LengthInDays = 5, Price = 1200, MaxParticipants = 15, IsActive = true, TourType = "Cultural", TourCode = "CUL-001", AddedBy = "Admin", AddedDate = DateTime.Now }
            );

            // Seed Activity data
            modelBuilder.Entity<Activity>().HasData(
                new Activity { Id = 1, ActivityName = "Sightseeing", Description = "Visit famous landmarks", FitnessLevel = "Low", DurationInMinutes = 120, IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now },
                new Activity { Id = 2, ActivityName = "Hiking", Description = "Mountain trek", FitnessLevel = "High", DurationInMinutes = 180, IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now }
            );

            // Seed Guide data
            modelBuilder.Entity<Guide>().HasData(
                new Guide { Id = 1, FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(1980, 5, 15), PhoneNumber = "123-456-7890", EmailAddress = "john.doe@example.com", IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now, HiredFrom = DateTime.Now },
                new Guide { Id = 2, FirstName = "Jane", LastName = "Smith", DateOfBirth = new DateTime(1985, 3, 25), PhoneNumber = "987-654-3210", EmailAddress = "jane.smith@example.com", IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now, HiredFrom = DateTime.Now }
            );

            // Seed Hotel data
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { Id = 1, Name = "Hotel Paris", Address = "123 Champs-Elysees", PostCode = "75008", City = "Paris", Country = "France", IsActive = true, PhoneNumber = "123-456-7890", EMailAddress = "contact@hotelparis.com", CheckInTime = new TimeSpan(14, 0, 0), CheckOutTime = new TimeSpan(11, 0, 0), HotelType = "Luxury", AddedBy = "Admin", AddedDate = DateTime.Now },
                new Hotel { Id = 2, Name = "Florence Inn", Address = "456 Via Firenze", PostCode = "50123", City = "Florence", Country = "Italy", IsActive = true, PhoneNumber = "987-654-3210", EMailAddress = "info@florenceinn.com", CheckInTime = new TimeSpan(15, 0, 0), CheckOutTime = new TimeSpan(10, 0, 0), HotelType = "Boutique", AddedBy = "Admin", AddedDate = DateTime.Now }
            );


            // Seed Payment data
            modelBuilder.Entity<Payment>().HasData(
                new Payment { Id = 1, BookingId = 1, DateInvoice = DateTime.Now, AmountInvoice = 1500, DatePayment = DateTime.Now, AmountPaid = 1500, PaymentMethod = "Credit Card", TransactionReference = "TX12345", IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now }
            );

            // Seed Customer data
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, FirstName = "Alice", LastName = "Johnson", DateOfBirth = new DateTime(1990, 7, 20), HomeAddress = "789 Elm St", PostCode = "12345", City = "Paris", Country = "France", PhoneNumber = "555-1234", EmailAddress = "alice.johnson@example.com", IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now },
                new Customer { Id = 2, FirstName = "Bob", LastName = "Williams", DateOfBirth = new DateTime(1988, 11, 15), HomeAddress = "456 Oak Ave", PostCode = "67890", City = "Florence", Country = "Italy", PhoneNumber = "555-5678", EmailAddress = "bob.williams@example.com", IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now }
            );

            // Seed Booking data
            modelBuilder.Entity<Booking>().HasData(
                new Booking { Id = 1, CustomerId = 1, CustomTourScheduleId = 1, NoPax = 2, TotalPrice = 3000, BookingStatus = "Confirmed", BookingDate = DateTime.Now, IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now }
            );

            // Seed TourSchedule data
            modelBuilder.Entity<TourSchedule>().HasData(
                new TourSchedule { Id = 1, TourId = 1, GuideId = 1, HotelId = 1, TourStartDate = DateTime.Now.AddDays(5), IsActive = true, AddedBy = "Admin", AddedDate = DateTime.Now }
            );

        }
    }
}
