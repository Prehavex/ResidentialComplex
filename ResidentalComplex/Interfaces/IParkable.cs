

using System;

namespace RC.Interfaces
{
    public interface IParkable
    {
        public Guid Id { get; set; }
        public bool IsFree { get; set; }
        public bool IsPrivate { get; set; }

        public void FreePlace();
        public void TakePlace();
    }
}
