using System.Collections.Generic;
using System.Threading.Tasks;
using Hotel_Schwanen.Models;

namespace Hotel_Schwanen.Interfaces
{
    public interface IAdditionalServiceService
    {
        Task<List<AdditionalService>> GetAllServices();
        Task<AdditionalService> GetServiceById(string id);
        Task AddService(AdditionalService service);
        Task UpdateService(string id, AdditionalService serviceIn);
        Task DeleteService(string id);
    }
}