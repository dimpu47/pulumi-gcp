// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Monitoring.Inputs
{

    public sealed class CustomServiceTelemetryArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The full name of the resource that defines this service.
        /// Formatted as described in
        /// https://cloud.google.com/apis/design/resource_names.
        /// </summary>
        [Input("resourceName")]
        public Input<string>? ResourceName { get; set; }

        public CustomServiceTelemetryArgs()
        {
        }
    }
}
