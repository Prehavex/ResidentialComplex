using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC.Models
{
    class Worker : User
    {
        public string AccessLevel { get; set; }
        public double Salary { get; set; }
        public List<DateTime> Schedule { get; set; }
    }
}
