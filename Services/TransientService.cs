namespace TodoAPI.Services
{
    public class TransientService : IWeatherIdService
    {
        private Guid _id = Guid.NewGuid();
        public Guid GetOperationId() => _id;
    }
}