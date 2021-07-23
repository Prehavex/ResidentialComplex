using System;

namespace RC.Models
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
