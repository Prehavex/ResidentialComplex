using DAL.Interfaces;
using System;

namespace DAL.Models
{
    public class Garage : IParkable
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public bool IsFree { get { return Owner == null ? true : false; } set { IsFree = Owner == null ? true : false; } }
        public Guid? DwellerId { get; set; }
        public Dweller Owner { get; set; }

        public void FreePlace()
        {
            Owner = null;
            IsFree = true;
        }
        public void TakePlace()
        {
            IsFree = false;
        }
        public void BecomeBought(Dweller newOwner)
        {
            Owner = newOwner;
            TakePlace();
        }
    }
}
