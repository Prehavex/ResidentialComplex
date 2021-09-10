using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public class Worker : User
    {
        public string AreaOfResponsibility { get; set; }
        public string AccessLevel { get; set; }
        public double Salary { get; set; }
        public string Schedule { get; set; }
    }
}
