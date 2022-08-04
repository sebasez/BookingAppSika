using BookingApp.Entities.Interfaces;
using BookingApp.Entities.POCOs;

namespace BookingApp.Repository.Repositories
{
    public class SalaRepository : ISalaRepository
    {
        public Task CrearSala(Sala sala)
        {
            throw new NotImplementedException();
        }

        public Task<Sala> ObtenerSala(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Sala>> ObtenerSalas()
        {
            throw new NotImplementedException();
        }
    }
}
