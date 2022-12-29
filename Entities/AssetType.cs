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
    /// Asset type entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class AssetType : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AssetType() : base()
        {
            Assets = new HashSet<Asset>();
            Transactions = new HashSet<AssetTransaction>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [ProtoMember(1)]
        [DataMember()]
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [ProtoMember(2)]
        [DataMember()]
        public string Description
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets part number.
        /// </summary>
        [ProtoMember(3)]
        [DataMember()]
        public string PartNumber
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets assets.
        /// </summary>
        [ProtoMember(4)]
        public virtual ISet<Asset> Assets
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets transactions.
        /// </summary>
        public virtual ISet<AssetTransaction> Transactions
        {
            get; protected set;
        }

        #endregion
    }
}