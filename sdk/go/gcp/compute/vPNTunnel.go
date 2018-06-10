// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a VPN Tunnel to the GCE network. For more info, read the
// [documentation](https://cloud.google.com/compute/docs/vpn).
// 
// ~> **Note:** All arguments including the `shared_secret` will be stored in the raw state as plain-text.
// [Read more about sensitive data in state](/docs/state/sensitive-data.html).
type VPNTunnel struct {
	s *pulumi.ResourceState
}

// NewVPNTunnel registers a new resource with the given unique name, arguments, and options.
func NewVPNTunnel(ctx *pulumi.Context,
	name string, args *VPNTunnelArgs, opts ...pulumi.ResourceOpt) (*VPNTunnel, error) {
	if args == nil || args.PeerIp == nil {
		return nil, errors.New("missing required argument 'PeerIp'")
	}
	if args == nil || args.SharedSecret == nil {
		return nil, errors.New("missing required argument 'SharedSecret'")
	}
	if args == nil || args.TargetVpnGateway == nil {
		return nil, errors.New("missing required argument 'TargetVpnGateway'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["description"] = nil
		inputs["ikeVersion"] = nil
		inputs["localTrafficSelectors"] = nil
		inputs["name"] = nil
		inputs["peerIp"] = nil
		inputs["project"] = nil
		inputs["region"] = nil
		inputs["remoteTrafficSelectors"] = nil
		inputs["router"] = nil
		inputs["sharedSecret"] = nil
		inputs["targetVpnGateway"] = nil
	} else {
		inputs["description"] = args.Description
		inputs["ikeVersion"] = args.IkeVersion
		inputs["localTrafficSelectors"] = args.LocalTrafficSelectors
		inputs["name"] = args.Name
		inputs["peerIp"] = args.PeerIp
		inputs["project"] = args.Project
		inputs["region"] = args.Region
		inputs["remoteTrafficSelectors"] = args.RemoteTrafficSelectors
		inputs["router"] = args.Router
		inputs["sharedSecret"] = args.SharedSecret
		inputs["targetVpnGateway"] = args.TargetVpnGateway
	}
	inputs["detailedStatus"] = nil
	inputs["selfLink"] = nil
	s, err := ctx.RegisterResource("gcp:compute/vPNTunnel:VPNTunnel", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &VPNTunnel{s: s}, nil
}

// GetVPNTunnel gets an existing VPNTunnel resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVPNTunnel(ctx *pulumi.Context,
	name string, id pulumi.ID, state *VPNTunnelState, opts ...pulumi.ResourceOpt) (*VPNTunnel, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["description"] = state.Description
		inputs["detailedStatus"] = state.DetailedStatus
		inputs["ikeVersion"] = state.IkeVersion
		inputs["localTrafficSelectors"] = state.LocalTrafficSelectors
		inputs["name"] = state.Name
		inputs["peerIp"] = state.PeerIp
		inputs["project"] = state.Project
		inputs["region"] = state.Region
		inputs["remoteTrafficSelectors"] = state.RemoteTrafficSelectors
		inputs["router"] = state.Router
		inputs["selfLink"] = state.SelfLink
		inputs["sharedSecret"] = state.SharedSecret
		inputs["targetVpnGateway"] = state.TargetVpnGateway
	}
	s, err := ctx.ReadResource("gcp:compute/vPNTunnel:VPNTunnel", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &VPNTunnel{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *VPNTunnel) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *VPNTunnel) ID() *pulumi.IDOutput {
	return r.s.ID
}

// A description of the resource. Changing this forces
// a new resource to be created.
func (r *VPNTunnel) Description() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["description"])
}

// Information about the status of the VPN tunnel.
func (r *VPNTunnel) DetailedStatus() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["detailedStatus"])
}

// Either version 1 or 2. Default is 2. Changing this
// forces a new resource to be created.
func (r *VPNTunnel) IkeVersion() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["ikeVersion"])
}

// Specifies which CIDR ranges are
// announced to the VPN peer. Mandatory if the VPN gateway is attached to a
// custom subnetted network. Refer to Google documentation for more
// information.
func (r *VPNTunnel) LocalTrafficSelectors() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["localTrafficSelectors"])
}

// A unique name for the resource, required by GCE. Changing
// this forces a new resource to be created.
func (r *VPNTunnel) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The VPN gateway sitting outside of GCE. Changing this
// forces a new resource to be created.
func (r *VPNTunnel) PeerIp() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["peerIp"])
}

// The ID of the project in which the resource belongs. If it
// is not provided, the provider project is used.
func (r *VPNTunnel) Project() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["project"])
}

// The region this tunnel should sit in. If not specified,
// the project region will be used. Changing this forces a new resource to be
// created.
func (r *VPNTunnel) Region() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["region"])
}

// Specifies which CIDR ranges the VPN
// tunnel can route to the remote side. Mandatory if the VPN gateway is attached to a
// custom subnetted network. Refer to Google documentation for more
// information.
func (r *VPNTunnel) RemoteTrafficSelectors() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["remoteTrafficSelectors"])
}

// Name of a Cloud Router in the same region
// to be used for dynamic routing. Refer to Google documentation for more
// information.
func (r *VPNTunnel) Router() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["router"])
}

// The URI of the created resource.
func (r *VPNTunnel) SelfLink() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["selfLink"])
}

// A passphrase shared between the two VPN gateways.
// Changing this forces a new resource to be created.
func (r *VPNTunnel) SharedSecret() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["sharedSecret"])
}

// A link to the VPN gateway sitting inside
// GCE. Changing this forces a new resource to be created.
func (r *VPNTunnel) TargetVpnGateway() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["targetVpnGateway"])
}

// Input properties used for looking up and filtering VPNTunnel resources.
type VPNTunnelState struct {
	// A description of the resource. Changing this forces
	// a new resource to be created.
	Description interface{}
	// Information about the status of the VPN tunnel.
	DetailedStatus interface{}
	// Either version 1 or 2. Default is 2. Changing this
	// forces a new resource to be created.
	IkeVersion interface{}
	// Specifies which CIDR ranges are
	// announced to the VPN peer. Mandatory if the VPN gateway is attached to a
	// custom subnetted network. Refer to Google documentation for more
	// information.
	LocalTrafficSelectors interface{}
	// A unique name for the resource, required by GCE. Changing
	// this forces a new resource to be created.
	Name interface{}
	// The VPN gateway sitting outside of GCE. Changing this
	// forces a new resource to be created.
	PeerIp interface{}
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
	// The region this tunnel should sit in. If not specified,
	// the project region will be used. Changing this forces a new resource to be
	// created.
	Region interface{}
	// Specifies which CIDR ranges the VPN
	// tunnel can route to the remote side. Mandatory if the VPN gateway is attached to a
	// custom subnetted network. Refer to Google documentation for more
	// information.
	RemoteTrafficSelectors interface{}
	// Name of a Cloud Router in the same region
	// to be used for dynamic routing. Refer to Google documentation for more
	// information.
	Router interface{}
	// The URI of the created resource.
	SelfLink interface{}
	// A passphrase shared between the two VPN gateways.
	// Changing this forces a new resource to be created.
	SharedSecret interface{}
	// A link to the VPN gateway sitting inside
	// GCE. Changing this forces a new resource to be created.
	TargetVpnGateway interface{}
}

// The set of arguments for constructing a VPNTunnel resource.
type VPNTunnelArgs struct {
	// A description of the resource. Changing this forces
	// a new resource to be created.
	Description interface{}
	// Either version 1 or 2. Default is 2. Changing this
	// forces a new resource to be created.
	IkeVersion interface{}
	// Specifies which CIDR ranges are
	// announced to the VPN peer. Mandatory if the VPN gateway is attached to a
	// custom subnetted network. Refer to Google documentation for more
	// information.
	LocalTrafficSelectors interface{}
	// A unique name for the resource, required by GCE. Changing
	// this forces a new resource to be created.
	Name interface{}
	// The VPN gateway sitting outside of GCE. Changing this
	// forces a new resource to be created.
	PeerIp interface{}
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
	// The region this tunnel should sit in. If not specified,
	// the project region will be used. Changing this forces a new resource to be
	// created.
	Region interface{}
	// Specifies which CIDR ranges the VPN
	// tunnel can route to the remote side. Mandatory if the VPN gateway is attached to a
	// custom subnetted network. Refer to Google documentation for more
	// information.
	RemoteTrafficSelectors interface{}
	// Name of a Cloud Router in the same region
	// to be used for dynamic routing. Refer to Google documentation for more
	// information.
	Router interface{}
	// A passphrase shared between the two VPN gateways.
	// Changing this forces a new resource to be created.
	SharedSecret interface{}
	// A link to the VPN gateway sitting inside
	// GCE. Changing this forces a new resource to be created.
	TargetVpnGateway interface{}
}
