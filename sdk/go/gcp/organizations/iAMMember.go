// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package organizations

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Allows creation and management of a single member for a single binding within
// the IAM policy for an existing Google Cloud Platform Organization.
// 
// ~> **Note:** This resource __must not__ be used in conjunction with
//    `google_organization_iam_binding` for the __same role__ or they will fight over
//    what your policy should be.
type IAMMember struct {
	s *pulumi.ResourceState
}

// NewIAMMember registers a new resource with the given unique name, arguments, and options.
func NewIAMMember(ctx *pulumi.Context,
	name string, args *IAMMemberArgs, opts ...pulumi.ResourceOpt) (*IAMMember, error) {
	if args == nil || args.Member == nil {
		return nil, errors.New("missing required argument 'Member'")
	}
	if args == nil || args.OrgId == nil {
		return nil, errors.New("missing required argument 'OrgId'")
	}
	if args == nil || args.Role == nil {
		return nil, errors.New("missing required argument 'Role'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["member"] = nil
		inputs["orgId"] = nil
		inputs["role"] = nil
	} else {
		inputs["member"] = args.Member
		inputs["orgId"] = args.OrgId
		inputs["role"] = args.Role
	}
	inputs["etag"] = nil
	s, err := ctx.RegisterResource("gcp:organizations/iAMMember:IAMMember", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &IAMMember{s: s}, nil
}

// GetIAMMember gets an existing IAMMember resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIAMMember(ctx *pulumi.Context,
	name string, id pulumi.ID, state *IAMMemberState, opts ...pulumi.ResourceOpt) (*IAMMember, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["etag"] = state.Etag
		inputs["member"] = state.Member
		inputs["orgId"] = state.OrgId
		inputs["role"] = state.Role
	}
	s, err := ctx.ReadResource("gcp:organizations/iAMMember:IAMMember", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &IAMMember{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *IAMMember) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *IAMMember) ID() *pulumi.IDOutput {
	return r.s.ID
}

// (Computed) The etag of the organization's IAM policy.
func (r *IAMMember) Etag() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["etag"])
}

// The user that the role should apply to.
func (r *IAMMember) Member() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["member"])
}

// The numeric ID of the organization in which you want to create a custom role.
func (r *IAMMember) OrgId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["orgId"])
}

// The role that should be applied. Note that custom roles must be of the format
// `[projects|organizations]/{parent-name}/roles/{role-name}`.
func (r *IAMMember) Role() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["role"])
}

// Input properties used for looking up and filtering IAMMember resources.
type IAMMemberState struct {
	// (Computed) The etag of the organization's IAM policy.
	Etag interface{}
	// The user that the role should apply to.
	Member interface{}
	// The numeric ID of the organization in which you want to create a custom role.
	OrgId interface{}
	// The role that should be applied. Note that custom roles must be of the format
	// `[projects|organizations]/{parent-name}/roles/{role-name}`.
	Role interface{}
}

// The set of arguments for constructing a IAMMember resource.
type IAMMemberArgs struct {
	// The user that the role should apply to.
	Member interface{}
	// The numeric ID of the organization in which you want to create a custom role.
	OrgId interface{}
	// The role that should be applied. Note that custom roles must be of the format
	// `[projects|organizations]/{parent-name}/roles/{role-name}`.
	Role interface{}
}
