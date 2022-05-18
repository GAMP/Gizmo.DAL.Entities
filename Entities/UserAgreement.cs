using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User agreement entity.
    /// </summary>
    public class UserAgreement : GizmoDALV2.Entities.ModifiableByOperatorBase
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
        /// Gets agreement.
        /// </summary>
        public string Aggrement
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
