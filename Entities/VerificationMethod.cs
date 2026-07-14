#nullable enable

using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Verification method entity.
    /// </summary>
    /// <remarks>
    /// An operator-curated entry in a verification method chain — references an integration instance
    /// together with the capability (delivery mechanism) to use, e.g. sms send, flash call or email send.
    /// The capability guid is code-owned (a well known integration capability, like <see cref="Integration.TypeGuid"/>)
    /// and is validated against the integration type capabilities at write time; it has no database counterpart by design.
    /// </remarks>
    public sealed class VerificationMethod : CreatedByOperatorBase, IDisable , IDisplayOrder
    {
        /// <summary>
        /// Chain context this entry belongs to.
        /// </summary>
        public VerificationContext Context { get; set; }

        /// <summary>
        /// Referenced integration id.
        /// </summary>
        public int IntegrationId { get; set; }

        /// <summary>
        /// Capability guid identifying the delivery mechanism of the referenced integration.
        /// </summary>
        public Guid CapabilityGuid { get; set; }

        /// <summary>
        /// Optional custom display name shown to end users. When not set the referenced integration name is used.
        /// </summary>
        public string? CustomName { get; set; }

        /// <summary>
        /// Indicates the entry is offered on the initial method selection; non primary entries serve as fallback.
        /// </summary>
        public bool IsPrimary { get; set; }

        /// <inheritdoc/>
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Display order within the chain.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Referenced integration.
        /// </summary>
        public Integration? Integration { get; set; }
    }
}
