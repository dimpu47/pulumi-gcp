// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class ResourcePolicyGroupPlacementPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of availability domains instances will be spread across. If two instances are in different
        /// availability domain, they will not be put in the same low latency network
        /// </summary>
        [Input("availabilityDomainCount")]
        public Input<int>? AvailabilityDomainCount { get; set; }

        /// <summary>
        /// Collocation specifies whether to place VMs inside the same availability domain on the same low-latency network.
        /// Specify `COLLOCATED` to enable collocation. Can only be specified with `vm_count`. If compute instances are created
        /// with a COLLOCATED policy, then exactly `vm_count` instances must be created at the same time with the resource policy
        /// attached.
        /// </summary>
        [Input("collocation")]
        public Input<string>? Collocation { get; set; }

        /// <summary>
        /// Number of vms in this placement group.
        /// </summary>
        [Input("vmCount")]
        public Input<int>? VmCount { get; set; }

        public ResourcePolicyGroupPlacementPolicyArgs()
        {
        }
    }
}
