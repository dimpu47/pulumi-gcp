// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.BigQuery.Inputs
{

    public sealed class JobLoadDestinationEncryptionConfigurationGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table.
        /// The BigQuery Service Account associated with your project requires access to this encryption key.
        /// </summary>
        [Input("kmsKeyName", required: true)]
        public Input<string> KmsKeyName { get; set; } = null!;

        public JobLoadDestinationEncryptionConfigurationGetArgs()
        {
        }
    }
}
