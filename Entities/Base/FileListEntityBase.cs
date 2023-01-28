using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Base file list entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class FileListEntityBase : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public FileListEntityBase() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets list of files that should be excluded.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public string ExcludeFiles
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets list of directories that should be excluded.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public string ExcludeDirectories
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets list of files that should be included.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public string IncludeFiles
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets list of directories that should be included.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public string IncludeDirectories
        {
            get;
            set;
        }

        #endregion
    }
}