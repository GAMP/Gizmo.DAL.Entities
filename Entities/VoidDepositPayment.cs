using ProtoBuf;

using System;

namespace Gizmo.DAL.Entities
{
    [Serializable()]
    [ProtoContract()]
    public class VoidDepositPayment : Void
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets deposit payment id.
        /// </summary>
        [ProtoMember(1)]
        public int DepositPaymentId
        {
            get; set;
        }

        #endregion

        #region VIRTUAL PROPERTIES

        /// <summary>
        /// Gets or sets deposit payment.
        /// </summary>
        public virtual DepositPayment DepositPayment
        {
            get; set;
        }

        #endregion
    }
}
