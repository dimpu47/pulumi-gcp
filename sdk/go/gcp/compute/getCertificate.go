// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package compute

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Get info about a Google Compute SSL Certificate from its name.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/d/datasource_compute_ssl_certificate.html.markdown.
func GetCertificate(ctx *pulumi.Context, args *GetCertificateArgs, opts ...pulumi.InvokeOption) (*GetCertificateResult, error) {
	var rv GetCertificateResult
	err := ctx.Invoke("gcp:compute/getCertificate:getCertificate", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getCertificate.
type GetCertificateArgs struct {
	// The name of the certificate.
	Name string `pulumi:"name"`
	// The project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project *string `pulumi:"project"`
}


// A collection of values returned by getCertificate.
type GetCertificateResult struct {
	Certificate string `pulumi:"certificate"`
	CertificateId int `pulumi:"certificateId"`
	CreationTimestamp string `pulumi:"creationTimestamp"`
	Description string `pulumi:"description"`
	// id is the provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	Name string `pulumi:"name"`
	NamePrefix string `pulumi:"namePrefix"`
	PrivateKey string `pulumi:"privateKey"`
	Project *string `pulumi:"project"`
	SelfLink string `pulumi:"selfLink"`
}

