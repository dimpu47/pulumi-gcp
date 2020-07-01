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
    /// BGP information that must be configured into the routing stack to
    /// establish BGP peering. This information must specify the peer ASN
    /// and either the interface name, IP address, or peer IP address.
    /// Please refer to RFC4273.
    /// 
    /// To get more information about RouterBgpPeer, see:
    /// 
    /// * [API documentation](https://cloud.google.com/compute/docs/reference/rest/v1/routers)
    /// * How-to Guides
    ///     * [Google Cloud Router](https://cloud.google.com/router/docs/)
    /// 
    /// ## Example Usage
    /// </summary>
    public partial class RouterPeer : Pulumi.CustomResource
    {
        /// <summary>
        /// User-specified flag to indicate which mode to use for advertisement.
        /// Valid values of this enum field are: `DEFAULT`, `CUSTOM`
        /// </summary>
        [Output("advertiseMode")]
        public Output<string?> AdvertiseMode { get; private set; } = null!;

        /// <summary>
        /// User-specified list of prefix groups to advertise in custom
        /// mode, which can take one of the following options:
        /// * `ALL_SUBNETS`: Advertises all available subnets, including peer VPC subnets.
        /// * `ALL_VPC_SUBNETS`: Advertises the router's own VPC subnets.
        /// * `ALL_PEER_VPC_SUBNETS`: Advertises peer subnets of the router's VPC network.
        /// </summary>
        [Output("advertisedGroups")]
        public Output<ImmutableArray<string>> AdvertisedGroups { get; private set; } = null!;

        /// <summary>
        /// User-specified list of individual IP ranges to advertise in
        /// custom mode. This field can only be populated if advertiseMode
        /// is `CUSTOM` and is advertised to all peers of the router. These IP
        /// ranges will be advertised in addition to any specified groups.
        /// Leave this field blank to advertise no custom IP ranges.  Structure is documented below.
        /// </summary>
        [Output("advertisedIpRanges")]
        public Output<ImmutableArray<Outputs.RouterPeerAdvertisedIpRange>> AdvertisedIpRanges { get; private set; } = null!;

        /// <summary>
        /// The priority of routes advertised to this BGP peer.
        /// Where there is more than one matching route of maximum
        /// length, the routes with the lowest priority value win.
        /// </summary>
        [Output("advertisedRoutePriority")]
        public Output<int?> AdvertisedRoutePriority { get; private set; } = null!;

        /// <summary>
        /// Name of the interface the BGP peer is associated with.
        /// </summary>
        [Output("interface")]
        public Output<string> Interface { get; private set; } = null!;

        /// <summary>
        /// IP address of the interface inside Google Cloud Platform. Only IPv4 is supported.
        /// </summary>
        [Output("ipAddress")]
        public Output<string> IpAddress { get; private set; } = null!;

        /// <summary>
        /// The resource that configures and manages this BGP peer. * 'MANAGED_BY_USER' is the default value and can be managed by
        /// you or other users * 'MANAGED_BY_ATTACHMENT' is a BGP peer that is configured and managed by Cloud Interconnect,
        /// specifically by an InterconnectAttachment of type PARTNER. Google automatically creates, updates, and deletes this type
        /// of BGP peer when the PARTNER InterconnectAttachment is created, updated, or deleted.
        /// </summary>
        [Output("managementType")]
        public Output<string> ManagementType { get; private set; } = null!;

        /// <summary>
        /// Name of this BGP peer. The name must be 1-63 characters long,
        /// and comply with RFC1035. Specifically, the name must be 1-63 characters
        /// long and match the regular expression `a-z?` which
        /// means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit,
        /// except the last character, which cannot be a dash.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Peer BGP Autonomous System Number (ASN).
        /// Each BGP interface may use a different value.
        /// </summary>
        [Output("peerAsn")]
        public Output<int> PeerAsn { get; private set; } = null!;

        /// <summary>
        /// IP address of the BGP interface outside Google Cloud Platform.
        /// Only IPv4 is supported.
        /// </summary>
        [Output("peerIpAddress")]
        public Output<string> PeerIpAddress { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// Region where the router and BgpPeer reside.
        /// If it is not provided, the provider region is used.
        /// </summary>
        [Output("region")]
        public Output<string> Region { get; private set; } = null!;

        /// <summary>
        /// The name of the Cloud Router in which this BgpPeer will be configured.
        /// </summary>
        [Output("router")]
        public Output<string> Router { get; private set; } = null!;


        /// <summary>
        /// Create a RouterPeer resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RouterPeer(string name, RouterPeerArgs args, CustomResourceOptions? options = null)
            : base("gcp:compute/routerPeer:RouterPeer", name, args ?? new RouterPeerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RouterPeer(string name, Input<string> id, RouterPeerState? state = null, CustomResourceOptions? options = null)
            : base("gcp:compute/routerPeer:RouterPeer", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing RouterPeer resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RouterPeer Get(string name, Input<string> id, RouterPeerState? state = null, CustomResourceOptions? options = null)
        {
            return new RouterPeer(name, id, state, options);
        }
    }

    public sealed class RouterPeerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// User-specified flag to indicate which mode to use for advertisement.
        /// Valid values of this enum field are: `DEFAULT`, `CUSTOM`
        /// </summary>
        [Input("advertiseMode")]
        public Input<string>? AdvertiseMode { get; set; }

        [Input("advertisedGroups")]
        private InputList<string>? _advertisedGroups;

        /// <summary>
        /// User-specified list of prefix groups to advertise in custom
        /// mode, which can take one of the following options:
        /// * `ALL_SUBNETS`: Advertises all available subnets, including peer VPC subnets.
        /// * `ALL_VPC_SUBNETS`: Advertises the router's own VPC subnets.
        /// * `ALL_PEER_VPC_SUBNETS`: Advertises peer subnets of the router's VPC network.
        /// </summary>
        public InputList<string> AdvertisedGroups
        {
            get => _advertisedGroups ?? (_advertisedGroups = new InputList<string>());
            set => _advertisedGroups = value;
        }

        [Input("advertisedIpRanges")]
        private InputList<Inputs.RouterPeerAdvertisedIpRangeArgs>? _advertisedIpRanges;

        /// <summary>
        /// User-specified list of individual IP ranges to advertise in
        /// custom mode. This field can only be populated if advertiseMode
        /// is `CUSTOM` and is advertised to all peers of the router. These IP
        /// ranges will be advertised in addition to any specified groups.
        /// Leave this field blank to advertise no custom IP ranges.  Structure is documented below.
        /// </summary>
        public InputList<Inputs.RouterPeerAdvertisedIpRangeArgs> AdvertisedIpRanges
        {
            get => _advertisedIpRanges ?? (_advertisedIpRanges = new InputList<Inputs.RouterPeerAdvertisedIpRangeArgs>());
            set => _advertisedIpRanges = value;
        }

        /// <summary>
        /// The priority of routes advertised to this BGP peer.
        /// Where there is more than one matching route of maximum
        /// length, the routes with the lowest priority value win.
        /// </summary>
        [Input("advertisedRoutePriority")]
        public Input<int>? AdvertisedRoutePriority { get; set; }

        /// <summary>
        /// Name of the interface the BGP peer is associated with.
        /// </summary>
        [Input("interface", required: true)]
        public Input<string> Interface { get; set; } = null!;

        /// <summary>
        /// Name of this BGP peer. The name must be 1-63 characters long,
        /// and comply with RFC1035. Specifically, the name must be 1-63 characters
        /// long and match the regular expression `a-z?` which
        /// means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit,
        /// except the last character, which cannot be a dash.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Peer BGP Autonomous System Number (ASN).
        /// Each BGP interface may use a different value.
        /// </summary>
        [Input("peerAsn", required: true)]
        public Input<int> PeerAsn { get; set; } = null!;

        /// <summary>
        /// IP address of the BGP interface outside Google Cloud Platform.
        /// Only IPv4 is supported.
        /// </summary>
        [Input("peerIpAddress", required: true)]
        public Input<string> PeerIpAddress { get; set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// Region where the router and BgpPeer reside.
        /// If it is not provided, the provider region is used.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// The name of the Cloud Router in which this BgpPeer will be configured.
        /// </summary>
        [Input("router", required: true)]
        public Input<string> Router { get; set; } = null!;

        public RouterPeerArgs()
        {
        }
    }

    public sealed class RouterPeerState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// User-specified flag to indicate which mode to use for advertisement.
        /// Valid values of this enum field are: `DEFAULT`, `CUSTOM`
        /// </summary>
        [Input("advertiseMode")]
        public Input<string>? AdvertiseMode { get; set; }

        [Input("advertisedGroups")]
        private InputList<string>? _advertisedGroups;

        /// <summary>
        /// User-specified list of prefix groups to advertise in custom
        /// mode, which can take one of the following options:
        /// * `ALL_SUBNETS`: Advertises all available subnets, including peer VPC subnets.
        /// * `ALL_VPC_SUBNETS`: Advertises the router's own VPC subnets.
        /// * `ALL_PEER_VPC_SUBNETS`: Advertises peer subnets of the router's VPC network.
        /// </summary>
        public InputList<string> AdvertisedGroups
        {
            get => _advertisedGroups ?? (_advertisedGroups = new InputList<string>());
            set => _advertisedGroups = value;
        }

        [Input("advertisedIpRanges")]
        private InputList<Inputs.RouterPeerAdvertisedIpRangeGetArgs>? _advertisedIpRanges;

        /// <summary>
        /// User-specified list of individual IP ranges to advertise in
        /// custom mode. This field can only be populated if advertiseMode
        /// is `CUSTOM` and is advertised to all peers of the router. These IP
        /// ranges will be advertised in addition to any specified groups.
        /// Leave this field blank to advertise no custom IP ranges.  Structure is documented below.
        /// </summary>
        public InputList<Inputs.RouterPeerAdvertisedIpRangeGetArgs> AdvertisedIpRanges
        {
            get => _advertisedIpRanges ?? (_advertisedIpRanges = new InputList<Inputs.RouterPeerAdvertisedIpRangeGetArgs>());
            set => _advertisedIpRanges = value;
        }

        /// <summary>
        /// The priority of routes advertised to this BGP peer.
        /// Where there is more than one matching route of maximum
        /// length, the routes with the lowest priority value win.
        /// </summary>
        [Input("advertisedRoutePriority")]
        public Input<int>? AdvertisedRoutePriority { get; set; }

        /// <summary>
        /// Name of the interface the BGP peer is associated with.
        /// </summary>
        [Input("interface")]
        public Input<string>? Interface { get; set; }

        /// <summary>
        /// IP address of the interface inside Google Cloud Platform. Only IPv4 is supported.
        /// </summary>
        [Input("ipAddress")]
        public Input<string>? IpAddress { get; set; }

        /// <summary>
        /// The resource that configures and manages this BGP peer. * 'MANAGED_BY_USER' is the default value and can be managed by
        /// you or other users * 'MANAGED_BY_ATTACHMENT' is a BGP peer that is configured and managed by Cloud Interconnect,
        /// specifically by an InterconnectAttachment of type PARTNER. Google automatically creates, updates, and deletes this type
        /// of BGP peer when the PARTNER InterconnectAttachment is created, updated, or deleted.
        /// </summary>
        [Input("managementType")]
        public Input<string>? ManagementType { get; set; }

        /// <summary>
        /// Name of this BGP peer. The name must be 1-63 characters long,
        /// and comply with RFC1035. Specifically, the name must be 1-63 characters
        /// long and match the regular expression `a-z?` which
        /// means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit,
        /// except the last character, which cannot be a dash.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Peer BGP Autonomous System Number (ASN).
        /// Each BGP interface may use a different value.
        /// </summary>
        [Input("peerAsn")]
        public Input<int>? PeerAsn { get; set; }

        /// <summary>
        /// IP address of the BGP interface outside Google Cloud Platform.
        /// Only IPv4 is supported.
        /// </summary>
        [Input("peerIpAddress")]
        public Input<string>? PeerIpAddress { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// Region where the router and BgpPeer reside.
        /// If it is not provided, the provider region is used.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// The name of the Cloud Router in which this BgpPeer will be configured.
        /// </summary>
        [Input("router")]
        public Input<string>? Router { get; set; }

        public RouterPeerState()
        {
        }
    }
}
