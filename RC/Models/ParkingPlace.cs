using RC.Interfaces;

namespace RC.Models
{
    class ParkingPlace : IParkable
    {
        public bool IsFree { get; set; }
        public bool IsPrivate { get { return IsPrivate; } set { IsPrivate = true; } }
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
