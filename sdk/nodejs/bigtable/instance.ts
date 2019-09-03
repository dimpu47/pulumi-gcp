// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Creates a Google Bigtable instance. For more information see
 * [the official documentation](https://cloud.google.com/bigtable/) and
 * [API](https://cloud.google.com/bigtable/docs/go/reference).
 * 
 * 
 * ## Example Usage - Production Instance
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as gcp from "@pulumi/gcp";
 * 
 * const productionInstance = new gcp.bigtable.Instance("production-instance", {
 *     clusters: [{
 *         clusterId: "tf-instance-cluster",
 *         numNodes: 3,
 *         storageType: "HDD",
 *         zone: "us-central1-b",
 *     }],
 * });
 * ```
 * 
 * ## Example Usage - Development Instance
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as gcp from "@pulumi/gcp";
 * 
 * const developmentInstance = new gcp.bigtable.Instance("development-instance", {
 *     clusters: [{
 *         clusterId: "tf-instance-cluster",
 *         storageType: "HDD",
 *         zone: "us-central1-b",
 *     }],
 *     instanceType: "DEVELOPMENT",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/bigtable_instance.html.markdown.
 */
export class Instance extends pulumi.CustomResource {
    /**
     * Get an existing Instance resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: InstanceState, opts?: pulumi.CustomResourceOptions): Instance {
        return new Instance(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:bigtable/instance:Instance';

    /**
     * Returns true if the given object is an instance of Instance.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Instance {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Instance.__pulumiType;
    }

    /**
     * A block of cluster configuration options. This can be specified 1 or 2 times. See structure below.
     */
    public readonly clusters!: pulumi.Output<outputs.bigtable.InstanceCluster[]>;
    /**
     * The human-readable display name of the Bigtable instance. Defaults to the instance `name`.
     */
    public readonly displayName!: pulumi.Output<string>;
    /**
     * The instance type to create. One of `"DEVELOPMENT"` or `"PRODUCTION"`. Defaults to `"PRODUCTION"`.
     */
    public readonly instanceType!: pulumi.Output<string | undefined>;
    /**
     * The name (also called Instance Id in the Cloud Console) of the Cloud Bigtable instance.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The ID of the project in which the resource belongs. If it
     * is not provided, the provider project is used.
     */
    public readonly project!: pulumi.Output<string>;

    /**
     * Create a Instance resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: InstanceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: InstanceArgs | InstanceState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as InstanceState | undefined;
            inputs["clusters"] = state ? state.clusters : undefined;
            inputs["displayName"] = state ? state.displayName : undefined;
            inputs["instanceType"] = state ? state.instanceType : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["project"] = state ? state.project : undefined;
        } else {
            const args = argsOrState as InstanceArgs | undefined;
            inputs["clusters"] = args ? args.clusters : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["instanceType"] = args ? args.instanceType : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["project"] = args ? args.project : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Instance.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Instance resources.
 */
export interface InstanceState {
    /**
     * A block of cluster configuration options. This can be specified 1 or 2 times. See structure below.
     */
    readonly clusters?: pulumi.Input<pulumi.Input<inputs.bigtable.InstanceCluster>[]>;
    /**
     * The human-readable display name of the Bigtable instance. Defaults to the instance `name`.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * The instance type to create. One of `"DEVELOPMENT"` or `"PRODUCTION"`. Defaults to `"PRODUCTION"`.
     */
    readonly instanceType?: pulumi.Input<string>;
    /**
     * The name (also called Instance Id in the Cloud Console) of the Cloud Bigtable instance.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs. If it
     * is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Instance resource.
 */
export interface InstanceArgs {
    /**
     * A block of cluster configuration options. This can be specified 1 or 2 times. See structure below.
     */
    readonly clusters?: pulumi.Input<pulumi.Input<inputs.bigtable.InstanceCluster>[]>;
    /**
     * The human-readable display name of the Bigtable instance. Defaults to the instance `name`.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * The instance type to create. One of `"DEVELOPMENT"` or `"PRODUCTION"`. Defaults to `"PRODUCTION"`.
     */
    readonly instanceType?: pulumi.Input<string>;
    /**
     * The name (also called Instance Id in the Cloud Console) of the Cloud Bigtable instance.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs. If it
     * is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
}
