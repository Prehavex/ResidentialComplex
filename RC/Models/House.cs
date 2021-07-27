using System.Collections.Generic;

namespace RC.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public List<Apartment> Apartments { get; set; }
    }
}
