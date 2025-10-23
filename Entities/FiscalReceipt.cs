#nullable enable

using System;
using ProtoBuf;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Fiscal receipt entity.
    /// </summary>
    [Serializable()]
    [ProtoContract()]
    public sealed class FiscalReceipt : EntityWithShift
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public FiscalReceipt() : base()
        { }

        /// <summary>
        /// Gets or sets receipt type.
        /// </summary>
        /// <remarks>
        /// Indicates fiscal receipt type. For example pay or return (still in consideration).
        /// </remarks>
        [ProtoMember(1)]
        public FiscalReceiptType Type
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets receipt tax system.
        /// </summary>
        [ProtoMember(2)]
        public TaxSystems? TaxSystem
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets document number.
        /// </summary>
        [ProtoMember(3)]
        public int? DocumentNumber
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets signature.
        /// </summary>
        /// <remarks>
        /// This value is optional.
        /// </remarks>
        [ProtoMember(4)]
        public string? Signature
        {
            get; set;
        }

        /// <summary>
        /// Fiscal receipt companion id.
        /// </summary>
        /// <remarks>
        /// This value identifies the companion the receipt was printed on.
        /// </remarks>
        public int? CompanionId
        {
            get; set;
        }

        /// <summary>
        /// Fiscal receipt printer number.
        /// </summary>
        /// <remarks>
        /// This value indicates the printer number that printed the fiscal receipt.
        /// </remarks>
        public int? PrinterNumber
        {
            get; set;
        }

        /// <summary>
        /// Gets or set companion.
        /// </summary>
        public Companion? Companion
        {
            get; set;
        }
    }
}
