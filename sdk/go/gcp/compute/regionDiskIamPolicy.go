// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Three different resources help you manage your IAM policy for Compute Engine Disk. Each of these resources serves a different use case:
//
// * `compute.DiskIamPolicy`: Authoritative. Sets the IAM policy for the disk and replaces any existing policy already attached.
// * `compute.DiskIamBinding`: Authoritative for a given role. Updates the IAM policy to grant a role to a list of members. Other roles within the IAM policy for the disk are preserved.
// * `compute.DiskIamMember`: Non-authoritative. Updates the IAM policy to grant a role to a new member. Other members for the role for the disk are preserved.
//
// > **Note:** `compute.DiskIamPolicy` **cannot** be used in conjunction with `compute.DiskIamBinding` and `compute.DiskIamMember` or they will fight over what your policy should be.
//
// > **Note:** `compute.DiskIamBinding` resources **can be** used in conjunction with `compute.DiskIamMember` resources **only if** they do not grant privilege to the same role.
type RegionDiskIamPolicy struct {
	pulumi.CustomResourceState

	// (Computed) The etag of the IAM policy.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// Used to find the parent resource to bind the IAM policy to
	Name pulumi.StringOutput `pulumi:"name"`
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData pulumi.StringOutput `pulumi:"policyData"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project pulumi.StringOutput `pulumi:"project"`
	Region  pulumi.StringOutput `pulumi:"region"`
}

// NewRegionDiskIamPolicy registers a new resource with the given unique name, arguments, and options.
func NewRegionDiskIamPolicy(ctx *pulumi.Context,
	name string, args *RegionDiskIamPolicyArgs, opts ...pulumi.ResourceOption) (*RegionDiskIamPolicy, error) {
	if args == nil || args.PolicyData == nil {
		return nil, errors.New("missing required argument 'PolicyData'")
	}
	if args == nil {
		args = &RegionDiskIamPolicyArgs{}
	}
	var resource RegionDiskIamPolicy
	err := ctx.RegisterResource("gcp:compute/regionDiskIamPolicy:RegionDiskIamPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRegionDiskIamPolicy gets an existing RegionDiskIamPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRegionDiskIamPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RegionDiskIamPolicyState, opts ...pulumi.ResourceOption) (*RegionDiskIamPolicy, error) {
	var resource RegionDiskIamPolicy
	err := ctx.ReadResource("gcp:compute/regionDiskIamPolicy:RegionDiskIamPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RegionDiskIamPolicy resources.
type regionDiskIamPolicyState struct {
	// (Computed) The etag of the IAM policy.
	Etag *string `pulumi:"etag"`
	// Used to find the parent resource to bind the IAM policy to
	Name *string `pulumi:"name"`
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData *string `pulumi:"policyData"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project *string `pulumi:"project"`
	Region  *string `pulumi:"region"`
}

type RegionDiskIamPolicyState struct {
	// (Computed) The etag of the IAM policy.
	Etag pulumi.StringPtrInput
	// Used to find the parent resource to bind the IAM policy to
	Name pulumi.StringPtrInput
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData pulumi.StringPtrInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project pulumi.StringPtrInput
	Region  pulumi.StringPtrInput
}

func (RegionDiskIamPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*regionDiskIamPolicyState)(nil)).Elem()
}

type regionDiskIamPolicyArgs struct {
	// Used to find the parent resource to bind the IAM policy to
	Name *string `pulumi:"name"`
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData string `pulumi:"policyData"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project *string `pulumi:"project"`
	Region  *string `pulumi:"region"`
}

// The set of arguments for constructing a RegionDiskIamPolicy resource.
type RegionDiskIamPolicyArgs struct {
	// Used to find the parent resource to bind the IAM policy to
	Name pulumi.StringPtrInput
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData pulumi.StringInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project pulumi.StringPtrInput
	Region  pulumi.StringPtrInput
}

func (RegionDiskIamPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*regionDiskIamPolicyArgs)(nil)).Elem()
}