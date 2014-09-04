using System;
using AutoMapper;
using AutoMapper.Mappers;
using Mapper21.Business.Dto;
using Mapper21.Domain;
using Mapper21.Domain.LookUps;

namespace Mapper21.Business
{
    public static class AutoMapperConfig
    {
        public static void Init()
        {
            try
            {
                var useless = new ListSourceMapper();
                Mapper.Initialize(cfg =>
                {
                    //Automapper config for Client section
                    cfg.CreateMap<Section, SectionDto>()
                        .ReverseMap();

                    cfg.CreateMap<Habit, HabitDto>()
                        .ReverseMap();

                    cfg.CreateMap<ScienceBigIdea, ScienceBigIdeaDto>()
                        .ReverseMap();

                    cfg.CreateMap<SocialStudiesBigIdea, SocialStudiesBigIdeaDto>()
                        .ReverseMap();

                    cfg.CreateMap<CommonCoreStandard, CommonCoreStandardDto>()
                        .ReverseMap();
                });
            }
            catch (AutoMapperConfigurationException ace)
            {
                throw ace;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
