using ProtoBuf;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Setting entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public partial class Setting : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Setting()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets setting name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets setting value.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets setting group.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [StringLength(45)]
        public string GroupName { get; set; }

        #endregion
    }
}