#nullable enable

using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Client options entity.
    /// </summary>
    public sealed class ClientOptions : ModifiableByOperatorBase 
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ClientOptions() : base()
        {
            HostGroups = new HashSet<HostGroup>();
        }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets if this is the default options.
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or sets data.
        /// </summary>
        public string Data { get; set; } = null!;

        /// <summary>
        /// Gets host groups.
        /// </summary>
        public ISet<HostGroup> HostGroups { get; private set; }
    }
}
