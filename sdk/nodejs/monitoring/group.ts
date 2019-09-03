// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/monitoring_group.html.markdown.
 */
export class Group extends pulumi.CustomResource {
    /**
     * Get an existing Group resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: GroupState, opts?: pulumi.CustomResourceOptions): Group {
        return new Group(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:monitoring/group:Group';

    /**
     * Returns true if the given object is an instance of Group.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Group {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Group.__pulumiType;
    }

    public readonly displayName!: pulumi.Output<string>;
    public readonly filter!: pulumi.Output<string>;
    public readonly isCluster!: pulumi.Output<boolean | undefined>;
    public /*out*/ readonly name!: pulumi.Output<string>;
    public readonly parentName!: pulumi.Output<string | undefined>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    public readonly project!: pulumi.Output<string>;

    /**
     * Create a Group resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: GroupArgs | GroupState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as GroupState | undefined;
            inputs["displayName"] = state ? state.displayName : undefined;
            inputs["filter"] = state ? state.filter : undefined;
            inputs["isCluster"] = state ? state.isCluster : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["parentName"] = state ? state.parentName : undefined;
            inputs["project"] = state ? state.project : undefined;
        } else {
            const args = argsOrState as GroupArgs | undefined;
            if (!args || args.displayName === undefined) {
                throw new Error("Missing required property 'displayName'");
            }
            if (!args || args.filter === undefined) {
                throw new Error("Missing required property 'filter'");
            }
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["filter"] = args ? args.filter : undefined;
            inputs["isCluster"] = args ? args.isCluster : undefined;
            inputs["parentName"] = args ? args.parentName : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["name"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Group.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Group resources.
 */
export interface GroupState {
    readonly displayName?: pulumi.Input<string>;
    readonly filter?: pulumi.Input<string>;
    readonly isCluster?: pulumi.Input<boolean>;
    readonly name?: pulumi.Input<string>;
    readonly parentName?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Group resource.
 */
export interface GroupArgs {
    readonly displayName: pulumi.Input<string>;
    readonly filter: pulumi.Input<string>;
    readonly isCluster?: pulumi.Input<boolean>;
    readonly parentName?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
}
