using DAL.Models;
using DAL.Repository;
using System;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        BaseRepository<Apartment> Apartments { get; set; }
        BaseRepository<House> Houses { get; set; }
        BaseRepository<Garage> Garages { get; set; }
        BaseRepository<ParkingPlace> ParkingPlaces { get; set; }
        BaseRepository<Dweller> Dwellers { get; set; }
        BaseRepository<Worker> Workers { get; set; }
        public void Save();
    }
}
