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
    public sealed class ExternalVpnGatewayInterface
    {
        /// <summary>
        /// The numberic ID for this interface. Allowed values are based on the redundancy type
        /// of this external VPN gateway
        /// * `0 - SINGLE_IP_INTERNALLY_REDUNDANT`
        /// * `0, 1 - TWO_IPS_REDUNDANCY`
        /// * `0, 1, 2, 3 - FOUR_IPS_REDUNDANCY`
        /// </summary>
        public readonly int? Id;
        /// <summary>
        /// IP address of the interface in the external VPN gateway.
        /// Only IPv4 is supported. This IP address can be either from
        /// your on-premise gateway or another Cloud provider’s VPN gateway,
        /// it cannot be an IP address from Google Compute Engine.
        /// </summary>
        public readonly string? IpAddress;

        [OutputConstructor]
        private ExternalVpnGatewayInterface(
            int? id,

            string? ipAddress)
        {
            Id = id;
            IpAddress = ipAddress;
        }
    }
}
