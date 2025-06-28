namespace MonitoringPlanService.Models
{
    public record GeneralTechnicalPlace
    {
        public string Name { get; set; } = default!;

        public List<TechnicalPlace> TechnicalPlaces { get; set; } = default!;
    }
}
