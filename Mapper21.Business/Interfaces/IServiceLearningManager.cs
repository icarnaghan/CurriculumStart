using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface IServiceLearningManager
    {
        IList<GridDto> GetList(Guid Id);
        GridDto Find(Guid id);
        GridDto SaveOrUpdate(GridDto x);
        bool Delete(Guid id);
        void Dispose();
    }
}