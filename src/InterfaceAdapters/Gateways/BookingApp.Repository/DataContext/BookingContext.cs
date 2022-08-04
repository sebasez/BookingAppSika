using BookingApp.Entities.POCOs;
using Microsoft.EntityFrameworkCore;

namespace BookingApp.Repository.DataContext
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options)
            : base(options) { }

        public DbSet<Sala> Salas { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sala>()
                .Property(p => p.Id)
                .HasColumnName(nameof(Sala) + "Id");
            modelBuilder.Entity<Sala>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<Recurso>()
                .Property(p => p.Id)
                .HasColumnName(nameof(Recurso) + "Id");
            modelBuilder.Entity<Recurso>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<Reserva>()
                .Property(p => p.Id)
                .HasColumnName(nameof(Reserva) + "Id");
            modelBuilder.Entity<Reserva>()
                .HasKey(t => t.Id);
        }
    }
}
