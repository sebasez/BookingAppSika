using BookingApp.Entities.Interfaces;
using BookingApp.Entities.POCOs;

namespace BookingApp.Repository.Repositories
{
    public class RecursoRepository : IRecursoRepository
    {
        public Task CrearRecurso(Recurso recurso)
        {
            throw new NotImplementedException();
        }

        public Task EliminarRecurso(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Recurso>> ObtenerRecursos()
        {
            throw new NotImplementedException();
        }
    }
}
