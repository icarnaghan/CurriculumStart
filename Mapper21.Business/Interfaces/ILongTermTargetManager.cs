using System;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface ILongTermTargetManager
    {
        GridDto Find(Guid id);
        GridDto SaveOrUpdate(GridDto x);
        bool Delete(Guid id);
        void Dispose();
    }
}