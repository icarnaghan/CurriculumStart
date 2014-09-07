using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface ILongTermTargetManager
    {
        IList<LongTermTargetDto> GetAll();
        LongTermTargetDto SaveOrUpdate(LongTermTargetDto subSectionLongTermTarget);
        LongTermTargetDto Find(Guid id);
        bool Delete(Guid id);
    }
}