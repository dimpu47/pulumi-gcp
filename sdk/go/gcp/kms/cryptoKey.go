// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package kms

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Allows creation of a Google Cloud Platform KMS CryptoKey. For more information see
// [the official documentation](https://cloud.google.com/kms/docs/object-hierarchy#cryptokey)
// and
// [API](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyRings.cryptoKeys).
// 
// A CryptoKey is an interface to key material which can be used to encrypt and decrypt data. A CryptoKey belongs to a
// Google Cloud KMS KeyRing.
// 
// > Note: CryptoKeys cannot be deleted from Google Cloud Platform. Destroying a
// Terraform-managed CryptoKey will remove it from state and delete all
// CryptoKeyVersions, rendering the key unusable, but **will not delete the
// resource on the server**. When Terraform destroys these keys, any data
// previously encrypted with these keys will be irrecoverable. For this reason, it
// is strongly recommended that you add lifecycle hooks to the resource to prevent
// accidental destruction.
type CryptoKey struct {
	s *pulumi.ResourceState
}

// NewCryptoKey registers a new resource with the given unique name, arguments, and options.
func NewCryptoKey(ctx *pulumi.Context,
	name string, args *CryptoKeyArgs, opts ...pulumi.ResourceOpt) (*CryptoKey, error) {
	if args == nil || args.KeyRing == nil {
		return nil, errors.New("missing required argument 'KeyRing'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["keyRing"] = nil
		inputs["name"] = nil
		inputs["rotationPeriod"] = nil
		inputs["versionTemplate"] = nil
	} else {
		inputs["keyRing"] = args.KeyRing
		inputs["name"] = args.Name
		inputs["rotationPeriod"] = args.RotationPeriod
		inputs["versionTemplate"] = args.VersionTemplate
	}
	inputs["selfLink"] = nil
	s, err := ctx.RegisterResource("gcp:kms/cryptoKey:CryptoKey", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &CryptoKey{s: s}, nil
}

// GetCryptoKey gets an existing CryptoKey resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCryptoKey(ctx *pulumi.Context,
	name string, id pulumi.ID, state *CryptoKeyState, opts ...pulumi.ResourceOpt) (*CryptoKey, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["keyRing"] = state.KeyRing
		inputs["name"] = state.Name
		inputs["rotationPeriod"] = state.RotationPeriod
		inputs["selfLink"] = state.SelfLink
		inputs["versionTemplate"] = state.VersionTemplate
	}
	s, err := ctx.ReadResource("gcp:kms/cryptoKey:CryptoKey", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &CryptoKey{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *CryptoKey) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *CryptoKey) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// The id of the Google Cloud Platform KeyRing to which the key shall belong.
func (r *CryptoKey) KeyRing() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["keyRing"])
}

// The CryptoKey's name.
// A CryptoKey’s name must be unique within a location and match the regular expression `[a-zA-Z0-9_-]{1,63}`
func (r *CryptoKey) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// Every time this period passes, generate a new CryptoKeyVersion and set it as
// the primary. The first rotation will take place after the specified period. The rotation period has the format
// of a decimal number with up to 9 fractional digits, followed by the letter s (seconds). It must be greater than
// a day (ie, 86400).
func (r *CryptoKey) RotationPeriod() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["rotationPeriod"])
}

// The self link of the created CryptoKey. Its format is `projects/{projectId}/locations/{location}/keyRings/{keyRingName}/cryptoKeys/{cryptoKeyName}`.
func (r *CryptoKey) SelfLink() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["selfLink"])
}

func (r *CryptoKey) VersionTemplate() *pulumi.Output {
	return r.s.State["versionTemplate"]
}

// Input properties used for looking up and filtering CryptoKey resources.
type CryptoKeyState struct {
	// The id of the Google Cloud Platform KeyRing to which the key shall belong.
	KeyRing interface{}
	// The CryptoKey's name.
	// A CryptoKey’s name must be unique within a location and match the regular expression `[a-zA-Z0-9_-]{1,63}`
	Name interface{}
	// Every time this period passes, generate a new CryptoKeyVersion and set it as
	// the primary. The first rotation will take place after the specified period. The rotation period has the format
	// of a decimal number with up to 9 fractional digits, followed by the letter s (seconds). It must be greater than
	// a day (ie, 86400).
	RotationPeriod interface{}
	// The self link of the created CryptoKey. Its format is `projects/{projectId}/locations/{location}/keyRings/{keyRingName}/cryptoKeys/{cryptoKeyName}`.
	SelfLink interface{}
	VersionTemplate interface{}
}

// The set of arguments for constructing a CryptoKey resource.
type CryptoKeyArgs struct {
	// The id of the Google Cloud Platform KeyRing to which the key shall belong.
	KeyRing interface{}
	// The CryptoKey's name.
	// A CryptoKey’s name must be unique within a location and match the regular expression `[a-zA-Z0-9_-]{1,63}`
	Name interface{}
	// Every time this period passes, generate a new CryptoKeyVersion and set it as
	// the primary. The first rotation will take place after the specified period. The rotation period has the format
	// of a decimal number with up to 9 fractional digits, followed by the letter s (seconds). It must be greater than
	// a day (ie, 86400).
	RotationPeriod interface{}
	VersionTemplate interface{}
}
