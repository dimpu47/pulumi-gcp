// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/dataproc_autoscaling_policy.html.markdown.
 */
export class AutoscalingPolicy extends pulumi.CustomResource {
    /**
     * Get an existing AutoscalingPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AutoscalingPolicyState, opts?: pulumi.CustomResourceOptions): AutoscalingPolicy {
        return new AutoscalingPolicy(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:dataproc/autoscalingPolicy:AutoscalingPolicy';

    /**
     * Returns true if the given object is an instance of AutoscalingPolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AutoscalingPolicy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AutoscalingPolicy.__pulumiType;
    }

    /**
     * Basic algorithm for autoscaling.
     */
    public readonly basicAlgorithm!: pulumi.Output<outputs.dataproc.AutoscalingPolicyBasicAlgorithm | undefined>;
    /**
     * The location where the autoscaling poicy should reside. The default value is 'global'.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * The "resource name" of the autoscaling policy.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The policy id. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). Cannot
     * begin or end with underscore or hyphen. Must consist of between 3 and 50 characters.
     */
    public readonly policyId!: pulumi.Output<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    public readonly project!: pulumi.Output<string>;
    /**
     * Describes how the autoscaler will operate for secondary workers.
     */
    public readonly secondaryWorkerConfig!: pulumi.Output<outputs.dataproc.AutoscalingPolicySecondaryWorkerConfig | undefined>;
    /**
     * Describes how the autoscaler will operate for primary workers.
     */
    public readonly workerConfig!: pulumi.Output<outputs.dataproc.AutoscalingPolicyWorkerConfig | undefined>;

    /**
     * Create a AutoscalingPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AutoscalingPolicyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AutoscalingPolicyArgs | AutoscalingPolicyState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as AutoscalingPolicyState | undefined;
            inputs["basicAlgorithm"] = state ? state.basicAlgorithm : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["policyId"] = state ? state.policyId : undefined;
            inputs["project"] = state ? state.project : undefined;
            inputs["secondaryWorkerConfig"] = state ? state.secondaryWorkerConfig : undefined;
            inputs["workerConfig"] = state ? state.workerConfig : undefined;
        } else {
            const args = argsOrState as AutoscalingPolicyArgs | undefined;
            if (!args || args.policyId === undefined) {
                throw new Error("Missing required property 'policyId'");
            }
            inputs["basicAlgorithm"] = args ? args.basicAlgorithm : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["policyId"] = args ? args.policyId : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["secondaryWorkerConfig"] = args ? args.secondaryWorkerConfig : undefined;
            inputs["workerConfig"] = args ? args.workerConfig : undefined;
            inputs["name"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(AutoscalingPolicy.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AutoscalingPolicy resources.
 */
export interface AutoscalingPolicyState {
    /**
     * Basic algorithm for autoscaling.
     */
    readonly basicAlgorithm?: pulumi.Input<inputs.dataproc.AutoscalingPolicyBasicAlgorithm>;
    /**
     * The location where the autoscaling poicy should reside. The default value is 'global'.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The "resource name" of the autoscaling policy.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The policy id. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). Cannot
     * begin or end with underscore or hyphen. Must consist of between 3 and 50 characters.
     */
    readonly policyId?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    /**
     * Describes how the autoscaler will operate for secondary workers.
     */
    readonly secondaryWorkerConfig?: pulumi.Input<inputs.dataproc.AutoscalingPolicySecondaryWorkerConfig>;
    /**
     * Describes how the autoscaler will operate for primary workers.
     */
    readonly workerConfig?: pulumi.Input<inputs.dataproc.AutoscalingPolicyWorkerConfig>;
}

/**
 * The set of arguments for constructing a AutoscalingPolicy resource.
 */
export interface AutoscalingPolicyArgs {
    /**
     * Basic algorithm for autoscaling.
     */
    readonly basicAlgorithm?: pulumi.Input<inputs.dataproc.AutoscalingPolicyBasicAlgorithm>;
    /**
     * The location where the autoscaling poicy should reside. The default value is 'global'.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The policy id. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). Cannot
     * begin or end with underscore or hyphen. Must consist of between 3 and 50 characters.
     */
    readonly policyId: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    /**
     * Describes how the autoscaler will operate for secondary workers.
     */
    readonly secondaryWorkerConfig?: pulumi.Input<inputs.dataproc.AutoscalingPolicySecondaryWorkerConfig>;
    /**
     * Describes how the autoscaler will operate for primary workers.
     */
    readonly workerConfig?: pulumi.Input<inputs.dataproc.AutoscalingPolicyWorkerConfig>;
}
