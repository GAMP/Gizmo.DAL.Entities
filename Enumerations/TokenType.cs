namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Security token types.
    /// </summary>
    public enum TokenType
    {
        /// <summary>
        /// JWT Refresh token.
        /// </summary>
        JWTRefresh = 0,

        /// <summary>
        /// Email verification token.
        /// </summary>
        VerifyEmail = 1,
        
        /// <summary>
        /// Mobile phone verification token.
        /// </summary>
        VerifyMobilePhone = 2,
        
        /// <summary>
        /// Create account token.
        /// </summary>
        CreateAccount = 3,
        
        /// <summary>
        /// Reset password token.
        /// </summary>
        ResetPassword = 4,

        /// <summary>
        /// Device JWT refresh token minted by phone-approved activation.
        /// </summary>
        DeviceRefresh = 5,
    }
}
