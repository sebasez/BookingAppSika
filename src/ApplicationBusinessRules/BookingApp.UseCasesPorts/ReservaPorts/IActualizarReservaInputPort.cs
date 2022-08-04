using BookingApp.DTOs;

namespace BookingApp.UseCasesPorts.ReservaPorts
{
    public interface IActualizarReservaInputPort
    {
        Task Handle(ActualizarReservaDTO actualizarReserva);
    }
}
