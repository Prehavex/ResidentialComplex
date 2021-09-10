using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public class Apartment : IEntity
    {
        public Guid Id { get; set; }
        public double Cost{ get; set; }
        public double Utilities { get; set; }
        public int Area { get; set; } //m^2
        public string Description { get; set; }
        public List<Dweller> Dwellers { get; set; }
        public Guid HouseId { get; set; }
        public House House { get; set; }
    }
}
