namespace GizmoDALV2
{
    #region IModifiedBy
    /// <summary>
    /// Base implementation for entities that support modification by user.
    /// </summary>
    public interface IModifiedBy : IModifiable , ICreatedBy
    {
        /// <summary>
        /// Gets or sets modifier id.
        /// </summary>
        int? ModifiedById
        {
            get;
            set;
        }
    } 
    #endregion

    #region IModifiableByOperator
    /// <summary>
    /// Implemented by entities that support modification by operator users.
    /// </summary>
    public interface IModifiableByOperator : IModifiedBy
    {        
    }
    #endregion

    #region IModifiableByUser
    /// <summary>
    /// Implemented by entities that support modification by all user kinds.
    /// </summary>
    public interface IModifiableByUser : IModifiedBy
    {
    }
    #endregion     
}
