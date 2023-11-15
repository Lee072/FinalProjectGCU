using SeniorProject.Models;

namespace SeniorProject.Services
{
    public interface IDevicesDataService
    {
        List<DeviceModel> AllProducts();
        
        int Insert(DeviceModel device);
        bool Delete(DeviceModel device);
        int Update(DeviceModel device);


    }
}
