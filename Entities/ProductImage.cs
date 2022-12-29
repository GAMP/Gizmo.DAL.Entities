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
    /// Product image entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductImage : ImageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new product image instance.
        /// </summary>
        public ProductImage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductId
        {
            get;
            set;
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

        #endregion
    }
}