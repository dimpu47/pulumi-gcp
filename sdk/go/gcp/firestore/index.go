// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package firestore

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

type Index struct {
	pulumi.CustomResourceState

	// The collection being indexed.
	Collection pulumi.StringOutput `pulumi:"collection"`
	// The Firestore database id. Defaults to '"(default)"'.
	Database pulumi.StringPtrOutput `pulumi:"database"`
	// The fields supported by this index. The last field entry is always for the field path '__name__'. If, on creation,
	// '__name__' was not specified as the last field, it will be added automatically with the same direction as that of the
	// last field defined. If the final field in a composite index is not directional, the '__name__' will be ordered
	// '"ASCENDING"' (unless explicitly specified otherwise).
	Fields IndexFieldArrayOutput `pulumi:"fields"`
	// A server defined name for this index. Format:
	// 'projects/{{project}}/databases/{{database}}/collectionGroups/{{collection}}/indexes/{{server_generated_id}}'
	Name pulumi.StringOutput `pulumi:"name"`
	Project pulumi.StringOutput `pulumi:"project"`
	// The scope at which a query is run. One of '"COLLECTION"' or '"COLLECTION_GROUP"'. Defaults to '"COLLECTION"'.
	QueryScope pulumi.StringPtrOutput `pulumi:"queryScope"`
}

// NewIndex registers a new resource with the given unique name, arguments, and options.
func NewIndex(ctx *pulumi.Context,
	name string, args *IndexArgs, opts ...pulumi.ResourceOption) (*Index, error) {
	if args == nil || args.Collection == nil {
		return nil, errors.New("missing required argument 'Collection'")
	}
	if args == nil || args.Fields == nil {
		return nil, errors.New("missing required argument 'Fields'")
	}
	if args == nil {
		args = &IndexArgs{}
	}
	var resource Index
	err := ctx.RegisterResource("gcp:firestore/index:Index", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIndex gets an existing Index resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIndex(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IndexState, opts ...pulumi.ResourceOption) (*Index, error) {
	var resource Index
	err := ctx.ReadResource("gcp:firestore/index:Index", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Index resources.
type indexState struct {
	// The collection being indexed.
	Collection *string `pulumi:"collection"`
	// The Firestore database id. Defaults to '"(default)"'.
	Database *string `pulumi:"database"`
	// The fields supported by this index. The last field entry is always for the field path '__name__'. If, on creation,
	// '__name__' was not specified as the last field, it will be added automatically with the same direction as that of the
	// last field defined. If the final field in a composite index is not directional, the '__name__' will be ordered
	// '"ASCENDING"' (unless explicitly specified otherwise).
	Fields []IndexField `pulumi:"fields"`
	// A server defined name for this index. Format:
	// 'projects/{{project}}/databases/{{database}}/collectionGroups/{{collection}}/indexes/{{server_generated_id}}'
	Name *string `pulumi:"name"`
	Project *string `pulumi:"project"`
	// The scope at which a query is run. One of '"COLLECTION"' or '"COLLECTION_GROUP"'. Defaults to '"COLLECTION"'.
	QueryScope *string `pulumi:"queryScope"`
}

type IndexState struct {
	// The collection being indexed.
	Collection pulumi.StringPtrInput
	// The Firestore database id. Defaults to '"(default)"'.
	Database pulumi.StringPtrInput
	// The fields supported by this index. The last field entry is always for the field path '__name__'. If, on creation,
	// '__name__' was not specified as the last field, it will be added automatically with the same direction as that of the
	// last field defined. If the final field in a composite index is not directional, the '__name__' will be ordered
	// '"ASCENDING"' (unless explicitly specified otherwise).
	Fields IndexFieldArrayInput
	// A server defined name for this index. Format:
	// 'projects/{{project}}/databases/{{database}}/collectionGroups/{{collection}}/indexes/{{server_generated_id}}'
	Name pulumi.StringPtrInput
	Project pulumi.StringPtrInput
	// The scope at which a query is run. One of '"COLLECTION"' or '"COLLECTION_GROUP"'. Defaults to '"COLLECTION"'.
	QueryScope pulumi.StringPtrInput
}

func (IndexState) ElementType() reflect.Type {
	return reflect.TypeOf((*indexState)(nil)).Elem()
}

type indexArgs struct {
	// The collection being indexed.
	Collection string `pulumi:"collection"`
	// The Firestore database id. Defaults to '"(default)"'.
	Database *string `pulumi:"database"`
	// The fields supported by this index. The last field entry is always for the field path '__name__'. If, on creation,
	// '__name__' was not specified as the last field, it will be added automatically with the same direction as that of the
	// last field defined. If the final field in a composite index is not directional, the '__name__' will be ordered
	// '"ASCENDING"' (unless explicitly specified otherwise).
	Fields []IndexField `pulumi:"fields"`
	Project *string `pulumi:"project"`
	// The scope at which a query is run. One of '"COLLECTION"' or '"COLLECTION_GROUP"'. Defaults to '"COLLECTION"'.
	QueryScope *string `pulumi:"queryScope"`
}

// The set of arguments for constructing a Index resource.
type IndexArgs struct {
	// The collection being indexed.
	Collection pulumi.StringInput
	// The Firestore database id. Defaults to '"(default)"'.
	Database pulumi.StringPtrInput
	// The fields supported by this index. The last field entry is always for the field path '__name__'. If, on creation,
	// '__name__' was not specified as the last field, it will be added automatically with the same direction as that of the
	// last field defined. If the final field in a composite index is not directional, the '__name__' will be ordered
	// '"ASCENDING"' (unless explicitly specified otherwise).
	Fields IndexFieldArrayInput
	Project pulumi.StringPtrInput
	// The scope at which a query is run. One of '"COLLECTION"' or '"COLLECTION_GROUP"'. Defaults to '"COLLECTION"'.
	QueryScope pulumi.StringPtrInput
}

func (IndexArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*indexArgs)(nil)).Elem()
}

