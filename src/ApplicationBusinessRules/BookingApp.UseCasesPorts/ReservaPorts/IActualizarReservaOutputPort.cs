using BookingApp.DTOs;

namespace BookingApp.UseCasesPorts.ReservaPorts
{
    public interface IActualizarReservaOutputPort
    {
        Task Handle(ReservaDTO reserva);
    }
}
