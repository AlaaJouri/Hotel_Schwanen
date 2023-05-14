using Hotel_Schwanen.Interfaces;
using Hotel_Schwanen.Models;
using MongoDB.Driver;

namespace Hotel_Schwanen.Services
{
    public class AdditionalServiceService : IAdditionalServiceService
    {
        private readonly IMongoCollection<AdditionalService> _services;
        public AdditionalServiceService(IMongoDbSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _services = database.GetCollection<AdditionalService>(settings.CollectionName);
        }

        public async Task<List<AdditionalService>> GetAllServices()
        {
            return await _services.Find(service => true).ToListAsync();
        }

        public async Task<AdditionalService> GetServiceById(string id)
        {
            return await _services.Find(service => service.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddService(AdditionalService service)
        {
            await _services.InsertOneAsync(service);
        }

        public async Task UpdateService(string id, AdditionalService serviceIn)
        {
            await _services.ReplaceOneAsync(service => service.Id == id, serviceIn);
        }

        public async Task DeleteService(string id)
        {
            await _services.DeleteOneAsync(service => service.Id == id);
        }
    }

}
