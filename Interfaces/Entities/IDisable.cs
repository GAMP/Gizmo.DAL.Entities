namespace Gizmo.DAL
{
    /// <summary>
    /// Represents an entity that can be disabled or enabled.
    /// </summary>
    public interface IDisable
    {
        #region PROPERTIES
        
        /// <summary>
        /// Gets or sets if entity is marked as disabled.
        /// </summary>
        bool IsDisabled { get; set; } 

        #endregion
    }
}
