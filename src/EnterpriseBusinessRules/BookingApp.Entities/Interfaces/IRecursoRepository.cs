using BookingApp.Entities.POCOs;

namespace BookingApp.Entities.Interfaces
{
    public interface IRecursoRepository
    {
        Task CrearRecurso(Recurso recurso);
        Task EliminarRecurso(Guid id);
        Task<List<Recurso>> ObtenerRecursos();
    }
}
