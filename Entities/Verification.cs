namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Verification entity base.
    /// </summary>
    public class Verification : ModifiableByUserCreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Verification() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets associated token id.
        /// </summary>
        public int TokenId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        public int? UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets verification status.
        /// </summary>
        public VerificationStatus Status
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPETIES

        /// <summary>
        /// Gets or sets associated token.
        /// </summary>
        public virtual Token Token
        {
            get; set;
        }

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
