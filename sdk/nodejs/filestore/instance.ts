// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/filestore_instance.html.markdown.
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
    public static readonly __pulumiType = 'gcp:filestore/instance:Instance';

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

    public /*out*/ readonly createTime!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string | undefined>;
    public /*out*/ readonly etag!: pulumi.Output<string>;
    public readonly fileShares!: pulumi.Output<outputs.filestore.InstanceFileShares>;
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly name!: pulumi.Output<string>;
    public readonly networks!: pulumi.Output<outputs.filestore.InstanceNetwork[]>;
    public readonly project!: pulumi.Output<string>;
    public readonly tier!: pulumi.Output<string>;
    public readonly zone!: pulumi.Output<string>;

    /**
     * Create a Instance resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: InstanceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: InstanceArgs | InstanceState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as InstanceState | undefined;
            inputs["createTime"] = state ? state.createTime : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["etag"] = state ? state.etag : undefined;
            inputs["fileShares"] = state ? state.fileShares : undefined;
            inputs["labels"] = state ? state.labels : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["networks"] = state ? state.networks : undefined;
            inputs["project"] = state ? state.project : undefined;
            inputs["tier"] = state ? state.tier : undefined;
            inputs["zone"] = state ? state.zone : undefined;
        } else {
            const args = argsOrState as InstanceArgs | undefined;
            if (!args || args.fileShares === undefined) {
                throw new Error("Missing required property 'fileShares'");
            }
            if (!args || args.networks === undefined) {
                throw new Error("Missing required property 'networks'");
            }
            if (!args || args.tier === undefined) {
                throw new Error("Missing required property 'tier'");
            }
            if (!args || args.zone === undefined) {
                throw new Error("Missing required property 'zone'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["fileShares"] = args ? args.fileShares : undefined;
            inputs["labels"] = args ? args.labels : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["networks"] = args ? args.networks : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["tier"] = args ? args.tier : undefined;
            inputs["zone"] = args ? args.zone : undefined;
            inputs["createTime"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
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
    readonly createTime?: pulumi.Input<string>;
    readonly description?: pulumi.Input<string>;
    readonly etag?: pulumi.Input<string>;
    readonly fileShares?: pulumi.Input<inputs.filestore.InstanceFileShares>;
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    readonly name?: pulumi.Input<string>;
    readonly networks?: pulumi.Input<pulumi.Input<inputs.filestore.InstanceNetwork>[]>;
    readonly project?: pulumi.Input<string>;
    readonly tier?: pulumi.Input<string>;
    readonly zone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Instance resource.
 */
export interface InstanceArgs {
    readonly description?: pulumi.Input<string>;
    readonly fileShares: pulumi.Input<inputs.filestore.InstanceFileShares>;
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    readonly name?: pulumi.Input<string>;
    readonly networks: pulumi.Input<pulumi.Input<inputs.filestore.InstanceNetwork>[]>;
    readonly project?: pulumi.Input<string>;
    readonly tier: pulumi.Input<string>;
    readonly zone: pulumi.Input<string>;
}
