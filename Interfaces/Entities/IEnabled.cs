namespace Gizmo.DAL
{
    /// <summary>
    /// IEnabled interface.
    /// </summary>
    public interface IEnabled
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets if entity is marked as enabled.
        /// </summary>
        bool IsEnabled { get; set; }

        #endregion
    }
}
