namespace TaskBoard.Repository
{
    using System.Data.Entity;
    using PersistenceModel;
    public partial class TaskBoardContext : DbContext
    {
        public TaskBoardContext()
            : base("name=DefaultConnection")
        {
        }
        public virtual DbSet<User> Users { get; set; }
    }
}
