// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class AttachedDisk extends pulumi.CustomResource {
    /**
     * Get an existing AttachedDisk resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AttachedDiskState, opts?: pulumi.CustomResourceOptions): AttachedDisk {
        return new AttachedDisk(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:compute/attachedDisk:AttachedDisk';

    /**
     * Returns true if the given object is an instance of AttachedDisk.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AttachedDisk {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AttachedDisk.__pulumiType;
    }

    public readonly deviceName!: pulumi.Output<string>;
    public readonly disk!: pulumi.Output<string>;
    public readonly instance!: pulumi.Output<string>;
    public readonly mode!: pulumi.Output<string | undefined>;
    public readonly project!: pulumi.Output<string>;
    public readonly zone!: pulumi.Output<string>;

    /**
     * Create a AttachedDisk resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AttachedDiskArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AttachedDiskArgs | AttachedDiskState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as AttachedDiskState | undefined;
            inputs["deviceName"] = state ? state.deviceName : undefined;
            inputs["disk"] = state ? state.disk : undefined;
            inputs["instance"] = state ? state.instance : undefined;
            inputs["mode"] = state ? state.mode : undefined;
            inputs["project"] = state ? state.project : undefined;
            inputs["zone"] = state ? state.zone : undefined;
        } else {
            const args = argsOrState as AttachedDiskArgs | undefined;
            if (!args || args.disk === undefined) {
                throw new Error("Missing required property 'disk'");
            }
            if (!args || args.instance === undefined) {
                throw new Error("Missing required property 'instance'");
            }
            inputs["deviceName"] = args ? args.deviceName : undefined;
            inputs["disk"] = args ? args.disk : undefined;
            inputs["instance"] = args ? args.instance : undefined;
            inputs["mode"] = args ? args.mode : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["zone"] = args ? args.zone : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(AttachedDisk.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AttachedDisk resources.
 */
export interface AttachedDiskState {
    readonly deviceName?: pulumi.Input<string>;
    readonly disk?: pulumi.Input<string>;
    readonly instance?: pulumi.Input<string>;
    readonly mode?: pulumi.Input<string>;
    readonly project?: pulumi.Input<string>;
    readonly zone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a AttachedDisk resource.
 */
export interface AttachedDiskArgs {
    readonly deviceName?: pulumi.Input<string>;
    readonly disk: pulumi.Input<string>;
    readonly instance: pulumi.Input<string>;
    readonly mode?: pulumi.Input<string>;
    readonly project?: pulumi.Input<string>;
    readonly zone?: pulumi.Input<string>;
}
