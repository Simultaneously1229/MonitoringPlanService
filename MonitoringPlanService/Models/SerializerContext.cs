using MonitoringPlanService.Services;
using System.Text.Json.Serialization;

namespace MonitoringPlanService.Models
{
    [JsonSourceGenerationOptions(
    GenerationMode = JsonSourceGenerationMode.Default)]
    [JsonSerializable(typeof(JsonRpcResponse<MonitoringPlan>))]
    public partial class SerializerContext : JsonSerializerContext
    {
    }
}
