using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Renting.Classes
{
    public class Vehicle
    {
        public Vehicle() { }

        public Vehicle(string Manufacturer, string Model, string MakeYear, string RegistrationNumber, string TotalKMTravelled, string TotalServices, string FuelEconomy, string RequiresAService)
        {
            manufacturer = Manufacturer;
            model = Model;
            makeYear = MakeYear;
            registrationNo = RegistrationNumber;
            totalKm = TotalKMTravelled;
            totalServices = TotalServices;
            FuelEcon = FuelEconomy;
            RequiredService = RequiresAService;
        }

        public Vehicle(string TotalKMTravelled, string TotalServices, string RequiresAService)
        {
            totalKm = TotalKMTravelled;
            totalServices = TotalServices;
            RequiredService = RequiresAService;
        }
        
        public Vehicle(string FuelEconomy)
        {
            FuelEcon = FuelEconomy;
        }


        public string manufacturer { get; set; }

        public string model { get; set; } 

        public string makeYear { get; set; }

        public string registrationNo { get; set; }

        public string totalKm { get; set; }

        public string totalServices { get; set; }

        public string FuelEcon { get; set; }

        public string RequiredService { get; set; }

    }
}