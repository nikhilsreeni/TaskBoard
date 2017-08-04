namespace TaskBoard.Repository
{
    using System.Data.Entity;
    using Model;
    public partial class TaskBoardContext : DbContext
    {
        public TaskBoardContext()
            : base("name=DefaultConnection")
        {
        }
        public virtual DbSet<User> Users { get; set; }
    }
}
