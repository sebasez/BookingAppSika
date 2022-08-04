using BookingApp.DTOs;

namespace BookingApp.UseCasesPorts.ReservaPorts
{
    public interface IEliminarReservaInputPort
    {
        Task Handle(EliminarReservaDTO eliminarReserva);
    }
}
