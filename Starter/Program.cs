using RC.Models;
using RC.Modules;
using System;

namespace Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingPlace parkingPlace = new ParkingPlace { IsFree = true, IsStuffOnly = true };
            ParkingObserving parkingObserving = new ParkingObserving();
            parkingObserving.SerializeParkPlace("park.json", parkingPlace);
        }
    }
}
