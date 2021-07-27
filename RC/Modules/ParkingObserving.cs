using RC.Models;
using System.IO;
using System.Text.Json;

namespace RC.Modules
{
    public class ParkingObserving
    {
        public void SerializeParkPlace(string path, ParkingPlace parkingPlace)
        {
            File.WriteAllText(path, JsonSerializer.Serialize<ParkingPlace>(parkingPlace));
        }
    }
}
