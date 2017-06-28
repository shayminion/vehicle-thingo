using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Renting.Classes;

namespace Vehicle_Renting.Services
{
    public interface IJourney
    {
        Journey UpdateJourneyParameters(Journey journey); // changing specifically the journey part of the form
    }
}
