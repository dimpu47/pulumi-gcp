// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package folder

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Allows creation and management of the IAM policy for an existing Google Cloud
// Platform folder.
type IAMPolicy struct {
	s *pulumi.ResourceState
}

// NewIAMPolicy registers a new resource with the given unique name, arguments, and options.
func NewIAMPolicy(ctx *pulumi.Context,
	name string, args *IAMPolicyArgs, opts ...pulumi.ResourceOpt) (*IAMPolicy, error) {
	if args == nil || args.Folder == nil {
		return nil, errors.New("missing required argument 'Folder'")
	}
	if args == nil || args.PolicyData == nil {
		return nil, errors.New("missing required argument 'PolicyData'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["folder"] = nil
		inputs["policyData"] = nil
	} else {
		inputs["folder"] = args.Folder
		inputs["policyData"] = args.PolicyData
	}
	inputs["etag"] = nil
	s, err := ctx.RegisterResource("gcp:folder/iAMPolicy:IAMPolicy", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &IAMPolicy{s: s}, nil
}

// GetIAMPolicy gets an existing IAMPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIAMPolicy(ctx *pulumi.Context,
	name string, id pulumi.ID, state *IAMPolicyState, opts ...pulumi.ResourceOpt) (*IAMPolicy, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["etag"] = state.Etag
		inputs["folder"] = state.Folder
		inputs["policyData"] = state.PolicyData
	}
	s, err := ctx.ReadResource("gcp:folder/iAMPolicy:IAMPolicy", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &IAMPolicy{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *IAMPolicy) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *IAMPolicy) ID() *pulumi.IDOutput {
	return r.s.ID
}

// (Computed) The etag of the folder's IAM policy. `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other. 
func (r *IAMPolicy) Etag() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["etag"])
}

// The resource name of the folder the policy is attached to. Its format is folders/{folder_id}.
func (r *IAMPolicy) Folder() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["folder"])
}

// The `google_iam_policy` data source that represents
// the IAM policy that will be applied to the folder. This policy overrides any existing
// policy applied to the folder.
func (r *IAMPolicy) PolicyData() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["policyData"])
}

// Input properties used for looking up and filtering IAMPolicy resources.
type IAMPolicyState struct {
	// (Computed) The etag of the folder's IAM policy. `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other. 
	Etag interface{}
	// The resource name of the folder the policy is attached to. Its format is folders/{folder_id}.
	Folder interface{}
	// The `google_iam_policy` data source that represents
	// the IAM policy that will be applied to the folder. This policy overrides any existing
	// policy applied to the folder.
	PolicyData interface{}
}

// The set of arguments for constructing a IAMPolicy resource.
type IAMPolicyArgs struct {
	// The resource name of the folder the policy is attached to. Its format is folders/{folder_id}.
	Folder interface{}
	// The `google_iam_policy` data source that represents
	// the IAM policy that will be applied to the folder. This policy overrides any existing
	// policy applied to the folder.
	PolicyData interface{}
}
