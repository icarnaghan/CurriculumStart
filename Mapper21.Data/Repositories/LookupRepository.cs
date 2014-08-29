using System.Collections.Generic;
using System.Linq;
using Mapper21.Data.Interfaces;
using Mapper21.Data.Provider;
using Mapper21.Domain.LookUps;

namespace Mapper21.Data.Repositories
{
    public class LookupRepository : ILookupRepository
    {
        private Mapper21Context db = new Mapper21Context();

        public IEnumerable<Habit> GetHabits()
        {
            return db.Habits.ToList();
        }

        public IEnumerable<ScienceBigIdea> GetBigIdeaForSciences()
        {
            return db.ScienceBigIdeas.ToList();
        }

        public IEnumerable<SocialStudiesBigIdea> GetBigIdeaForSocialStudies()
        {
            return db.SocialStudiesBigIdeas.ToList();
        }

        public IEnumerable<CommonCoreStandard> GetCommonCoreStandards()
        {
            return db.CommonCoreStandards.ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}