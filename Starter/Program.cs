using RC.Models;
using RC.Modules;
using System.Collections.Generic;
using System;

namespace Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingPlace parkingPlace = new ParkingPlace { IsFree = true, IsStuffOnly = true };
            ParkingObserving.SerializeParkPlace("park.json", parkingPlace);
            List<Dweller> dwellers = new List<Dweller> {
                new Dweller { Name = "Александр", Surname = "Попов", Patronymic = "Игоревич" }, 
                new Dweller { Name = "Василий", Surname = "Попов", Patronymic = "Александрович" }, 
                new Dweller { Name = "Василий", Surname = "Чапаев", Patronymic = "Иванович" }, 
            };
            List<Dweller> choosenDwellers = UserControl<Dweller>.UsersByNames("василий", dwellers);
            foreach (Dweller item in choosenDwellers)
            {
                Console.WriteLine(item.GetFullName());
            }
            Console.ReadKey();
        }
    }
}
