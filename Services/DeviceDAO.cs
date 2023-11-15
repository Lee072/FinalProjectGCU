using SeniorProject.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System;
using System.Data.SqlClient;

namespace SeniorProject.Services
{
    public class DeviceDAO : IDevicesDataService
    {

        //connection string from database
        string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SeniorTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public List<DeviceModel> AllProducts()
        {
            //assuming nothing is found
            List<DeviceModel> foundDevices = new List<DeviceModel>();

            string sqlStatement = "SELECT * FROM dbo.Devices";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
            }
            return foundDevices;
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
