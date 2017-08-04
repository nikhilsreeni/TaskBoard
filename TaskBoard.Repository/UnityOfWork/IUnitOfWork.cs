namespace TaskBoard.Repository
{
    using TaskBoard.Model;
    public interface IUnitOfWork
    {
        #region Properties
        EntityFrameworkRepository<User> UserRepository { get; }
        #endregion

        #region Public methods
        /// <summary>
        /// Save method.
        /// </summary>
        bool Save();
        #endregion
    }
}
