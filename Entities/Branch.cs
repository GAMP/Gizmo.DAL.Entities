#nullable enable

using System;
using System.Collections.Generic;

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

            Executables = new HashSet<AppExeBranch>();
            Products = new HashSet<ProductBranch>();
            Feeds = new HashSet<FeedBranch>();
            News = new HashSet<NewsBranch>();

            Operators = new HashSet<UserOperatorBranch>();
            Shifts = new HashSet<Shift>();
            AssetTransactions = new HashSet<AssetTransaction>();
            Users = new HashSet<User>();
        } 

        /// <summary>
        /// Gets or sets branch name.
        /// </summary>
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
        /// Gets to sets postal code.
        /// </summary>
        public string? PostalCode { get; set; }

        /// <summary>
        /// Gets or sets region.
        /// </summary>
        public string? Region { get; set; }

        /// <summary>
        /// Location latitude.
        /// </summary>
        public decimal Latitude { get; set; }

        /// <summary>
        /// Location longitude.
        /// </summary>
        public decimal Longitude { get; set; }

        /// <summary>
        /// Gets or sets contact phone.
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        public string? Email { get; set; }

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
        /// Gets or sets companion id.
        /// </summary>
        public int? CompanionId { get; set; }

        /// <summary>
        /// Gets companion assigned to this branch.
        /// </summary>
        public virtual Companion? Companion { get; private set; }

        /// <summary>
        /// Gets operators assigned to this branch.
        /// </summary>
        public virtual ISet<UserOperatorBranch> Operators { get; private set; }

        /// <summary>
        /// Gets users assigned to this branch.
        /// </summary>
        /// <remarks>
        /// This will contain all user types, the primary goal of this relationship is to keep statistics on branch where the user where created.
        /// </remarks>
        public virtual ISet<User> Users
        {
            get; protected set;
        }

        /// <summary>
        /// Gets shifts assigned to this branch.
        /// </summary>
        public virtual ISet<Shift> Shifts { get; private set; }

        /// <summary>
        /// Gets asset transactions assigned to this branch.
        /// </summary>
        public virtual ISet<AssetTransaction> AssetTransactions { get; private set; } 

        /// <summary>
        /// Gets executables assigned to this branch.
        /// </summary>
        public virtual ISet<AppExeBranch> Executables { get; private set; }

        /// <summary>
        /// Gets products assigned to this branch.
        /// </summary>
        public virtual ISet<ProductBranch> Products { get; private set; }

        /// <summary>
        /// Gets feeds assigned to this branch.
        /// </summary>
        public virtual ISet<FeedBranch> Feeds { get; private set; }

        /// <summary>
        /// Gets news assigned to this branch.
        /// </summary>
        public virtual ISet<NewsBranch> News { get; private set; }      
    }
}
