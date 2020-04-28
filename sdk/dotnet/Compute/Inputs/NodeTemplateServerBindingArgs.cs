// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class NodeTemplateServerBindingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Type of server binding policy. If `RESTART_NODE_ON_ANY_SERVER`,
        /// nodes using this template will restart on any physical server
        /// following a maintenance event.
        /// If `RESTART_NODE_ON_MINIMAL_SERVER`, nodes using this template
        /// will restart on the same physical server following a maintenance
        /// event, instead of being live migrated to or restarted on a new
        /// physical server. This option may be useful if you are using
        /// software licenses tied to the underlying server characteristics
        /// such as physical sockets or cores, to avoid the need for
        /// additional licenses when maintenance occurs. However, VMs on such
        /// nodes will experience outages while maintenance is applied.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public NodeTemplateServerBindingArgs()
        {
        }
    }
}
