using ProtoBuf;

using SharedLib;

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Note base class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class Note : ModifiableByOperatorBase, IDeletable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new note base instance.
        /// </summary>
        public Note() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets note text.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(65535)]
        [ProtoMember(1)]
        public string Text
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets note options.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public NoteOptions Options
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets note sevirirty.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public SharedLib.NoteSeverity Sevirity
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if note is deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsDeleted
        {
            get; set;
        }

        #endregion
    }
}