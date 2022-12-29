using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Product group entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductGroup : ModifiableByOperatorBase,
        IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance of product group.
        /// </summary>
        public ProductGroup()
            : base()
        {
            Guid = Guid.NewGuid();
            ChildGroups = new HashSet<ProductGroup>();
            Products = new HashSet<ProductBase>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [StringLength(45)]
        [DataMember()]
        [ProtoMember(1)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets parent id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int? ParentId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int DisplayOrder
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets sort options.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public ProductSortOptionType SortOption
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets entity guid.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public Guid Guid
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets parent.
        /// </summary>
        public virtual ProductGroup Parent
        {
            get;
            set;
        }

        /// <summary>
        /// Gets child groups.
        /// </summary>
        public virtual ISet<ProductGroup> ChildGroups
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets products.
        /// </summary>
        public virtual ISet<ProductBase> Products
        {
            get;
            protected set;
        }

        #endregion
    }
}