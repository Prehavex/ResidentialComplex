using RC.Interfaces;
using System;

namespace RC.Models
{
    class Garage : IParkable
    {
        public bool IsFree { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsPrivate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void FreePlace()
        {
            throw new NotImplementedException();
        }

        public void TakePlace()
        {
            throw new NotImplementedException();
        }
    }
}
