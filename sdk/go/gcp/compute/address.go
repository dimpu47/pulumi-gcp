// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_address.html.markdown.
type Address struct {
	s *pulumi.ResourceState
}

// NewAddress registers a new resource with the given unique name, arguments, and options.
func NewAddress(ctx *pulumi.Context,
	name string, args *AddressArgs, opts ...pulumi.ResourceOpt) (*Address, error) {
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["address"] = nil
		inputs["addressType"] = nil
		inputs["description"] = nil
		inputs["labels"] = nil
		inputs["name"] = nil
		inputs["networkTier"] = nil
		inputs["project"] = nil
		inputs["region"] = nil
		inputs["subnetwork"] = nil
	} else {
		inputs["address"] = args.Address
		inputs["addressType"] = args.AddressType
		inputs["description"] = args.Description
		inputs["labels"] = args.Labels
		inputs["name"] = args.Name
		inputs["networkTier"] = args.NetworkTier
		inputs["project"] = args.Project
		inputs["region"] = args.Region
		inputs["subnetwork"] = args.Subnetwork
	}
	inputs["creationTimestamp"] = nil
	inputs["labelFingerprint"] = nil
	inputs["selfLink"] = nil
	inputs["users"] = nil
	s, err := ctx.RegisterResource("gcp:compute/address:Address", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Address{s: s}, nil
}

// GetAddress gets an existing Address resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAddress(ctx *pulumi.Context,
	name string, id pulumi.ID, state *AddressState, opts ...pulumi.ResourceOpt) (*Address, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["address"] = state.Address
		inputs["addressType"] = state.AddressType
		inputs["creationTimestamp"] = state.CreationTimestamp
		inputs["description"] = state.Description
		inputs["labelFingerprint"] = state.LabelFingerprint
		inputs["labels"] = state.Labels
		inputs["name"] = state.Name
		inputs["networkTier"] = state.NetworkTier
		inputs["project"] = state.Project
		inputs["region"] = state.Region
		inputs["selfLink"] = state.SelfLink
		inputs["subnetwork"] = state.Subnetwork
		inputs["users"] = state.Users
	}
	s, err := ctx.ReadResource("gcp:compute/address:Address", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Address{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Address) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Address) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// The IP of the created resource.
func (r *Address) Address() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["address"])
}

func (r *Address) AddressType() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["addressType"])
}

func (r *Address) CreationTimestamp() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["creationTimestamp"])
}

func (r *Address) Description() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["description"])
}

func (r *Address) LabelFingerprint() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["labelFingerprint"])
}

func (r *Address) Labels() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["labels"])
}

func (r *Address) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

func (r *Address) NetworkTier() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["networkTier"])
}

// The ID of the project in which the resource belongs.
// If it is not provided, the provider project is used.
func (r *Address) Project() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["project"])
}

func (r *Address) Region() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["region"])
}

// The URI of the created resource.
func (r *Address) SelfLink() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["selfLink"])
}

func (r *Address) Subnetwork() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["subnetwork"])
}

func (r *Address) Users() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["users"])
}

// Input properties used for looking up and filtering Address resources.
type AddressState struct {
	// The IP of the created resource.
	Address interface{}
	AddressType interface{}
	CreationTimestamp interface{}
	Description interface{}
	LabelFingerprint interface{}
	Labels interface{}
	Name interface{}
	NetworkTier interface{}
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project interface{}
	Region interface{}
	// The URI of the created resource.
	SelfLink interface{}
	Subnetwork interface{}
	Users interface{}
}

// The set of arguments for constructing a Address resource.
type AddressArgs struct {
	// The IP of the created resource.
	Address interface{}
	AddressType interface{}
	Description interface{}
	Labels interface{}
	Name interface{}
	NetworkTier interface{}
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project interface{}
	Region interface{}
	Subnetwork interface{}
}
