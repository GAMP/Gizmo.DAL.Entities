using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Asset transaction entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class AssetTransaction : ModifiableByWithRequiredUserMemberBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AssetTransaction() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets asset type id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int AssetTypeId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets asset type name.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public string AssetTypeName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets asset id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int AssetId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if transaction is active.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsActive
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets checked in operator id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int? CheckedInById
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets checked in time.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public DateTime? CheckInTime
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public int? RegisterId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets checked in operator.
        /// </summary>
        public virtual UserOperator CheckedInBy
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets asset type.
        /// </summary>
        public virtual AssetType AssetType
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets asset.
        /// </summary>
        [ProtoMember(9)]
        public virtual Asset Asset
        {
            get; set;
        }

        #endregion
    }
}