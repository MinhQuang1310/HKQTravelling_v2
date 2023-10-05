using HKQTravelling.Models;
using Microsoft.EntityFrameworkCore;

namespace HKQTravelling.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-1ARB7R2;Database=HKQ_Travelling;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Add the unique constraint into RoleName property of Role Entity
            modelBuilder.Entity<Role>()
                .HasIndex(u => u.RoleName)
                .IsUnique();
            //Same the unique code above
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();
            modelBuilder.Entity<UserDetails>()
                .HasIndex(u => u.Email)
                .IsUnique();
            modelBuilder.Entity<TicketType>()
                .HasIndex(u => u.TypeName)
                .IsUnique();
            modelBuilder.Entity<Discount>()
                .HasIndex(u => u.Discount_Name)
                .IsUnique();
            //Set-up M:N relationship between Tour and User
            modelBuilder.Entity<Feedback>()
                .HasKey(ut => ut.FeedbackId);
            modelBuilder.Entity<Feedback>()
                .HasOne(ut => ut.User)
                .WithMany(u => u.Feedbacks)
                .HasForeignKey(ut => ut.UserId);
            modelBuilder.Entity<Feedback>()
                .HasOne(ut => ut.Tour)
                .WithMany(t => t.Feedbacks)
                .HasForeignKey(ut => ut.TourId);
        }


        public DbSet<Role> Roles { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourDay> ToursDays { get; set; }
        public DbSet<TourImage> TourImages { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<TicketInformation> TicketInformations { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
