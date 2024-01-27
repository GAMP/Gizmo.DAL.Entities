namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Operator branch entity.
    /// </summary>
    public sealed class UserOperatorBranch : ModifiableByOperatorBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserOperatorBranch() : base()
        { }

        /// <summary>
        /// Gets or sets operator id.
        /// </summary>
        public int OperatorId { get; set; }

        /// <summary>
        /// Gets or sets branch id.
        /// </summary>
        public int BranchId { get; set; }

        /// <summary>
        /// Gets or sets default.
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or sets operator.
        /// </summary>
        public UserOperator Operator { get; set; }

        /// <summary>
        /// Gets or sets branch.
        /// </summary>
        public Branch Branch { get; set; }       
    }
}
