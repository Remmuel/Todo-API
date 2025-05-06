namespace TodoAPI.Services
{
    public class SingletonService : IWeatherIdService
    {
        private Guid _id = Guid.NewGuid();
        public Guid GetOperationId() => _id;
    }
}