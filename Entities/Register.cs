using ProtoBuf;

using SharedLib;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Register entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Register : ModifiableByOperatorBase, IDeletable, IBranchedEntity
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Register() : base()
        {
            Shifts = new HashSet<Shift>();
            Transactions = new HashSet<RegisterTransaction>();
        }

        [NonSerialized()]
        private Branch _branch;

#nullable enable

        [NonSerialized()]
        private Companion? _companion;

        [NonSerialized()]
        private Stock? _stock;

#nullable disable

        /// <summary>
        /// Gets or sets register number.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int Number
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets terminal name.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [StringLength(45)]
        public string Name
        {
            get; set;
        } = string.Empty;

#nullable enable

        /// <summary>
        /// Gets or sets register mac address.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [StringLength(255)]
        public string? MacAddress
        {
            get;
            set;
        }

#nullable disable

        /// <summary>
        /// Gets or sets register options.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public RegisterOptions Options
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if register is deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public bool IsDeleted
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets register idle timeout.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int? IdleTimeout
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register start cash.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public decimal StartCash
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment terminal number.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public int? PaymentTerminalNumber
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets fiscal receipt printer number.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public int? FiscalReceiptPrinterNumber
        {
            get; set;
        }

        /// <inheritdoc/>        
        public int BranchId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets companion id.
        /// </summary>
        public int? CompanionId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets assigned stock id.
        /// </summary>
        public int? StockId { get; set; }

#nullable enable

        /// <summary>
        /// Gets companion assigned to this branch.
        /// </summary>
        public virtual Companion? Companion
        {
            get { return _companion; }
            set
            {
                _companion = value;
            }
        }

        /// <summary>
        /// Gets or sets assigned stock.
        /// </summary>
        public Stock? Stock
        {
            get { return _stock; }
            set
            {
                _stock = value;
            }
        }

#nullable disable

        /// <summary>
        /// Gets or sets shifts.
        /// </summary>
        public virtual ISet<Shift> Shifts
        {
            get; protected set;
        }

        /// <summary>
        /// Gets register payments.
        /// </summary>
        public virtual ISet<RegisterTransaction> Transactions
        {
            get; protected set;
        }

        /// <inheritdoc/>  
        public virtual Branch Branch
        {
            get { return _branch; }
            protected set { _branch = value; }
        }  
    }
}
