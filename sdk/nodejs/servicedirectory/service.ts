// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * An individual service. A service contains a name and optional metadata.
 *
 * To get more information about Service, see:
 *
 * * [API documentation](https://cloud.google.com/service-directory/docs/reference/rest/v1beta1/projects.locations.namespaces.services)
 * * How-to Guides
 *     * [Configuring a service](https://cloud.google.com/service-directory/docs/configuring-service-directory#configuring_a_service)
 *
 * ## Example Usage
 */
export class Service extends pulumi.CustomResource {
    /**
     * Get an existing Service resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ServiceState, opts?: pulumi.CustomResourceOptions): Service {
        return new Service(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:servicedirectory/service:Service';

    /**
     * Returns true if the given object is an instance of Service.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Service {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Service.__pulumiType;
    }

    /**
     * Metadata for the service. This data can be consumed
     * by service clients. The entire metadata dictionary may contain
     * up to 2000 characters, spread across all key-value pairs.
     * Metadata that goes beyond any these limits will be rejected.
     */
    public readonly metadata!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The resource name for the service in the format 'projects/*&#47;locations/*&#47;namespaces/*&#47;services/*'.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The resource name of the namespace this service will belong to.
     */
    public readonly namespace!: pulumi.Output<string>;
    /**
     * The Resource ID must be 1-63 characters long, including digits,
     * lowercase letters or the hyphen character.
     */
    public readonly serviceId!: pulumi.Output<string>;

    /**
     * Create a Service resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServiceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ServiceArgs | ServiceState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ServiceState | undefined;
            inputs["metadata"] = state ? state.metadata : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["namespace"] = state ? state.namespace : undefined;
            inputs["serviceId"] = state ? state.serviceId : undefined;
        } else {
            const args = argsOrState as ServiceArgs | undefined;
            if (!args || args.namespace === undefined) {
                throw new Error("Missing required property 'namespace'");
            }
            if (!args || args.serviceId === undefined) {
                throw new Error("Missing required property 'serviceId'");
            }
            inputs["metadata"] = args ? args.metadata : undefined;
            inputs["namespace"] = args ? args.namespace : undefined;
            inputs["serviceId"] = args ? args.serviceId : undefined;
            inputs["name"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Service.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Service resources.
 */
export interface ServiceState {
    /**
     * Metadata for the service. This data can be consumed
     * by service clients. The entire metadata dictionary may contain
     * up to 2000 characters, spread across all key-value pairs.
     * Metadata that goes beyond any these limits will be rejected.
     */
    readonly metadata?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The resource name for the service in the format 'projects/*&#47;locations/*&#47;namespaces/*&#47;services/*'.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The resource name of the namespace this service will belong to.
     */
    readonly namespace?: pulumi.Input<string>;
    /**
     * The Resource ID must be 1-63 characters long, including digits,
     * lowercase letters or the hyphen character.
     */
    readonly serviceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Service resource.
 */
export interface ServiceArgs {
    /**
     * Metadata for the service. This data can be consumed
     * by service clients. The entire metadata dictionary may contain
     * up to 2000 characters, spread across all key-value pairs.
     * Metadata that goes beyond any these limits will be rejected.
     */
    readonly metadata?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The resource name of the namespace this service will belong to.
     */
    readonly namespace: pulumi.Input<string>;
    /**
     * The Resource ID must be 1-63 characters long, including digits,
     * lowercase letters or the hyphen character.
     */
    readonly serviceId: pulumi.Input<string>;
}
