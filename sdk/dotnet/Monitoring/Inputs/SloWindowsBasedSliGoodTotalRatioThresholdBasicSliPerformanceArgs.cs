// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Monitoring.Inputs
{

    public sealed class SloWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Parameters for a latency threshold SLI.  Structure is documented below.
        /// </summary>
        [Input("latency", required: true)]
        public Input<Inputs.SloWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceLatencyArgs> Latency { get; set; } = null!;

        [Input("locations")]
        private InputList<string>? _locations;

        /// <summary>
        /// An optional set of locations to which this SLI is relevant.
        /// Telemetry from other locations will not be used to calculate
        /// performance for this SLI. If omitted, this SLI applies to all
        /// locations in which the Service has activity. For service types
        /// that don't support breaking down by location, setting this
        /// field will result in an error.
        /// </summary>
        public InputList<string> Locations
        {
            get => _locations ?? (_locations = new InputList<string>());
            set => _locations = value;
        }

        [Input("methods")]
        private InputList<string>? _methods;

        /// <summary>
        /// An optional set of RPCs to which this SLI is relevant.
        /// Telemetry from other methods will not be used to calculate
        /// performance for this SLI. If omitted, this SLI applies to all
        /// the Service's methods. For service types that don't support
        /// breaking down by method, setting this field will result in an
        /// error.
        /// </summary>
        public InputList<string> Methods
        {
            get => _methods ?? (_methods = new InputList<string>());
            set => _methods = value;
        }

        [Input("versions")]
        private InputList<string>? _versions;

        /// <summary>
        /// The set of API versions to which this SLI is relevant.
        /// Telemetry from other API versions will not be used to
        /// calculate performance for this SLI. If omitted,
        /// this SLI applies to all API versions. For service types
        /// that don't support breaking down by version, setting this
        /// field will result in an error.
        /// </summary>
        public InputList<string> Versions
        {
            get => _versions ?? (_versions = new InputList<string>());
            set => _versions = value;
        }

        public SloWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceArgs()
        {
        }
    }
}
