namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Recipient user entity.
    /// </summary>
    public sealed class RecipientUser : RecipientChanneled
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets user.
        /// </summary>
        public User User { get; set; }
    }
}
