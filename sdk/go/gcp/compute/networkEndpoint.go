// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_network_endpoint.html.markdown.
type NetworkEndpoint struct {
	s *pulumi.ResourceState
}

// NewNetworkEndpoint registers a new resource with the given unique name, arguments, and options.
func NewNetworkEndpoint(ctx *pulumi.Context,
	name string, args *NetworkEndpointArgs, opts ...pulumi.ResourceOpt) (*NetworkEndpoint, error) {
	if args == nil || args.Instance == nil {
		return nil, errors.New("missing required argument 'Instance'")
	}
	if args == nil || args.IpAddress == nil {
		return nil, errors.New("missing required argument 'IpAddress'")
	}
	if args == nil || args.NetworkEndpointGroup == nil {
		return nil, errors.New("missing required argument 'NetworkEndpointGroup'")
	}
	if args == nil || args.Port == nil {
		return nil, errors.New("missing required argument 'Port'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["instance"] = nil
		inputs["ipAddress"] = nil
		inputs["networkEndpointGroup"] = nil
		inputs["port"] = nil
		inputs["project"] = nil
		inputs["zone"] = nil
	} else {
		inputs["instance"] = args.Instance
		inputs["ipAddress"] = args.IpAddress
		inputs["networkEndpointGroup"] = args.NetworkEndpointGroup
		inputs["port"] = args.Port
		inputs["project"] = args.Project
		inputs["zone"] = args.Zone
	}
	s, err := ctx.RegisterResource("gcp:compute/networkEndpoint:NetworkEndpoint", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &NetworkEndpoint{s: s}, nil
}

// GetNetworkEndpoint gets an existing NetworkEndpoint resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNetworkEndpoint(ctx *pulumi.Context,
	name string, id pulumi.ID, state *NetworkEndpointState, opts ...pulumi.ResourceOpt) (*NetworkEndpoint, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["instance"] = state.Instance
		inputs["ipAddress"] = state.IpAddress
		inputs["networkEndpointGroup"] = state.NetworkEndpointGroup
		inputs["port"] = state.Port
		inputs["project"] = state.Project
		inputs["zone"] = state.Zone
	}
	s, err := ctx.ReadResource("gcp:compute/networkEndpoint:NetworkEndpoint", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &NetworkEndpoint{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *NetworkEndpoint) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *NetworkEndpoint) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// The name for a specific VM instance that the IP address belongs to. This is required for network endpoints of type
// GCE_VM_IP_PORT. The instance must be in the same zone of network endpoint group.
func (r *NetworkEndpoint) Instance() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["instance"])
}

// IPv4 address of network endpoint. The IP address must belong to a VM in GCE (either the primary IP or as part of an
// aliased IP range).
func (r *NetworkEndpoint) IpAddress() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["ipAddress"])
}

// The network endpoint group this endpoint is part of.
func (r *NetworkEndpoint) NetworkEndpointGroup() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["networkEndpointGroup"])
}

// Port number of network endpoint.
func (r *NetworkEndpoint) Port() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["port"])
}

// The ID of the project in which the resource belongs.
// If it is not provided, the provider project is used.
func (r *NetworkEndpoint) Project() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["project"])
}

// Zone where the containing network endpoint group is located.
func (r *NetworkEndpoint) Zone() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["zone"])
}

// Input properties used for looking up and filtering NetworkEndpoint resources.
type NetworkEndpointState struct {
	// The name for a specific VM instance that the IP address belongs to. This is required for network endpoints of type
	// GCE_VM_IP_PORT. The instance must be in the same zone of network endpoint group.
	Instance interface{}
	// IPv4 address of network endpoint. The IP address must belong to a VM in GCE (either the primary IP or as part of an
	// aliased IP range).
	IpAddress interface{}
	// The network endpoint group this endpoint is part of.
	NetworkEndpointGroup interface{}
	// Port number of network endpoint.
	Port interface{}
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project interface{}
	// Zone where the containing network endpoint group is located.
	Zone interface{}
}

// The set of arguments for constructing a NetworkEndpoint resource.
type NetworkEndpointArgs struct {
	// The name for a specific VM instance that the IP address belongs to. This is required for network endpoints of type
	// GCE_VM_IP_PORT. The instance must be in the same zone of network endpoint group.
	Instance interface{}
	// IPv4 address of network endpoint. The IP address must belong to a VM in GCE (either the primary IP or as part of an
	// aliased IP range).
	IpAddress interface{}
	// The network endpoint group this endpoint is part of.
	NetworkEndpointGroup interface{}
	// Port number of network endpoint.
	Port interface{}
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project interface{}
	// Zone where the containing network endpoint group is located.
	Zone interface{}
}
