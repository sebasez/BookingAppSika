namespace BookingApp.Entities.POCOs
{
    public class Reserva: Entity
    {
        public string? NombreReserva { get; set; }
        public DateTime FechaInicioReserva { get; set; }
        public DateTime FechaFinReserva { get; set; }
        public Guid SalaId { get; set; }
        public virtual Sala? Sala { get; set; }
        public virtual ICollection<Recurso>? Recursos { get; set; }
    }
}
