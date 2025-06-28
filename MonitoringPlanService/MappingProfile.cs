using AutoMapper;
using MonitoringPlanService.Models;
using MonitoringPlanService.UI.PresentationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlanService
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<GeneralTechnicalPlace, GeneralTechnicalPlaceModel>().ReverseMap();
            CreateMap<MonitoringPlan, MonitoringPlanModel>().ReverseMap();
            CreateMap<MonitoringTask, MonitoringTaskModel>().ReverseMap();
            CreateMap<TechnicalPlace, TechnicalPlaceModel>().ReverseMap();
            CreateMap<Equipment, EquipmentModel>().ReverseMap();
        }
    }
}
