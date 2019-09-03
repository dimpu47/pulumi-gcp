// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_network.html.markdown.
 */
export class Network extends pulumi.CustomResource {
    /**
     * Get an existing Network resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: NetworkState, opts?: pulumi.CustomResourceOptions): Network {
        return new Network(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:compute/network:Network';

    /**
     * Returns true if the given object is an instance of Network.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Network {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Network.__pulumiType;
    }

    public readonly autoCreateSubnetworks!: pulumi.Output<boolean | undefined>;
    /**
     * If set to `true`, default routes (`0.0.0.0/0`) will be deleted
     * immediately after network creation. Defaults to `false`.
     */
    public readonly deleteDefaultRoutesOnCreate!: pulumi.Output<boolean | undefined>;
    public readonly description!: pulumi.Output<string | undefined>;
    public /*out*/ readonly gatewayIpv4!: pulumi.Output<string>;
    public readonly ipv4Range!: pulumi.Output<string | undefined>;
    public readonly name!: pulumi.Output<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    public readonly project!: pulumi.Output<string>;
    public readonly routingMode!: pulumi.Output<string>;
    /**
     * The URI of the created resource.
     */
    public /*out*/ readonly selfLink!: pulumi.Output<string>;

    /**
     * Create a Network resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: NetworkArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: NetworkArgs | NetworkState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as NetworkState | undefined;
            inputs["autoCreateSubnetworks"] = state ? state.autoCreateSubnetworks : undefined;
            inputs["deleteDefaultRoutesOnCreate"] = state ? state.deleteDefaultRoutesOnCreate : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["gatewayIpv4"] = state ? state.gatewayIpv4 : undefined;
            inputs["ipv4Range"] = state ? state.ipv4Range : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["project"] = state ? state.project : undefined;
            inputs["routingMode"] = state ? state.routingMode : undefined;
            inputs["selfLink"] = state ? state.selfLink : undefined;
        } else {
            const args = argsOrState as NetworkArgs | undefined;
            inputs["autoCreateSubnetworks"] = args ? args.autoCreateSubnetworks : undefined;
            inputs["deleteDefaultRoutesOnCreate"] = args ? args.deleteDefaultRoutesOnCreate : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["ipv4Range"] = args ? args.ipv4Range : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["routingMode"] = args ? args.routingMode : undefined;
            inputs["gatewayIpv4"] = undefined /*out*/;
            inputs["selfLink"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Network.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Network resources.
 */
export interface NetworkState {
    readonly autoCreateSubnetworks?: pulumi.Input<boolean>;
    /**
     * If set to `true`, default routes (`0.0.0.0/0`) will be deleted
     * immediately after network creation. Defaults to `false`.
     */
    readonly deleteDefaultRoutesOnCreate?: pulumi.Input<boolean>;
    readonly description?: pulumi.Input<string>;
    readonly gatewayIpv4?: pulumi.Input<string>;
    readonly ipv4Range?: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    readonly routingMode?: pulumi.Input<string>;
    /**
     * The URI of the created resource.
     */
    readonly selfLink?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Network resource.
 */
export interface NetworkArgs {
    readonly autoCreateSubnetworks?: pulumi.Input<boolean>;
    /**
     * If set to `true`, default routes (`0.0.0.0/0`) will be deleted
     * immediately after network creation. Defaults to `false`.
     */
    readonly deleteDefaultRoutesOnCreate?: pulumi.Input<boolean>;
    readonly description?: pulumi.Input<string>;
    readonly ipv4Range?: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    readonly routingMode?: pulumi.Input<string>;
}
