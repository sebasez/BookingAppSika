namespace BookingApp.Entities.Exceptions
{
    public class GeneralException : Exception
    {
        public string Detalle { get; set; }
        public GeneralException() { }
        public GeneralException(string message) : base(message) { }
        public GeneralException(string message, Exception exception) : base(message, exception) { }
        public GeneralException(string titulo, string detalle) : base(titulo) =>
            Detalle = detalle;
    }
}
