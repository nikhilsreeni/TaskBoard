using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoard.Service.Interface.Backlog
{
    public interface IBacklogService
    {
        IQueryable<Model.Backlog> Get();
        void Add(Model.Backlog backlog);
        void Delete(Guid UserID);
    }
}
