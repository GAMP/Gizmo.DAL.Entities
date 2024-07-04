#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Branch entity.
    /// </summary>
    public class Branch : ModifiableByOperatorBase, IEnabled, IDeletable, IReplicatable
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Branch() : base()
        {
            Guid = Guid.NewGuid();
            Operators = new HashSet<UserOperatorBranch>();
            Shifts = new HashSet<Shift>();
        }

        /// <summary>
        /// Gets or sets branch name.
        /// </summary>
        [StringLength(SQLStringSize.TINY)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets branch city.
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// Gets or sets address.
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// Gets or sets contact phone.
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Gets to sets postal code.
        /// </summary>
        public string? PostalCode { get; set; }

        /// <summary>
        /// Gets or sets region.
        /// </summary>
        public string? Region { get; set; }

        /// <summary>
        /// Gets or sets web site.
        /// </summary>
        public string? WebSite { get; set; }

        /// <summary>
        /// Gets or sets info.
        /// </summary>
        public string? Info { get; set; }

        /// <summary>
        /// Gets or sets time zone.
        /// </summary>
        public string? TimeZone { get; set; }

        /// <inheritdoc/>
        public Guid Guid { get; set; }

        /// <inheritdoc/>
        public bool IsEnabled { get; set; }

        /// <inheritdoc/>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets operators assigned to this branch.
        /// </summary>
        public virtual ISet<UserOperatorBranch> Operators { get; private set; }

        /// <summary>
        /// Gets branch shifts.
        /// </summary>
        public virtual ISet<Shift> Shifts { get; private set; }
    }
}
