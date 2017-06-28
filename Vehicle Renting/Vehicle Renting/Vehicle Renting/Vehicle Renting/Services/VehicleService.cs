using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Renting.Classes;
using System.Configuration;
using Vehicle_Renting.Services;

namespace Vehicle_Renting.Services
{
    public class VehicleService : IVehicle
    {
        public List<Vehicle> RetrieveVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            {
                vehicles.Add(new Vehicle(
                    "Ford",
                    "T812",
                    "2014",
                    "1 ABD 760",
                    "294.0",
                    "2",
                    "10L/100km",
                    "No"));

                return vehicles;
            }
        }
    }
}
