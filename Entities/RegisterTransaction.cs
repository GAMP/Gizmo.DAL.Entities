#nullable enable

using System;
using System.Runtime.Serialization;
using ProtoBuf;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Register transaction entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class RegisterTransaction : ModifiableByOperatorBase, IBranchedEntity
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public RegisterTransaction() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int RegisterId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Amount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public RegisterTransactionType Type
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets note.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public string? Note
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets fiscal receipt status.
        /// </summary>
        public FiscalReceiptPrintStatus FiscalReceiptStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets (optional) fiscal receipt id.
        /// </summary>
        public int? FiscalReceiptId
        {
            get;
            set;
        }

        /// <inheritdoc/>
        public int BranchId { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public virtual Shift? Shift
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register.
        /// </summary>
        public virtual Register Register
        {
            get; set;
        } = null!;

        /// <summary>
        /// Gets or sets (optional) fiscal receipt.
        /// </summary>
        public virtual FiscalReceipt? FiscalReceipt
        {
            get; set;
        }

        /// <inheritdoc/>
        public virtual Branch Branch
        {
            get; set;
        }

        #endregion
    }
}
