using System;
using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Companion entity.
    /// </summary>
    public sealed class Companion : ModifiableByOperatorBase, IReplicatable
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Companion()
        {
            Guid = Guid.NewGuid();
            Branches = new HashSet<Branch>();
            Registers = new HashSet<Register>();
            FiscalReceipts = new HashSet<FiscalReceipt>();
            PaymentReceipts = new HashSet<PaymentReceipt>();
        }

        /// <summary>
        /// Gets or sets companion name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets companion id.
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// Gets assigned branches.
        /// </summary>
        public ISet<Branch> Branches { get; private set; }

        /// <summary>
        /// Gets assigned registers.
        /// </summary>
        public ISet<Register> Registers { get; private set; }

        /// <summary>
        /// Gets assigned fiscal receipts.
        /// </summary>
        public ISet<FiscalReceipt> FiscalReceipts { get; private set; }

        /// <summary>
        /// Gets assigned payment receipts.
        /// </summary>
        public ISet<PaymentReceipt> PaymentReceipts { get; private set; }
    }
}
