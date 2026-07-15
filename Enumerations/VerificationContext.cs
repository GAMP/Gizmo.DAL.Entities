namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Verification method chain context.
    /// </summary>
    /// <remarks>
    /// Identifies the chain a <see cref="VerificationMethod"/> entry belongs to. Every verification
    /// flow resolves its chain by exact context match — there is no shared or fallback chain.
    /// </remarks>
    public enum VerificationContext
    {
        /// <summary>
        /// User registration chain.
        /// </summary>
        Registration = 0,

        /// <summary>
        /// Password recovery chain.
        /// </summary>
        PasswordRecovery = 1,

        /// <summary>
        /// Phone number verification chain. Only phone channel mechanisms are eligible.
        /// </summary>
        PhoneVerification = 2,

        /// <summary>
        /// Email address verification chain. Only email channel mechanisms are eligible.
        /// </summary>
        EmailVerification = 3,
    }
}
