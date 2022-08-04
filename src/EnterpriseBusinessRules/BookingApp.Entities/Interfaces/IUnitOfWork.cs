namespace BookingApp.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> Guardar();
    }
}
