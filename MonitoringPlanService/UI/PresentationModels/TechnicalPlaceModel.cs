using MonitoringPlanService.UI.Interfaces;

namespace MonitoringPlanService.UI.PresentationModels
{
    public class TechnicalPlaceModel : IPresentationModel
    {
        public string? Name { get; set; }
        public List<EquipmentModel>? Equipments { get; set; }

        public void Print(int indentLevel = 0)
        {
            string indent = new string(' ', indentLevel * 2);
            Console.WriteLine($"{indent}{Name} (Equipments: {Equipments.Count})");

            foreach (var equipment in Equipments)
            {
                equipment.Print(indentLevel + 1);
            }
        }
    }
}
