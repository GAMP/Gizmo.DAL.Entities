using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Token entity.
    /// </summary>
    public class Token : ModifiableByUserCreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Token() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        public int? UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets token value.
        /// </summary>
        [MaxLength(32)]
        public string Value
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user confirmation code.
        /// </summary>
        [MaxLength(6)]
        public string ConfirmationCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets token type.
        /// </summary>
        public TokenType Type
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets token status.
        /// </summary>
        public TokenStatus Status
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets optional expiration time.
        /// </summary>
        public DateTime? Expires
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual User User
        {
            get; set;
        }

        #endregion
    }
}
