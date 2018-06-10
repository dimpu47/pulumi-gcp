// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package kms

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Three different resources help you manage your IAM policy for KMS key ring. Each of these resources serves a different use case:
// 
// * `google_kms_key_ring_iam_policy`: Authoritative. Sets the IAM policy for the key ring and replaces any existing policy already attached.
// * `google_kms_key_ring_iam_binding`: Authoritative for a given role. Updates the IAM policy to grant a role to a list of members. Other roles within the IAM policy for the key ring are preserved.
// * `google_kms_key_ring_iam_member`: Non-authoritative. Updates the IAM policy to grant a role to a new member. Other members for the role for the key ring are preserved.
// 
// ~> **Note:** `google_kms_key_ring_iam_policy` **cannot** be used in conjunction with `google_kms_key_ring_iam_binding` and `google_kms_key_ring_iam_member` or they will fight over what your policy should be.
// 
// ~> **Note:** `google_kms_key_ring_iam_binding` resources **can be** used in conjunction with `google_kms_key_ring_iam_member` resources **only if** they do not grant privilege to the same role.
type KeyRingIAMMember struct {
	s *pulumi.ResourceState
}

// NewKeyRingIAMMember registers a new resource with the given unique name, arguments, and options.
func NewKeyRingIAMMember(ctx *pulumi.Context,
	name string, args *KeyRingIAMMemberArgs, opts ...pulumi.ResourceOpt) (*KeyRingIAMMember, error) {
	if args == nil || args.KeyRingId == nil {
		return nil, errors.New("missing required argument 'KeyRingId'")
	}
	if args == nil || args.Member == nil {
		return nil, errors.New("missing required argument 'Member'")
	}
	if args == nil || args.Role == nil {
		return nil, errors.New("missing required argument 'Role'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["keyRingId"] = nil
		inputs["member"] = nil
		inputs["role"] = nil
	} else {
		inputs["keyRingId"] = args.KeyRingId
		inputs["member"] = args.Member
		inputs["role"] = args.Role
	}
	inputs["etag"] = nil
	s, err := ctx.RegisterResource("gcp:kms/keyRingIAMMember:KeyRingIAMMember", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &KeyRingIAMMember{s: s}, nil
}

// GetKeyRingIAMMember gets an existing KeyRingIAMMember resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetKeyRingIAMMember(ctx *pulumi.Context,
	name string, id pulumi.ID, state *KeyRingIAMMemberState, opts ...pulumi.ResourceOpt) (*KeyRingIAMMember, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["etag"] = state.Etag
		inputs["keyRingId"] = state.KeyRingId
		inputs["member"] = state.Member
		inputs["role"] = state.Role
	}
	s, err := ctx.ReadResource("gcp:kms/keyRingIAMMember:KeyRingIAMMember", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &KeyRingIAMMember{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *KeyRingIAMMember) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *KeyRingIAMMember) ID() *pulumi.IDOutput {
	return r.s.ID
}

// (Computed) The etag of the key ring's IAM policy.
func (r *KeyRingIAMMember) Etag() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["etag"])
}

// The key ring ID, in the form
// `{project_id}/{location_name}/{key_ring_name}` or
// `{location_name}/{key_ring_name}`. In the second form, the provider's
// project setting will be used as a fallback.
func (r *KeyRingIAMMember) KeyRingId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["keyRingId"])
}

func (r *KeyRingIAMMember) Member() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["member"])
}

// The role that should be applied. Only one
// `google_kms_key_ring_iam_binding` can be used per role. Note that custom roles must be of the format
// `[projects|organizations]/{parent-name}/roles/{role-name}`.
func (r *KeyRingIAMMember) Role() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["role"])
}

// Input properties used for looking up and filtering KeyRingIAMMember resources.
type KeyRingIAMMemberState struct {
	// (Computed) The etag of the key ring's IAM policy.
	Etag interface{}
	// The key ring ID, in the form
	// `{project_id}/{location_name}/{key_ring_name}` or
	// `{location_name}/{key_ring_name}`. In the second form, the provider's
	// project setting will be used as a fallback.
	KeyRingId interface{}
	Member interface{}
	// The role that should be applied. Only one
	// `google_kms_key_ring_iam_binding` can be used per role. Note that custom roles must be of the format
	// `[projects|organizations]/{parent-name}/roles/{role-name}`.
	Role interface{}
}

// The set of arguments for constructing a KeyRingIAMMember resource.
type KeyRingIAMMemberArgs struct {
	// The key ring ID, in the form
	// `{project_id}/{location_name}/{key_ring_name}` or
	// `{location_name}/{key_ring_name}`. In the second form, the provider's
	// project setting will be used as a fallback.
	KeyRingId interface{}
	Member interface{}
	// The role that should be applied. Only one
	// `google_kms_key_ring_iam_binding` can be used per role. Note that custom roles must be of the format
	// `[projects|organizations]/{parent-name}/roles/{role-name}`.
	Role interface{}
}
