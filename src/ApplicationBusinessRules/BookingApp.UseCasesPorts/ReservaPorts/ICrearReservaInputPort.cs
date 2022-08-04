using BookingApp.DTOs;

namespace BookingApp.UseCasesPorts.ReservaPorts
{
    public interface ICrearReservaInputPort
    {
        Task Handle(CrearReservaDTO crearReserva);
    }
}
