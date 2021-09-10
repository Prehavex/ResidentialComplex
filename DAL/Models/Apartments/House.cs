using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public class House : IEntity
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public List<Apartment> Apartments { get; set; }
    }
}
