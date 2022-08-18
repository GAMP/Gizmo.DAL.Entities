using GizmoDALV2.Entities;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Deposit intent entity.
    /// </summary>
    public class DepositIntent : ModifiableByUserCreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DepositIntent() : base()
        { } 
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets deposit intent amount.
        /// </summary>
        public decimal Amount
        {
            get; set;
        } 

        /// <summary>
        /// Gets or sets intent state.
        /// </summary>
        public DepositIntentState State
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets intent user id.
        /// </summary>
        public int UserId
        {
            get;set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets intent user.
        /// </summary>
        public virtual UserMember User
        {
            get;set;
        }

        #endregion
    }
}
