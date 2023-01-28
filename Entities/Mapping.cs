using CyClone;
using ProtoBuf;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Mapping entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Mapping : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Mapping()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets volume label.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [StringLength(45)]
        public string Label
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets source.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [StringLength(255)]
        public string Source
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets mount point.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [StringLength(255)]
        public string MountPoint
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets size.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int Size
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets username.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        [StringLength(45)]
        public string Username
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets password.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        [StringLength(45)]
        public string Password
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets options.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public MappingFlags Options
        {
            get;
            set;
        }

        #endregion
    }
}