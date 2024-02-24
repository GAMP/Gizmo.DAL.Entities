using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User agreement state.
    /// </summary>
    [Serializable()]
    public class UserAgreementState : ModifiableByUserCreatedByUserBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        public int UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user agreement id.
        /// </summary>
        public int UserAgreementId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets accept state.
        /// </summary>
        public UserAgreementAcceptState AcceptState
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user agreement.
        /// </summary>
        public virtual UserAgreement UserAgreement
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
