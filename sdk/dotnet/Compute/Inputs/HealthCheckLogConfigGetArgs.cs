// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class HealthCheckLogConfigGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates whether or not to export logs. This is false by default,
        /// which means no health check logging will be done.
        /// </summary>
        [Input("enable")]
        public Input<bool>? Enable { get; set; }

        public HealthCheckLogConfigGetArgs()
        {
        }
    }
}
