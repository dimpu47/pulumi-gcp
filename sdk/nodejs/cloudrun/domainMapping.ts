// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/cloud_run_domain_mapping.html.markdown.
 */
export class DomainMapping extends pulumi.CustomResource {
    /**
     * Get an existing DomainMapping resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DomainMappingState, opts?: pulumi.CustomResourceOptions): DomainMapping {
        return new DomainMapping(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:cloudrun/domainMapping:DomainMapping';

    /**
     * Returns true if the given object is an instance of DomainMapping.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DomainMapping {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DomainMapping.__pulumiType;
    }

    public readonly location!: pulumi.Output<string>;
    public readonly metadata!: pulumi.Output<{ annotations: {[key: string]: string}, generation: number, labels: {[key: string]: string}, namespace: string, resourceVersion: string, selfLink: string, uid: string }>;
    public readonly name!: pulumi.Output<string>;
    public readonly project!: pulumi.Output<string>;
    public readonly spec!: pulumi.Output<{ certificateMode?: string, forceOverride?: boolean, routeName: string }>;
    public /*out*/ readonly status!: pulumi.Output<{ conditions: { message: string, reason: string, status: string, type: string }[], mappedRouteName: string, observedGeneration: number, resourceRecords?: { name: string, rrdata?: string, type?: string }[] }>;

    /**
     * Create a DomainMapping resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DomainMappingArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DomainMappingArgs | DomainMappingState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as DomainMappingState | undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["metadata"] = state ? state.metadata : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["project"] = state ? state.project : undefined;
            inputs["spec"] = state ? state.spec : undefined;
            inputs["status"] = state ? state.status : undefined;
        } else {
            const args = argsOrState as DomainMappingArgs | undefined;
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.metadata === undefined) {
                throw new Error("Missing required property 'metadata'");
            }
            if (!args || args.spec === undefined) {
                throw new Error("Missing required property 'spec'");
            }
            inputs["location"] = args ? args.location : undefined;
            inputs["metadata"] = args ? args.metadata : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["spec"] = args ? args.spec : undefined;
            inputs["status"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(DomainMapping.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DomainMapping resources.
 */
export interface DomainMappingState {
    readonly location?: pulumi.Input<string>;
    readonly metadata?: pulumi.Input<{ annotations?: pulumi.Input<{[key: string]: pulumi.Input<string>}>, generation?: pulumi.Input<number>, labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>, namespace: pulumi.Input<string>, resourceVersion?: pulumi.Input<string>, selfLink?: pulumi.Input<string>, uid?: pulumi.Input<string> }>;
    readonly name?: pulumi.Input<string>;
    readonly project?: pulumi.Input<string>;
    readonly spec?: pulumi.Input<{ certificateMode?: pulumi.Input<string>, forceOverride?: pulumi.Input<boolean>, routeName: pulumi.Input<string> }>;
    readonly status?: pulumi.Input<{ conditions?: pulumi.Input<pulumi.Input<{ message?: pulumi.Input<string>, reason?: pulumi.Input<string>, status?: pulumi.Input<string>, type?: pulumi.Input<string> }>[]>, mappedRouteName?: pulumi.Input<string>, observedGeneration?: pulumi.Input<number>, resourceRecords?: pulumi.Input<pulumi.Input<{ name?: pulumi.Input<string>, rrdata?: pulumi.Input<string>, type?: pulumi.Input<string> }>[]> }>;
}

/**
 * The set of arguments for constructing a DomainMapping resource.
 */
export interface DomainMappingArgs {
    readonly location: pulumi.Input<string>;
    readonly metadata: pulumi.Input<{ annotations?: pulumi.Input<{[key: string]: pulumi.Input<string>}>, generation?: pulumi.Input<number>, labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>, namespace: pulumi.Input<string>, resourceVersion?: pulumi.Input<string>, selfLink?: pulumi.Input<string>, uid?: pulumi.Input<string> }>;
    readonly name?: pulumi.Input<string>;
    readonly project?: pulumi.Input<string>;
    readonly spec: pulumi.Input<{ certificateMode?: pulumi.Input<string>, forceOverride?: pulumi.Input<boolean>, routeName: pulumi.Input<string> }>;
}