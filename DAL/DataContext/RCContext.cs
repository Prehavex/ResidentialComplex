using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataContext
{
    public class RCContext : DbContext
    {
        public DbSet<Dweller> Dwellers { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<ParkingPlace> ParkingPlaces { get; set; }
        public DbSet<Garage> Garages { get; set; }
        public RCContext()
        {

        }
        public RCContext(DbContextOptions<RCContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {

        }
    }
}
