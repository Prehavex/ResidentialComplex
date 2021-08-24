using System;

namespace RC.Models
{
    public class Dweller : User
    {
        public Apartment PersonalApartment { get; set; }
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
