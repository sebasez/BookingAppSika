using BookingApp.Entities.Interfaces;

namespace BookingApp.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public Task<int> Guardar()
        {
            throw new NotImplementedException();
        }
    }
}
