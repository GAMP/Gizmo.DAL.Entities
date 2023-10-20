namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Deposit intent state.
    /// </summary>
    public enum DepositIntentState
    {
        /// <summary>
        /// The intent is pending.
        /// </summary>
        Pending = 0,
        /// <summary>
        /// The intent was processed.
        /// </summary>
        Processed = 1,
        /// <summary>
        /// The intent was canceled.
        /// </summary>
        Canceled = 2,
        /// <summary>
        /// The intent has failed.
        /// </summary>
        Failed = 3,
    }
}
