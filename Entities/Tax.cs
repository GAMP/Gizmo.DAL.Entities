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
    /// Tax entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class Tax : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Tax() : base()
        {
            Products = new HashSet<ProductTax>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Tax name.
        /// </summary>
        [StringLength(45)]
        [Required()]
        [DataMember()]
        [ProtoMember(1)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Tax value.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public decimal Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets use order.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int UseOrder
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets products using this tax.
        /// </summary>
        public virtual ISet<ProductTax> Products
        {
            get;
            protected set;
        }

        #endregion
    }
}