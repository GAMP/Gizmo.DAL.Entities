namespace Gizmo.DAL
{
    /// <summary>
    /// Represents an entry that can be marked as deleted.
    /// </summary>
    public interface IDeletable
    {
        /// <summary>
        /// Gets or sets if entity is marked as deleted.
        /// </summary>
        bool IsDeleted
        {
            get;
            set;
        }
    }
}
