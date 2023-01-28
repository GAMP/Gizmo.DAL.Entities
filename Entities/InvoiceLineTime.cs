using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Invoice line time entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class InvoiceLineTime : InvoiceLineExtended, IOrderLineReference, ITimeDepletable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InvoiceLineTime() : base()
        {
            Usages = new HashSet<UsageTime>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or set order line.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int OrderLineId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets product time id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int ProductTimeId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if product is depleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public bool IsDepleted
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets order line.
        /// </summary>
        public virtual ProductOLTime OrderLine
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual ProductTime Product
        {
            get; set;
        }

        /// <summary>
        /// Gets usages.
        /// </summary>
        public virtual ISet<UsageTime> Usages
        {
            get; protected set;
        }

        #endregion
    }
}