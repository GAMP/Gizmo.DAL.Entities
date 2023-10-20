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
    public class Register : ModifiableByOperatorBase, IDeletable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Register() : base()
        {
            Shifts = new HashSet<Shift>();
            Transactions = new HashSet<RegisterTransaction>();
        }
        #endregion

        #region PROPERTIES

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
        }

        /// <summary>
        /// Gets or sets register mac address.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [StringLength(255)]
        public string MacAddress
        {
            get;
            set;
        }

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

        #endregion

        #region VIRTUAL PROPERTIES

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

        #endregion
    }
}