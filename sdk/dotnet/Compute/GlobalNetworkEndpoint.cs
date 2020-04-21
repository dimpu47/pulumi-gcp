// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute
{
    /// <summary>
    /// A Global Network endpoint represents a IP address and port combination that exists outside of GCP.
    /// **NOTE**: Global network endpoints cannot be created outside of a
    /// global network endpoint group.
    /// 
    /// 
    /// To get more information about GlobalNetworkEndpoint, see:
    /// 
    /// * [API documentation](https://cloud.google.com/compute/docs/reference/rest/beta/networkEndpointGroups)
    /// * How-to Guides
    ///     * [Official Documentation](https://cloud.google.com/load-balancing/docs/negs/)
    /// </summary>
    public partial class GlobalNetworkEndpoint : Pulumi.CustomResource
    {
        /// <summary>
        /// Fully qualified domain name of network endpoint. This can only be specified when network_endpoint_type of the NEG is
        /// INTERNET_FQDN_PORT.
        /// </summary>
        [Output("fqdn")]
        public Output<string?> Fqdn { get; private set; } = null!;

        /// <summary>
        /// The global network endpoint group this endpoint is part of.
        /// </summary>
        [Output("globalNetworkEndpointGroup")]
        public Output<string> GlobalNetworkEndpointGroup { get; private set; } = null!;

        /// <summary>
        /// IPv4 address external endpoint.
        /// </summary>
        [Output("ipAddress")]
        public Output<string?> IpAddress { get; private set; } = null!;

        /// <summary>
        /// Port number of the external endpoint.
        /// </summary>
        [Output("port")]
        public Output<int> Port { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;


        /// <summary>
        /// Create a GlobalNetworkEndpoint resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GlobalNetworkEndpoint(string name, GlobalNetworkEndpointArgs args, CustomResourceOptions? options = null)
            : base("gcp:compute/globalNetworkEndpoint:GlobalNetworkEndpoint", name, args ?? new GlobalNetworkEndpointArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GlobalNetworkEndpoint(string name, Input<string> id, GlobalNetworkEndpointState? state = null, CustomResourceOptions? options = null)
            : base("gcp:compute/globalNetworkEndpoint:GlobalNetworkEndpoint", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing GlobalNetworkEndpoint resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GlobalNetworkEndpoint Get(string name, Input<string> id, GlobalNetworkEndpointState? state = null, CustomResourceOptions? options = null)
        {
            return new GlobalNetworkEndpoint(name, id, state, options);
        }
    }

    public sealed class GlobalNetworkEndpointArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Fully qualified domain name of network endpoint. This can only be specified when network_endpoint_type of the NEG is
        /// INTERNET_FQDN_PORT.
        /// </summary>
        [Input("fqdn")]
        public Input<string>? Fqdn { get; set; }

        /// <summary>
        /// The global network endpoint group this endpoint is part of.
        /// </summary>
        [Input("globalNetworkEndpointGroup", required: true)]
        public Input<string> GlobalNetworkEndpointGroup { get; set; } = null!;

        /// <summary>
        /// IPv4 address external endpoint.
        /// </summary>
        [Input("ipAddress")]
        public Input<string>? IpAddress { get; set; }

        /// <summary>
        /// Port number of the external endpoint.
        /// </summary>
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        public GlobalNetworkEndpointArgs()
        {
        }
    }

    public sealed class GlobalNetworkEndpointState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Fully qualified domain name of network endpoint. This can only be specified when network_endpoint_type of the NEG is
        /// INTERNET_FQDN_PORT.
        /// </summary>
        [Input("fqdn")]
        public Input<string>? Fqdn { get; set; }

        /// <summary>
        /// The global network endpoint group this endpoint is part of.
        /// </summary>
        [Input("globalNetworkEndpointGroup")]
        public Input<string>? GlobalNetworkEndpointGroup { get; set; }

        /// <summary>
        /// IPv4 address external endpoint.
        /// </summary>
        [Input("ipAddress")]
        public Input<string>? IpAddress { get; set; }

        /// <summary>
        /// Port number of the external endpoint.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        public GlobalNetworkEndpointState()
        {
        }
    }
}
