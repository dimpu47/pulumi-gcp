// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to retrieve default service account for this project
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as gcp from "@pulumi/gcp";
 * 
 * const defaultDefaultServiceAccount = gcp.bigquery.getDefaultServiceAccount();
 * 
 * export const defaultAccount = defaultDefaultServiceAccount.email;
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/d/google_bigquery_default_service_account.html.markdown.
 */
export function getDefaultServiceAccount(args?: GetDefaultServiceAccountArgs, opts?: pulumi.InvokeOptions): Promise<GetDefaultServiceAccountResult> & GetDefaultServiceAccountResult {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    const promise: Promise<GetDefaultServiceAccountResult> = pulumi.runtime.invoke("gcp:bigquery/getDefaultServiceAccount:getDefaultServiceAccount", {
        "project": args.project,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getDefaultServiceAccount.
 */
export interface GetDefaultServiceAccountArgs {
    /**
     * The project ID. If it is not provided, the provider project is used.
     */
    readonly project?: string;
}

/**
 * A collection of values returned by getDefaultServiceAccount.
 */
export interface GetDefaultServiceAccountResult {
    /**
     * Email address of the default service account used by bigquery encryption in this project
     */
    readonly email: string;
    readonly project: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
