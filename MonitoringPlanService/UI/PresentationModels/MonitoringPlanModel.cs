using MonitoringPlanService.Models;
using MonitoringPlanService.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlanService.UI.PresentationModels
{
    public class MonitoringPlanModel : IPresentationModel
    {
        public List<GeneralTechnicalPlaceModel>? TechnicalPlaces { get; set; }

        public void Print(int indentLevel = 0)
        {
            foreach (var tp in TechnicalPlaces)
            {
                tp.Print();
            }
        }
    }
}
