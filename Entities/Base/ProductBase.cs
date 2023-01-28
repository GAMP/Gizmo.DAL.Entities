using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
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
}