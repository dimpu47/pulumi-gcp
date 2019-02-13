// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages a URL Map resource within GCE. For more information see
 * [the official documentation](https://cloud.google.com/compute/docs/load-balancing/http/url-map)
 * and
 * [API](https://cloud.google.com/compute/docs/reference/latest/urlMaps).
 * 
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as gcp from "@pulumi/gcp";
 * 
 * const defaultHttpHealthCheck = new gcp.compute.HttpHealthCheck("default", {
 *     checkIntervalSec: 1,
 *     requestPath: "/",
 *     timeoutSec: 1,
 * });
 * const staticBucket = new gcp.storage.Bucket("static", {
 *     location: "US",
 * });
 * const staticBackendBucket = new gcp.compute.BackendBucket("static", {
 *     bucketName: staticBucket.name,
 *     enableCdn: true,
 * });
 * const home = new gcp.compute.BackendService("home", {
 *     healthChecks: defaultHttpHealthCheck.selfLink,
 *     portName: "http",
 *     protocol: "HTTP",
 *     timeoutSec: 10,
 * });
 * const login = new gcp.compute.BackendService("login", {
 *     healthChecks: defaultHttpHealthCheck.selfLink,
 *     portName: "http",
 *     protocol: "HTTP",
 *     timeoutSec: 10,
 * });
 * const foobar = new gcp.compute.URLMap("foobar", {
 *     defaultService: home.selfLink,
 *     description: "a description",
 *     hostRules: [{
 *         hosts: ["mysite.com"],
 *         pathMatcher: "allpaths",
 *     }],
 *     pathMatchers: [{
 *         defaultService: home.selfLink,
 *         name: "allpaths",
 *         pathRules: [
 *             {
 *                 paths: ["/home"],
 *                 service: home.selfLink,
 *             },
 *             {
 *                 paths: ["/login"],
 *                 service: login.selfLink,
 *             },
 *             {
 *                 paths: ["/static"],
 *                 service: staticBackendBucket.selfLink,
 *             },
 *         ],
 *     }],
 *     tests: [{
 *         host: "hi.com",
 *         path: "/home",
 *         service: home.selfLink,
 *     }],
 * });
 * ```
 */
export class URLMap extends pulumi.CustomResource {
    /**
     * Get an existing URLMap resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: URLMapState, opts?: pulumi.CustomResourceOptions): URLMap {
        return new URLMap(name, <any>state, { ...opts, id: id });
    }

    public /*out*/ readonly creationTimestamp: pulumi.Output<string>;
    /**
     * The backend service or backend bucket to use when none of the given rules match.
     */
    public readonly defaultService: pulumi.Output<string>;
    /**
     * A brief description of this resource.
     */
    public readonly description: pulumi.Output<string | undefined>;
    /**
     * The unique fingerprint for this resource.
     */
    public /*out*/ readonly fingerprint: pulumi.Output<string>;
    /**
     * A list of host rules. Multiple blocks of this type are permitted. Structure is documented below.
     */
    public readonly hostRules: pulumi.Output<{ description?: string, hosts: string[], pathMatcher: string }[] | undefined>;
    /**
     * The GCE assigned ID of the resource.
     */
    public /*out*/ readonly mapId: pulumi.Output<number>;
    /**
     * A unique name for the resource, required by GCE.
     * Changing this forces a new resource to be created.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * A list of paths to match. Structure is documented below.
     */
    public readonly pathMatchers: pulumi.Output<{ defaultService: string, description?: string, name: string, pathRules?: { paths: string[], service: string }[] }[] | undefined>;
    /**
     * The ID of the project in which the resource belongs. If it
     * is not provided, the provider project is used.
     */
    public readonly project: pulumi.Output<string>;
    /**
     * The URI of the created resource.
     */
    public /*out*/ readonly selfLink: pulumi.Output<string>;
    /**
     * The test to perform.  Multiple blocks of this type are permitted. Structure is documented below.
     */
    public readonly tests: pulumi.Output<{ description?: string, host: string, path: string, service: string }[] | undefined>;

    /**
     * Create a URLMap resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: URLMapArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: URLMapArgs | URLMapState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: URLMapState = argsOrState as URLMapState | undefined;
            inputs["creationTimestamp"] = state ? state.creationTimestamp : undefined;
            inputs["defaultService"] = state ? state.defaultService : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["fingerprint"] = state ? state.fingerprint : undefined;
            inputs["hostRules"] = state ? state.hostRules : undefined;
            inputs["mapId"] = state ? state.mapId : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["pathMatchers"] = state ? state.pathMatchers : undefined;
            inputs["project"] = state ? state.project : undefined;
            inputs["selfLink"] = state ? state.selfLink : undefined;
            inputs["tests"] = state ? state.tests : undefined;
        } else {
            const args = argsOrState as URLMapArgs | undefined;
            if (!args || args.defaultService === undefined) {
                throw new Error("Missing required property 'defaultService'");
            }
            inputs["defaultService"] = args ? args.defaultService : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["hostRules"] = args ? args.hostRules : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["pathMatchers"] = args ? args.pathMatchers : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["tests"] = args ? args.tests : undefined;
            inputs["creationTimestamp"] = undefined /*out*/;
            inputs["fingerprint"] = undefined /*out*/;
            inputs["mapId"] = undefined /*out*/;
            inputs["selfLink"] = undefined /*out*/;
        }
        super("gcp:compute/uRLMap:URLMap", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering URLMap resources.
 */
export interface URLMapState {
    readonly creationTimestamp?: pulumi.Input<string>;
    /**
     * The backend service or backend bucket to use when none of the given rules match.
     */
    readonly defaultService?: pulumi.Input<string>;
    /**
     * A brief description of this resource.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * The unique fingerprint for this resource.
     */
    readonly fingerprint?: pulumi.Input<string>;
    /**
     * A list of host rules. Multiple blocks of this type are permitted. Structure is documented below.
     */
    readonly hostRules?: pulumi.Input<pulumi.Input<{ description?: pulumi.Input<string>, hosts: pulumi.Input<pulumi.Input<string>[]>, pathMatcher: pulumi.Input<string> }>[]>;
    /**
     * The GCE assigned ID of the resource.
     */
    readonly mapId?: pulumi.Input<number>;
    /**
     * A unique name for the resource, required by GCE.
     * Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A list of paths to match. Structure is documented below.
     */
    readonly pathMatchers?: pulumi.Input<pulumi.Input<{ defaultService: pulumi.Input<string>, description?: pulumi.Input<string>, name: pulumi.Input<string>, pathRules?: pulumi.Input<pulumi.Input<{ paths: pulumi.Input<pulumi.Input<string>[]>, service: pulumi.Input<string> }>[]> }>[]>;
    /**
     * The ID of the project in which the resource belongs. If it
     * is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    /**
     * The URI of the created resource.
     */
    readonly selfLink?: pulumi.Input<string>;
    /**
     * The test to perform.  Multiple blocks of this type are permitted. Structure is documented below.
     */
    readonly tests?: pulumi.Input<pulumi.Input<{ description?: pulumi.Input<string>, host: pulumi.Input<string>, path: pulumi.Input<string>, service: pulumi.Input<string> }>[]>;
}

/**
 * The set of arguments for constructing a URLMap resource.
 */
export interface URLMapArgs {
    /**
     * The backend service or backend bucket to use when none of the given rules match.
     */
    readonly defaultService: pulumi.Input<string>;
    /**
     * A brief description of this resource.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * A list of host rules. Multiple blocks of this type are permitted. Structure is documented below.
     */
    readonly hostRules?: pulumi.Input<pulumi.Input<{ description?: pulumi.Input<string>, hosts: pulumi.Input<pulumi.Input<string>[]>, pathMatcher: pulumi.Input<string> }>[]>;
    /**
     * A unique name for the resource, required by GCE.
     * Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A list of paths to match. Structure is documented below.
     */
    readonly pathMatchers?: pulumi.Input<pulumi.Input<{ defaultService: pulumi.Input<string>, description?: pulumi.Input<string>, name: pulumi.Input<string>, pathRules?: pulumi.Input<pulumi.Input<{ paths: pulumi.Input<pulumi.Input<string>[]>, service: pulumi.Input<string> }>[]> }>[]>;
    /**
     * The ID of the project in which the resource belongs. If it
     * is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    /**
     * The test to perform.  Multiple blocks of this type are permitted. Structure is documented below.
     */
    readonly tests?: pulumi.Input<pulumi.Input<{ description?: pulumi.Input<string>, host: pulumi.Input<string>, path: pulumi.Input<string>, service: pulumi.Input<string> }>[]>;
}
