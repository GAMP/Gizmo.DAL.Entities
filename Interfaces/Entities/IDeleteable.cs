namespace GizmoDALV2
{
    /// <summary>
    /// Represents and item that can be marked as deleted.
    /// </summary>
    public interface IDeletable
    {
        #region PROPERTIES
        
        /// <summary>
        /// Gets or sets if entity is marked as deleted.
        /// </summary>
        bool IsDeleted
        {
            get;
            set;
        } 

        #endregion
    }
}
