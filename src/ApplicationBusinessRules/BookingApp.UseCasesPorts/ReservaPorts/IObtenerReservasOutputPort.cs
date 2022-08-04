using BookingApp.DTOs;

namespace BookingApp.UseCasesPorts.ReservaPorts
{
    public interface IObtenerReservasOutputPort
    {
        Task Handle(IEnumerable<ReservaDTO> reservas);
    }
}
