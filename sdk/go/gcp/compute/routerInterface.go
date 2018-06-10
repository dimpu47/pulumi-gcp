// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a Cloud Router interface. For more information see
// [the official documentation](https://cloud.google.com/compute/docs/cloudrouter)
// and
// [API](https://cloud.google.com/compute/docs/reference/latest/routers).
type RouterInterface struct {
	s *pulumi.ResourceState
}

// NewRouterInterface registers a new resource with the given unique name, arguments, and options.
func NewRouterInterface(ctx *pulumi.Context,
	name string, args *RouterInterfaceArgs, opts ...pulumi.ResourceOpt) (*RouterInterface, error) {
	if args == nil || args.Router == nil {
		return nil, errors.New("missing required argument 'Router'")
	}
	if args == nil || args.VpnTunnel == nil {
		return nil, errors.New("missing required argument 'VpnTunnel'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["ipRange"] = nil
		inputs["name"] = nil
		inputs["project"] = nil
		inputs["region"] = nil
		inputs["router"] = nil
		inputs["vpnTunnel"] = nil
	} else {
		inputs["ipRange"] = args.IpRange
		inputs["name"] = args.Name
		inputs["project"] = args.Project
		inputs["region"] = args.Region
		inputs["router"] = args.Router
		inputs["vpnTunnel"] = args.VpnTunnel
	}
	s, err := ctx.RegisterResource("gcp:compute/routerInterface:RouterInterface", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &RouterInterface{s: s}, nil
}

// GetRouterInterface gets an existing RouterInterface resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRouterInterface(ctx *pulumi.Context,
	name string, id pulumi.ID, state *RouterInterfaceState, opts ...pulumi.ResourceOpt) (*RouterInterface, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["ipRange"] = state.IpRange
		inputs["name"] = state.Name
		inputs["project"] = state.Project
		inputs["region"] = state.Region
		inputs["router"] = state.Router
		inputs["vpnTunnel"] = state.VpnTunnel
	}
	s, err := ctx.ReadResource("gcp:compute/routerInterface:RouterInterface", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &RouterInterface{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *RouterInterface) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *RouterInterface) ID() *pulumi.IDOutput {
	return r.s.ID
}

// IP address and range of the interface. The IP range must be
// in the RFC3927 link-local IP space. Changing this forces a new interface to be created.
func (r *RouterInterface) IpRange() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["ipRange"])
}

// A unique name for the interface, required by GCE. Changing
// this forces a new interface to be created.
func (r *RouterInterface) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The ID of the project in which this interface's router belongs. If it
// is not provided, the provider project is used. Changing this forces a new interface to be created.
func (r *RouterInterface) Project() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["project"])
}

// The region this interface's router sits in. If not specified,
// the project region will be used. Changing this forces a new interface to be
// created.
func (r *RouterInterface) Region() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["region"])
}

// The name of the router this interface will be attached to.
// Changing this forces a new interface to be created.
func (r *RouterInterface) Router() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["router"])
}

// The name or resource link to the VPN tunnel this
// interface will be linked to. Changing this forces a new interface to be created.
func (r *RouterInterface) VpnTunnel() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["vpnTunnel"])
}

// Input properties used for looking up and filtering RouterInterface resources.
type RouterInterfaceState struct {
	// IP address and range of the interface. The IP range must be
	// in the RFC3927 link-local IP space. Changing this forces a new interface to be created.
	IpRange interface{}
	// A unique name for the interface, required by GCE. Changing
	// this forces a new interface to be created.
	Name interface{}
	// The ID of the project in which this interface's router belongs. If it
	// is not provided, the provider project is used. Changing this forces a new interface to be created.
	Project interface{}
	// The region this interface's router sits in. If not specified,
	// the project region will be used. Changing this forces a new interface to be
	// created.
	Region interface{}
	// The name of the router this interface will be attached to.
	// Changing this forces a new interface to be created.
	Router interface{}
	// The name or resource link to the VPN tunnel this
	// interface will be linked to. Changing this forces a new interface to be created.
	VpnTunnel interface{}
}

// The set of arguments for constructing a RouterInterface resource.
type RouterInterfaceArgs struct {
	// IP address and range of the interface. The IP range must be
	// in the RFC3927 link-local IP space. Changing this forces a new interface to be created.
	IpRange interface{}
	// A unique name for the interface, required by GCE. Changing
	// this forces a new interface to be created.
	Name interface{}
	// The ID of the project in which this interface's router belongs. If it
	// is not provided, the provider project is used. Changing this forces a new interface to be created.
	Project interface{}
	// The region this interface's router sits in. If not specified,
	// the project region will be used. Changing this forces a new interface to be
	// created.
	Region interface{}
	// The name of the router this interface will be attached to.
	// Changing this forces a new interface to be created.
	Router interface{}
	// The name or resource link to the VPN tunnel this
	// interface will be linked to. Changing this forces a new interface to be created.
	VpnTunnel interface{}
}
