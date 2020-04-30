// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package healthcare

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A Hl7V2Store is a datastore inside a Healthcare dataset that conforms to the FHIR (https://www.hl7.org/hl7V2/STU3/)
// standard for Healthcare information exchange
//
// To get more information about Hl7V2Store, see:
//
// * [API documentation](https://cloud.google.com/healthcare/docs/reference/rest/v1/projects.locations.datasets.hl7V2Stores)
// * How-to Guides
//     * [Creating a HL7v2 Store](https://cloud.google.com/healthcare/docs/how-tos/hl7v2)
type Hl7Store struct {
	pulumi.CustomResourceState

	// Identifies the dataset addressed by this request. Must be in the format
	// 'projects/{project}/locations/{location}/datasets/{dataset}'
	Dataset pulumi.StringOutput `pulumi:"dataset"`
	// User-supplied key-value pairs used to organize HL7v2 stores.
	// Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must
	// conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
	// Label values are optional, must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128
	// bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63}
	// No more than 64 labels can be associated with a given store.
	// An object containing a list of "key": value pairs.
	// Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// The resource name for the Hl7V2Store.
	// ** Changing this property may recreate the Hl7v2 store (removing all data) **
	Name pulumi.StringOutput `pulumi:"name"`
	// A nested object resource  Structure is documented below.
	NotificationConfig Hl7StoreNotificationConfigPtrOutput `pulumi:"notificationConfig"`
	// A nested object resource  Structure is documented below.
	ParserConfig Hl7StoreParserConfigPtrOutput `pulumi:"parserConfig"`
	// The fully qualified name of this dataset
	SelfLink pulumi.StringOutput `pulumi:"selfLink"`
}

// NewHl7Store registers a new resource with the given unique name, arguments, and options.
func NewHl7Store(ctx *pulumi.Context,
	name string, args *Hl7StoreArgs, opts ...pulumi.ResourceOption) (*Hl7Store, error) {
	if args == nil || args.Dataset == nil {
		return nil, errors.New("missing required argument 'Dataset'")
	}
	if args == nil {
		args = &Hl7StoreArgs{}
	}
	var resource Hl7Store
	err := ctx.RegisterResource("gcp:healthcare/hl7Store:Hl7Store", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetHl7Store gets an existing Hl7Store resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetHl7Store(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *Hl7StoreState, opts ...pulumi.ResourceOption) (*Hl7Store, error) {
	var resource Hl7Store
	err := ctx.ReadResource("gcp:healthcare/hl7Store:Hl7Store", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Hl7Store resources.
type hl7StoreState struct {
	// Identifies the dataset addressed by this request. Must be in the format
	// 'projects/{project}/locations/{location}/datasets/{dataset}'
	Dataset *string `pulumi:"dataset"`
	// User-supplied key-value pairs used to organize HL7v2 stores.
	// Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must
	// conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
	// Label values are optional, must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128
	// bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63}
	// No more than 64 labels can be associated with a given store.
	// An object containing a list of "key": value pairs.
	// Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
	Labels map[string]string `pulumi:"labels"`
	// The resource name for the Hl7V2Store.
	// ** Changing this property may recreate the Hl7v2 store (removing all data) **
	Name *string `pulumi:"name"`
	// A nested object resource  Structure is documented below.
	NotificationConfig *Hl7StoreNotificationConfig `pulumi:"notificationConfig"`
	// A nested object resource  Structure is documented below.
	ParserConfig *Hl7StoreParserConfig `pulumi:"parserConfig"`
	// The fully qualified name of this dataset
	SelfLink *string `pulumi:"selfLink"`
}

type Hl7StoreState struct {
	// Identifies the dataset addressed by this request. Must be in the format
	// 'projects/{project}/locations/{location}/datasets/{dataset}'
	Dataset pulumi.StringPtrInput
	// User-supplied key-value pairs used to organize HL7v2 stores.
	// Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must
	// conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
	// Label values are optional, must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128
	// bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63}
	// No more than 64 labels can be associated with a given store.
	// An object containing a list of "key": value pairs.
	// Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
	Labels pulumi.StringMapInput
	// The resource name for the Hl7V2Store.
	// ** Changing this property may recreate the Hl7v2 store (removing all data) **
	Name pulumi.StringPtrInput
	// A nested object resource  Structure is documented below.
	NotificationConfig Hl7StoreNotificationConfigPtrInput
	// A nested object resource  Structure is documented below.
	ParserConfig Hl7StoreParserConfigPtrInput
	// The fully qualified name of this dataset
	SelfLink pulumi.StringPtrInput
}

func (Hl7StoreState) ElementType() reflect.Type {
	return reflect.TypeOf((*hl7StoreState)(nil)).Elem()
}

type hl7StoreArgs struct {
	// Identifies the dataset addressed by this request. Must be in the format
	// 'projects/{project}/locations/{location}/datasets/{dataset}'
	Dataset string `pulumi:"dataset"`
	// User-supplied key-value pairs used to organize HL7v2 stores.
	// Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must
	// conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
	// Label values are optional, must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128
	// bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63}
	// No more than 64 labels can be associated with a given store.
	// An object containing a list of "key": value pairs.
	// Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
	Labels map[string]string `pulumi:"labels"`
	// The resource name for the Hl7V2Store.
	// ** Changing this property may recreate the Hl7v2 store (removing all data) **
	Name *string `pulumi:"name"`
	// A nested object resource  Structure is documented below.
	NotificationConfig *Hl7StoreNotificationConfig `pulumi:"notificationConfig"`
	// A nested object resource  Structure is documented below.
	ParserConfig *Hl7StoreParserConfig `pulumi:"parserConfig"`
}

// The set of arguments for constructing a Hl7Store resource.
type Hl7StoreArgs struct {
	// Identifies the dataset addressed by this request. Must be in the format
	// 'projects/{project}/locations/{location}/datasets/{dataset}'
	Dataset pulumi.StringInput
	// User-supplied key-value pairs used to organize HL7v2 stores.
	// Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must
	// conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
	// Label values are optional, must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128
	// bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63}
	// No more than 64 labels can be associated with a given store.
	// An object containing a list of "key": value pairs.
	// Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
	Labels pulumi.StringMapInput
	// The resource name for the Hl7V2Store.
	// ** Changing this property may recreate the Hl7v2 store (removing all data) **
	Name pulumi.StringPtrInput
	// A nested object resource  Structure is documented below.
	NotificationConfig Hl7StoreNotificationConfigPtrInput
	// A nested object resource  Structure is documented below.
	ParserConfig Hl7StoreParserConfigPtrInput
}

func (Hl7StoreArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*hl7StoreArgs)(nil)).Elem()
}
