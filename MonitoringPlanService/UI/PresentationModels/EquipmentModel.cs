using MonitoringPlanService.UI.Interfaces;

namespace MonitoringPlanService.UI.PresentationModels
{
    public class EquipmentModel : IPresentationModel
    {
        public string? Name { get; set; }
        public List<MonitoringTaskModel>? MonitoringTasks { get; set; }

        public void Print(int indentLevel = 0)
        {
            string indent = new string(' ', indentLevel * 2);
            Console.WriteLine($"{indent}{Name} (MonitoringTasks: {MonitoringTasks.Count})");

            foreach (var task in MonitoringTasks)
            {
                task.Print(indentLevel + 1);
            }
        }
    }
}
