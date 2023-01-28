using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Asset entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class Asset : ModifiableByOperatorBase, IEnabled
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Asset() : base()
        {
            Transactions = new HashSet<AssetTransaction>();
        }

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
        /// Gets or sets asset number.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int Number
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets asset name.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public string Tag
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets RFID identifier.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public string SmartCardUID
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets barcode.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public string Barcode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets serial number.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public string SerialNumber
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if asset is enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public bool IsEnabled
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets asset type.
        /// </summary>
        public virtual AssetType AssetType
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets asset leases.
        /// </summary>
        public virtual ISet<AssetTransaction> Transactions
        {
            get; protected set;
        }

        #endregion
    }
}