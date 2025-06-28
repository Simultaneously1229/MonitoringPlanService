using MonitoringPlanService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MonitoringPlanService.Models
{
    [JsonSourceGenerationOptions(
    GenerationMode = JsonSourceGenerationMode.Default)]
    [JsonSerializable(typeof(JsonRpcResponse<MonitoringPlan>))]
    public partial class SerializerContext : JsonSerializerContext
    {
    }
}
