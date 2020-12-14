namespace GizmoDALV2
{
    #region IDeletable
    /// <summary>
    /// Represents and item that can be marked as deleted.
    /// </summary>
    public interface IDeletable
    {
        /// <summary>
        /// Gets or sets if item is marked as deleted.
        /// </summary>
        bool IsDeleted
        {
            get;
            set;
        }
    }
    #endregion
}
