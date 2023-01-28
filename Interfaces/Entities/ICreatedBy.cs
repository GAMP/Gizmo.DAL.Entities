namespace Gizmo.DAL
{
    #region ICreatedBy
    /// <summary>
    /// Created by interface.
    /// </summary>
    public interface ICreatedBy : ICreatable
    {
        /// <summary>
        /// Gets or sets creator id.
        /// </summary>
        int? CreatedById
        {
            get;
            set;
        }
    }
    #endregion

    #region ICreatedByOperator
    /// <summary>
    /// Created by operator interface.
    /// </summary>
    public interface ICreatedByOperator : ICreatedBy
    {
    }
    #endregion

    #region ICreatedByUser
    /// <summary>
    /// Created by user interface.
    /// </summary>
    public interface ICreatedByUser : ICreatedBy
    {
    }
    #endregion
}
