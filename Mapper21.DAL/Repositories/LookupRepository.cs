using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mapper21.BE.Domain.LookUps;
using Mapper21.DAL.Interfaces;
using Mapper21.DAL.Provider;

namespace Mapper21.DAL.Repositories
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

        public void Dispose()
        {
            db.Dispose();
        }
    }
}