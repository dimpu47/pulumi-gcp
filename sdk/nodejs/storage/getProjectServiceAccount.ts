// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Use this data source to get the email address of the project's Google Cloud Storage service account.
 *  For more information see 
 * [API](https://cloud.google.com/storage/docs/json_api/v1/projects/serviceAccount).
 */
export function getProjectServiceAccount(): Promise<GetProjectServiceAccountResult> {
    return pulumi.runtime.invoke("gcp:storage/getProjectServiceAccount:getProjectServiceAccount", {
    });
}

/**
 * A collection of values returned by getProjectServiceAccount.
 */
export interface GetProjectServiceAccountResult {
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
