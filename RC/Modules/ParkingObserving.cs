using RC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace RC.Modules
{
    public class ParkingObserving
    {
        public static void SerializeParkPlaces(string path, List<ParkingPlace> parkingPlaces)
        {
            File.WriteAllText(path, JsonSerializer.Serialize<List<ParkingPlace>>(parkingPlaces));
        }
        public static List<ParkingPlace> DeserializeParkPlaces(string path)
        {
            return JsonSerializer.Deserialize<List<ParkingPlace>>(File.ReadAllText(path));
        }
        public static void GetPlacesInfo(List<ParkingPlace> parkingPlaces)
        {
            var PPD = from par in parkingPlaces
                      where par.IsFree == true
                      orderby par.Id
                      select par;

            var PPDE = PPD.Where(p => p.Id > 1).OrderByDescending(i => i.Id).GroupBy(p => p.IsStuffOnly);

            Console.WriteLine("Free parking places");
            foreach (var group in PPDE)
            {
                if (group.Key)
                    Console.WriteLine("  For employees: ");
                else
                    Console.WriteLine($"  For all: ");
                foreach (var item in group)
                {
                    Console.WriteLine($"    Place №{item.Id}");
                }
            }
        }
    }
}
