// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export class KeyRing extends pulumi.CustomResource {
    /**
     * Get an existing KeyRing resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: KeyRingState, opts?: pulumi.CustomResourceOptions): KeyRing {
        return new KeyRing(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:kms/keyRing:KeyRing';

    /**
     * Returns true if the given object is an instance of KeyRing.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is KeyRing {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === KeyRing.__pulumiType;
    }

    /**
     * The location for the KeyRing. A full list of valid locations can be found by running 'gcloud kms locations list'.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The resource name for the KeyRing.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    public readonly project!: pulumi.Output<string>;
    public /*out*/ readonly selfLink!: pulumi.Output<string>;

    /**
     * Create a KeyRing resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: KeyRingArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: KeyRingArgs | KeyRingState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as KeyRingState | undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["project"] = state ? state.project : undefined;
            inputs["selfLink"] = state ? state.selfLink : undefined;
        } else {
            const args = argsOrState as KeyRingArgs | undefined;
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["selfLink"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(KeyRing.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering KeyRing resources.
 */
export interface KeyRingState {
    /**
     * The location for the KeyRing. A full list of valid locations can be found by running 'gcloud kms locations list'.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The resource name for the KeyRing.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    readonly selfLink?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a KeyRing resource.
 */
export interface KeyRingArgs {
    /**
     * The location for the KeyRing. A full list of valid locations can be found by running 'gcloud kms locations list'.
     */
    readonly location: pulumi.Input<string>;
    /**
     * The resource name for the KeyRing.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
}
