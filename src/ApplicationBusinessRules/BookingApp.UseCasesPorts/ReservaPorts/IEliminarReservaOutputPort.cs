using BookingApp.DTOs;

namespace BookingApp.UseCasesPorts.ReservaPorts
{
    public interface IEliminarReservaOutputPort
    {
        Task Handle(ReservaDTO reserva);
    }
}
