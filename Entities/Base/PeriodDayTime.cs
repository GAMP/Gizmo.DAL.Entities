using ProtoBuf;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Period day time entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class PeriodDayTime
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance of period day time.
        /// </summary>
        public PeriodDayTime() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets start second.
        /// </summary>
        [DataMember()]
        [Range(0, 86400)]
        [ProtoMember(1)]
        public int StartSecond
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets end second.
        /// </summary>
        [DataMember()]
        [Range(0, 86400)]
        [ProtoMember(2)]
        public int EndSecond
        {
            get;
            set;
        }

        #endregion
    }
}