// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An HttpsHealthCheck resource. This resource defines a template for how
// individual VMs should be checked for health, via HTTPS.
//
// > **Note:** compute.HttpsHealthCheck is a legacy health check.
// The newer [compute.HealthCheck](https://www.terraform.io/docs/providers/google/r/compute_health_check.html)
// should be preferred for all uses except
// [Network Load Balancers](https://cloud.google.com/compute/docs/load-balancing/network/)
// which still require the legacy version.
//
// To get more information about HttpsHealthCheck, see:
//
// * [API documentation](https://cloud.google.com/compute/docs/reference/v1/httpsHealthChecks)
// * How-to Guides
//     * [Adding Health Checks](https://cloud.google.com/compute/docs/load-balancing/health-checks#legacy_health_checks)
//
// ## Example Usage
type HttpsHealthCheck struct {
	pulumi.CustomResourceState

	// How often (in seconds) to send a health check. The default value is 5
	// seconds.
	CheckIntervalSec pulumi.IntPtrOutput `pulumi:"checkIntervalSec"`
	// Creation timestamp in RFC3339 text format.
	CreationTimestamp pulumi.StringOutput `pulumi:"creationTimestamp"`
	// An optional description of this resource. Provide this property when
	// you create the resource.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// A so-far unhealthy instance will be marked healthy after this many
	// consecutive successes. The default value is 2.
	HealthyThreshold pulumi.IntPtrOutput `pulumi:"healthyThreshold"`
	// The value of the host header in the HTTPS health check request. If
	// left empty (default value), the public IP on behalf of which this
	// health check is performed will be used.
	Host pulumi.StringPtrOutput `pulumi:"host"`
	// Name of the resource. Provided by the client when the resource is
	// created. The name must be 1-63 characters long, and comply with
	// RFC1035.  Specifically, the name must be 1-63 characters long and
	// match the regular expression `a-z?` which means
	// the first character must be a lowercase letter, and all following
	// characters must be a dash, lowercase letter, or digit, except the
	// last character, which cannot be a dash.
	Name pulumi.StringOutput `pulumi:"name"`
	// The TCP port number for the HTTPS health check request.
	// The default value is 80.
	Port pulumi.IntPtrOutput `pulumi:"port"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringOutput `pulumi:"project"`
	// The request path of the HTTPS health check request.
	// The default value is /.
	RequestPath pulumi.StringPtrOutput `pulumi:"requestPath"`
	// The URI of the created resource.
	SelfLink pulumi.StringOutput `pulumi:"selfLink"`
	// How long (in seconds) to wait before claiming failure.
	// The default value is 5 seconds.  It is invalid for timeoutSec to have
	// greater value than checkIntervalSec.
	TimeoutSec pulumi.IntPtrOutput `pulumi:"timeoutSec"`
	// A so-far healthy instance will be marked unhealthy after this many
	// consecutive failures. The default value is 2.
	UnhealthyThreshold pulumi.IntPtrOutput `pulumi:"unhealthyThreshold"`
}

// NewHttpsHealthCheck registers a new resource with the given unique name, arguments, and options.
func NewHttpsHealthCheck(ctx *pulumi.Context,
	name string, args *HttpsHealthCheckArgs, opts ...pulumi.ResourceOption) (*HttpsHealthCheck, error) {
	if args == nil {
		args = &HttpsHealthCheckArgs{}
	}
	var resource HttpsHealthCheck
	err := ctx.RegisterResource("gcp:compute/httpsHealthCheck:HttpsHealthCheck", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetHttpsHealthCheck gets an existing HttpsHealthCheck resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetHttpsHealthCheck(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *HttpsHealthCheckState, opts ...pulumi.ResourceOption) (*HttpsHealthCheck, error) {
	var resource HttpsHealthCheck
	err := ctx.ReadResource("gcp:compute/httpsHealthCheck:HttpsHealthCheck", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering HttpsHealthCheck resources.
type httpsHealthCheckState struct {
	// How often (in seconds) to send a health check. The default value is 5
	// seconds.
	CheckIntervalSec *int `pulumi:"checkIntervalSec"`
	// Creation timestamp in RFC3339 text format.
	CreationTimestamp *string `pulumi:"creationTimestamp"`
	// An optional description of this resource. Provide this property when
	// you create the resource.
	Description *string `pulumi:"description"`
	// A so-far unhealthy instance will be marked healthy after this many
	// consecutive successes. The default value is 2.
	HealthyThreshold *int `pulumi:"healthyThreshold"`
	// The value of the host header in the HTTPS health check request. If
	// left empty (default value), the public IP on behalf of which this
	// health check is performed will be used.
	Host *string `pulumi:"host"`
	// Name of the resource. Provided by the client when the resource is
	// created. The name must be 1-63 characters long, and comply with
	// RFC1035.  Specifically, the name must be 1-63 characters long and
	// match the regular expression `a-z?` which means
	// the first character must be a lowercase letter, and all following
	// characters must be a dash, lowercase letter, or digit, except the
	// last character, which cannot be a dash.
	Name *string `pulumi:"name"`
	// The TCP port number for the HTTPS health check request.
	// The default value is 80.
	Port *int `pulumi:"port"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project *string `pulumi:"project"`
	// The request path of the HTTPS health check request.
	// The default value is /.
	RequestPath *string `pulumi:"requestPath"`
	// The URI of the created resource.
	SelfLink *string `pulumi:"selfLink"`
	// How long (in seconds) to wait before claiming failure.
	// The default value is 5 seconds.  It is invalid for timeoutSec to have
	// greater value than checkIntervalSec.
	TimeoutSec *int `pulumi:"timeoutSec"`
	// A so-far healthy instance will be marked unhealthy after this many
	// consecutive failures. The default value is 2.
	UnhealthyThreshold *int `pulumi:"unhealthyThreshold"`
}

type HttpsHealthCheckState struct {
	// How often (in seconds) to send a health check. The default value is 5
	// seconds.
	CheckIntervalSec pulumi.IntPtrInput
	// Creation timestamp in RFC3339 text format.
	CreationTimestamp pulumi.StringPtrInput
	// An optional description of this resource. Provide this property when
	// you create the resource.
	Description pulumi.StringPtrInput
	// A so-far unhealthy instance will be marked healthy after this many
	// consecutive successes. The default value is 2.
	HealthyThreshold pulumi.IntPtrInput
	// The value of the host header in the HTTPS health check request. If
	// left empty (default value), the public IP on behalf of which this
	// health check is performed will be used.
	Host pulumi.StringPtrInput
	// Name of the resource. Provided by the client when the resource is
	// created. The name must be 1-63 characters long, and comply with
	// RFC1035.  Specifically, the name must be 1-63 characters long and
	// match the regular expression `a-z?` which means
	// the first character must be a lowercase letter, and all following
	// characters must be a dash, lowercase letter, or digit, except the
	// last character, which cannot be a dash.
	Name pulumi.StringPtrInput
	// The TCP port number for the HTTPS health check request.
	// The default value is 80.
	Port pulumi.IntPtrInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringPtrInput
	// The request path of the HTTPS health check request.
	// The default value is /.
	RequestPath pulumi.StringPtrInput
	// The URI of the created resource.
	SelfLink pulumi.StringPtrInput
	// How long (in seconds) to wait before claiming failure.
	// The default value is 5 seconds.  It is invalid for timeoutSec to have
	// greater value than checkIntervalSec.
	TimeoutSec pulumi.IntPtrInput
	// A so-far healthy instance will be marked unhealthy after this many
	// consecutive failures. The default value is 2.
	UnhealthyThreshold pulumi.IntPtrInput
}

func (HttpsHealthCheckState) ElementType() reflect.Type {
	return reflect.TypeOf((*httpsHealthCheckState)(nil)).Elem()
}

type httpsHealthCheckArgs struct {
	// How often (in seconds) to send a health check. The default value is 5
	// seconds.
	CheckIntervalSec *int `pulumi:"checkIntervalSec"`
	// An optional description of this resource. Provide this property when
	// you create the resource.
	Description *string `pulumi:"description"`
	// A so-far unhealthy instance will be marked healthy after this many
	// consecutive successes. The default value is 2.
	HealthyThreshold *int `pulumi:"healthyThreshold"`
	// The value of the host header in the HTTPS health check request. If
	// left empty (default value), the public IP on behalf of which this
	// health check is performed will be used.
	Host *string `pulumi:"host"`
	// Name of the resource. Provided by the client when the resource is
	// created. The name must be 1-63 characters long, and comply with
	// RFC1035.  Specifically, the name must be 1-63 characters long and
	// match the regular expression `a-z?` which means
	// the first character must be a lowercase letter, and all following
	// characters must be a dash, lowercase letter, or digit, except the
	// last character, which cannot be a dash.
	Name *string `pulumi:"name"`
	// The TCP port number for the HTTPS health check request.
	// The default value is 80.
	Port *int `pulumi:"port"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project *string `pulumi:"project"`
	// The request path of the HTTPS health check request.
	// The default value is /.
	RequestPath *string `pulumi:"requestPath"`
	// How long (in seconds) to wait before claiming failure.
	// The default value is 5 seconds.  It is invalid for timeoutSec to have
	// greater value than checkIntervalSec.
	TimeoutSec *int `pulumi:"timeoutSec"`
	// A so-far healthy instance will be marked unhealthy after this many
	// consecutive failures. The default value is 2.
	UnhealthyThreshold *int `pulumi:"unhealthyThreshold"`
}

// The set of arguments for constructing a HttpsHealthCheck resource.
type HttpsHealthCheckArgs struct {
	// How often (in seconds) to send a health check. The default value is 5
	// seconds.
	CheckIntervalSec pulumi.IntPtrInput
	// An optional description of this resource. Provide this property when
	// you create the resource.
	Description pulumi.StringPtrInput
	// A so-far unhealthy instance will be marked healthy after this many
	// consecutive successes. The default value is 2.
	HealthyThreshold pulumi.IntPtrInput
	// The value of the host header in the HTTPS health check request. If
	// left empty (default value), the public IP on behalf of which this
	// health check is performed will be used.
	Host pulumi.StringPtrInput
	// Name of the resource. Provided by the client when the resource is
	// created. The name must be 1-63 characters long, and comply with
	// RFC1035.  Specifically, the name must be 1-63 characters long and
	// match the regular expression `a-z?` which means
	// the first character must be a lowercase letter, and all following
	// characters must be a dash, lowercase letter, or digit, except the
	// last character, which cannot be a dash.
	Name pulumi.StringPtrInput
	// The TCP port number for the HTTPS health check request.
	// The default value is 80.
	Port pulumi.IntPtrInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringPtrInput
	// The request path of the HTTPS health check request.
	// The default value is /.
	RequestPath pulumi.StringPtrInput
	// How long (in seconds) to wait before claiming failure.
	// The default value is 5 seconds.  It is invalid for timeoutSec to have
	// greater value than checkIntervalSec.
	TimeoutSec pulumi.IntPtrInput
	// A so-far healthy instance will be marked unhealthy after this many
	// consecutive failures. The default value is 2.
	UnhealthyThreshold pulumi.IntPtrInput
}

func (HttpsHealthCheckArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*httpsHealthCheckArgs)(nil)).Elem()
}
