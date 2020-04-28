// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.BinaryAuthorization.Inputs
{

    public sealed class AttestorAttestationAuthorityNoteGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// -
        /// This field will contain the service account email address that
        /// this Attestor will use as the principal when querying Container
        /// Analysis. Attestor administrators must grant this service account
        /// the IAM role needed to read attestations from the noteReference in
        /// Container Analysis (containeranalysis.notes.occurrences.viewer).
        /// This email address is fixed for the lifetime of the Attestor, but
        /// callers should not make any other assumptions about the service
        /// account email; future versions may use an email based on a
        /// different naming pattern.
        /// </summary>
        [Input("delegationServiceAccountEmail")]
        public Input<string>? DelegationServiceAccountEmail { get; set; }

        /// <summary>
        /// The resource name of a ATTESTATION_AUTHORITY Note, created by the
        /// user. If the Note is in a different project from the Attestor, it
        /// should be specified in the format `projects/*/notes/*` (or the legacy
        /// `providers/*/notes/*`). This field may not be updated.
        /// An attestation by this attestor is stored as a Container Analysis
        /// ATTESTATION_AUTHORITY Occurrence that names a container image
        /// and that links to this Note.
        /// </summary>
        [Input("noteReference", required: true)]
        public Input<string> NoteReference { get; set; } = null!;

        [Input("publicKeys")]
        private InputList<Inputs.AttestorAttestationAuthorityNotePublicKeyGetArgs>? _publicKeys;

        /// <summary>
        /// Public keys that verify attestations signed by this attestor. This
        /// field may be updated.
        /// If this field is non-empty, one of the specified public keys must
        /// verify that an attestation was signed by this attestor for the
        /// image specified in the admission request.
        /// If this field is empty, this attestor always returns that no valid
        /// attestations exist.  Structure is documented below.
        /// </summary>
        public InputList<Inputs.AttestorAttestationAuthorityNotePublicKeyGetArgs> PublicKeys
        {
            get => _publicKeys ?? (_publicKeys = new InputList<Inputs.AttestorAttestationAuthorityNotePublicKeyGetArgs>());
            set => _publicKeys = value;
        }

        public AttestorAttestationAuthorityNoteGetArgs()
        {
        }
    }
}
