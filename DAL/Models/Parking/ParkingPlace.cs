using DAL.Interfaces;
using System;

namespace DAL.Models
{
    public class ParkingPlace : IParkable
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public bool IsFree { get; set; }
        public bool IsStuffOnly { get; set; }

        public void FreePlace()
        {
            IsFree = true;
        }

        public void TakePlace()
        {
            IsFree = false;
        }
    }
}
