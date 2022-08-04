using BookingApp.Entities.POCOs;

namespace BookingApp.Entities.Interfaces
{
    public interface ISalaRepository
    {
        Task CrearSala(Sala sala);
        Task<Sala> ObtenerSala(Guid id);
        Task<List<Sala>> ObtenerSalas();
    }
}
