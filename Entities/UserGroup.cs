using ProtoBuf;

using SharedLib;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User group entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class UserGroup : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserGroup()
            : base()
        {
            Users = new HashSet<UserMember>();
            ProductPrices = new HashSet<ProductUserPrice>();
            DissalowedProducts = new HashSet<ProductUserDisallowed>();
            DissalowedHostGroups = new HashSet<UserGroupHostDisallowed>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(45)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [StringLength(255)]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets app profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int? AppGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets security profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int? SecurityProfileId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets bill profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int? BillProfileId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets required user info.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public UserInfoTypes RequiredUserInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets ovverides.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public GroupOverrides Overrides
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets options.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public UserGroupOptionType Options
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets credit limit options.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public CreditLimitOptionType CreditLimitOptions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if user group allows negative balance.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public bool IsNegativeBalanceAllowed
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets credit limit.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public decimal CreditLimit
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets time point award options.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public TimePointAwardOptionType PointsAwardOptions
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets points money ratio. 
        /// </summary>
        [DataMember()]
        [ProtoMember(13)]
        public decimal PointsMoneyRatio
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets points time multiplier.
        /// </summary>
        [DataMember()]
        [ProtoMember(14)]
        public int PointsTimeRatio
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets amount of points to award.
        /// </summary>
        [DataMember()]
        [ProtoMember(15)]
        public int? Points
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if user group is default for new users.
        /// </summary>
        [DataMember()]
        [ProtoMember(16)]
        public bool IsDefault
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if age rating is enabled for the group.
        /// </summary>
        [DataMember()]
        [ProtoMember(17)]
        public bool IsAgeRatingEnabled
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user billing option.
        /// </summary>
        [DataMember()]
        [ProtoMember(19)]
        public BillingOption BillingOptions
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user group priority.
        /// </summary>
        [DataMember()]
        [ProtoMember(20)]
        public int WaitingLinePriority
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if waiting line priority enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(21)]
        public bool IsWaitingLinePriorityEnabled
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets app profile.
        /// </summary>
        public virtual AppGroup AppGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets security profile.
        /// </summary>
        public virtual SecurityProfile SecurityProfile
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets bill profile.
        /// </summary>
        public virtual BillProfile BillProfile
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets users.
        /// </summary>
        public virtual ISet<UserMember> Users { get; protected set; }

        /// <summary>
        /// Gets product prices.
        /// </summary>
        public virtual ISet<ProductUserPrice> ProductPrices { get; protected set; }

        /// <summary>
        /// Gets or sets dissalowed products.
        /// </summary>
        public virtual ISet<ProductUserDisallowed> DissalowedProducts { get; protected set; }

        /// <summary>
        /// Gets dissalowed host groups.
        /// </summary>
        [ProtoMember(18)]
        public virtual ISet<UserGroupHostDisallowed> DissalowedHostGroups { get; protected set; }

        #endregion
    }
}