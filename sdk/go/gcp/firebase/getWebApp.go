// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package firebase

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A Google Cloud Firebase web application instance
func LookupWebApp(ctx *pulumi.Context, args *LookupWebAppArgs, opts ...pulumi.InvokeOption) (*LookupWebAppResult, error) {
	var rv LookupWebAppResult
	err := ctx.Invoke("gcp:firebase/getWebApp:getWebApp", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getWebApp.
type LookupWebAppArgs struct {
	// The appIp of name of the Firebase webApp.
	AppId string `pulumi:"appId"`
}

// A collection of values returned by getWebApp.
type LookupWebAppResult struct {
	AppId       string `pulumi:"appId"`
	DisplayName string `pulumi:"displayName"`
	// The provider-assigned unique ID for this managed resource.
	Id      string `pulumi:"id"`
	Name    string `pulumi:"name"`
	Project string `pulumi:"project"`
}
