using System;
using AutoMapper;
using AutoMapper.Mappers;
using Mapper21.Business.Dto;
using Mapper21.Domain;

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
