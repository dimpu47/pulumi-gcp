// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package iam

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Retrieve a list of testable permissions for a resource. Testable permissions mean the permissions that user can add or remove in a role at a given resource. The resource can be referenced either via the full resource name or via a URI.
//
// ## Example Usage
//
//
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		perms, err := iam.LookupTestablePermissions(ctx, &iam.LookupTestablePermissionsArgs{
// 			FullResourceName: "//cloudresourcemanager.googleapis.com/projects/my-project",
// 			Stages: []string{
// 				"GA",
// 				"BETA",
// 			},
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetTestablePermissions(ctx *pulumi.Context, args *GetTestablePermissionsArgs, opts ...pulumi.InvokeOption) (*GetTestablePermissionsResult, error) {
	var rv GetTestablePermissionsResult
	err := ctx.Invoke("gcp:iam/getTestablePermissions:getTestablePermissions", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getTestablePermissions.
type GetTestablePermissionsArgs struct {
	// The level of support for custom roles. Can be one of `"NOT_SUPPORTED"`, `"SUPPORTED"`, `"TESTING"`. Default is `"SUPPORTED"`
	CustomSupportLevel *string `pulumi:"customSupportLevel"`
	// See [full resource name documentation](https://cloud.google.com/apis/design/resource_names#full_resource_name) for more detail.
	FullResourceName string `pulumi:"fullResourceName"`
	// The acceptable release stages of the permission in the output. Note that `BETA` does not include permissions in `GA`, but you can specify both with `["GA", "BETA"]` for example. Can be a list of `"ALPHA"`, `"BETA"`, `"GA"`, `"DEPRECATED"`. Default is `["GA"]`.
	Stages []string `pulumi:"stages"`
}

// A collection of values returned by getTestablePermissions.
type GetTestablePermissionsResult struct {
	// The the support level of this permission for custom roles.
	CustomSupportLevel *string `pulumi:"customSupportLevel"`
	FullResourceName   string  `pulumi:"fullResourceName"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// A list of permissions matching the provided input. Structure is defined below.
	Permissions []GetTestablePermissionsPermission `pulumi:"permissions"`
	Stages      []string                           `pulumi:"stages"`
}