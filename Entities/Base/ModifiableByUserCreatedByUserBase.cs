using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Base class where entity can be created and modified by user.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class ModifiableByUserCreatedByUserBase : ModifiedByBase<User, User>, IModifiableByUser
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ModifiableByUserCreatedByUserBase() : base()
        { }
        #endregion
    }
}