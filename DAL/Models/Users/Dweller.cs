using System;

namespace DAL.Models
{
    public class Dweller : User
    {
        public Guid? ApartmentId { get; set; }
        public Apartment PersonalApartment { get; set; }
        public Guid? GarageId { get; set; }
        public Garage PersonalGarage { get; set; }
        public bool IsAdult()
        {
            if (BirthDay.AddYears(18).CompareTo(DateTime.Today) <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
