namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement challenge reward lifecycle statuses.
    /// </summary>
    /// <remarks>
    /// The two undelivered statuses record who the reward waits on, and the two delivered ones
    /// record which path delivered it. Both distinctions are stamped when the row moves — never
    /// derived from the processing operator, which is an audit stamp and is null for system acts
    /// and user declines alike.
    /// </remarks>
    public enum AchievementChallengeRewardStatus
    {
        /// <summary>
        /// The reward delivers automatically and has not been delivered yet — the normal
        /// state only momentarily at completion; a lingering row is a retryable
        /// delivery failure.
        /// </summary>
        Pending = 0,

        /// <summary>
        /// The reward awaits manual operator fulfillment (physical prize handover or
        /// forced claim).
        /// </summary>
        AwaitingClaim = 1,

        /// <summary>
        /// The reward was delivered automatically by the system.
        /// </summary>
        Delivered = 2,

        /// <summary>
        /// The reward was declined — by an operator (out of stock, ineligible claim) or by
        /// the user refusing it. Terminal like <see cref="Delivered"/> and
        /// <see cref="Claimed"/> but nothing was delivered; ledger references stay null. An
        /// operator may re-offer by moving the reward back to <see cref="AwaitingClaim"/>.
        /// </summary>
        Declined = 3,

        /// <summary>
        /// The reward was claimed — an operator confirming a handover, or the user claiming a
        /// non-physical reward themselves. The processing operator is stamped only in the
        /// former case, which is why the claim is recorded here and not read off that column.
        /// </summary>
        Claimed = 4,
    }
}
