// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package spanner

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/spanner_instance.html.markdown.
type Instance struct {
	s *pulumi.ResourceState
}

// NewInstance registers a new resource with the given unique name, arguments, and options.
func NewInstance(ctx *pulumi.Context,
	name string, args *InstanceArgs, opts ...pulumi.ResourceOpt) (*Instance, error) {
	if args == nil || args.Config == nil {
		return nil, errors.New("missing required argument 'Config'")
	}
	if args == nil || args.DisplayName == nil {
		return nil, errors.New("missing required argument 'DisplayName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["config"] = nil
		inputs["displayName"] = nil
		inputs["labels"] = nil
		inputs["name"] = nil
		inputs["numNodes"] = nil
		inputs["project"] = nil
	} else {
		inputs["config"] = args.Config
		inputs["displayName"] = args.DisplayName
		inputs["labels"] = args.Labels
		inputs["name"] = args.Name
		inputs["numNodes"] = args.NumNodes
		inputs["project"] = args.Project
	}
	inputs["state"] = nil
	s, err := ctx.RegisterResource("gcp:spanner/instance:Instance", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Instance{s: s}, nil
}

// GetInstance gets an existing Instance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetInstance(ctx *pulumi.Context,
	name string, id pulumi.ID, state *InstanceState, opts ...pulumi.ResourceOpt) (*Instance, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["config"] = state.Config
		inputs["displayName"] = state.DisplayName
		inputs["labels"] = state.Labels
		inputs["name"] = state.Name
		inputs["numNodes"] = state.NumNodes
		inputs["project"] = state.Project
		inputs["state"] = state.State
	}
	s, err := ctx.ReadResource("gcp:spanner/instance:Instance", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Instance{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Instance) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Instance) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// The name of the instance's configuration (similar but not quite the same as a region) which defines defines the
// geographic placement and replication of your databases in this instance. It determines where your data is stored. Values
// are typically of the form 'regional-europe-west1' , 'us-central' etc. In order to obtain a valid list please consult the
// [Configuration section of the docs](https://cloud.google.com/spanner/docs/instances).
func (r *Instance) Config() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["config"])
}

// The descriptive name for this instance as it appears in UIs. Must be unique per project and between 4 and 30 characters
// in length.
func (r *Instance) DisplayName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["displayName"])
}

// An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
func (r *Instance) Labels() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["labels"])
}

// A unique identifier for the instance, which cannot be changed after the instance is created. The name must be between 6
// and 30 characters in length. If not provided, a random string starting with 'tf-' will be selected.
func (r *Instance) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The number of nodes allocated to this instance.
func (r *Instance) NumNodes() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["numNodes"])
}

// The ID of the project in which the resource belongs.
// If it is not provided, the provider project is used.
func (r *Instance) Project() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["project"])
}

// Instance status: 'CREATING' or 'READY'.
func (r *Instance) State() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["state"])
}

// Input properties used for looking up and filtering Instance resources.
type InstanceState struct {
	// The name of the instance's configuration (similar but not quite the same as a region) which defines defines the
	// geographic placement and replication of your databases in this instance. It determines where your data is stored.
	// Values are typically of the form 'regional-europe-west1' , 'us-central' etc. In order to obtain a valid list please
	// consult the [Configuration section of the docs](https://cloud.google.com/spanner/docs/instances).
	Config interface{}
	// The descriptive name for this instance as it appears in UIs. Must be unique per project and between 4 and 30 characters
	// in length.
	DisplayName interface{}
	// An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
	Labels interface{}
	// A unique identifier for the instance, which cannot be changed after the instance is created. The name must be between 6
	// and 30 characters in length. If not provided, a random string starting with 'tf-' will be selected.
	Name interface{}
	// The number of nodes allocated to this instance.
	NumNodes interface{}
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project interface{}
	// Instance status: 'CREATING' or 'READY'.
	State interface{}
}

// The set of arguments for constructing a Instance resource.
type InstanceArgs struct {
	// The name of the instance's configuration (similar but not quite the same as a region) which defines defines the
	// geographic placement and replication of your databases in this instance. It determines where your data is stored.
	// Values are typically of the form 'regional-europe-west1' , 'us-central' etc. In order to obtain a valid list please
	// consult the [Configuration section of the docs](https://cloud.google.com/spanner/docs/instances).
	Config interface{}
	// The descriptive name for this instance as it appears in UIs. Must be unique per project and between 4 and 30 characters
	// in length.
	DisplayName interface{}
	// An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
	Labels interface{}
	// A unique identifier for the instance, which cannot be changed after the instance is created. The name must be between 6
	// and 30 characters in length. If not provided, a random string starting with 'tf-' will be selected.
	Name interface{}
	// The number of nodes allocated to this instance.
	NumNodes interface{}
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project interface{}
}
