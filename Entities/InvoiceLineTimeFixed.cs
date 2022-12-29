using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Invoice line time fixed entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class InvoiceLineTimeFixed : InvoiceLine, ITimeDepletable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InvoiceLineTimeFixed() : base()
        {
            Usages = new HashSet<UsageTimeFixed>();
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
        /// Gets or sets if product is depleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public bool IsDepleted
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets fixed time order line.
        /// </summary>
        public virtual ProductOLTimeFixed OrderLine
        {
            get; set;
        }

        /// <summary>
        /// Gets usages.
        /// </summary>
        public virtual ISet<UsageTimeFixed> Usages
        {
            get; protected set;
        }

        #endregion
    }
}