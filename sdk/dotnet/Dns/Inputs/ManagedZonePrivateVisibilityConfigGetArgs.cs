// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Dns.Inputs
{

    public sealed class ManagedZonePrivateVisibilityConfigGetArgs : Pulumi.ResourceArgs
    {
        [Input("networks", required: true)]
        private InputList<Inputs.ManagedZonePrivateVisibilityConfigNetworkGetArgs>? _networks;

        /// <summary>
        /// The list of VPC networks that can see this zone. Structure is documented below.
        /// </summary>
        public InputList<Inputs.ManagedZonePrivateVisibilityConfigNetworkGetArgs> Networks
        {
            get => _networks ?? (_networks = new InputList<Inputs.ManagedZonePrivateVisibilityConfigNetworkGetArgs>());
            set => _networks = value;
        }

        public ManagedZonePrivateVisibilityConfigGetArgs()
        {
        }
    }
}
