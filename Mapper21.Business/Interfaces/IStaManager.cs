using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface IStaManager
    {
        IList<StaGridDto> GetStaGrids(Guid id);
        StaDto SaveOrUpdate(StaDto subSectionSta);
        StaDto Find(Guid id);
        bool Delete(Guid id);
    }
}