using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RC.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDay { get; set; }
        public bool IsHasCar { get; set; }
        public int? PhoneNumber { get; set; }
        public string? Email { get; set; }

        public string GetFullName()
        {
            return Surname + " " + Name + " " + Patronymic;
        }

    }
}
