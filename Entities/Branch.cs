#nullable enable

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Branch entity.
    /// </summary>
    [NotMapped()]
    public class Branch : ModifiableByOperatorBase, IEnabled, IDeletable, IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Branch() : base()
        {
            Guid = Guid.NewGuid();
        }
        #endregion

        #region PROPERTIES

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
        public string? ContactPhone { get; set; }

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


        //Guid add guid
        //City add city (45 char)
        //Address add address (255 char)
        //ContactPhone phone ? contact phone mobile or landline (45 char)
        //Email email contact
        //ZipCode zip code ? (alphanumeric)
        //Region region (255 chars)
        //GeoLocation geo location
        //WebSite url
        //Info (255 char)

        /// <inheritdoc/>
        public bool IsEnabled { get; set; }

        /// <inheritdoc/>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets time zone.
        /// </summary>
        public string? TimeZone { get; set; }

        /// <summary>
        /// Gets or sets replication guid.
        /// </summary>
        public Guid Guid { get; set; }

        #endregion
    }
}
