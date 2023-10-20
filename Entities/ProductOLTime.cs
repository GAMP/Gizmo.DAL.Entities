using ProtoBuf;

using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Product order line time entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductOLTime : ProductOLExtended
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductOLTime()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product time id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductTimeId
        {
            get; set;
        }

        #endregion

        #region VIRTUAL PROTPERTIES

        /// <summary>
        /// Gets or sets product time.
        /// </summary>
        public virtual ProductTime ProductTime
        {
            get; set;
        }

        #endregion
    }
}