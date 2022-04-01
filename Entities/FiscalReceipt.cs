using GizmoDALV2.Entities;
using ProtoBuf;
using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Fiscal receipt entity.
    /// </summary>
    [Serializable()]
    [ProtoContract()]
    public class FiscalReceipt : EntityWithShift
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public FiscalReceipt() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets receipt type.
        /// </summary>
        /// <remarks>
        /// Indicates fiscal receipt type. For example pay or return (still in cosnideration).
        /// </remarks>
        [ProtoMember(1)]
        public int Type
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets receipt tax system.
        /// </summary>
        [ProtoMember(2)]
        public int TaxSystem
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets document id.
        /// </summary>
        [ProtoMember(3)]
        public int DocumentId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets signature.
        /// </summary>
        [ProtoMember(4)]
        public string Signature
        {
            get; set;
        } 

        #endregion
    }
}
