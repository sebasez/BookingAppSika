using BookingApp.Entities.Interfaces;
using BookingApp.Entities.POCOs;

namespace BookingApp.Repository.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        public Task<Reserva> ActualizarReserva(Guid id, Reserva reserva)
        {
            throw new NotImplementedException();
        }

        public Task CrearReserva(Reserva reserva)
        {
            throw new NotImplementedException();
        }

        public Task EliminarReserva(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Reserva> ObtenerReserva(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Reserva>> ObtenerReservas()
        {
            throw new NotImplementedException();
        }
    }
}
