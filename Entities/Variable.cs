using ProtoBuf;
using SharedLib;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Variable entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Variable : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Variable()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets variable name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [StringLength(255)]
        [Required()]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets variable value.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [StringLength(65535)]
        [Required()]
        public string Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets module scope.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [Required()]
        public ModuleScopes Scope
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets order.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        [Required()]
        public int UseOrder
        {
            get;
            set;
        }

        #endregion
    }
}