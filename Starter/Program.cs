using RC.Models;
using RC.Modules;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ParkingPlace> ParkPlaces = new List<ParkingPlace>()
            {
                new ParkingPlace { Id = 0, IsFree = true, IsStuffOnly = true, IsPrivate = false},
                new ParkingPlace { Id = 1, IsFree = true, IsStuffOnly = false, IsPrivate = true},
                new ParkingPlace { Id = 2, IsFree = false, IsStuffOnly = false, IsPrivate = false},
                new ParkingPlace { Id = 3, IsFree = false, IsStuffOnly = true, IsPrivate = true},
                new ParkingPlace { Id = 4, IsFree = true, IsStuffOnly = false, IsPrivate = false},
                new ParkingPlace { Id = 5, IsFree = true, IsStuffOnly = true, IsPrivate = true},
                new ParkingPlace { Id = 6, IsFree = true, IsStuffOnly = false, IsPrivate = false}
            };
            ParkingObserving.SerializeParkPlaces("Parking.json", ParkPlaces);
            List<ParkingPlace> ParkPlacesDes = ParkingObserving.DeserializeParkPlaces("Parking.json");
            ParkingObserving.GetPlacesInfo(ParkPlacesDes);

            List<Dweller> dwellers = new List<Dweller> {
                new Dweller { Name = "Александр", Surname = "Попов", Patronymic = "Игоревич" }, 
                new Dweller { Name = "Василий", Surname = "Попов", Patronymic = "Александрович" }, 
                new Dweller { Name = "Василий", Surname = "Чапаев", Patronymic = "Иванович" }, 
            };
            List<Dweller> choosenDwellers = UserControl<Dweller>.UsersByNames("василий", dwellers); //using regex
            var CDSorted = choosenDwellers.OrderByDescending(n => n.Surname);
            Console.WriteLine($"Choosen by name 'Василий'");
            foreach (Dweller item in CDSorted)
            {
                Console.WriteLine($"  {item.GetFullName()}");
            }

            Console.ReadKey();
        }
    }
}