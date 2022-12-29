using ProtoBuf;
using SharedLib;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Plugin libarary entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class PluginLibrary : ModifiableByOperatorBase, IEnabled
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PluginLibrary()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets plugin library file name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(255)]
        public string FileName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets configuration scope.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public ModuleScopes Scope
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if library is enabled and should be loaded into process.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public bool IsEnabled
        {
            get;
            set;
        }

        #endregion
    }
}