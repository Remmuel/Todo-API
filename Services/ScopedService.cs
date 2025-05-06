namespace TodoAPI.Services
{
    public class ScopedService : IWeatherIdService
    {
        private Guid _id = Guid.NewGuid();
        public Guid GetOperationId() => _id;
    }
}