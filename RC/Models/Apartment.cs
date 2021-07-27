using System.Collections.Generic;

namespace RC.Models
{
    public class Apartment
    {
        public int Id { get; set; }
        public double Cost{ get; set; }
        public double Utilities { get; set; }
        public int Area { get; set; } //m^2
        public string Description { get; set; }
        public List<Dweller> Owners { get; set; }
        public House WhichHouse { get; set; }
    }
}
