using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Product discount base class.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class DiscountBase : ModifiableByOperatorBase, IDisable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DiscountBase()
            : base()
        {
            this.TargetUserGroups = new HashSet<DiscountUser>();
            this.TargetProductGroups = new HashSet<DiscountProductGroup>();
            this.TargetProducts = new HashSet<DiscountProduct>();
            this.BonusProducts = new HashSet<DiscountBonus>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets discount name.
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
        /// Amount of money required.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public decimal Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets target of this discount.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public DiscountTargetType ProductTrget
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets discount value.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public decimal Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets discount type.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public DiscountAmountType DiscountAmountType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets calculation trigger.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public DiscountCalcTrigger CalcTrigger
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets input trigger.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public DiscountInputTrigger InputTrigger
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets amount trigger.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public DiscountAmountTrigger AmountTrigger
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if discount is disabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public bool IsDisabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if discount targets all user groups.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public bool IsAllUserGroups
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets discount period.
        /// </summary>
        public virtual DiscountTimePeriod Period
        {
            get;
            set;
        }

        /// <summary>
        /// Gets targeted user groups.
        /// </summary>
        public virtual ISet<DiscountUser> TargetUserGroups
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets targeted product groups.
        /// </summary>
        public virtual ISet<DiscountProductGroup> TargetProductGroups
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets targeted products.
        /// </summary>
        public virtual ISet<DiscountProduct> TargetProducts
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets discount bonus products.
        /// </summary>
        public virtual ISet<DiscountBonus> BonusProducts
        {
            get;
            protected set;
        }

        #endregion
    }
}