// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package cloudrun

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Resource to hold the state and status of a user's domain mapping.
//
// To get more information about DomainMapping, see:
//
// * [API documentation](https://cloud.google.com/run/docs/reference/rest/v1alpha1/projects.locations.domainmappings)
// * How-to Guides
//     * [Official Documentation](https://cloud.google.com/run/docs/mapping-custom-domains)
//
// ## Example Usage
type DomainMapping struct {
	pulumi.CustomResourceState

	// The location of the cloud run instance. eg us-central1
	Location pulumi.StringOutput `pulumi:"location"`
	// Metadata associated with this DomainMapping.  Structure is documented below.
	Metadata DomainMappingMetadataOutput `pulumi:"metadata"`
	// Name should be a verified domain
	Name pulumi.StringOutput `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringOutput `pulumi:"project"`
	// The spec for this DomainMapping.  Structure is documented below.
	Spec DomainMappingSpecOutput `pulumi:"spec"`
	// The current status of the DomainMapping.
	Status DomainMappingStatusOutput `pulumi:"status"`
}

// NewDomainMapping registers a new resource with the given unique name, arguments, and options.
func NewDomainMapping(ctx *pulumi.Context,
	name string, args *DomainMappingArgs, opts ...pulumi.ResourceOption) (*DomainMapping, error) {
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.Metadata == nil {
		return nil, errors.New("missing required argument 'Metadata'")
	}
	if args == nil || args.Spec == nil {
		return nil, errors.New("missing required argument 'Spec'")
	}
	if args == nil {
		args = &DomainMappingArgs{}
	}
	var resource DomainMapping
	err := ctx.RegisterResource("gcp:cloudrun/domainMapping:DomainMapping", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDomainMapping gets an existing DomainMapping resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDomainMapping(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DomainMappingState, opts ...pulumi.ResourceOption) (*DomainMapping, error) {
	var resource DomainMapping
	err := ctx.ReadResource("gcp:cloudrun/domainMapping:DomainMapping", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DomainMapping resources.
type domainMappingState struct {
	// The location of the cloud run instance. eg us-central1
	Location *string `pulumi:"location"`
	// Metadata associated with this DomainMapping.  Structure is documented below.
	Metadata *DomainMappingMetadata `pulumi:"metadata"`
	// Name should be a verified domain
	Name *string `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project *string `pulumi:"project"`
	// The spec for this DomainMapping.  Structure is documented below.
	Spec *DomainMappingSpec `pulumi:"spec"`
	// The current status of the DomainMapping.
	Status *DomainMappingStatus `pulumi:"status"`
}

type DomainMappingState struct {
	// The location of the cloud run instance. eg us-central1
	Location pulumi.StringPtrInput
	// Metadata associated with this DomainMapping.  Structure is documented below.
	Metadata DomainMappingMetadataPtrInput
	// Name should be a verified domain
	Name pulumi.StringPtrInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringPtrInput
	// The spec for this DomainMapping.  Structure is documented below.
	Spec DomainMappingSpecPtrInput
	// The current status of the DomainMapping.
	Status DomainMappingStatusPtrInput
}

func (DomainMappingState) ElementType() reflect.Type {
	return reflect.TypeOf((*domainMappingState)(nil)).Elem()
}

type domainMappingArgs struct {
	// The location of the cloud run instance. eg us-central1
	Location string `pulumi:"location"`
	// Metadata associated with this DomainMapping.  Structure is documented below.
	Metadata DomainMappingMetadata `pulumi:"metadata"`
	// Name should be a verified domain
	Name *string `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project *string `pulumi:"project"`
	// The spec for this DomainMapping.  Structure is documented below.
	Spec DomainMappingSpec `pulumi:"spec"`
}

// The set of arguments for constructing a DomainMapping resource.
type DomainMappingArgs struct {
	// The location of the cloud run instance. eg us-central1
	Location pulumi.StringInput
	// Metadata associated with this DomainMapping.  Structure is documented below.
	Metadata DomainMappingMetadataInput
	// Name should be a verified domain
	Name pulumi.StringPtrInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringPtrInput
	// The spec for this DomainMapping.  Structure is documented below.
	Spec DomainMappingSpecInput
}

func (DomainMappingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*domainMappingArgs)(nil)).Elem()
}
