namespace TaskBoard.Repository.Interface
{
    using TaskBoard.PersistenceModel;
    public interface IUnitOfWork
    {
        #region Properties
        IRepository<User> UserRepository { get; }
        #endregion

        #region Public methods
        /// <summary>
        /// Save method.
        /// </summary>
        bool Save();
        #endregion
    }
}
