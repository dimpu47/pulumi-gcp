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
    public sealed class RegionBackendServiceCircuitBreakers
    {
        /// <summary>
        /// The timeout for new network connections to hosts.  Structure is documented below.
        /// </summary>
        public readonly Outputs.RegionBackendServiceCircuitBreakersConnectTimeout? ConnectTimeout;
        /// <summary>
        /// The maximum number of connections to the backend cluster.
        /// Defaults to 1024.
        /// </summary>
        public readonly int? MaxConnections;
        /// <summary>
        /// The maximum number of pending requests to the backend cluster.
        /// Defaults to 1024.
        /// </summary>
        public readonly int? MaxPendingRequests;
        /// <summary>
        /// The maximum number of parallel requests to the backend cluster.
        /// Defaults to 1024.
        /// </summary>
        public readonly int? MaxRequests;
        /// <summary>
        /// Maximum requests for a single backend connection. This parameter
        /// is respected by both the HTTP/1.1 and HTTP/2 implementations. If
        /// not specified, there is no limit. Setting this parameter to 1
        /// will effectively disable keep alive.
        /// </summary>
        public readonly int? MaxRequestsPerConnection;
        /// <summary>
        /// The maximum number of parallel retries to the backend cluster.
        /// Defaults to 3.
        /// </summary>
        public readonly int? MaxRetries;

        [OutputConstructor]
        private RegionBackendServiceCircuitBreakers(
            Outputs.RegionBackendServiceCircuitBreakersConnectTimeout? connectTimeout,

            int? maxConnections,

            int? maxPendingRequests,

            int? maxRequests,

            int? maxRequestsPerConnection,

            int? maxRetries)
        {
            ConnectTimeout = connectTimeout;
            MaxConnections = maxConnections;
            MaxPendingRequests = maxPendingRequests;
            MaxRequests = maxRequests;
            MaxRequestsPerConnection = maxRequestsPerConnection;
            MaxRetries = maxRetries;
        }
    }
}
