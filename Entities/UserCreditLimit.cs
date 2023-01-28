using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User credit limit entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class UserCreditLimit : ModifiableByOperatorBase, IEnabled
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserCreditLimit() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets credit limit.
        /// </summary>
        [DataMember()]
        public decimal CreditLimit
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if credit limit is enabled.
        /// </summary>
        [DataMember()]
        public bool IsEnabled
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get;
            set;
        }

        #endregion
    }
}