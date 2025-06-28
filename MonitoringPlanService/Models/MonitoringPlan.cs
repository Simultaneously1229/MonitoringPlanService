namespace MonitoringPlanService.Models
{
    public record MonitoringPlan
    {
        public List<GeneralTechnicalPlace> TechnicalPlaces { get; set; } = default!;
    }
}
