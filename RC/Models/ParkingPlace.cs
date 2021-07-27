using RC.Interfaces;

namespace RC.Models
{
    public class ParkingPlace : IParkable
    {
        public int Id { get; set; }
        public bool IsFree { get; set; }
        public bool IsPrivate { get { return false; } set { IsPrivate = false; } }
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
