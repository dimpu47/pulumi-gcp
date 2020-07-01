// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to access a Network Endpoint Group's attributes.
 *
 * The NEG may be found by providing either a `selfLink`, or a `name` and a `zone`.
 */
export function getNetworkEndpointGroup(args?: GetNetworkEndpointGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetNetworkEndpointGroupResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("gcp:compute/getNetworkEndpointGroup:getNetworkEndpointGroup", {
        "name": args.name,
        "selfLink": args.selfLink,
        "zone": args.zone,
    }, opts);
}

/**
 * A collection of arguments for invoking getNetworkEndpointGroup.
 */
export interface GetNetworkEndpointGroupArgs {
    /**
     * The Network Endpoint Group name.
     * Provide either this or a `selfLink`.
     */
    readonly name?: string;
    /**
     * The Network Endpoint Group self\_link.
     */
    readonly selfLink?: string;
    /**
     * The Network Endpoint Group availability zone.
     */
    readonly zone?: string;
}

/**
 * A collection of values returned by getNetworkEndpointGroup.
 */
export interface GetNetworkEndpointGroupResult {
    /**
     * The NEG default port.
     */
    readonly defaultPort: number;
    /**
     * The NEG description.
     */
    readonly description: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name?: string;
    /**
     * The network to which all network endpoints in the NEG belong.
     */
    readonly network: string;
    /**
     * Type of network endpoints in this network endpoint group.
     */
    readonly networkEndpointType: string;
    readonly project: string;
    readonly selfLink?: string;
    /**
     * Number of network endpoints in the network endpoint group.
     */
    readonly size: number;
    /**
     * subnetwork to which all network endpoints in the NEG belong.
     */
    readonly subnetwork: string;
    readonly zone?: string;
}
