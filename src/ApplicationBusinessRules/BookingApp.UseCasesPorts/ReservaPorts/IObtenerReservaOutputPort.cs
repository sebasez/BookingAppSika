using BookingApp.DTOs;

namespace BookingApp.UseCasesPorts.ReservaPorts
{
    public interface IObtenerReservaOutputPort
    {
        Task Handle(ReservaDTO reserva);
    }
}
