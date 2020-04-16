// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class InstanceTemplateSchedulingGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies whether the instance should be
        /// automatically restarted if it is terminated by Compute Engine (not
        /// terminated by a user). This defaults to true.
        /// </summary>
        [Input("automaticRestart")]
        public Input<bool>? AutomaticRestart { get; set; }

        [Input("nodeAffinities")]
        private InputList<Inputs.InstanceTemplateSchedulingNodeAffinityGetArgs>? _nodeAffinities;

        /// <summary>
        /// Specifies node affinities or anti-affinities
        /// to determine which sole-tenant nodes your instances and managed instance
        /// groups will use as host systems. Read more on sole-tenant node creation
        /// [here](https://cloud.google.com/compute/docs/nodes/create-nodes).
        /// Structure documented below.
        /// </summary>
        public InputList<Inputs.InstanceTemplateSchedulingNodeAffinityGetArgs> NodeAffinities
        {
            get => _nodeAffinities ?? (_nodeAffinities = new InputList<Inputs.InstanceTemplateSchedulingNodeAffinityGetArgs>());
            set => _nodeAffinities = value;
        }

        /// <summary>
        /// Defines the maintenance behavior for this
        /// instance.
        /// </summary>
        [Input("onHostMaintenance")]
        public Input<string>? OnHostMaintenance { get; set; }

        /// <summary>
        /// Allows instance to be preempted. This defaults to
        /// false. Read more on this
        /// [here](https://cloud.google.com/compute/docs/instances/preemptible).
        /// </summary>
        [Input("preemptible")]
        public Input<bool>? Preemptible { get; set; }

        public InstanceTemplateSchedulingGetArgs()
        {
        }
    }
}