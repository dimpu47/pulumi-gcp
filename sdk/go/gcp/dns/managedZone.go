// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package dns

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a zone within Google Cloud DNS. For more information see [the official documentation](https://cloud.google.com/dns/zones/) and
// [API](https://cloud.google.com/dns/api/v1/managedZones).
type ManagedZone struct {
	s *pulumi.ResourceState
}

// NewManagedZone registers a new resource with the given unique name, arguments, and options.
func NewManagedZone(ctx *pulumi.Context,
	name string, args *ManagedZoneArgs, opts ...pulumi.ResourceOpt) (*ManagedZone, error) {
	if args == nil || args.DnsName == nil {
		return nil, errors.New("missing required argument 'DnsName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["description"] = nil
		inputs["dnsName"] = nil
		inputs["name"] = nil
		inputs["project"] = nil
	} else {
		inputs["description"] = args.Description
		inputs["dnsName"] = args.DnsName
		inputs["name"] = args.Name
		inputs["project"] = args.Project
	}
	inputs["nameServers"] = nil
	s, err := ctx.RegisterResource("gcp:dns/managedZone:ManagedZone", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ManagedZone{s: s}, nil
}

// GetManagedZone gets an existing ManagedZone resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetManagedZone(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ManagedZoneState, opts ...pulumi.ResourceOpt) (*ManagedZone, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["description"] = state.Description
		inputs["dnsName"] = state.DnsName
		inputs["name"] = state.Name
		inputs["nameServers"] = state.NameServers
		inputs["project"] = state.Project
	}
	s, err := ctx.ReadResource("gcp:dns/managedZone:ManagedZone", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ManagedZone{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *ManagedZone) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *ManagedZone) ID() *pulumi.IDOutput {
	return r.s.ID
}

// A textual description field. Defaults to 'Managed by Terraform'.
func (r *ManagedZone) Description() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["description"])
}

// The fully qualified DNS name of this zone, e.g. `terraform.io.`.
func (r *ManagedZone) DnsName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["dnsName"])
}

// A unique name for the resource, required by GCE.
// Changing this forces a new resource to be created.
func (r *ManagedZone) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The list of nameservers that will be authoritative for this
// domain. Use NS records to redirect from your DNS provider to these names,
// thus making Google Cloud DNS authoritative for this zone.
func (r *ManagedZone) NameServers() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["nameServers"])
}

// The ID of the project in which the resource belongs. If it
// is not provided, the provider project is used.
func (r *ManagedZone) Project() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["project"])
}

// Input properties used for looking up and filtering ManagedZone resources.
type ManagedZoneState struct {
	// A textual description field. Defaults to 'Managed by Terraform'.
	Description interface{}
	// The fully qualified DNS name of this zone, e.g. `terraform.io.`.
	DnsName interface{}
	// A unique name for the resource, required by GCE.
	// Changing this forces a new resource to be created.
	Name interface{}
	// The list of nameservers that will be authoritative for this
	// domain. Use NS records to redirect from your DNS provider to these names,
	// thus making Google Cloud DNS authoritative for this zone.
	NameServers interface{}
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
}

// The set of arguments for constructing a ManagedZone resource.
type ManagedZoneArgs struct {
	// A textual description field. Defaults to 'Managed by Terraform'.
	Description interface{}
	// The fully qualified DNS name of this zone, e.g. `terraform.io.`.
	DnsName interface{}
	// A unique name for the resource, required by GCE.
	// Changing this forces a new resource to be created.
	Name interface{}
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
}
