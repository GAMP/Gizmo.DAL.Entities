namespace GizmoDALV2
{
    #region IVoidable
    /// <summary>
    /// IVoidable interface.
    /// </summary>
    public interface IVoidable
    {
        #region PROPERTIES
        
        /// <summary>
        /// Gets or sets if entity is voided.
        /// </summary>
        bool IsVoided
        {
            get;
            set;
        } 

        #endregion
    }
    #endregion
}
