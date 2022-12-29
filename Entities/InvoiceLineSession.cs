using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Invoice line usage session entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class InvoiceLineSession : InvoiceLine
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InvoiceLineSession() : base()
        { }
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
        /// Gets or sets session id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int UsageSessionId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets fixed time order line.
        /// </summary>
        public virtual ProductOLSession OrderLine
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets usage session.
        /// </summary>
        public virtual UsageSession UsageSession
        {
            get; set;
        }

        #endregion
    }
}