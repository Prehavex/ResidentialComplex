using RC.Interfaces;
using System;

namespace RC.Models
{
    public class Garage : IParkable
    {
        public Dweller Owner { get; set; }
        public bool IsFree { get { return IsFree; } set { IsFree = Owner == null ? true : false; } }
        public bool IsPrivate { get { return IsPrivate; } set { IsPrivate = true; } }

        public void FreePlace()
        {
            Owner = null;
            IsFree = true;
        }

        public void TakePlace()
        {
            IsFree = false;
        }
        public void BecomeBought(Dweller NewOwner)
        {
            Owner = NewOwner;
            TakePlace();
        }
    }
}
