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
    /// Product host hidden entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductHostHidden : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductHostHidden() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets host group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int HostGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int ProductId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets hidden value.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public bool IsHidden
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets host group.
        /// </summary>
        public virtual HostGroup HostGroup
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual ProductBase Product
        {
            get; set;
        }

        #endregion
    }
}