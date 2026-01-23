#nullable enable

using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Integration entity.
    /// </summary>
    public sealed class Integration : CreatedByOperatorBase , IDisable , IDeletable
    {
        /// <summary>
        /// Integration name.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Integration type guid.
        /// </summary>
        public Guid TypeGuid {  get; set; }

        /// <summary>
        /// Public stable id.
        /// </summary>
        public Guid PublicId { get; set; }

        /// <summary>
        /// Configuration json.
        /// </summary>
        public string? ConfigJson { get; set; }

        /// <summary>
        /// Current config schema version.
        /// </summary>
        public int? ConfigSchemaVersion { get; set; }

        /// <inheritdoc/>
        public bool IsDisabled { get; set; }

        /// <inheritdoc/>
        public bool IsDeleted { get; set; }
    }
}
