// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package bigquery

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Three different resources help you manage your IAM policy for BigQuery dataset. Each of these resources serves a different use case:
//
// * `bigquery.DatasetIamPolicy`: Authoritative. Sets the IAM policy for the dataset and replaces any existing policy already attached.
// * `bigquery.DatasetIamBinding`: Authoritative for a given role. Updates the IAM policy to grant a role to a list of members. Other roles within the IAM policy for the dataset are preserved.
// * `bigquery.DatasetIamMember`: Non-authoritative. Updates the IAM policy to grant a role to a new member. Other members for the role for the dataset are preserved.
//
// These resources are intended to convert the permissions system for BigQuery datasets to the standard IAM interface. For advanced usages, including [creating authorized views](https://cloud.google.com/bigquery/docs/share-access-views), please use either `bigquery.DatasetAccess` or the `access` field on `bigquery.Dataset`.
//
// > **Note:** These resources **cannot** be used with `bigquery.DatasetAccess` resources or the `access` field on `bigquery.Dataset` or they will fight over what the policy should be.
//
// > **Note:** Using any of these resources will remove any authorized view permissions from the dataset. To assign and preserve authorized view permissions use the `bigquery.DatasetAccess` instead.
//
// > **Note:** Legacy BigQuery roles `OWNER` `WRITER` and `READER` **cannot** be used with any of these IAM resources. Instead use the full role form of: `roles/bigquery.dataOwner` `roles/bigquery.dataEditor` and `roles/bigquery.dataViewer`.
//
// > **Note:** `bigquery.DatasetIamPolicy` **cannot** be used in conjunction with `bigquery.DatasetIamBinding` and `bigquery.DatasetIamMember` or they will fight over what your policy should be.
//
// > **Note:** `bigquery.DatasetIamBinding` resources **can be** used in conjunction with `bigquery.DatasetIamMember` resources **only if** they do not grant privilege to the same role.
type DatasetIamPolicy struct {
	pulumi.CustomResourceState

	// The dataset ID, in the form `projects/{project}/datasets/{dataset_id}`
	DatasetId pulumi.StringOutput `pulumi:"datasetId"`
	// (Computed) The etag of the dataset's IAM policy.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData pulumi.StringOutput `pulumi:"policyData"`
	Project    pulumi.StringOutput `pulumi:"project"`
}

// NewDatasetIamPolicy registers a new resource with the given unique name, arguments, and options.
func NewDatasetIamPolicy(ctx *pulumi.Context,
	name string, args *DatasetIamPolicyArgs, opts ...pulumi.ResourceOption) (*DatasetIamPolicy, error) {
	if args == nil || args.DatasetId == nil {
		return nil, errors.New("missing required argument 'DatasetId'")
	}
	if args == nil || args.PolicyData == nil {
		return nil, errors.New("missing required argument 'PolicyData'")
	}
	if args == nil {
		args = &DatasetIamPolicyArgs{}
	}
	var resource DatasetIamPolicy
	err := ctx.RegisterResource("gcp:bigquery/datasetIamPolicy:DatasetIamPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDatasetIamPolicy gets an existing DatasetIamPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDatasetIamPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DatasetIamPolicyState, opts ...pulumi.ResourceOption) (*DatasetIamPolicy, error) {
	var resource DatasetIamPolicy
	err := ctx.ReadResource("gcp:bigquery/datasetIamPolicy:DatasetIamPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DatasetIamPolicy resources.
type datasetIamPolicyState struct {
	// The dataset ID, in the form `projects/{project}/datasets/{dataset_id}`
	DatasetId *string `pulumi:"datasetId"`
	// (Computed) The etag of the dataset's IAM policy.
	Etag *string `pulumi:"etag"`
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData *string `pulumi:"policyData"`
	Project    *string `pulumi:"project"`
}

type DatasetIamPolicyState struct {
	// The dataset ID, in the form `projects/{project}/datasets/{dataset_id}`
	DatasetId pulumi.StringPtrInput
	// (Computed) The etag of the dataset's IAM policy.
	Etag pulumi.StringPtrInput
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData pulumi.StringPtrInput
	Project    pulumi.StringPtrInput
}

func (DatasetIamPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*datasetIamPolicyState)(nil)).Elem()
}

type datasetIamPolicyArgs struct {
	// The dataset ID, in the form `projects/{project}/datasets/{dataset_id}`
	DatasetId string `pulumi:"datasetId"`
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData string  `pulumi:"policyData"`
	Project    *string `pulumi:"project"`
}

// The set of arguments for constructing a DatasetIamPolicy resource.
type DatasetIamPolicyArgs struct {
	// The dataset ID, in the form `projects/{project}/datasets/{dataset_id}`
	DatasetId pulumi.StringInput
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData pulumi.StringInput
	Project    pulumi.StringPtrInput
}

func (DatasetIamPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*datasetIamPolicyArgs)(nil)).Elem()
}
