using System;
using System.Collections.Generic;

namespace RC.Models
{
    class Worker : User
    {
        public string AccessLevel { get; set; }
        public double Salary { get; set; }
        public List<DateTime> Schedule { get; set; }
    }
}
