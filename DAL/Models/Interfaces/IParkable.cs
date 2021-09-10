using DAL.Models.Interfaces;

namespace DAL.Interfaces
{
    public interface IParkable : IEntity
    {
        public bool IsFree { get; set; }
        public string Number { get; set; }
        public void FreePlace();
        public void TakePlace();
    }
}
