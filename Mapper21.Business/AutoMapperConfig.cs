using System;
using AutoMapper;
using AutoMapper.Mappers;
using Mapper21.Business.Dto;
using Mapper21.Business.Dto.LookUps;
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
                    //Non-Grid Mappings
                    cfg.CreateMap<Section, SectionDto>()
                        .ReverseMap();

                    cfg.CreateMap<SubSection, SubSectionDto>()
                        .ReverseMap();

                    cfg.CreateMap<Habit, HabitLookupDto>()
                        .ReverseMap();

                    cfg.CreateMap<ScienceBigIdea, ScienceBigIdeaLookupDto>()
                        .ReverseMap();

                    cfg.CreateMap<SocialStudiesBigIdea, SocialStudiesBigIdeaLookupDto>()
                        .ReverseMap();

                    cfg.CreateMap<CommonCoreStandard, CommonCoreStandardLookupDto>()
                        .ReverseMap();

                    cfg.CreateMap<SubSectionSta, StaDto>()
                        .ReverseMap();

                    cfg.CreateMap<SubSectionLongTermTarget, LongTermTargetDto>()
                        .ReverseMap();

                    cfg.CreateMap<SubSectionStaGrid, StaGridDto>()
                        .ReverseMap();

                    //Grid Sections
                    cfg.CreateMap<GridDto, SectionHabit>()
                        .ForMember(dest => dest.SectionId, opt => opt.MapFrom(src => src.ParentId));
                    cfg.CreateMap<SectionHabit, GridDto>()
                        .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.SectionId));

                    cfg.CreateMap<GridDto, SectionScienceBigIdea>()
                        .ForMember(dest => dest.SectionId, opt => opt.MapFrom(src => src.ParentId));
                    cfg.CreateMap<SectionScienceBigIdea, GridDto>()
                        .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.SectionId));

                    cfg.CreateMap<GridDto, SectionSocialStudiesBigIdea>()
                        .ForMember(dest => dest.SectionId, opt => opt.MapFrom(src => src.ParentId));
                    cfg.CreateMap<SectionSocialStudiesBigIdea, GridDto>()
                        .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.SectionId));

                    cfg.CreateMap<GridDto, SectionOtherBigIdea>()
                        .ForMember(dest => dest.SectionId, opt => opt.MapFrom(src => src.ParentId));
                    cfg.CreateMap<SectionOtherBigIdea, GridDto>()
                        .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.SectionId));


                    // Grid SubSections
                    cfg.CreateMap<GridDto, SubSectionHabit>()
                        .ForMember(dest => dest.SubSectionId, opt => opt.MapFrom(src => src.ParentId));
                    cfg.CreateMap<SubSectionHabit, GridDto>()
                        .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.SubSectionId));

                    cfg.CreateMap<GridDto, SubSectionExpert>()
                        .ForMember(dest => dest.SubSectionId, opt => opt.MapFrom(src => src.ParentId));
                    cfg.CreateMap<SubSectionExpert, GridDto>()
                        .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.SubSectionId));

                    cfg.CreateMap<GridDto, SubSectionFieldwork>()
                        .ForMember(dest => dest.SubSectionId, opt => opt.MapFrom(src => src.ParentId));
                    cfg.CreateMap<SubSectionFieldwork, GridDto>()
                        .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.SubSectionId));

                    cfg.CreateMap<GridDto, SubSectionServiceLearning>()
                        .ForMember(dest => dest.SubSectionId, opt => opt.MapFrom(src => src.ParentId));
                    cfg.CreateMap<SubSectionServiceLearning, GridDto>()
                        .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.SubSectionId));

                    // Grid STAs
                    cfg.CreateMap<GridDto, SubSectionStandard>()
                        .ForMember(dest => dest.SubSectionStaId, opt => opt.MapFrom(src => src.ParentId));
                    cfg.CreateMap<SubSectionStandard, GridDto>()
                        .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.SubSectionStaId));

                    cfg.CreateMap<GridDto, SubSectionShortTermTarget>()
                        .ForMember(dest => dest.SubSectionStaId, opt => opt.MapFrom(src => src.ParentId));
                    cfg.CreateMap<SubSectionShortTermTarget, GridDto>()
                        .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.SubSectionStaId));


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
