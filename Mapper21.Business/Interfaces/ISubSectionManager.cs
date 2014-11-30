using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;
using Mapper21.Domain;

namespace Mapper21.Business.Interfaces
{
    public interface ISubSectionManager
    {
        IList<SubSectionDto> GetAll();
        IList<SubSectionDto> GetAllBySection(Guid id);
        SubSectionDto SaveOrUpdate(SubSectionDto x);
        SubSectionDto Find(Guid id);
        bool Delete(Guid id);
    }
}