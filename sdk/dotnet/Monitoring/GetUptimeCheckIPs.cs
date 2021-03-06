// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Monitoring
{
    public static class GetUptimeCheckIPs
    {
        /// <summary>
        /// Returns the list of IP addresses that checkers run from. For more information see
        /// the [official documentation](https://cloud.google.com/monitoring/uptime-checks#get-ips).
        /// </summary>
        public static Task<GetUptimeCheckIPsResult> InvokeAsync(InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetUptimeCheckIPsResult>("gcp:monitoring/getUptimeCheckIPs:getUptimeCheckIPs", InvokeArgs.Empty, options.WithVersion());
    }


    [OutputType]
    public sealed class GetUptimeCheckIPsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A list of uptime check IPs used by Stackdriver Monitoring. Each `uptime_check_ip` contains:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetUptimeCheckIPsUptimeCheckIpResult> UptimeCheckIps;

        [OutputConstructor]
        private GetUptimeCheckIPsResult(
            string id,

            ImmutableArray<Outputs.GetUptimeCheckIPsUptimeCheckIpResult> uptimeCheckIps)
        {
            Id = id;
            UptimeCheckIps = uptimeCheckIps;
        }
    }
}
