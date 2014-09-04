using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface ILookupManager : IDisposable
    {
        IList<HabitDto> GetHabits();
        IList<ScienceBigIdeaDto> GetBigIdeaForSciences();
        IList<SocialStudiesBigIdeaDto> GetBigIdeaForSocialStudies();
        IList<CommonCoreStandardDto> GetCommonCoreStandards();
    }
}