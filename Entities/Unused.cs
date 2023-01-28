using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    #region UNUSED

    #region USEROPERATORUSERGROUPACESS
    /// <summary>
    /// User opearator group access entity.
    /// </summary>
    [DataContract()]
    [ProtoContract()]
    [Serializable()]
    public class UserOperatorUserGroupAccess : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserOperatorUserGroupAccess() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets operator id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int OperatorId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UserGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if login is disallowed.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public bool DisallowLogin
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if login is disallowed.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public bool DisallowMove
        {
            get; set;
        }

        #endregion

        #region VIRTUAL PROPERTIES

        /// <summary>
        /// Gets or sets operator.
        /// </summary>
        public virtual UserOperator Operator
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user group.
        /// </summary>
        public virtual UserGroup UserGroup
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region DISCOUNTS

    #region DISCOUNTBONUS
    /// <summary>
    /// Discount bonus entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class DiscountBonus : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DiscountBonus() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets discount id.
        /// </summary>
        [DataMember()]
        public int DiscountId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        public int? ProductId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets next logical operator.
        /// </summary>
        [DataMember()]
        public LogicalOperator? Operator
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual ProductBase Product
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets discount.
        /// </summary>
        public virtual DiscountBase Discount
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region DISCOUNTPRODUCT
    /// <summary>
    /// Discount product entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class DiscountProduct : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DiscountProduct()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets discount id.
        /// </summary>
        [DataMember()]
        public int DiscountId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        public int ProductId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets discount.
        /// </summary>
        public virtual DiscountBase Discount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual Product Product
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region DISCOUNTPRODUCTGROUP
    /// <summary>
    /// Discount product group.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class DiscountProductGroup : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DiscountProductGroup()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets discount id.
        /// </summary>
        [DataMember()]
        public int DiscountId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        public int ProductGroupId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets discount.
        /// </summary>
        public virtual DiscountBase Discount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets product group.
        /// </summary>
        public virtual ProductGroup ProductGroup
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region DISCOUNTUSER
    /// <summary>
    /// Discount user entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class DiscountUser : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DiscountUser()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets discount id.
        /// </summary>
        [DataMember()]
        public int DiscountId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user group id.
        /// </summary>
        [DataMember()]
        public int UserGroupId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets discount.
        /// </summary>
        public virtual DiscountBase Discount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user group.
        /// </summary>
        public virtual UserGroup UserGroup
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region DISCOUNTTIMEPERIOD
    /// <summary>
    /// Discount time period entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class DiscountTimePeriod : PeriodDate
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DiscountTimePeriod() : base()
        {
            WeekDays = new HashSet<ProductPeriodDay>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets discount.
        /// </summary>
        public virtual DiscountBase Discount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets days of week.
        /// </summary>
        public virtual ISet<ProductPeriodDay> WeekDays
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region DISCOUNTTIMEPERIODWEEKDAY
    /// <summary>
    /// Discount time period day week day entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class DiscountTimePeriodWeekDay : PeriodDay
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DiscountTimePeriodWeekDay()
            : base()
        {
            DayTimes = new HashSet<DiscountTimePeriodWeekDay>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets time offer period id.
        /// </summary>
        [DataMember()]
        public int PeriodId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets time offer period.
        /// </summary>
        public DiscountTimePeriod Period
        {
            get;
            set;
        }

        /// <summary>
        /// Gets time offer period day times.
        /// </summary>
        public virtual ISet<DiscountTimePeriodWeekDay> DayTimes
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region DISCOUNTTIMEPERIODDAYTIME
    /// <summary>
    /// Discount time period day time entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class DiscountTimePeriodDayTime : PeriodDayTime
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DiscountTimePeriodDayTime()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets period day id.
        /// </summary>
        public int PeriodWeekDayId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets period day.
        /// </summary>
        public virtual ProductPeriodDay PeriodWeekDay
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #endregion

    #endregion
}
