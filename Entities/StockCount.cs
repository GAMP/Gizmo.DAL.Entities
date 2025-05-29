#nullable enable

using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Stock count entity.
    /// </summary>
    public sealed class StockCount : EntityWithShift
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public StockCount()
        {
            Entries = new HashSet<StockCountEntry>();
        }

        /// <summary>
        /// Gets or sets stock id.
        /// </summary>
        public int StockId { get; set; }

        /// <summary>
        /// Gets or sets stock count type.
        /// </summary>
        public StockCountType Type { get; set; }

        /// <summary>
        /// Gets or sets unexpected entries count.
        /// </summary>
        public int UnexpectedEntries { get; set; }

        /// <summary>
        /// Gets or sets count note.
        /// </summary>
        public string? Note { get; set; }

        /// <summary>
        /// Gets count entries.
        /// </summary>
        public ISet<StockCountEntry> Entries { get; private set; }

        /// <summary>
        /// Gets associated stock.
        /// </summary>
        public Stock Stock { get; set; } = null!;
    }
}
