namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement challenge reward grant statuses.
    /// </summary>
    public enum AchievementChallengeRewardStatus
    {
        /// <summary>
        /// The reward grants automatically and has not been granted yet — the normal
        /// state only momentarily at completion; a lingering row is a retryable
        /// grant failure.
        /// </summary>
        Pending = 0,

        /// <summary>
        /// The reward awaits manual operator fulfillment (physical prize handover or
        /// forced claim).
        /// </summary>
        AwaitingClaim = 1,

        /// <summary>
        /// The reward has been granted.
        /// </summary>
        Granted = 2,

        /// <summary>
        /// The reward was declined — by an operator (out of stock, ineligible claim) or by
        /// the user refusing it. Terminal like <see cref="Granted"/> but nothing was
        /// delivered; ledger references stay null. An operator may re-offer by moving the
        /// reward back to <see cref="AwaitingClaim"/>.
        /// </summary>
        Declined = 3,
    }
}
