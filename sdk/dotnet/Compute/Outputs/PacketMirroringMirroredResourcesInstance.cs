// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Outputs
{

    [OutputType]
    public sealed class PacketMirroringMirroredResourcesInstance
    {
        /// <summary>
        /// The URL of the instances where this rule should be active.
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private PacketMirroringMirroredResourcesInstance(string url)
        {
            Url = url;
        }
    }
}
