// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Configurations options for authenticating with a the standard set of Identity Toolkit-trusted IDPs.
 *
 * You must enable the
 * [Google Identity Platform](https://console.cloud.google.com/marketplace/details/google-cloud-platform/customer-identity) in
 * the marketplace prior to using this resource.
 *
 * ## Example Usage
 */
export class DefaultSupportedIdpConfig extends pulumi.CustomResource {
    /**
     * Get an existing DefaultSupportedIdpConfig resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DefaultSupportedIdpConfigState, opts?: pulumi.CustomResourceOptions): DefaultSupportedIdpConfig {
        return new DefaultSupportedIdpConfig(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:identityplatform/defaultSupportedIdpConfig:DefaultSupportedIdpConfig';

    /**
     * Returns true if the given object is an instance of DefaultSupportedIdpConfig.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DefaultSupportedIdpConfig {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DefaultSupportedIdpConfig.__pulumiType;
    }

    /**
     * OAuth client ID
     */
    public readonly clientId!: pulumi.Output<string>;
    /**
     * OAuth client secret
     */
    public readonly clientSecret!: pulumi.Output<string>;
    /**
     * If this IDP allows the user to sign in
     */
    public readonly enabled!: pulumi.Output<boolean | undefined>;
    /**
     * ID of the IDP. Possible values include:
     * * `apple.com`
     * * `facebook.com`
     * * `gc.apple.com`
     * * `github.com`
     * * `google.com`
     * * `linkedin.com`
     * * `microsoft.com`
     * * `playgames.google.com`
     * * `twitter.com`
     * * `yahoo.com`
     */
    public readonly idpId!: pulumi.Output<string>;
    /**
     * The name of the DefaultSupportedIdpConfig resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    public readonly project!: pulumi.Output<string>;

    /**
     * Create a DefaultSupportedIdpConfig resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DefaultSupportedIdpConfigArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DefaultSupportedIdpConfigArgs | DefaultSupportedIdpConfigState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as DefaultSupportedIdpConfigState | undefined;
            inputs["clientId"] = state ? state.clientId : undefined;
            inputs["clientSecret"] = state ? state.clientSecret : undefined;
            inputs["enabled"] = state ? state.enabled : undefined;
            inputs["idpId"] = state ? state.idpId : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["project"] = state ? state.project : undefined;
        } else {
            const args = argsOrState as DefaultSupportedIdpConfigArgs | undefined;
            if (!args || args.clientId === undefined) {
                throw new Error("Missing required property 'clientId'");
            }
            if (!args || args.clientSecret === undefined) {
                throw new Error("Missing required property 'clientSecret'");
            }
            if (!args || args.idpId === undefined) {
                throw new Error("Missing required property 'idpId'");
            }
            inputs["clientId"] = args ? args.clientId : undefined;
            inputs["clientSecret"] = args ? args.clientSecret : undefined;
            inputs["enabled"] = args ? args.enabled : undefined;
            inputs["idpId"] = args ? args.idpId : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["name"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(DefaultSupportedIdpConfig.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DefaultSupportedIdpConfig resources.
 */
export interface DefaultSupportedIdpConfigState {
    /**
     * OAuth client ID
     */
    readonly clientId?: pulumi.Input<string>;
    /**
     * OAuth client secret
     */
    readonly clientSecret?: pulumi.Input<string>;
    /**
     * If this IDP allows the user to sign in
     */
    readonly enabled?: pulumi.Input<boolean>;
    /**
     * ID of the IDP. Possible values include:
     * * `apple.com`
     * * `facebook.com`
     * * `gc.apple.com`
     * * `github.com`
     * * `google.com`
     * * `linkedin.com`
     * * `microsoft.com`
     * * `playgames.google.com`
     * * `twitter.com`
     * * `yahoo.com`
     */
    readonly idpId?: pulumi.Input<string>;
    /**
     * The name of the DefaultSupportedIdpConfig resource
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a DefaultSupportedIdpConfig resource.
 */
export interface DefaultSupportedIdpConfigArgs {
    /**
     * OAuth client ID
     */
    readonly clientId: pulumi.Input<string>;
    /**
     * OAuth client secret
     */
    readonly clientSecret: pulumi.Input<string>;
    /**
     * If this IDP allows the user to sign in
     */
    readonly enabled?: pulumi.Input<boolean>;
    /**
     * ID of the IDP. Possible values include:
     * * `apple.com`
     * * `facebook.com`
     * * `gc.apple.com`
     * * `github.com`
     * * `google.com`
     * * `linkedin.com`
     * * `microsoft.com`
     * * `playgames.google.com`
     * * `twitter.com`
     * * `yahoo.com`
     */
    readonly idpId: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
}
