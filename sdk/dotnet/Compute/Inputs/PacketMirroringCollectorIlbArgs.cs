// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class PacketMirroringCollectorIlbArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The URL of the instances where this rule should be active.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public PacketMirroringCollectorIlbArgs()
        {
        }
    }
}
