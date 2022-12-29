using CoreLib;
using CyClone;
using Gizmo.DAL.Entities;
using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Shift count entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ShiftCount : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ShiftCount() : base()
        { }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment method id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int PaymentMethodId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets start cash.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal StartCash
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets sales.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public decimal Sales
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets deposits.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public decimal Deposits
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets pay ins.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public decimal PayIns
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets withdrawals.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public decimal Withdrawals
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payouts.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public decimal PayOuts
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refunds.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public decimal Refunds
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets voids.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public decimal Voids
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets expected.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public decimal Expected
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets actual.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public decimal Actual
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets difference.
        /// </summary>
        [DataMember()]
        [ProtoMember(13)]
        public decimal Difference
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets note.
        /// </summary>
        [DataMember()]
        [ProtoMember(14)]
        public string Note
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public virtual Shift Shift
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment method.
        /// </summary>
        public virtual PaymentMethod PaymentMethod
        {
            get; set;
        }

        #endregion
    }
}