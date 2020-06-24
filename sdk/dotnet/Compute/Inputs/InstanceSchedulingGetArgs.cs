// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class InstanceSchedulingGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies if the instance should be
        /// restarted if it was terminated by Compute Engine (not a user).
        /// Defaults to true.
        /// </summary>
        [Input("automaticRestart")]
        public Input<bool>? AutomaticRestart { get; set; }

        [Input("minNodeCpus")]
        public Input<int>? MinNodeCpus { get; set; }

        [Input("nodeAffinities")]
        private InputList<Inputs.InstanceSchedulingNodeAffinityGetArgs>? _nodeAffinities;

        /// <summary>
        /// Specifies node affinities or anti-affinities
        /// to determine which sole-tenant nodes your instances and managed instance
        /// groups will use as host systems. Read more on sole-tenant node creation
        /// [here](https://cloud.google.com/compute/docs/nodes/create-nodes).
        /// Structure documented below.
        /// </summary>
        public InputList<Inputs.InstanceSchedulingNodeAffinityGetArgs> NodeAffinities
        {
            get => _nodeAffinities ?? (_nodeAffinities = new InputList<Inputs.InstanceSchedulingNodeAffinityGetArgs>());
            set => _nodeAffinities = value;
        }

        /// <summary>
        /// Describes maintenance behavior for the
        /// instance. Can be MIGRATE or TERMINATE, for more info, read
        /// [here](https://cloud.google.com/compute/docs/instances/setting-instance-scheduling-options).
        /// </summary>
        [Input("onHostMaintenance")]
        public Input<string>? OnHostMaintenance { get; set; }

        /// <summary>
        /// Specifies if the instance is preemptible.
        /// If this field is set to true, then `automatic_restart` must be
        /// set to false.  Defaults to false.
        /// </summary>
        [Input("preemptible")]
        public Input<bool>? Preemptible { get; set; }

        public InstanceSchedulingGetArgs()
        {
        }
    }
}
