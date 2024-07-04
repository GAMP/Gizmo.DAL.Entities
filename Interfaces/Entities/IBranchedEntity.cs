namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Branched entity.
    /// </summary>
    /// <remarks>
    /// Represents an entity with required branch.
    /// </remarks>
    public interface IBranchedEntity
    {
        /// <summary>
        /// Gets or sets branch id.
        /// </summary>
        public int BranchId { get; set; }

        /// <summary>
        /// Gets branch navigation entity.
        /// </summary>
        public Branch Branch { get; }
    }
}
