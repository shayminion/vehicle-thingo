using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Renting.Classes;
using Vehicle_Renting.Services;

namespace Vehicle_Renting
{
    public partial class VehiclesForRent : Form
    {
        private readonly IVehicle vehiclesService;

        public VehiclesForRent()
        {
            vehiclesService = new VehicleService();
            InitializeComponent();
            
        }

        private void btnViewVehicles_Click(object sender, EventArgs e)
        {
            listBoxVehicles.Items.Clear();

            try
            {
                List<Vehicle> vehicles = new List<Vehicle>();
                vehicles = vehiclesService.RetrieveVehicles();

                if (vehicles != null && vehicles.Count > 0)
                {
                    foreach (Vehicle v in vehicles)
                    {
                        listBoxVehicles.Items.Add($"{v.manufacturer} {v.model}, {v.makeYear}");
                    }
                }
                else
                {
                    listBoxVehicles.Items.Add("No vehicles found.");
                }
            }
            catch (Exception ex)
            {
                listBoxVehicles.Items.Add(ex.StackTrace);
            }
        }

        private void listBoxVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int l = 0; l < 1; l++)
            {
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtManufacturer.Clear();
            txtModel.Clear();
            txtMakeYear.Clear();
            txtRegistrationNo.Clear();
            txtTotalKm.Clear();
            txtTotalServices.Clear();
            txtFuelEconomy.Clear();
            txtServiceRequired.Clear();
            listBoxVehicles.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
