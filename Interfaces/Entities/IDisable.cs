namespace GizmoDALV2
{
    #region IDisable
    /// <summary>
    /// Represents an entity that can be disabled or enabled.
    /// </summary>
    public interface IDisable
    {
        /// <summary>
        /// Gets or sets if entity is disabled.
        /// </summary>
        bool IsDisabled { get; set; }
    }
    #endregion
}
