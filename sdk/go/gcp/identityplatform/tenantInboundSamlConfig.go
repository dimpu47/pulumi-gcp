// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package identityplatform

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Inbound SAML configuration for a Identity Toolkit tenant.
//
// You must enable the
// [Google Identity Platform](https://console.cloud.google.com/marketplace/details/google-cloud-platform/customer-identity) in
// the marketplace prior to using this resource.
type TenantInboundSamlConfig struct {
	pulumi.CustomResourceState

	// Human friendly display name.
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// If this config allows users to sign in with the provider.
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
	// SAML IdP configuration when the project acts as the relying party  Structure is documented below.
	IdpConfig TenantInboundSamlConfigIdpConfigOutput `pulumi:"idpConfig"`
	// The name of the InboundSamlConfig resource. Must start with 'saml.' and can only have alphanumeric characters,
	// hyphens, underscores or periods. The part after 'saml.' must also start with a lowercase letter, end with an
	// alphanumeric character, and have at least 2 characters.
	Name pulumi.StringOutput `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringOutput `pulumi:"project"`
	// SAML SP (Service Provider) configuration when the project acts as the relying party to receive
	// and accept an authentication assertion issued by a SAML identity provider.  Structure is documented below.
	SpConfig TenantInboundSamlConfigSpConfigOutput `pulumi:"spConfig"`
	// The name of the tenant where this inbound SAML config resource exists
	Tenant pulumi.StringOutput `pulumi:"tenant"`
}

// NewTenantInboundSamlConfig registers a new resource with the given unique name, arguments, and options.
func NewTenantInboundSamlConfig(ctx *pulumi.Context,
	name string, args *TenantInboundSamlConfigArgs, opts ...pulumi.ResourceOption) (*TenantInboundSamlConfig, error) {
	if args == nil || args.DisplayName == nil {
		return nil, errors.New("missing required argument 'DisplayName'")
	}
	if args == nil || args.IdpConfig == nil {
		return nil, errors.New("missing required argument 'IdpConfig'")
	}
	if args == nil || args.SpConfig == nil {
		return nil, errors.New("missing required argument 'SpConfig'")
	}
	if args == nil || args.Tenant == nil {
		return nil, errors.New("missing required argument 'Tenant'")
	}
	if args == nil {
		args = &TenantInboundSamlConfigArgs{}
	}
	var resource TenantInboundSamlConfig
	err := ctx.RegisterResource("gcp:identityplatform/tenantInboundSamlConfig:TenantInboundSamlConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTenantInboundSamlConfig gets an existing TenantInboundSamlConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTenantInboundSamlConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TenantInboundSamlConfigState, opts ...pulumi.ResourceOption) (*TenantInboundSamlConfig, error) {
	var resource TenantInboundSamlConfig
	err := ctx.ReadResource("gcp:identityplatform/tenantInboundSamlConfig:TenantInboundSamlConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TenantInboundSamlConfig resources.
type tenantInboundSamlConfigState struct {
	// Human friendly display name.
	DisplayName *string `pulumi:"displayName"`
	// If this config allows users to sign in with the provider.
	Enabled *bool `pulumi:"enabled"`
	// SAML IdP configuration when the project acts as the relying party  Structure is documented below.
	IdpConfig *TenantInboundSamlConfigIdpConfig `pulumi:"idpConfig"`
	// The name of the InboundSamlConfig resource. Must start with 'saml.' and can only have alphanumeric characters,
	// hyphens, underscores or periods. The part after 'saml.' must also start with a lowercase letter, end with an
	// alphanumeric character, and have at least 2 characters.
	Name *string `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project *string `pulumi:"project"`
	// SAML SP (Service Provider) configuration when the project acts as the relying party to receive
	// and accept an authentication assertion issued by a SAML identity provider.  Structure is documented below.
	SpConfig *TenantInboundSamlConfigSpConfig `pulumi:"spConfig"`
	// The name of the tenant where this inbound SAML config resource exists
	Tenant *string `pulumi:"tenant"`
}

type TenantInboundSamlConfigState struct {
	// Human friendly display name.
	DisplayName pulumi.StringPtrInput
	// If this config allows users to sign in with the provider.
	Enabled pulumi.BoolPtrInput
	// SAML IdP configuration when the project acts as the relying party  Structure is documented below.
	IdpConfig TenantInboundSamlConfigIdpConfigPtrInput
	// The name of the InboundSamlConfig resource. Must start with 'saml.' and can only have alphanumeric characters,
	// hyphens, underscores or periods. The part after 'saml.' must also start with a lowercase letter, end with an
	// alphanumeric character, and have at least 2 characters.
	Name pulumi.StringPtrInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringPtrInput
	// SAML SP (Service Provider) configuration when the project acts as the relying party to receive
	// and accept an authentication assertion issued by a SAML identity provider.  Structure is documented below.
	SpConfig TenantInboundSamlConfigSpConfigPtrInput
	// The name of the tenant where this inbound SAML config resource exists
	Tenant pulumi.StringPtrInput
}

func (TenantInboundSamlConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*tenantInboundSamlConfigState)(nil)).Elem()
}

type tenantInboundSamlConfigArgs struct {
	// Human friendly display name.
	DisplayName string `pulumi:"displayName"`
	// If this config allows users to sign in with the provider.
	Enabled *bool `pulumi:"enabled"`
	// SAML IdP configuration when the project acts as the relying party  Structure is documented below.
	IdpConfig TenantInboundSamlConfigIdpConfig `pulumi:"idpConfig"`
	// The name of the InboundSamlConfig resource. Must start with 'saml.' and can only have alphanumeric characters,
	// hyphens, underscores or periods. The part after 'saml.' must also start with a lowercase letter, end with an
	// alphanumeric character, and have at least 2 characters.
	Name *string `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project *string `pulumi:"project"`
	// SAML SP (Service Provider) configuration when the project acts as the relying party to receive
	// and accept an authentication assertion issued by a SAML identity provider.  Structure is documented below.
	SpConfig TenantInboundSamlConfigSpConfig `pulumi:"spConfig"`
	// The name of the tenant where this inbound SAML config resource exists
	Tenant string `pulumi:"tenant"`
}

// The set of arguments for constructing a TenantInboundSamlConfig resource.
type TenantInboundSamlConfigArgs struct {
	// Human friendly display name.
	DisplayName pulumi.StringInput
	// If this config allows users to sign in with the provider.
	Enabled pulumi.BoolPtrInput
	// SAML IdP configuration when the project acts as the relying party  Structure is documented below.
	IdpConfig TenantInboundSamlConfigIdpConfigInput
	// The name of the InboundSamlConfig resource. Must start with 'saml.' and can only have alphanumeric characters,
	// hyphens, underscores or periods. The part after 'saml.' must also start with a lowercase letter, end with an
	// alphanumeric character, and have at least 2 characters.
	Name pulumi.StringPtrInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringPtrInput
	// SAML SP (Service Provider) configuration when the project acts as the relying party to receive
	// and accept an authentication assertion issued by a SAML identity provider.  Structure is documented below.
	SpConfig TenantInboundSamlConfigSpConfigInput
	// The name of the tenant where this inbound SAML config resource exists
	Tenant pulumi.StringInput
}

func (TenantInboundSamlConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*tenantInboundSamlConfigArgs)(nil)).Elem()
}
