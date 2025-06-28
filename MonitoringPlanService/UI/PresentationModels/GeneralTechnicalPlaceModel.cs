using MonitoringPlanService.UI.Interfaces;

namespace MonitoringPlanService.UI.PresentationModels
{
    public class GeneralTechnicalPlaceModel : IPresentationModel
    {
        public string Name { get; set; } = default!;

        public List<TechnicalPlaceModel>? TechnicalPlaces { get; set; }

        public void Print(int indentLevel = 0)
        {
            string indent = new string(' ', indentLevel * 2);
            Console.WriteLine($"{indent}{Name} (TechnicalPlaces: {TechnicalPlaces?.Count})");

            foreach (var tp in TechnicalPlaces)
            {
                tp.Print(indentLevel + 1);
            }
        }
    }
}
