// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * A Region Backend Service defines a regionally-scoped group of virtual machines that will serve traffic for load balancing.
 * For more information see [the official documentation](https://cloud.google.com/compute/docs/load-balancing/internal/)
 * and [API](https://cloud.google.com/compute/docs/reference/latest/regionBackendServices).
 */
export class RegionBackendService extends pulumi.CustomResource {
    /**
     * Get an existing RegionBackendService resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RegionBackendServiceState): RegionBackendService {
        return new RegionBackendService(name, <any>state, { id });
    }

    /**
     * The list of backends that serve this BackendService.
     * Structure is documented below.
     */
    public readonly backends: pulumi.Output<{ description?: string, group?: string }[] | undefined>;
    /**
     * Time for which instance will be drained
     * (not accept new connections, but still work to finish started ones). Defaults to `0`.
     */
    public readonly connectionDrainingTimeoutSec: pulumi.Output<number | undefined>;
    /**
     * Textual description for the backend.
     */
    public readonly description: pulumi.Output<string | undefined>;
    /**
     * The fingerprint of the backend service.
     */
    public /*out*/ readonly fingerprint: pulumi.Output<string>;
    /**
     * Specifies a list of health checks
     * for checking the health of the backend service. Currently at most
     * one health check can be specified, and a health check is required.
     */
    public readonly healthChecks: pulumi.Output<string>;
    /**
     * The name of the backend service.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * The ID of the project in which the resource belongs. If it
     * is not provided, the provider project is used.
     */
    public readonly project: pulumi.Output<string>;
    /**
     * The protocol for incoming requests. Defaults to
     * `HTTP`.
     */
    public readonly protocol: pulumi.Output<string>;
    /**
     * The Region in which the created address should reside.
     * If it is not provided, the provider region is used.
     */
    public readonly region: pulumi.Output<string>;
    /**
     * The URI of the created resource.
     */
    public /*out*/ readonly selfLink: pulumi.Output<string>;
    /**
     * How to distribute load. Options are `NONE` (no
     * affinity), `CLIENT_IP`, `CLIENT_IP_PROTO`, or `CLIENT_IP_PORT_PROTO`.
     * Defaults to `NONE`.
     */
    public readonly sessionAffinity: pulumi.Output<string>;
    /**
     * The number of secs to wait for a backend to respond
     * to a request before considering the request failed. Defaults to `30`.
     */
    public readonly timeoutSec: pulumi.Output<number>;

    /**
     * Create a RegionBackendService resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RegionBackendServiceArgs, opts?: pulumi.ResourceOptions)
    constructor(name: string, argsOrState?: RegionBackendServiceArgs | RegionBackendServiceState, opts?: pulumi.ResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: RegionBackendServiceState = argsOrState as RegionBackendServiceState | undefined;
            inputs["backends"] = state ? state.backends : undefined;
            inputs["connectionDrainingTimeoutSec"] = state ? state.connectionDrainingTimeoutSec : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["fingerprint"] = state ? state.fingerprint : undefined;
            inputs["healthChecks"] = state ? state.healthChecks : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["project"] = state ? state.project : undefined;
            inputs["protocol"] = state ? state.protocol : undefined;
            inputs["region"] = state ? state.region : undefined;
            inputs["selfLink"] = state ? state.selfLink : undefined;
            inputs["sessionAffinity"] = state ? state.sessionAffinity : undefined;
            inputs["timeoutSec"] = state ? state.timeoutSec : undefined;
        } else {
            const args = argsOrState as RegionBackendServiceArgs | undefined;
            if (!args || args.healthChecks === undefined) {
                throw new Error("Missing required property 'healthChecks'");
            }
            inputs["backends"] = args ? args.backends : undefined;
            inputs["connectionDrainingTimeoutSec"] = args ? args.connectionDrainingTimeoutSec : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["healthChecks"] = args ? args.healthChecks : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["protocol"] = args ? args.protocol : undefined;
            inputs["region"] = args ? args.region : undefined;
            inputs["sessionAffinity"] = args ? args.sessionAffinity : undefined;
            inputs["timeoutSec"] = args ? args.timeoutSec : undefined;
            inputs["fingerprint"] = undefined /*out*/;
            inputs["selfLink"] = undefined /*out*/;
        }
        super("gcp:compute/regionBackendService:RegionBackendService", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RegionBackendService resources.
 */
export interface RegionBackendServiceState {
    /**
     * The list of backends that serve this BackendService.
     * Structure is documented below.
     */
    readonly backends?: pulumi.Input<{ description?: pulumi.Input<string>, group?: pulumi.Input<string> }[]>;
    /**
     * Time for which instance will be drained
     * (not accept new connections, but still work to finish started ones). Defaults to `0`.
     */
    readonly connectionDrainingTimeoutSec?: pulumi.Input<number>;
    /**
     * Textual description for the backend.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * The fingerprint of the backend service.
     */
    readonly fingerprint?: pulumi.Input<string>;
    /**
     * Specifies a list of health checks
     * for checking the health of the backend service. Currently at most
     * one health check can be specified, and a health check is required.
     */
    readonly healthChecks?: pulumi.Input<pulumi.Input<string>>;
    /**
     * The name of the backend service.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs. If it
     * is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    /**
     * The protocol for incoming requests. Defaults to
     * `HTTP`.
     */
    readonly protocol?: pulumi.Input<string>;
    /**
     * The Region in which the created address should reside.
     * If it is not provided, the provider region is used.
     */
    readonly region?: pulumi.Input<string>;
    /**
     * The URI of the created resource.
     */
    readonly selfLink?: pulumi.Input<string>;
    /**
     * How to distribute load. Options are `NONE` (no
     * affinity), `CLIENT_IP`, `CLIENT_IP_PROTO`, or `CLIENT_IP_PORT_PROTO`.
     * Defaults to `NONE`.
     */
    readonly sessionAffinity?: pulumi.Input<string>;
    /**
     * The number of secs to wait for a backend to respond
     * to a request before considering the request failed. Defaults to `30`.
     */
    readonly timeoutSec?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a RegionBackendService resource.
 */
export interface RegionBackendServiceArgs {
    /**
     * The list of backends that serve this BackendService.
     * Structure is documented below.
     */
    readonly backends?: pulumi.Input<{ description?: pulumi.Input<string>, group?: pulumi.Input<string> }[]>;
    /**
     * Time for which instance will be drained
     * (not accept new connections, but still work to finish started ones). Defaults to `0`.
     */
    readonly connectionDrainingTimeoutSec?: pulumi.Input<number>;
    /**
     * Textual description for the backend.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Specifies a list of health checks
     * for checking the health of the backend service. Currently at most
     * one health check can be specified, and a health check is required.
     */
    readonly healthChecks: pulumi.Input<pulumi.Input<string>>;
    /**
     * The name of the backend service.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs. If it
     * is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    /**
     * The protocol for incoming requests. Defaults to
     * `HTTP`.
     */
    readonly protocol?: pulumi.Input<string>;
    /**
     * The Region in which the created address should reside.
     * If it is not provided, the provider region is used.
     */
    readonly region?: pulumi.Input<string>;
    /**
     * How to distribute load. Options are `NONE` (no
     * affinity), `CLIENT_IP`, `CLIENT_IP_PROTO`, or `CLIENT_IP_PORT_PROTO`.
     * Defaults to `NONE`.
     */
    readonly sessionAffinity?: pulumi.Input<string>;
    /**
     * The number of secs to wait for a backend to respond
     * to a request before considering the request failed. Defaults to `30`.
     */
    readonly timeoutSec?: pulumi.Input<number>;
}