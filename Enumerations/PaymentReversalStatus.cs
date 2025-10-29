namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Electronic reversal status.
    /// </summary>
    public enum PaymentReversalStatus
    {
        /// <summary>
        /// Payment reversal is not required.
        /// </summary>
        None = 0,

        /// <summary>
        /// Payment reversal is pending.
        /// </summary>
        Pending = 1,

        /// <summary>
        /// Payment reversal is completed.
        /// </summary>
        Completed = 2,

        /// <summary>
        /// Payment reversal is failed.
        /// </summary>
        Failed = 3,
    }
}
