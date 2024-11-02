#nullable enable

using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Void base class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class Void : EntityWithShift , IBranchedOptionalEntity
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Void() : base()
        { }
        #endregion

        #region FIELDS
        [NonSerialized()]
        private Branch? _branch;
        #endregion

        #region PROPERTIES

        /// <inheritdoc/>
        public int? BranchId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <inheritdoc/>
        public Branch? Branch
        {
            get { return _branch; }
            set { _branch = value; }
        }

        #endregion
    }
}
