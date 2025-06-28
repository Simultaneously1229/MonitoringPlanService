using MonitoringPlanService.UI.Interfaces;

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
