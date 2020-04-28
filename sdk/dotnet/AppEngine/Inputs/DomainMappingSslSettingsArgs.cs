// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.AppEngine.Inputs
{

    public sealed class DomainMappingSslSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of the AuthorizedCertificate resource configuring SSL for the application. Clearing this field will
        /// remove SSL support.
        /// By default, a managed certificate is automatically created for every domain mapping. To omit SSL support
        /// or to configure SSL manually, specify `SslManagementType.MANUAL` on a `CREATE` or `UPDATE` request. You must be
        /// authorized to administer the `AuthorizedCertificate` resource to manually map it to a DomainMapping resource.
        /// Example: 12345.
        /// </summary>
        [Input("certificateId")]
        public Input<string>? CertificateId { get; set; }

        /// <summary>
        /// -
        /// ID of the managed `AuthorizedCertificate` resource currently being provisioned, if applicable. Until the new
        /// managed certificate has been successfully provisioned, the previous SSL state will be preserved. Once the
        /// provisioning process completes, the `certificateId` field will reflect the new managed certificate and this
        /// field will be left empty. To remove SSL support while there is still a pending managed certificate, clear the
        /// `certificateId` field with an update request.
        /// </summary>
        [Input("pendingManagedCertificateId")]
        public Input<string>? PendingManagedCertificateId { get; set; }

        /// <summary>
        /// SSL management type for this domain. If `AUTOMATIC`, a managed certificate is automatically provisioned.
        /// If `MANUAL`, `certificateId` must be manually specified in order to configure SSL for this domain.
        /// </summary>
        [Input("sslManagementType", required: true)]
        public Input<string> SslManagementType { get; set; } = null!;

        public DomainMappingSslSettingsArgs()
        {
        }
    }
}
