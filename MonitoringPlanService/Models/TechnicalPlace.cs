namespace MonitoringPlanService.Models
{
    public record TechnicalPlace
    {
        public string Name { get; set; } = default!;

        public List<Equipment> Equipments { get; set; } = default!;
    }
}
