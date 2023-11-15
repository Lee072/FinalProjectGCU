using System.Diagnostics.Eventing.Reader;

namespace SeniorProject.Models
{
    public class DeviceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Alert { get; set; }
        public bool Powered {  get; set; }

        public DeviceModel (int id, string name, bool alert, bool powered)
        {
            Id = id;
            Name = name;
            Alert = alert;
            Powered = powered;
        }
    }
}
