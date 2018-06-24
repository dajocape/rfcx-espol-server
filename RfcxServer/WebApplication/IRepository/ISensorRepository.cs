using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.IRepository
{
    public interface ISensorRepository
    {
        Task<IEnumerable<Sensor>> Get();
        Task<Sensor> Get(string id);
        Task<Sensor> Get(int id);
        Task<Sensor> Get(int DeviceId, int SensorId);
        Sensor getSensor(int id);
        Task<IEnumerable<Sensor>> GetByDevice(int DeviceId);
        Task Add(Sensor item);
        Task<bool> Update(string id, Sensor item);
        Task<bool> Remove(string id);
        Task<bool> RemoveAll();
    }
}