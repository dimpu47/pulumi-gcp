// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.CloudRun.Inputs
{

    public sealed class ServiceTemplateMetadataGetArgs : Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<string>? _annotations;

        /// <summary>
        /// Annotations is a key value map stored with a resource that
        /// may be set by external tools to store and retrieve arbitrary metadata. More
        /// info: http://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        /// <summary>
        /// -
        /// A sequence number representing a specific generation of the desired state.
        /// </summary>
        [Input("generation")]
        public Input<int>? Generation { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Map of string keys and values that can be used to organize and categorize
        /// (scope and select) objects. May match selectors of replication controllers
        /// and routes.
        /// More info: http://kubernetes.io/docs/user-guide/labels
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of the environment variable.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// In Cloud Run the namespace must be equal to either the
        /// project ID or project number.
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        /// <summary>
        /// -
        /// An opaque value that represents the internal version of this object that
        /// can be used by clients to determine when objects have changed. May be used
        /// for optimistic concurrency, change detection, and the watch operation on a
        /// resource or set of resources. They may only be valid for a
        /// particular resource or set of resources.
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency
        /// </summary>
        [Input("resourceVersion")]
        public Input<string>? ResourceVersion { get; set; }

        /// <summary>
        /// -
        /// SelfLink is a URL representing this object.
        /// </summary>
        [Input("selfLink")]
        public Input<string>? SelfLink { get; set; }

        /// <summary>
        /// -
        /// UID is a unique id generated by the server on successful creation of a resource and is not
        /// allowed to change on PUT operations.
        /// More info: http://kubernetes.io/docs/user-guide/identifiers#uids
        /// </summary>
        [Input("uid")]
        public Input<string>? Uid { get; set; }

        public ServiceTemplateMetadataGetArgs()
        {
        }
    }
}
