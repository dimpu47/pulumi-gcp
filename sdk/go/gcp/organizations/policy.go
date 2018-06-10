// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package organizations

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Allows management of Organization policies for a Google Organization. For more information see
// [the official
// documentation](https://cloud.google.com/resource-manager/docs/organization-policy/overview) and
// [API](https://cloud.google.com/resource-manager/reference/rest/v1/organizations/setOrgPolicy).
type Policy struct {
	s *pulumi.ResourceState
}

// NewPolicy registers a new resource with the given unique name, arguments, and options.
func NewPolicy(ctx *pulumi.Context,
	name string, args *PolicyArgs, opts ...pulumi.ResourceOpt) (*Policy, error) {
	if args == nil || args.Constraint == nil {
		return nil, errors.New("missing required argument 'Constraint'")
	}
	if args == nil || args.OrgId == nil {
		return nil, errors.New("missing required argument 'OrgId'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["booleanPolicy"] = nil
		inputs["constraint"] = nil
		inputs["listPolicy"] = nil
		inputs["orgId"] = nil
		inputs["version"] = nil
	} else {
		inputs["booleanPolicy"] = args.BooleanPolicy
		inputs["constraint"] = args.Constraint
		inputs["listPolicy"] = args.ListPolicy
		inputs["orgId"] = args.OrgId
		inputs["version"] = args.Version
	}
	inputs["etag"] = nil
	inputs["updateTime"] = nil
	s, err := ctx.RegisterResource("gcp:organizations/policy:Policy", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Policy{s: s}, nil
}

// GetPolicy gets an existing Policy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPolicy(ctx *pulumi.Context,
	name string, id pulumi.ID, state *PolicyState, opts ...pulumi.ResourceOpt) (*Policy, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["booleanPolicy"] = state.BooleanPolicy
		inputs["constraint"] = state.Constraint
		inputs["etag"] = state.Etag
		inputs["listPolicy"] = state.ListPolicy
		inputs["orgId"] = state.OrgId
		inputs["updateTime"] = state.UpdateTime
		inputs["version"] = state.Version
	}
	s, err := ctx.ReadResource("gcp:organizations/policy:Policy", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Policy{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Policy) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Policy) ID() *pulumi.IDOutput {
	return r.s.ID
}

// A boolean policy is a constraint that is either enforced or not. Structure is documented below. 
func (r *Policy) BooleanPolicy() *pulumi.Output {
	return r.s.State["booleanPolicy"]
}

// The name of the Constraint the Policy is configuring, for example, `serviceuser.services`. Check out the [complete list of available constraints](https://cloud.google.com/resource-manager/docs/organization-policy/understanding-constraints#available_constraints).
func (r *Policy) Constraint() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["constraint"])
}

// (Computed) The etag of the organization policy. `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other. 
func (r *Policy) Etag() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["etag"])
}

// A policy that can define specific values that are allowed or denied for the given constraint. It can also be used to allow or deny all values. Structure is documented below.
func (r *Policy) ListPolicy() *pulumi.Output {
	return r.s.State["listPolicy"]
}

// The numeric ID of the organization to set the policy for.
func (r *Policy) OrgId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["orgId"])
}

// (Computed) The timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds, representing when the variable was last updated. Example: "2016-10-09T12:33:37.578138407Z".
func (r *Policy) UpdateTime() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["updateTime"])
}

// Version of the Policy. Default version is 0.
func (r *Policy) Version() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["version"])
}

// Input properties used for looking up and filtering Policy resources.
type PolicyState struct {
	// A boolean policy is a constraint that is either enforced or not. Structure is documented below. 
	BooleanPolicy interface{}
	// The name of the Constraint the Policy is configuring, for example, `serviceuser.services`. Check out the [complete list of available constraints](https://cloud.google.com/resource-manager/docs/organization-policy/understanding-constraints#available_constraints).
	Constraint interface{}
	// (Computed) The etag of the organization policy. `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other. 
	Etag interface{}
	// A policy that can define specific values that are allowed or denied for the given constraint. It can also be used to allow or deny all values. Structure is documented below.
	ListPolicy interface{}
	// The numeric ID of the organization to set the policy for.
	OrgId interface{}
	// (Computed) The timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds, representing when the variable was last updated. Example: "2016-10-09T12:33:37.578138407Z".
	UpdateTime interface{}
	// Version of the Policy. Default version is 0.
	Version interface{}
}

// The set of arguments for constructing a Policy resource.
type PolicyArgs struct {
	// A boolean policy is a constraint that is either enforced or not. Structure is documented below. 
	BooleanPolicy interface{}
	// The name of the Constraint the Policy is configuring, for example, `serviceuser.services`. Check out the [complete list of available constraints](https://cloud.google.com/resource-manager/docs/organization-policy/understanding-constraints#available_constraints).
	Constraint interface{}
	// A policy that can define specific values that are allowed or denied for the given constraint. It can also be used to allow or deny all values. Structure is documented below.
	ListPolicy interface{}
	// The numeric ID of the organization to set the policy for.
	OrgId interface{}
	// Version of the Policy. Default version is 0.
	Version interface{}
}
