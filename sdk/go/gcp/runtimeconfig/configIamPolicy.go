// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package runtimeconfig

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

type ConfigIamPolicy struct {
	pulumi.CustomResourceState

	// Used to find the parent resource to bind the IAM policy to
	Config pulumi.StringOutput `pulumi:"config"`
	// (Computed) The etag of the IAM policy.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData pulumi.StringOutput `pulumi:"policyData"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project pulumi.StringOutput `pulumi:"project"`
}

// NewConfigIamPolicy registers a new resource with the given unique name, arguments, and options.
func NewConfigIamPolicy(ctx *pulumi.Context,
	name string, args *ConfigIamPolicyArgs, opts ...pulumi.ResourceOption) (*ConfigIamPolicy, error) {
	if args == nil || args.Config == nil {
		return nil, errors.New("missing required argument 'Config'")
	}
	if args == nil || args.PolicyData == nil {
		return nil, errors.New("missing required argument 'PolicyData'")
	}
	if args == nil {
		args = &ConfigIamPolicyArgs{}
	}
	var resource ConfigIamPolicy
	err := ctx.RegisterResource("gcp:runtimeconfig/configIamPolicy:ConfigIamPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConfigIamPolicy gets an existing ConfigIamPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConfigIamPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConfigIamPolicyState, opts ...pulumi.ResourceOption) (*ConfigIamPolicy, error) {
	var resource ConfigIamPolicy
	err := ctx.ReadResource("gcp:runtimeconfig/configIamPolicy:ConfigIamPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConfigIamPolicy resources.
type configIamPolicyState struct {
	// Used to find the parent resource to bind the IAM policy to
	Config *string `pulumi:"config"`
	// (Computed) The etag of the IAM policy.
	Etag *string `pulumi:"etag"`
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData *string `pulumi:"policyData"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project *string `pulumi:"project"`
}

type ConfigIamPolicyState struct {
	// Used to find the parent resource to bind the IAM policy to
	Config pulumi.StringPtrInput
	// (Computed) The etag of the IAM policy.
	Etag pulumi.StringPtrInput
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData pulumi.StringPtrInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project pulumi.StringPtrInput
}

func (ConfigIamPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*configIamPolicyState)(nil)).Elem()
}

type configIamPolicyArgs struct {
	// Used to find the parent resource to bind the IAM policy to
	Config string `pulumi:"config"`
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData string `pulumi:"policyData"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project *string `pulumi:"project"`
}

// The set of arguments for constructing a ConfigIamPolicy resource.
type ConfigIamPolicyArgs struct {
	// Used to find the parent resource to bind the IAM policy to
	Config pulumi.StringInput
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData pulumi.StringInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project pulumi.StringPtrInput
}

func (ConfigIamPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*configIamPolicyArgs)(nil)).Elem()
}

