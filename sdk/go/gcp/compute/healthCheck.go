// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a health check within GCE. This is used to monitor instances
// behind load balancers. Timeouts or HTTP errors cause the instance to be
// removed from the pool. For more information, see [the official
// documentation](https://cloud.google.com/compute/docs/load-balancing/health-checks)
// and
// [API](https://cloud.google.com/compute/docs/reference/latest/healthChecks).
type HealthCheck struct {
	s *pulumi.ResourceState
}

// NewHealthCheck registers a new resource with the given unique name, arguments, and options.
func NewHealthCheck(ctx *pulumi.Context,
	name string, args *HealthCheckArgs, opts ...pulumi.ResourceOpt) (*HealthCheck, error) {
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["checkIntervalSec"] = nil
		inputs["description"] = nil
		inputs["healthyThreshold"] = nil
		inputs["httpHealthCheck"] = nil
		inputs["httpsHealthCheck"] = nil
		inputs["name"] = nil
		inputs["project"] = nil
		inputs["sslHealthCheck"] = nil
		inputs["tcpHealthCheck"] = nil
		inputs["timeoutSec"] = nil
		inputs["unhealthyThreshold"] = nil
	} else {
		inputs["checkIntervalSec"] = args.CheckIntervalSec
		inputs["description"] = args.Description
		inputs["healthyThreshold"] = args.HealthyThreshold
		inputs["httpHealthCheck"] = args.HttpHealthCheck
		inputs["httpsHealthCheck"] = args.HttpsHealthCheck
		inputs["name"] = args.Name
		inputs["project"] = args.Project
		inputs["sslHealthCheck"] = args.SslHealthCheck
		inputs["tcpHealthCheck"] = args.TcpHealthCheck
		inputs["timeoutSec"] = args.TimeoutSec
		inputs["unhealthyThreshold"] = args.UnhealthyThreshold
	}
	inputs["selfLink"] = nil
	s, err := ctx.RegisterResource("gcp:compute/healthCheck:HealthCheck", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &HealthCheck{s: s}, nil
}

// GetHealthCheck gets an existing HealthCheck resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetHealthCheck(ctx *pulumi.Context,
	name string, id pulumi.ID, state *HealthCheckState, opts ...pulumi.ResourceOpt) (*HealthCheck, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["checkIntervalSec"] = state.CheckIntervalSec
		inputs["description"] = state.Description
		inputs["healthyThreshold"] = state.HealthyThreshold
		inputs["httpHealthCheck"] = state.HttpHealthCheck
		inputs["httpsHealthCheck"] = state.HttpsHealthCheck
		inputs["name"] = state.Name
		inputs["project"] = state.Project
		inputs["selfLink"] = state.SelfLink
		inputs["sslHealthCheck"] = state.SslHealthCheck
		inputs["tcpHealthCheck"] = state.TcpHealthCheck
		inputs["timeoutSec"] = state.TimeoutSec
		inputs["unhealthyThreshold"] = state.UnhealthyThreshold
	}
	s, err := ctx.ReadResource("gcp:compute/healthCheck:HealthCheck", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &HealthCheck{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *HealthCheck) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *HealthCheck) ID() *pulumi.IDOutput {
	return r.s.ID
}

// The number of seconds between each poll of
// the instance instance (default 5).
func (r *HealthCheck) CheckIntervalSec() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["checkIntervalSec"])
}

// Textual description field.
func (r *HealthCheck) Description() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["description"])
}

// Consecutive successes required (default 2).
func (r *HealthCheck) HealthyThreshold() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["healthyThreshold"])
}

// An HTTP Health Check. Only one kind of Health Check can be added.
// Structure is documented below.
func (r *HealthCheck) HttpHealthCheck() *pulumi.Output {
	return r.s.State["httpHealthCheck"]
}

// An HTTPS Health Check. Only one kind of Health Check can be added.
// Structure is documented below.
func (r *HealthCheck) HttpsHealthCheck() *pulumi.Output {
	return r.s.State["httpsHealthCheck"]
}

// A unique name for the resource, required by GCE.
// Changing this forces a new resource to be created.
func (r *HealthCheck) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The project in which the resource belongs. If it
// is not provided, the provider project is used.
func (r *HealthCheck) Project() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["project"])
}

// The URI of the created resource.
func (r *HealthCheck) SelfLink() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["selfLink"])
}

// An SSL Health Check. Only one kind of Health Check can be added.
// Structure is documented below.
func (r *HealthCheck) SslHealthCheck() *pulumi.Output {
	return r.s.State["sslHealthCheck"]
}

// A TCP Health Check. Only one kind of Health Check can be added.
// Structure is documented below.
func (r *HealthCheck) TcpHealthCheck() *pulumi.Output {
	return r.s.State["tcpHealthCheck"]
}

// The number of seconds to wait before declaring
// failure (default 5).
func (r *HealthCheck) TimeoutSec() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["timeoutSec"])
}

// Consecutive failures required (default 2).
func (r *HealthCheck) UnhealthyThreshold() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["unhealthyThreshold"])
}

// Input properties used for looking up and filtering HealthCheck resources.
type HealthCheckState struct {
	// The number of seconds between each poll of
	// the instance instance (default 5).
	CheckIntervalSec interface{}
	// Textual description field.
	Description interface{}
	// Consecutive successes required (default 2).
	HealthyThreshold interface{}
	// An HTTP Health Check. Only one kind of Health Check can be added.
	// Structure is documented below.
	HttpHealthCheck interface{}
	// An HTTPS Health Check. Only one kind of Health Check can be added.
	// Structure is documented below.
	HttpsHealthCheck interface{}
	// A unique name for the resource, required by GCE.
	// Changing this forces a new resource to be created.
	Name interface{}
	// The project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
	// The URI of the created resource.
	SelfLink interface{}
	// An SSL Health Check. Only one kind of Health Check can be added.
	// Structure is documented below.
	SslHealthCheck interface{}
	// A TCP Health Check. Only one kind of Health Check can be added.
	// Structure is documented below.
	TcpHealthCheck interface{}
	// The number of seconds to wait before declaring
	// failure (default 5).
	TimeoutSec interface{}
	// Consecutive failures required (default 2).
	UnhealthyThreshold interface{}
}

// The set of arguments for constructing a HealthCheck resource.
type HealthCheckArgs struct {
	// The number of seconds between each poll of
	// the instance instance (default 5).
	CheckIntervalSec interface{}
	// Textual description field.
	Description interface{}
	// Consecutive successes required (default 2).
	HealthyThreshold interface{}
	// An HTTP Health Check. Only one kind of Health Check can be added.
	// Structure is documented below.
	HttpHealthCheck interface{}
	// An HTTPS Health Check. Only one kind of Health Check can be added.
	// Structure is documented below.
	HttpsHealthCheck interface{}
	// A unique name for the resource, required by GCE.
	// Changing this forces a new resource to be created.
	Name interface{}
	// The project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
	// An SSL Health Check. Only one kind of Health Check can be added.
	// Structure is documented below.
	SslHealthCheck interface{}
	// A TCP Health Check. Only one kind of Health Check can be added.
	// Structure is documented below.
	TcpHealthCheck interface{}
	// The number of seconds to wait before declaring
	// failure (default 5).
	TimeoutSec interface{}
	// Consecutive failures required (default 2).
	UnhealthyThreshold interface{}
}
