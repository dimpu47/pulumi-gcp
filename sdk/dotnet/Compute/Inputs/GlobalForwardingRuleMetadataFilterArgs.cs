// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class GlobalForwardingRuleMetadataFilterArgs : Pulumi.ResourceArgs
    {
        [Input("filterLabels", required: true)]
        private InputList<Inputs.GlobalForwardingRuleMetadataFilterFilterLabelArgs>? _filterLabels;

        /// <summary>
        /// The list of label value pairs that must match labels in the
        /// provided metadata based on filterMatchCriteria
        /// This list must not be empty and can have at the most 64 entries.  Structure is documented below.
        /// </summary>
        public InputList<Inputs.GlobalForwardingRuleMetadataFilterFilterLabelArgs> FilterLabels
        {
            get => _filterLabels ?? (_filterLabels = new InputList<Inputs.GlobalForwardingRuleMetadataFilterFilterLabelArgs>());
            set => _filterLabels = value;
        }

        /// <summary>
        /// Specifies how individual filterLabel matches within the list of
        /// filterLabels contribute towards the overall metadataFilter match.
        /// MATCH_ANY - At least one of the filterLabels must have a matching
        /// label in the provided metadata.
        /// MATCH_ALL - All filterLabels must have matching labels in the
        /// provided metadata.
        /// </summary>
        [Input("filterMatchCriteria", required: true)]
        public Input<string> FilterMatchCriteria { get; set; } = null!;

        public GlobalForwardingRuleMetadataFilterArgs()
        {
        }
    }
}
