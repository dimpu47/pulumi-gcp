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
    public sealed class RegionUrlMapPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay
    {
        /// <summary>
        /// Specifies the value of the fixed delay interval.  Structure is documented below.
        /// </summary>
        public readonly Outputs.RegionUrlMapPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay FixedDelay;
        /// <summary>
        /// The percentage of traffic (connections/operations/requests) on which delay will
        /// be introduced as part of fault injection. The value must be between 0.0 and
        /// 100.0 inclusive.
        /// </summary>
        public readonly double Percentage;

        [OutputConstructor]
        private RegionUrlMapPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay(
            Outputs.RegionUrlMapPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay fixedDelay,

            double percentage)
        {
            FixedDelay = fixedDelay;
            Percentage = percentage;
        }
    }
}
