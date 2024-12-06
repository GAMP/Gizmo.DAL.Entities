using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User channel entity.
    /// </summary>
    public sealed class UserChannel : ModifiableByOperatorBase
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the channel id.
        /// </summary>
        public Guid Channel { get; set; }

        /// <summary>
        /// Gets or sets value.
        /// </summary>
        public string Value {  get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public User User { get; set; }
    }
}
