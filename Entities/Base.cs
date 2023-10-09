using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    #region ENTITYBASE
    /// <summary>
    /// Base entity class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class EntityBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new entity instance.
        /// </summary>
        public EntityBase()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets primary id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public virtual int Id
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region CREATEDBYBASE<TCREATED>
    /// <summary>
    /// Created by base calss.
    /// </summary>
    /// <typeparam name="TCreated">Created type.</typeparam>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class CreatedByBase<TCreated> : EntityBase, ICreatedBy
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new created by instance.
        /// </summary>
        public CreatedByBase() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets created by id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? CreatedById
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets created time.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public DateTime CreatedTime
        {
            get; set;
        }

        /// <summary>
        /// Indicates that when entity is saved creation time shouldnt be set automatically.
        /// </summary>
        [NotMapped()]
        public bool IgnoreCreatedUpdate
        {
            get; set;
        }

        /// <summary>
        /// Indicates that when entity is saved update time and user shouldnt be set automatically.
        /// </summary>
        [NotMapped()]
        public bool IgnoreUpdatedUpdate
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets created by.
        /// </summary>
        public virtual TCreated CreatedBy
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region MODIFIEDBYBASE<TCREATED, TMODIFIED>
    /// <summary>
    /// Modified by base class.
    /// </summary>
    /// <typeparam name="TCreated">Created type.</typeparam>
    /// <typeparam name="TModified">Modified type.</typeparam>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class ModifiedByBase<TCreated, TModified> : CreatedByBase<TCreated>, IModifiedBy
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ModifiedByBase() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets modifier id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? ModifiedById
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets modified time.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public DateTime? ModifiedTime
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Get or sets modified by.
        /// </summary>
        public virtual TModified ModifiedBy
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region CREATEDBYOPERATORBASE
    /// <summary>
    /// Base class where entity is created by operator.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class CreatedByOperatorBase : CreatedByBase<UserOperator>, ICreatedByOperator
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public CreatedByOperatorBase()
            : base()
        { }
        #endregion
    }
    #endregion

    #region CREATEDBYUSER
    /// <summary>
    /// Base class where entity is created by user.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class CreatedByUserBase : CreatedByBase<User>, ICreatedByUser
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public CreatedByUserBase() : base()
        { }
        #endregion
    }
    #endregion

    #region MODIFIABLEBYUSERCREATEDBYUSERBASE
    /// <summary>
    /// Base class where entity can be created and modified by user.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class ModifiableByUserCreatedByUserBase : ModifiedByBase<User, User>, IModifiableByUser
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ModifiableByUserCreatedByUserBase() : base()
        { }
        #endregion
    }
    #endregion

    #region MODIFIABLEBYOPERATORBASE
    /// <summary>
    /// Base class where entity can be created by operator and modified by operator.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class ModifiableByOperatorBase : CreatedByOperatorBase, IModifiableByOperator
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ModifiableByOperatorBase() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets modified by id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? ModifiedById
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets last modified time.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public DateTime? ModifiedTime
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or set modified by user.
        /// </summary>
        public virtual UserOperator ModifiedBy
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region MODIFIABLEBYUSERBASE
    /// <summary>
    /// Base class where entity can be created by operator and modified by user.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class ModifiableByUserBase : CreatedByOperatorBase, IModifiableByUser
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ModifiableByUserBase()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets modified by id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? ModifiedById
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets last modified time.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public DateTime? ModifiedTime
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or set modified by user.
        /// </summary>
        public virtual User ModifiedBy
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region MODIFIABLEBYWITHOPTIONALUSERBASE
    /// <summary>
    /// Modifiable with optional user base class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class ModifiableByWithOptionalUserBase : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ModifiableByWithOptionalUserBase()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? UserId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region MODIFIABLEBYWITHREQUIREDUSERMEMBERBASE
    /// <summary>
    /// Modifable with required user base class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class ModifiableByWithRequiredUserMemberBase : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ModifiableByWithRequiredUserMemberBase()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UserId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region FILELISTENTITYBASE
    /// <summary>
    /// Base file list entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class FileListEntityBase : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public FileListEntityBase() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets list of files that should be excluded.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public string ExcludeFiles
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets list of directories that should be excluded.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public string ExcludeDirectories
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets list of files that should be included.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public string IncludeFiles
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets list of directories that should be included.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public string IncludeDirectories
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region TASKBASE
    /// <summary>
    /// Task base class.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class TaskBase : ModifiableByOperatorBase, IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public TaskBase() : base()
        {
            this.Guid = Guid.NewGuid();
            this.UsedByTask = new HashSet<ClientTask>();
            this.UsedByAppExe = new HashSet<AppExeTask>();
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
        /// Gets or sets guid.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [Required()]
        public Guid Guid
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets list of used by items.
        /// </summary>
        public virtual ISet<AppExeTask> UsedByAppExe
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets list of used by items.
        /// </summary>
        public virtual ISet<ClientTask> UsedByTask
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region IMAGEBASE
    /// <summary>
    /// Base image entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class ImageBase : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ImageBase() : base()
        { }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets image data.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public virtual byte[] Image
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTBASE
    /// <summary>
    /// Product base entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductBase : ModifiableByOperatorBase,
        IDeletable,
        IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductBase() : base()
        {
            this.Guid = Guid.NewGuid();
            this.Taxes = new HashSet<ProductTax>();
            this.DisallowedUserGroups = new HashSet<ProductUserDisallowed>();
            this.UserGroupPrices = new HashSet<ProductUserPrice>();
            this.StockTransactions = new HashSet<StockTransaction>();
            this.StockTransactionsSource = new HashSet<StockTransaction>();
            this.Images = new HashSet<ProductImage>();
            this.HiddenHostGroups = new HashSet<ProductHostHidden>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(45)]
        [ProtoMember(1)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [StringLength(65535)]
        [DataMember()]
        [ProtoMember(2)]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets price.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets cost.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public decimal? Cost { get; set; }

        /// <summary>
        /// Gets or sets order options.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public OrderOptionType OrderOptions { get; set; }

        /// <summary>
        /// Gets or sets purchase options.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public PurchaseOptionType PurchaseOptions { get; set; }

        /// <summary>
        /// Gets or sets points.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public int? Points { get; set; }

        /// <summary>
        /// Gets or sets price points.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public int? PointsPrice { get; set; }

        /// <summary>
        /// Gets or sets barcode.
        /// </summary>
        [DataMember()]
        [StringLength(255)]
        [ProtoMember(9)]
        public string Barcode { get; set; }

        /// <summary>
        /// Gets or sets stock options.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public StockOptionType StockOptions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets stock alert.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public decimal StockAlert
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets stock product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public int? StockProductId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets stock product amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(13)]
        public decimal StockProductAmount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets is deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(14)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets product group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(15)]
        public int ProductGroupId { get; set; }

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        [DataMember()]
        [ProtoMember(16)]
        public int DisplayOrder
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets entity guid.
        /// </summary>
        [DataMember()]
        [ProtoMember(17)]
        public Guid Guid
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets period.
        /// </summary>
        [ProtoMember(18)]
        public virtual ProductPeriod Period
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets product group.
        /// </summary>
        public virtual ProductGroup ProductGroup { get; set; }

        /// <summary>
        /// Gets or sets stock product.
        /// </summary>
        public virtual ProductBase StockProduct
        {
            get; set;
        }

        /// <summary>
        /// Gets taxes.
        /// </summary>
        [ProtoMember(19)]
        public virtual ISet<ProductTax> Taxes { get; protected set; }

        /// <summary>
        /// Gets dissalowed user groups.
        /// </summary>
        [ProtoMember(20)]
        public virtual ISet<ProductUserDisallowed> DisallowedUserGroups { get; protected set; }

        /// <summary>
        /// Gets user group prices.
        /// </summary>
        [ProtoMember(21)]
        public virtual ISet<ProductUserPrice> UserGroupPrices { get; protected set; }

        /// <summary>
        /// Gets images.
        /// </summary>
        [ProtoMember(22)]
        public virtual ISet<ProductImage> Images { get; protected set; }

        /// <summary>
        /// Gets hidden host groups.
        /// </summary>
        [ProtoMember(23)]
        public virtual ISet<ProductHostHidden> HiddenHostGroups { get; protected set; }

        /// <summary>
        /// Gets product stock transactions.
        /// </summary>
        public virtual ISet<StockTransaction> StockTransactions { get; protected set; }

        /// <summary>
        /// Gets stock transactions where participating as source.
        /// </summary>
        public virtual ISet<StockTransaction> StockTransactionsSource { get; protected set; }

        #endregion
    }
    #endregion

    #region PRODUCTBASEEXTENDED
    /// <summary>
    /// Extended product entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class ProductBaseExtended : ProductBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductBaseExtended()
            : base()
        {
            this.OrderLines = new HashSet<ProductOLProduct>();
            this.InvoiceLines = new HashSet<InvoiceLineProduct>();
        }
        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets order lines.
        /// </summary>
        public virtual ISet<ProductOLProduct> OrderLines
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets invoice lines.
        /// </summary>
        public virtual ISet<InvoiceLineProduct> InvoiceLines
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion        

    #region PRICEBASE
    /// <summary>
    /// Price base class.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class PriceBase : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance of price base.
        /// </summary>
        public PriceBase() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets fixed price.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public decimal? Price
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets price in points.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int? PointsPrice
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets purchase options.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public PurchaseOptionType PurchaseOptions { get; set; }

        #endregion
    }
    #endregion

    #region USERGROUPPRICEBASE
    /// <summary>
    /// User group price base class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class UserGroupPriceBase : PriceBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance of user group price base.
        /// </summary>
        public UserGroupPriceBase() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UserGroupId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

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

    #region PERIODDAY
    /// <summary>
    /// Period day base class.
    /// </summary>
    [Serializable()]
    [DataContract]
    [ProtoContract()]
    public abstract class PeriodDay : EntityBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PeriodDay() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets day of week.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public DayOfWeek Day
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region PERIODDAYTIME
    /// <summary>
    /// Period day time entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class PeriodDayTime
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance of period day time.
        /// </summary>
        public PeriodDayTime() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets start second.
        /// </summary>
        [DataMember()]
        [Range(0, 86400)]
        [ProtoMember(1)]
        public int StartSecond
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets end second.
        /// </summary>
        [DataMember()]
        [Range(0, 86400)]
        [ProtoMember(2)]
        public int EndSecond
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region PERIODDATE
    /// <summary>
    /// Period date base class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class PeriodDate : EntityBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PeriodDate() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets start date.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public DateTime? StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets end date.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public DateTime? EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets flags.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public PeriodOptionType Options
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region USAGE
    /// <summary>
    /// Usage base class entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class Usage : EntityBase, IModifiable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Usage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets usage session id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UsageSessionId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total seconds.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public double Seconds
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets modified time.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public DateTime? ModifiedTime
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets created time.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public DateTime CreatedTime
        {
            get; set;
        }

        #endregion

        #region UNMAPPED PROPERTIES

        /// <summary>
        /// Indicates that when entity is saved creation time shouldnt be set automatically.
        /// </summary>
        [NotMapped()]
        public bool IgnoreCreatedUpdate
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates that when entity is saved update time and user shouldnt be set automatically.
        /// </summary>
        [NotMapped()]
        public bool IgnoreUpdatedUpdate { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets bill session.
        /// </summary>
        public virtual UsageSession UsageSession
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region USAGEUSERSESSION
    /// <summary>
    /// Usage user session base class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class UsageUserSession : Usage
    {
        #region CONSTRUCTOR
    
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UsageUserSession() : base()
        { }
      
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user session id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UserSessionId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user session.
        /// </summary>
        public virtual UserSession UserSession
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTOL
    /// <summary>
    /// Product order line entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductOL : ModifiableByWithRequiredUserMemberBase, IDeletable, IVoidable , IDeliverable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductOL() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets order id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductOrderId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets product name.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(45)]
        [ProtoMember(2)]
        public string ProductName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets order line quantity.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Quantity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets unit price.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public decimal UnitPrice
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets unit list price.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public decimal UnitListPrice
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets points unit price.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int UnitPointsPrice
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets unit cost.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public decimal? UnitCost
        {
            get; set;
        }

        /// <summary>
        /// Gets or set total price.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public decimal Total
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total points price.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public int PointsTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets product points.
        /// </summary>
        /// <remarks>
        /// This value specified amount of points user gets per unit.
        /// </remarks>
        [DataMember()]
        [ProtoMember(10)]
        public int? Points
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets points award for the order line.
        /// </summary>
        /// <remarks>This value specifies total award user will recieve for this item.
        /// The value can be zero in case such as when user pays with points.
        /// </remarks>
        [DataMember()]
        [ProtoMember(11)]
        public int PointsAward
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets tax rate.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public decimal TaxRate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total amount of tax.
        /// </summary>
        [DataMember()]
        [ProtoMember(13)]
        public decimal TaxTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total taxed price.
        /// </summary>
        [DataMember()]
        [ProtoMember(14)]
        public decimal PreTaxTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets is deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(15)]
        public bool IsDeleted
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if voided.
        /// </summary>
        [DataMember()]
        [ProtoMember(16)]
        public bool IsVoided
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(17)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(18)]
        public int? RegisterId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets pay type.
        /// </summary>
        [DataMember()]
        [ProtoMember(19)]
        public OrderLinePayType PayType
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets unit list price.
        /// </summary>
        [DataMember()]
        [ProtoMember(20)]
        public int? UnitPointsListPrice
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets cost.
        /// </summary>
        [DataMember()]
        [ProtoMember(21)]
        public decimal? Cost
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if delivered.
        /// </summary>
        [DataMember()]
        [ProtoMember(22)]
        public bool IsDelivered
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets delivered quantity.
        /// </summary>
        [DataMember()]
        [ProtoMember(23)]
        public decimal DeliveredQuantity
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets delivered time.
        /// </summary>
        [DataMember()]
        [ProtoMember(24)]
        public DateTime? DeliveredTime
        {
            get; set;
        }  

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets order.
        /// </summary>
        public virtual ProductOrder ProductOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public virtual Shift Shift
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register.
        /// </summary>
        public virtual Register Register
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTOLEXTENDED
    /// <summary>
    /// Extended product order line entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class ProductOLExtended : ProductOL
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductOLExtended() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets bundle id.
        /// <remarks>This value is set when product is added as part of a bundle.</remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? BundleLineId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets bundle.
        /// </summary>
        public virtual ProductOLProduct BundleLine
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region INVOICELINE
    /// <summary>
    /// Invoice line entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class InvoiceLine : ModifiableByWithRequiredUserMemberBase, IDeletable, IVoidable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InvoiceLine() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets invoice id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int InvoiceId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets product name.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(45)]
        [ProtoMember(2)]
        public string ProductName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets quantity.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Quantity
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets unit price.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public decimal UnitPrice
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets unit list price.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public decimal UnitListPrice
        {
            get; set;
        }

        /// <summary>
        /// Gets or set total price.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public decimal Total
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total points price.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public int PointsTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets product points.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public int? Points
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets points award for the invoice line.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public int PointsAward
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets tax rate.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public decimal TaxRate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total amount of tax.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public decimal TaxTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total pre taxed price.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public decimal PreTaxTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets points transaction id.
        /// </summary>
        [DataMember()]
        [ProtoMember(13)]
        public int? PointsTransactionId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if line is deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(14)]
        public bool IsDeleted
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if line is voided.
        /// </summary>
        [DataMember()]
        [ProtoMember(15)]
        public bool IsVoided
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(16)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(17)]
        public int? RegisterId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets points unit price.
        /// </summary>
        [DataMember()]
        [ProtoMember(18)]
        public int UnitPointsPrice
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets unit list price.
        /// </summary>
        [DataMember()]
        [ProtoMember(19)]
        public int? UnitPointsListPrice
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets pay type.
        /// </summary>
        [DataMember()]
        [ProtoMember(20)]
        public OrderLinePayType PayType
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets unit cost.
        /// </summary>
        [DataMember()]
        [ProtoMember(21)]
        public decimal? UnitCost
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets cost.
        /// </summary>
        [DataMember()]
        [ProtoMember(22)]
        public decimal? Cost
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets invoice.
        /// </summary>
        public virtual Invoice Invoice
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets points transaction.
        /// </summary>
        public virtual PointTransaction PointsTransaction
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public virtual Shift Shift
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register.
        /// </summary>
        public virtual Register Register
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region INVOICELINEEXTENDED
    /// <summary>
    /// Extended invoice line entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class InvoiceLineExtended : InvoiceLine
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InvoiceLineExtended() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets bundle line id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? BundleLineId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets stock transaction id.
        /// <remarks>This value is set when order line generates stock transaction.</remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int? StockTransactionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets stock return transaction id.
        /// </summary>
        /// <remarks>
        /// This value is set when order line item is returned to stock.
        /// </remarks>
        [DataMember()]
        [ProtoMember(3)]
        public int? StockReturnTransactionId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets bundle line.
        /// </summary>
        public virtual InvoiceLineProduct BundleLine
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets stock transaction.
        /// </summary>
        public virtual StockTransaction StockTransaction
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets stock return transaction.
        /// </summary>
        public virtual StockTransaction StockReturnTransaction
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region VALUEBASE
    /// <summary>
    /// Base class for value entities.
    /// </summary>
    /// <typeparam name="TValue">Value Type.</typeparam>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class ValueBase<TValue> : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ValueBase() : base()
        { }
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Gets or sets value.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public virtual TValue Value
        {
            get; set;
        }
        #endregion
    }
    #endregion

    #region NOTEBASE
    /// <summary>
    /// Note base class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class Note : ModifiableByOperatorBase, IDeletable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new note base instance.
        /// </summary>
        public Note() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets note text.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(65535)]
        [ProtoMember(1)]
        public string Text
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets note options.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public NoteOptions Options
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets note sevirirty.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public NoteSeverity Sevirity
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if note is deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsDeleted
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region ENTITYWITHSHIFT
    /// <summary>
    /// Base entity for Shift and Register entites.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class EntityWithShift : CreatedByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public EntityWithShift() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int? RegisterId
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
        /// Gets or sets register.
        /// </summary>
        public virtual Register Register
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region VOID
    /// <summary>
    /// Void base class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class Void : EntityWithShift
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Void() : base()
        { }
        #endregion
    }
    #endregion
}
