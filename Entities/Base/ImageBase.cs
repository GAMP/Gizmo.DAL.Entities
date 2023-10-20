using ProtoBuf;

using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Base image entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class ImageBase : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ImageBase() : base()
        { }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets image data.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public virtual byte[] Image
        {
            get;
            set;
        }

        #endregion
    }
}