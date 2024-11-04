#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Optional branch entity.
    /// </summary>
    /// <remarks>
    /// Represents an entity with optional branch.
    /// </remarks>
    public interface IBranchedOptionalEntity
    {
        /// <summary>
        /// Gets or sets optional branch id.
        /// </summary>
        public int? BranchId { get; set; }

        /// <summary>
        /// Gets branch navigation entity.
        /// </summary>
        public Branch? Branch { get; }
    }
}
