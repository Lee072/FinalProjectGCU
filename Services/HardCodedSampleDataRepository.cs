using SeniorProject.Models;

namespace SeniorProject.Services
{
    public class HardCodedSampleDataRepository : IDevicesDataService
    {
        //use static to ensure the data set does not change
        static List<DeviceModel> deviceList;

        //create the list in the constructor of the service

        public HardCodedSampleDataRepository()
        {
            deviceList = new List<DeviceModel>();
 
            deviceList.Add(new DeviceModel(1, "Door Cam", true, true));
            deviceList.Add(new DeviceModel(2, "Backyard Cam", false, true));
            deviceList.Add(new DeviceModel(3, "Kitchen Cam", false, false));
            deviceList.Add(new DeviceModel(4, "Livingroom Cam", true, true));
            deviceList.Add(new DeviceModel(5, "Bird Watcher", true, true));

        }


        public List<DeviceModel> AllProducts()
        {
            return deviceList;
        }

        public bool Delete(DeviceModel device)
        {
            throw new NotImplementedException();
        }

        public int Insert(DeviceModel device)
        {
            throw new NotImplementedException();
        }

        public int Update(DeviceModel device)
        {
            throw new NotImplementedException();
        }
    }
}
