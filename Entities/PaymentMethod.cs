using Gizmo.DAL.Entities;
using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Payment method entity.
    /// </summary>
    [Serializable()]
    [DataContract]
    [ProtoContract()]
    public class PaymentMethod : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new payment method instance.
        /// </summary>
        public PaymentMethod() : base()
        {
            Payments = new HashSet<Payment>();
            PaymentIntents = new HashSet<PaymentIntent>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets name.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(45)]
        [ProtoMember(1)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets description.
        /// </summary>
        [DataMember()]
        [StringLength(255)]
        [ProtoMember(2)]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets surcharge.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Surcharge
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int DisplayOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if payment method is enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public bool IsEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets options.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public PaymentMethodOptionType Options
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if payment method can be used by client.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public bool IsClient
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if payment method can be used by manager.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public bool IsManager
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if payment method can be used by web portal.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public bool IsPortal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if payment method can be used by web portal.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public bool IsDeleted
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment proider guid.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public Guid? PaymentProvider
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets payments done with this method.
        /// </summary>
        public virtual ISet<Payment> Payments { get; protected set; }

        /// <summary>
        /// Gets payment intents.
        /// </summary>
        public virtual ISet<PaymentIntent> PaymentIntents { get; protected set; }

        #endregion
    }
}