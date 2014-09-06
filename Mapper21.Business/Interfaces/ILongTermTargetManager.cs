using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface ILongTermTargetManager
    {
        IList<SubSectionLongTermTargetDto> GetAll();
        SubSectionLongTermTargetDto SaveOrUpdate(SubSectionLongTermTargetDto subSectionLongTermTarget);
        SubSectionLongTermTargetDto Find(Guid id);
        bool Delete(Guid id);
    }
}