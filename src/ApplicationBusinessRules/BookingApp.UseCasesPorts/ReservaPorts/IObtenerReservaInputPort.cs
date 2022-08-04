using BookingApp.DTOs;

namespace BookingApp.UseCasesPorts.ReservaPorts
{
    public interface IObtenerReservaInputPort
    {
        Task Handle(ObtenerReservaDTO obtenerReserva);
    }
}
