using Microsoft.EntityFrameworkCore;
using Parcial02.Entities.Reservations;
using Parcial02.Entities.SecurityQuestions;
using Parcial02.Entities.Specialties;
using Parcial02.Entities.Users;

namespace Parcial02.Context
{
    public class ClinicContext : DbContext

    {
        public DbSet<User> Users { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Specialty> Specialties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Server=QUIQUE;Database=Parcial02;Trusted_Connection=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .Property(R => R.IdReser)
                .ValueGeneratedOnAdd(); //Se auto incrementa  
        }
    }
}