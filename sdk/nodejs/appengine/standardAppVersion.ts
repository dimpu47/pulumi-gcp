// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/app_engine_standard_app_version.html.markdown.
 */
export class StandardAppVersion extends pulumi.CustomResource {
    /**
     * Get an existing StandardAppVersion resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: StandardAppVersionState, opts?: pulumi.CustomResourceOptions): StandardAppVersion {
        return new StandardAppVersion(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:appengine/standardAppVersion:StandardAppVersion';

    /**
     * Returns true if the given object is an instance of StandardAppVersion.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is StandardAppVersion {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === StandardAppVersion.__pulumiType;
    }

    public readonly deployment!: pulumi.Output<outputs.appengine.StandardAppVersionDeployment | undefined>;
    public readonly entrypoint!: pulumi.Output<outputs.appengine.StandardAppVersionEntrypoint | undefined>;
    public readonly envVariables!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly handlers!: pulumi.Output<outputs.appengine.StandardAppVersionHandler[] | undefined>;
    public readonly libraries!: pulumi.Output<outputs.appengine.StandardAppVersionLibrary[] | undefined>;
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * If set to `true`, the application version will not be deleted.
     */
    public readonly noopOnDestroy!: pulumi.Output<boolean | undefined>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    public readonly project!: pulumi.Output<string>;
    public readonly runtime!: pulumi.Output<string>;
    public readonly runtimeApiVersion!: pulumi.Output<string | undefined>;
    public readonly service!: pulumi.Output<string | undefined>;
    public readonly threadsafe!: pulumi.Output<boolean | undefined>;
    public readonly versionId!: pulumi.Output<string | undefined>;

    /**
     * Create a StandardAppVersion resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: StandardAppVersionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: StandardAppVersionArgs | StandardAppVersionState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as StandardAppVersionState | undefined;
            inputs["deployment"] = state ? state.deployment : undefined;
            inputs["entrypoint"] = state ? state.entrypoint : undefined;
            inputs["envVariables"] = state ? state.envVariables : undefined;
            inputs["handlers"] = state ? state.handlers : undefined;
            inputs["libraries"] = state ? state.libraries : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["noopOnDestroy"] = state ? state.noopOnDestroy : undefined;
            inputs["project"] = state ? state.project : undefined;
            inputs["runtime"] = state ? state.runtime : undefined;
            inputs["runtimeApiVersion"] = state ? state.runtimeApiVersion : undefined;
            inputs["service"] = state ? state.service : undefined;
            inputs["threadsafe"] = state ? state.threadsafe : undefined;
            inputs["versionId"] = state ? state.versionId : undefined;
        } else {
            const args = argsOrState as StandardAppVersionArgs | undefined;
            if (!args || args.runtime === undefined) {
                throw new Error("Missing required property 'runtime'");
            }
            inputs["deployment"] = args ? args.deployment : undefined;
            inputs["entrypoint"] = args ? args.entrypoint : undefined;
            inputs["envVariables"] = args ? args.envVariables : undefined;
            inputs["handlers"] = args ? args.handlers : undefined;
            inputs["libraries"] = args ? args.libraries : undefined;
            inputs["noopOnDestroy"] = args ? args.noopOnDestroy : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["runtime"] = args ? args.runtime : undefined;
            inputs["runtimeApiVersion"] = args ? args.runtimeApiVersion : undefined;
            inputs["service"] = args ? args.service : undefined;
            inputs["threadsafe"] = args ? args.threadsafe : undefined;
            inputs["versionId"] = args ? args.versionId : undefined;
            inputs["name"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(StandardAppVersion.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering StandardAppVersion resources.
 */
export interface StandardAppVersionState {
    readonly deployment?: pulumi.Input<inputs.appengine.StandardAppVersionDeployment>;
    readonly entrypoint?: pulumi.Input<inputs.appengine.StandardAppVersionEntrypoint>;
    readonly envVariables?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    readonly handlers?: pulumi.Input<pulumi.Input<inputs.appengine.StandardAppVersionHandler>[]>;
    readonly libraries?: pulumi.Input<pulumi.Input<inputs.appengine.StandardAppVersionLibrary>[]>;
    readonly name?: pulumi.Input<string>;
    /**
     * If set to `true`, the application version will not be deleted.
     */
    readonly noopOnDestroy?: pulumi.Input<boolean>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    readonly runtime?: pulumi.Input<string>;
    readonly runtimeApiVersion?: pulumi.Input<string>;
    readonly service?: pulumi.Input<string>;
    readonly threadsafe?: pulumi.Input<boolean>;
    readonly versionId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a StandardAppVersion resource.
 */
export interface StandardAppVersionArgs {
    readonly deployment?: pulumi.Input<inputs.appengine.StandardAppVersionDeployment>;
    readonly entrypoint?: pulumi.Input<inputs.appengine.StandardAppVersionEntrypoint>;
    readonly envVariables?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    readonly handlers?: pulumi.Input<pulumi.Input<inputs.appengine.StandardAppVersionHandler>[]>;
    readonly libraries?: pulumi.Input<pulumi.Input<inputs.appengine.StandardAppVersionLibrary>[]>;
    /**
     * If set to `true`, the application version will not be deleted.
     */
    readonly noopOnDestroy?: pulumi.Input<boolean>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    readonly runtime: pulumi.Input<string>;
    readonly runtimeApiVersion?: pulumi.Input<string>;
    readonly service?: pulumi.Input<string>;
    readonly threadsafe?: pulumi.Input<boolean>;
    readonly versionId?: pulumi.Input<string>;
}
