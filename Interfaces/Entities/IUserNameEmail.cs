namespace GizmoDALV2
{
    #region IUserNameEmail
    /// <summary>
    /// Represents an entity that have an username and email.
    /// </summary>
    public interface IUserNameEmail
    {
        /// <summary>
        /// Gets or sets username.
        /// </summary>
        string Username { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        string Email { get; set; }
    }
    #endregion
}
