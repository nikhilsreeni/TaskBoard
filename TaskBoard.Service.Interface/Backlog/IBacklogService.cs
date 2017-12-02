using System;
using System.Linq;

namespace TaskBoard.Service.Interface.Backlog
{
    public interface IBacklogService
    {
        IQueryable<PersistenceModel.Backlog> Get();
        void Add(PersistenceModel.Backlog backlog);
        void Delete(Guid UserID);
    }
}