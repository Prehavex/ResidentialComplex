using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidentialComplex.Domain.Core
{
    public abstract class User
    {
        public Guid Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDay { get; set; }
        public int? PhoneNumber { get; set; }
        public string? Email { get; set; }

        public User()
        {
        }

        public string GetFullName()
        {
            throw new NotImplementedException();
        }

    }
}
