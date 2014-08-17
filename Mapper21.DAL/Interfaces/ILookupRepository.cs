using System;
using System.Collections.Generic;
using Mapper21.BE.Domain;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.DAL.Interfaces
{
    public interface ILookupRepository : IDisposable
    {
        IEnumerable<Habit> GetHabits();
        IEnumerable<ScienceBigIdea> GetBigIdeaForSciences();
        IEnumerable<SocialStudiesBigIdea> GetBigIdeaForSocialStudies();
        IEnumerable<CommonCoreStandard> GetCommonCoreStandards();
    }
}