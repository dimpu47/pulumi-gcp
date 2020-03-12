// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export class RegionHealthCheck extends pulumi.CustomResource {
    /**
     * Get an existing RegionHealthCheck resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RegionHealthCheckState, opts?: pulumi.CustomResourceOptions): RegionHealthCheck {
        return new RegionHealthCheck(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:compute/regionHealthCheck:RegionHealthCheck';

    /**
     * Returns true if the given object is an instance of RegionHealthCheck.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RegionHealthCheck {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RegionHealthCheck.__pulumiType;
    }

    /**
     * How often (in seconds) to send a health check. The default value is 5 seconds.
     */
    public readonly checkIntervalSec!: pulumi.Output<number | undefined>;
    /**
     * Creation timestamp in RFC3339 text format.
     */
    public /*out*/ readonly creationTimestamp!: pulumi.Output<string>;
    /**
     * An optional description of this resource. Provide this property when you create the resource.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * A so-far unhealthy instance will be marked healthy after this many consecutive successes. The default value is 2.
     */
    public readonly healthyThreshold!: pulumi.Output<number | undefined>;
    /**
     * A nested object resource
     */
    public readonly http2HealthCheck!: pulumi.Output<outputs.compute.RegionHealthCheckHttp2HealthCheck | undefined>;
    /**
     * A nested object resource
     */
    public readonly httpHealthCheck!: pulumi.Output<outputs.compute.RegionHealthCheckHttpHealthCheck | undefined>;
    /**
     * A nested object resource
     */
    public readonly httpsHealthCheck!: pulumi.Output<outputs.compute.RegionHealthCheckHttpsHealthCheck | undefined>;
    /**
     * Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long,
     * and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
     * '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following
     * characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    public readonly project!: pulumi.Output<string>;
    /**
     * The Region in which the created health check should reside. If it is not provided, the provider region is used.
     */
    public readonly region!: pulumi.Output<string>;
    /**
     * The URI of the created resource.
     */
    public /*out*/ readonly selfLink!: pulumi.Output<string>;
    /**
     * A nested object resource
     */
    public readonly sslHealthCheck!: pulumi.Output<outputs.compute.RegionHealthCheckSslHealthCheck | undefined>;
    /**
     * A nested object resource
     */
    public readonly tcpHealthCheck!: pulumi.Output<outputs.compute.RegionHealthCheckTcpHealthCheck | undefined>;
    /**
     * How long (in seconds) to wait before claiming failure. The default value is 5 seconds. It is invalid for timeoutSec
     * to have greater value than checkIntervalSec.
     */
    public readonly timeoutSec!: pulumi.Output<number | undefined>;
    /**
     * The type of the health check. One of HTTP, HTTP2, HTTPS, TCP, or SSL.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * A so-far healthy instance will be marked unhealthy after this many consecutive failures. The default value is 2.
     */
    public readonly unhealthyThreshold!: pulumi.Output<number | undefined>;

    /**
     * Create a RegionHealthCheck resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: RegionHealthCheckArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RegionHealthCheckArgs | RegionHealthCheckState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as RegionHealthCheckState | undefined;
            inputs["checkIntervalSec"] = state ? state.checkIntervalSec : undefined;
            inputs["creationTimestamp"] = state ? state.creationTimestamp : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["healthyThreshold"] = state ? state.healthyThreshold : undefined;
            inputs["http2HealthCheck"] = state ? state.http2HealthCheck : undefined;
            inputs["httpHealthCheck"] = state ? state.httpHealthCheck : undefined;
            inputs["httpsHealthCheck"] = state ? state.httpsHealthCheck : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["project"] = state ? state.project : undefined;
            inputs["region"] = state ? state.region : undefined;
            inputs["selfLink"] = state ? state.selfLink : undefined;
            inputs["sslHealthCheck"] = state ? state.sslHealthCheck : undefined;
            inputs["tcpHealthCheck"] = state ? state.tcpHealthCheck : undefined;
            inputs["timeoutSec"] = state ? state.timeoutSec : undefined;
            inputs["type"] = state ? state.type : undefined;
            inputs["unhealthyThreshold"] = state ? state.unhealthyThreshold : undefined;
        } else {
            const args = argsOrState as RegionHealthCheckArgs | undefined;
            inputs["checkIntervalSec"] = args ? args.checkIntervalSec : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["healthyThreshold"] = args ? args.healthyThreshold : undefined;
            inputs["http2HealthCheck"] = args ? args.http2HealthCheck : undefined;
            inputs["httpHealthCheck"] = args ? args.httpHealthCheck : undefined;
            inputs["httpsHealthCheck"] = args ? args.httpsHealthCheck : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["region"] = args ? args.region : undefined;
            inputs["sslHealthCheck"] = args ? args.sslHealthCheck : undefined;
            inputs["tcpHealthCheck"] = args ? args.tcpHealthCheck : undefined;
            inputs["timeoutSec"] = args ? args.timeoutSec : undefined;
            inputs["unhealthyThreshold"] = args ? args.unhealthyThreshold : undefined;
            inputs["creationTimestamp"] = undefined /*out*/;
            inputs["selfLink"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(RegionHealthCheck.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RegionHealthCheck resources.
 */
export interface RegionHealthCheckState {
    /**
     * How often (in seconds) to send a health check. The default value is 5 seconds.
     */
    readonly checkIntervalSec?: pulumi.Input<number>;
    /**
     * Creation timestamp in RFC3339 text format.
     */
    readonly creationTimestamp?: pulumi.Input<string>;
    /**
     * An optional description of this resource. Provide this property when you create the resource.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * A so-far unhealthy instance will be marked healthy after this many consecutive successes. The default value is 2.
     */
    readonly healthyThreshold?: pulumi.Input<number>;
    /**
     * A nested object resource
     */
    readonly http2HealthCheck?: pulumi.Input<inputs.compute.RegionHealthCheckHttp2HealthCheck>;
    /**
     * A nested object resource
     */
    readonly httpHealthCheck?: pulumi.Input<inputs.compute.RegionHealthCheckHttpHealthCheck>;
    /**
     * A nested object resource
     */
    readonly httpsHealthCheck?: pulumi.Input<inputs.compute.RegionHealthCheckHttpsHealthCheck>;
    /**
     * Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long,
     * and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
     * '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following
     * characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    /**
     * The Region in which the created health check should reside. If it is not provided, the provider region is used.
     */
    readonly region?: pulumi.Input<string>;
    /**
     * The URI of the created resource.
     */
    readonly selfLink?: pulumi.Input<string>;
    /**
     * A nested object resource
     */
    readonly sslHealthCheck?: pulumi.Input<inputs.compute.RegionHealthCheckSslHealthCheck>;
    /**
     * A nested object resource
     */
    readonly tcpHealthCheck?: pulumi.Input<inputs.compute.RegionHealthCheckTcpHealthCheck>;
    /**
     * How long (in seconds) to wait before claiming failure. The default value is 5 seconds. It is invalid for timeoutSec
     * to have greater value than checkIntervalSec.
     */
    readonly timeoutSec?: pulumi.Input<number>;
    /**
     * The type of the health check. One of HTTP, HTTP2, HTTPS, TCP, or SSL.
     */
    readonly type?: pulumi.Input<string>;
    /**
     * A so-far healthy instance will be marked unhealthy after this many consecutive failures. The default value is 2.
     */
    readonly unhealthyThreshold?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a RegionHealthCheck resource.
 */
export interface RegionHealthCheckArgs {
    /**
     * How often (in seconds) to send a health check. The default value is 5 seconds.
     */
    readonly checkIntervalSec?: pulumi.Input<number>;
    /**
     * An optional description of this resource. Provide this property when you create the resource.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * A so-far unhealthy instance will be marked healthy after this many consecutive successes. The default value is 2.
     */
    readonly healthyThreshold?: pulumi.Input<number>;
    /**
     * A nested object resource
     */
    readonly http2HealthCheck?: pulumi.Input<inputs.compute.RegionHealthCheckHttp2HealthCheck>;
    /**
     * A nested object resource
     */
    readonly httpHealthCheck?: pulumi.Input<inputs.compute.RegionHealthCheckHttpHealthCheck>;
    /**
     * A nested object resource
     */
    readonly httpsHealthCheck?: pulumi.Input<inputs.compute.RegionHealthCheckHttpsHealthCheck>;
    /**
     * Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long,
     * and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
     * '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following
     * characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    /**
     * The Region in which the created health check should reside. If it is not provided, the provider region is used.
     */
    readonly region?: pulumi.Input<string>;
    /**
     * A nested object resource
     */
    readonly sslHealthCheck?: pulumi.Input<inputs.compute.RegionHealthCheckSslHealthCheck>;
    /**
     * A nested object resource
     */
    readonly tcpHealthCheck?: pulumi.Input<inputs.compute.RegionHealthCheckTcpHealthCheck>;
    /**
     * How long (in seconds) to wait before claiming failure. The default value is 5 seconds. It is invalid for timeoutSec
     * to have greater value than checkIntervalSec.
     */
    readonly timeoutSec?: pulumi.Input<number>;
    /**
     * A so-far healthy instance will be marked unhealthy after this many consecutive failures. The default value is 2.
     */
    readonly unhealthyThreshold?: pulumi.Input<number>;
}
