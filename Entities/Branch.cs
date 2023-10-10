using GizmoDALV2;
using GizmoDALV2.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Branch entity.
    /// </summary>
    [NotMapped()]
    public class Branch : ModifiableByOperatorBase, IEnabled, IDeletable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Branch() : base()
        { } 
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets branch name.
        /// </summary>
        [StringLength(SQLStringSize.TINY)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets if branch is default.
        /// </summary>
        public bool IsDefault { get; set; }

        /// <inheritdoc/>
        public bool IsEnabled { get; set; }

        /// <inheritdoc/>
        public bool IsDeleted { get; set; }

        #endregion
    }
}
