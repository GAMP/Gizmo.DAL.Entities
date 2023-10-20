using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Payment intent base entity. 
    /// </summary>
    public abstract class PaymentIntent : ModifiableByUserCreatedByUserBase, IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PaymentIntent() : base()
        {
            Guid = Guid.NewGuid();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets target user id.
        /// </summary>
        public int UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment method id.
        /// </summary>
        public int PaymentMethodId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment intent amount.
        /// </summary>
        public decimal Amount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets intent state.
        /// </summary>
        public PaymentIntentState State
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets transaction id.
        /// </summary>
        public string TransactionId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets transaction time.
        /// </summary>
        public DateTime? TransactionTime
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets unique id.
        /// </summary>
        public Guid Guid
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment intent provider.
        /// </summary>
        public Guid Provider
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or set target user.
        /// </summary>
        public virtual UserMember User
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment method.
        /// </summary>
        public virtual PaymentMethod PaymentMethod
        {
            get; set;
        }

        #endregion
    }
}
