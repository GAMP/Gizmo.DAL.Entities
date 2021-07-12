namespace GizmoDALV2
{
    /// <summary>
    /// Base implementation for entities that support modification by user.
    /// </summary>
    public interface IModifiedBy : IModifiable , ICreatedBy
    {
        #region PROPERTIES
        
        /// <summary>
        /// Gets or sets modifier id.
        /// </summary>
        int? ModifiedById
        {
            get;
            set;
        } 

        #endregion
    }     
}
