// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_network_endpoint_group.html.markdown.
type NetworkEndpointGroup struct {
	s *pulumi.ResourceState
}

// NewNetworkEndpointGroup registers a new resource with the given unique name, arguments, and options.
func NewNetworkEndpointGroup(ctx *pulumi.Context,
	name string, args *NetworkEndpointGroupArgs, opts ...pulumi.ResourceOpt) (*NetworkEndpointGroup, error) {
	if args == nil || args.Network == nil {
		return nil, errors.New("missing required argument 'Network'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["defaultPort"] = nil
		inputs["description"] = nil
		inputs["name"] = nil
		inputs["network"] = nil
		inputs["networkEndpointType"] = nil
		inputs["project"] = nil
		inputs["subnetwork"] = nil
		inputs["zone"] = nil
	} else {
		inputs["defaultPort"] = args.DefaultPort
		inputs["description"] = args.Description
		inputs["name"] = args.Name
		inputs["network"] = args.Network
		inputs["networkEndpointType"] = args.NetworkEndpointType
		inputs["project"] = args.Project
		inputs["subnetwork"] = args.Subnetwork
		inputs["zone"] = args.Zone
	}
	inputs["selfLink"] = nil
	inputs["size"] = nil
	s, err := ctx.RegisterResource("gcp:compute/networkEndpointGroup:NetworkEndpointGroup", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &NetworkEndpointGroup{s: s}, nil
}

// GetNetworkEndpointGroup gets an existing NetworkEndpointGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNetworkEndpointGroup(ctx *pulumi.Context,
	name string, id pulumi.ID, state *NetworkEndpointGroupState, opts ...pulumi.ResourceOpt) (*NetworkEndpointGroup, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["defaultPort"] = state.DefaultPort
		inputs["description"] = state.Description
		inputs["name"] = state.Name
		inputs["network"] = state.Network
		inputs["networkEndpointType"] = state.NetworkEndpointType
		inputs["project"] = state.Project
		inputs["selfLink"] = state.SelfLink
		inputs["size"] = state.Size
		inputs["subnetwork"] = state.Subnetwork
		inputs["zone"] = state.Zone
	}
	s, err := ctx.ReadResource("gcp:compute/networkEndpointGroup:NetworkEndpointGroup", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &NetworkEndpointGroup{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *NetworkEndpointGroup) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *NetworkEndpointGroup) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// The default port used if the port number is not specified in the network endpoint.
func (r *NetworkEndpointGroup) DefaultPort() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["defaultPort"])
}

// An optional description of this resource. Provide this property when you create the resource.
func (r *NetworkEndpointGroup) Description() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["description"])
}

// Name of the resource; provided by the client when the resource is created. The name must be 1-63 characters long, and
// comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
// '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
// must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
func (r *NetworkEndpointGroup) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The network to which all network endpoints in the NEG belong. Uses "default" project network if unspecified.
func (r *NetworkEndpointGroup) Network() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["network"])
}

// Type of network endpoints in this network endpoint group. Currently the only supported value is GCE_VM_IP_PORT.
func (r *NetworkEndpointGroup) NetworkEndpointType() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["networkEndpointType"])
}

// The ID of the project in which the resource belongs.
// If it is not provided, the provider project is used.
func (r *NetworkEndpointGroup) Project() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["project"])
}

// The URI of the created resource.
func (r *NetworkEndpointGroup) SelfLink() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["selfLink"])
}

// Number of network endpoints in the network endpoint group.
func (r *NetworkEndpointGroup) Size() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["size"])
}

// Optional subnetwork to which all network endpoints in the NEG belong.
func (r *NetworkEndpointGroup) Subnetwork() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["subnetwork"])
}

// Zone where the network endpoint group is located.
func (r *NetworkEndpointGroup) Zone() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["zone"])
}

// Input properties used for looking up and filtering NetworkEndpointGroup resources.
type NetworkEndpointGroupState struct {
	// The default port used if the port number is not specified in the network endpoint.
	DefaultPort interface{}
	// An optional description of this resource. Provide this property when you create the resource.
	Description interface{}
	// Name of the resource; provided by the client when the resource is created. The name must be 1-63 characters long, and
	// comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
	// '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
	// must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
	Name interface{}
	// The network to which all network endpoints in the NEG belong. Uses "default" project network if unspecified.
	Network interface{}
	// Type of network endpoints in this network endpoint group. Currently the only supported value is GCE_VM_IP_PORT.
	NetworkEndpointType interface{}
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project interface{}
	// The URI of the created resource.
	SelfLink interface{}
	// Number of network endpoints in the network endpoint group.
	Size interface{}
	// Optional subnetwork to which all network endpoints in the NEG belong.
	Subnetwork interface{}
	// Zone where the network endpoint group is located.
	Zone interface{}
}

// The set of arguments for constructing a NetworkEndpointGroup resource.
type NetworkEndpointGroupArgs struct {
	// The default port used if the port number is not specified in the network endpoint.
	DefaultPort interface{}
	// An optional description of this resource. Provide this property when you create the resource.
	Description interface{}
	// Name of the resource; provided by the client when the resource is created. The name must be 1-63 characters long, and
	// comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
	// '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
	// must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
	Name interface{}
	// The network to which all network endpoints in the NEG belong. Uses "default" project network if unspecified.
	Network interface{}
	// Type of network endpoints in this network endpoint group. Currently the only supported value is GCE_VM_IP_PORT.
	NetworkEndpointType interface{}
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project interface{}
	// Optional subnetwork to which all network endpoints in the NEG belong.
	Subnetwork interface{}
	// Zone where the network endpoint group is located.
	Zone interface{}
}
