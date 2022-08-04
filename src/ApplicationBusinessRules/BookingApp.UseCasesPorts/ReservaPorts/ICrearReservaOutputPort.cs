using BookingApp.DTOs;

namespace BookingApp.UseCasesPorts.ReservaPorts
{
    public interface ICrearReservaOutputPort
    {
        Task Handle(ReservaDTO reserva);
    }
}
