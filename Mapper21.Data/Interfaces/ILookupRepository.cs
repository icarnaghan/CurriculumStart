using System;
using System.Collections.Generic;
using Mapper21.Domain.LookUps;

namespace Mapper21.Data.Interfaces
{
    public interface ILookupRepository : IDisposable
    {
        IEnumerable<Habit> GetHabits();
        IEnumerable<ScienceBigIdea> GetBigIdeaForSciences();
        IEnumerable<SocialStudiesBigIdea> GetBigIdeaForSocialStudies();
        IEnumerable<CommonCoreStandard> GetCommonCoreStandards();
    }
}