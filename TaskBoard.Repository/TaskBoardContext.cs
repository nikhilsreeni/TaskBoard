using System.Data.Entity;
using TaskBoard.PersistenceModel;

namespace TaskBoard.Repository
{
    public class TaskBoardContext : DbContext
    {
        public TaskBoardContext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }
}