using DAL.DataContext;
using DAL.Interfaces;
using DAL.Models;
using System;

namespace DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        RCContext db;
        public BaseRepository<Apartment> Apartments { get; set; }
        public BaseRepository<House> Houses { get; set; }
        public BaseRepository<Garage> Garages { get; set; }
        public BaseRepository<ParkingPlace> ParkingPlaces { get; set; }
        public BaseRepository<Dweller> Dwellers { get; set; }
        public BaseRepository<Worker> Workers { get; set; }

        public UnitOfWork(RCContext context)
        {
            db = context;
            Apartments = new BaseRepository<Apartment>(db);
            Houses = new BaseRepository<House>(db);
            Garages = new BaseRepository<Garage>(db);
            ParkingPlaces = new BaseRepository<ParkingPlace>(db);
            Dwellers = new BaseRepository<Dweller>(db);
            Workers = new BaseRepository<Worker>(db);
        }

        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                disposed = true;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
