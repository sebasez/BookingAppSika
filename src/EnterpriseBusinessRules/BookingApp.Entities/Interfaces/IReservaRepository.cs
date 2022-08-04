using BookingApp.Entities.POCOs;

namespace BookingApp.Entities.Interfaces
{
    public interface IReservaRepository
    {
        Task CrearReserva(Reserva reserva);
        Task EliminarReserva(Guid id);
        Task<Reserva> ObtenerReserva(Guid id);
        Task<Reserva> ActualizarReserva(Guid id, Reserva reserva);
        Task<List<Reserva>> ObtenerReservas();

    }
}
