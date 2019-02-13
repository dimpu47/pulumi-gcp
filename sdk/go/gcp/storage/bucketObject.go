// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package storage

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Creates a new object inside an existing bucket in Google cloud storage service (GCS). 
// [ACLs](https://cloud.google.com/storage/docs/access-control/lists) can be applied using the `google_storage_object_acl` resource.
//  For more information see 
// [the official documentation](https://cloud.google.com/storage/docs/key-terms#objects) 
// and 
// [API](https://cloud.google.com/storage/docs/json_api/v1/objects).
type BucketObject struct {
	s *pulumi.ResourceState
}

// NewBucketObject registers a new resource with the given unique name, arguments, and options.
func NewBucketObject(ctx *pulumi.Context,
	name string, args *BucketObjectArgs, opts ...pulumi.ResourceOpt) (*BucketObject, error) {
	if args == nil || args.Bucket == nil {
		return nil, errors.New("missing required argument 'Bucket'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["bucket"] = nil
		inputs["cacheControl"] = nil
		inputs["content"] = nil
		inputs["contentDisposition"] = nil
		inputs["contentEncoding"] = nil
		inputs["contentLanguage"] = nil
		inputs["contentType"] = nil
		inputs["detectMd5hash"] = nil
		inputs["name"] = nil
		inputs["source"] = nil
		inputs["storageClass"] = nil
	} else {
		inputs["bucket"] = args.Bucket
		inputs["cacheControl"] = args.CacheControl
		inputs["content"] = args.Content
		inputs["contentDisposition"] = args.ContentDisposition
		inputs["contentEncoding"] = args.ContentEncoding
		inputs["contentLanguage"] = args.ContentLanguage
		inputs["contentType"] = args.ContentType
		inputs["detectMd5hash"] = args.DetectMd5hash
		inputs["name"] = args.Name
		inputs["source"] = args.Source
		inputs["storageClass"] = args.StorageClass
	}
	inputs["crc32c"] = nil
	inputs["md5hash"] = nil
	inputs["outputName"] = nil
	inputs["selfLink"] = nil
	s, err := ctx.RegisterResource("gcp:storage/bucketObject:BucketObject", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &BucketObject{s: s}, nil
}

// GetBucketObject gets an existing BucketObject resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBucketObject(ctx *pulumi.Context,
	name string, id pulumi.ID, state *BucketObjectState, opts ...pulumi.ResourceOpt) (*BucketObject, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["bucket"] = state.Bucket
		inputs["cacheControl"] = state.CacheControl
		inputs["content"] = state.Content
		inputs["contentDisposition"] = state.ContentDisposition
		inputs["contentEncoding"] = state.ContentEncoding
		inputs["contentLanguage"] = state.ContentLanguage
		inputs["contentType"] = state.ContentType
		inputs["crc32c"] = state.Crc32c
		inputs["detectMd5hash"] = state.DetectMd5hash
		inputs["md5hash"] = state.Md5hash
		inputs["name"] = state.Name
		inputs["outputName"] = state.OutputName
		inputs["selfLink"] = state.SelfLink
		inputs["source"] = state.Source
		inputs["storageClass"] = state.StorageClass
	}
	s, err := ctx.ReadResource("gcp:storage/bucketObject:BucketObject", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &BucketObject{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *BucketObject) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *BucketObject) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// The name of the containing bucket.
func (r *BucketObject) Bucket() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["bucket"])
}

// [Cache-Control](https://tools.ietf.org/html/rfc7234#section-5.2)
// directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
func (r *BucketObject) CacheControl() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["cacheControl"])
}

// Data as `string` to be uploaded. Must be defined if
// `source` is not.
func (r *BucketObject) Content() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["content"])
}

// [Content-Disposition](https://tools.ietf.org/html/rfc6266) of the object data.
func (r *BucketObject) ContentDisposition() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["contentDisposition"])
}

// [Content-Encoding](https://tools.ietf.org/html/rfc7231#section-3.1.2.2) of the object data.
func (r *BucketObject) ContentEncoding() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["contentEncoding"])
}

// [Content-Language](https://tools.ietf.org/html/rfc7231#section-3.1.3.2) of the object data.
func (r *BucketObject) ContentLanguage() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["contentLanguage"])
}

// [Content-Type](https://tools.ietf.org/html/rfc7231#section-3.1.1.5) of the object data. Defaults to "application/octet-stream" or "text/plain; charset=utf-8".
func (r *BucketObject) ContentType() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["contentType"])
}

// (Computed) Base 64 CRC32 hash of the uploaded data.
func (r *BucketObject) Crc32c() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["crc32c"])
}

func (r *BucketObject) DetectMd5hash() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["detectMd5hash"])
}

// (Computed) Base 64 MD5 hash of the uploaded data.
func (r *BucketObject) Md5hash() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["md5hash"])
}

// The name of the object.
func (r *BucketObject) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

func (r *BucketObject) OutputName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["outputName"])
}

func (r *BucketObject) SelfLink() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["selfLink"])
}

// A path to the data you want to upload. Must be defined
// if `content` is not.
func (r *BucketObject) Source() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["source"])
}

// The [StorageClass](https://cloud.google.com/storage/docs/storage-classes) of the new bucket object.
// Supported values include: `MULTI_REGIONAL`, `REGIONAL`, `NEARLINE`, `COLDLINE`. If not provided, this defaults to the bucket's default
// storage class or to a [standard](https://cloud.google.com/storage/docs/storage-classes#standard) class.
func (r *BucketObject) StorageClass() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["storageClass"])
}

// Input properties used for looking up and filtering BucketObject resources.
type BucketObjectState struct {
	// The name of the containing bucket.
	Bucket interface{}
	// [Cache-Control](https://tools.ietf.org/html/rfc7234#section-5.2)
	// directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
	CacheControl interface{}
	// Data as `string` to be uploaded. Must be defined if
	// `source` is not.
	Content interface{}
	// [Content-Disposition](https://tools.ietf.org/html/rfc6266) of the object data.
	ContentDisposition interface{}
	// [Content-Encoding](https://tools.ietf.org/html/rfc7231#section-3.1.2.2) of the object data.
	ContentEncoding interface{}
	// [Content-Language](https://tools.ietf.org/html/rfc7231#section-3.1.3.2) of the object data.
	ContentLanguage interface{}
	// [Content-Type](https://tools.ietf.org/html/rfc7231#section-3.1.1.5) of the object data. Defaults to "application/octet-stream" or "text/plain; charset=utf-8".
	ContentType interface{}
	// (Computed) Base 64 CRC32 hash of the uploaded data.
	Crc32c interface{}
	DetectMd5hash interface{}
	// (Computed) Base 64 MD5 hash of the uploaded data.
	Md5hash interface{}
	// The name of the object.
	Name interface{}
	OutputName interface{}
	SelfLink interface{}
	// A path to the data you want to upload. Must be defined
	// if `content` is not.
	Source interface{}
	// The [StorageClass](https://cloud.google.com/storage/docs/storage-classes) of the new bucket object.
	// Supported values include: `MULTI_REGIONAL`, `REGIONAL`, `NEARLINE`, `COLDLINE`. If not provided, this defaults to the bucket's default
	// storage class or to a [standard](https://cloud.google.com/storage/docs/storage-classes#standard) class.
	StorageClass interface{}
}

// The set of arguments for constructing a BucketObject resource.
type BucketObjectArgs struct {
	// The name of the containing bucket.
	Bucket interface{}
	// [Cache-Control](https://tools.ietf.org/html/rfc7234#section-5.2)
	// directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
	CacheControl interface{}
	// Data as `string` to be uploaded. Must be defined if
	// `source` is not.
	Content interface{}
	// [Content-Disposition](https://tools.ietf.org/html/rfc6266) of the object data.
	ContentDisposition interface{}
	// [Content-Encoding](https://tools.ietf.org/html/rfc7231#section-3.1.2.2) of the object data.
	ContentEncoding interface{}
	// [Content-Language](https://tools.ietf.org/html/rfc7231#section-3.1.3.2) of the object data.
	ContentLanguage interface{}
	// [Content-Type](https://tools.ietf.org/html/rfc7231#section-3.1.1.5) of the object data. Defaults to "application/octet-stream" or "text/plain; charset=utf-8".
	ContentType interface{}
	DetectMd5hash interface{}
	// The name of the object.
	Name interface{}
	// A path to the data you want to upload. Must be defined
	// if `content` is not.
	Source interface{}
	// The [StorageClass](https://cloud.google.com/storage/docs/storage-classes) of the new bucket object.
	// Supported values include: `MULTI_REGIONAL`, `REGIONAL`, `NEARLINE`, `COLDLINE`. If not provided, this defaults to the bucket's default
	// storage class or to a [standard](https://cloud.google.com/storage/docs/storage-classes#standard) class.
	StorageClass interface{}
}
