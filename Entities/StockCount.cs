#nullable enable

using System.Collections.Generic;
using Gizmo.DAL.Entities.Entities;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Stock count entity.
    /// </summary>
    public sealed class StockCount : CreatedByOperatorBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public StockCount()
        {
            Entries = new HashSet<StockCountEntry>();
        }

        /// <summary>
        /// Gets or sets count note.
        /// </summary>
        public string? Note { get; set; }

        /// <summary>
        /// Gets or sets stock id.
        /// </summary>
        public int StockId { get; set; }

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
