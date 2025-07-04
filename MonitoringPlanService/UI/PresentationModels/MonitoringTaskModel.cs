﻿using MonitoringPlanService.UI.Interfaces;

namespace MonitoringPlanService.UI.PresentationModels
{
    public class MonitoringTaskModel : IPresentationModel
    {
        public string? CharacteristicName { get; set; }

        public void Print(int indentLevel = 0)
        {
            string indent = new string(' ', indentLevel * 2);
            Console.WriteLine($"{indent}{CharacteristicName}");
        }
    }
}
