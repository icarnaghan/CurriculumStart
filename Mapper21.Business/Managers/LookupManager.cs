using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;
using log4net;
using Mapper21.Business.Dto.LookUps;
using Mapper21.Business.Interfaces;
using Mapper21.Data.Interfaces;
using Mapper21.Domain.LookUps;

namespace Mapper21.Business.Managers
{
    public class LookupManager : ILookupManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        readonly IGenericDataRepository<Habit> _habitRepo;
        readonly IGenericDataRepository<ScienceBigIdea> _scienceBigIdeaRepo;
        readonly IGenericDataRepository<SocialStudiesBigIdea> _socialStudiesBigIdeaRepo;
        readonly IGenericDataRepository<CommonCoreStandard> _commonCoreStandardRepo;

        //Initialize manager, inject repository instance and configure automapper
        public LookupManager(IGenericDataRepository<Habit> habitRepo,
                              IGenericDataRepository<ScienceBigIdea> scienceBigIdeaRepo,
                              IGenericDataRepository<SocialStudiesBigIdea> socialStudiesBigIdeaRepo,
                              IGenericDataRepository<CommonCoreStandard> commonCoreStandardRepo)
        {
            this._habitRepo = habitRepo;
            this._scienceBigIdeaRepo = scienceBigIdeaRepo;
            this._socialStudiesBigIdeaRepo = socialStudiesBigIdeaRepo;
            this._commonCoreStandardRepo = commonCoreStandardRepo;
            AutoMapperConfig.Init();
        }

        //Return a list of objects.  Intentional return of IList vs. IQueryable to 
        //more cleanly keep application layers clean.  
        //Developer may apply Linq Expressions as parameters to "GetAll" method to return child objects
        //or filter results to a subset of the list
        public IList<HabitLookupDto> GetHabits()
        {
            IList<Habit> _list;
            _list = _habitRepo.GetAll().ToList<Habit>();
            return Mapper.Map<IList<Habit>, IList<HabitLookupDto>>(_list);
        }

        public IList<ScienceBigIdeaLookupDto> GetBigIdeaForSciences()
        {
            IList<ScienceBigIdea> _list;
            _list = _scienceBigIdeaRepo.GetAll().ToList<ScienceBigIdea>();
            return Mapper.Map<IList<ScienceBigIdeaLookupDto>>(_list);
        }

        public IList<SocialStudiesBigIdeaLookupDto> GetBigIdeaForSocialStudies()
        {
            IList<SocialStudiesBigIdea> _list;
            _list = _socialStudiesBigIdeaRepo.GetAll().ToList<SocialStudiesBigIdea>();
            return Mapper.Map<IList<SocialStudiesBigIdea>, IList<SocialStudiesBigIdeaLookupDto>>(_list);
        }

        public IList<CommonCoreStandardLookupDto> GetCommonCoreStandards()
        {
            IList<CommonCoreStandard> _list;
            _list = _commonCoreStandardRepo.GetAll().ToList<CommonCoreStandard>();
            return Mapper.Map<IList<CommonCoreStandard>, IList<CommonCoreStandardLookupDto>>(_list);
        }

        public void Dispose()
        {
            _habitRepo.Dispose();
            _scienceBigIdeaRepo.Dispose();
            _socialStudiesBigIdeaRepo.Dispose();
            _commonCoreStandardRepo.Dispose();
        }
    }
}