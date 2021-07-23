using RC.Interfaces;

namespace RC.Models
{
    class ParkingPlace : IParkable
    {
        public bool IsFree { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool IsPrivate { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void FreePlace()
        {
            throw new System.NotImplementedException();
        }

        public void TakePlace()
        {
            throw new System.NotImplementedException();
        }
    }
}
