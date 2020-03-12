// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package serviceAccount

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Get service account public key. For more information, see [the official documentation](https://cloud.google.com/iam/docs/creating-managing-service-account-keys) and [API](https://cloud.google.com/iam/reference/rest/v1/projects.serviceAccounts.keys/get).
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/d/datasource_google_service_account_key.html.markdown.
func GetAccountKey(ctx *pulumi.Context, args *GetAccountKeyArgs, opts ...pulumi.InvokeOption) (*GetAccountKeyResult, error) {
	var rv GetAccountKeyResult
	err := ctx.Invoke("gcp:serviceAccount/getAccountKey:getAccountKey", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getAccountKey.
type GetAccountKeyArgs struct {
	// The name of the service account key. This must have format
	// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{KEYID}`, where `{ACCOUNT}`
	// is the email address or unique id of the service account.
	Name string `pulumi:"name"`
	// The ID of the project that the service account will be created in.
	// Defaults to the provider project configuration.
	Project *string `pulumi:"project"`
	// The output format of the public key requested. X509_PEM is the default output format.
	PublicKeyType *string `pulumi:"publicKeyType"`
}


// A collection of values returned by getAccountKey.
type GetAccountKeyResult struct {
	// id is the provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	KeyAlgorithm string `pulumi:"keyAlgorithm"`
	Name string `pulumi:"name"`
	Project *string `pulumi:"project"`
	// The public key, base64 encoded
	PublicKey string `pulumi:"publicKey"`
	PublicKeyType *string `pulumi:"publicKeyType"`
}

