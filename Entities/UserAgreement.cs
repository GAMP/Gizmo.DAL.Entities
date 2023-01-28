using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User agreement entity.
    /// </summary>
    public class UserAgreement : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserAgreement() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user agreement name.
        /// </summary>
        public string Name
        {
            get;set;
        }
        
        /// <summary>
        /// Gets agreement.
        /// </summary>
        public string Agreement
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets options.
        /// </summary>
        public UserAgreementOptions Options
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets display options.
        /// </summary>
        public UserAgreementDisplayOptions DisplayOptions
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        public int DisplayOrder
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if agreement is enabled.
        /// </summary>
        public bool IsEnabled
        {
            get;set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets user agreement states.
        /// </summary>
        public virtual ISet<UserAgreementState> UserAgreementStates
        {
            get; set;
        }

        #endregion
    }
}
