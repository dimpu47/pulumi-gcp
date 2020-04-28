// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Filestore.Inputs
{

    public sealed class InstanceFileSharesGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// File share capacity in GiB. This must be at least 1024 GiB
        /// for the standard tier, or 2560 GiB for the premium tier.
        /// </summary>
        [Input("capacityGb", required: true)]
        public Input<int> CapacityGb { get; set; } = null!;

        /// <summary>
        /// The name of the fileshare (16 characters or less)
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public InstanceFileSharesGetArgs()
        {
        }
    }
}
