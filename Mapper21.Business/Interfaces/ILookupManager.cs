using System;
using System.Collections.Generic;
using Mapper21.Business.Dto.LookUps;

namespace Mapper21.Business.Interfaces
{
    public interface ILookupManager : IDisposable
    {
        IList<HabitLookupDto> GetHabits();
        IList<ScienceBigIdeaLookupDto> GetBigIdeaForSciences();
        IList<SocialStudiesBigIdeaLookupDto> GetBigIdeaForSocialStudies();
        IList<CommonCoreStandardLookupDto> GetCommonCoreStandards();
    }
}