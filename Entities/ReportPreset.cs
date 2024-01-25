#nullable enable

using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Report preset entity.
    /// </summary>
    public sealed class ReportPreset : ModifiableByOperatorBase
    {
        /// <summary>
        /// Gets or sets preset name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets report guid.
        /// </summary>
        public Guid Report { get; set; }

        /// <summary>
        /// Gets or sets report preset range.
        /// </summary>
        public ReportPresetRange Range { get; set; }

        /// <summary>
        /// Gets or sets report parameters.
        /// </summary>
        public string? Filters { get; set; }

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
