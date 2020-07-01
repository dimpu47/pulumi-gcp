// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Three different resources help you manage your IAM policy for Healthcare FHIR store. Each of these resources serves a different use case:
 *
 * * `gcp.healthcare.FhirStoreIamPolicy`: Authoritative. Sets the IAM policy for the FHIR store and replaces any existing policy already attached.
 * * `gcp.healthcare.FhirStoreIamBinding`: Authoritative for a given role. Updates the IAM policy to grant a role to a list of members. Other roles within the IAM policy for the FHIR store are preserved.
 * * `gcp.healthcare.FhirStoreIamMember`: Non-authoritative. Updates the IAM policy to grant a role to a new member. Other members for the role for the FHIR store are preserved.
 *
 * > **Note:** `gcp.healthcare.FhirStoreIamPolicy` **cannot** be used in conjunction with `gcp.healthcare.FhirStoreIamBinding` and `gcp.healthcare.FhirStoreIamMember` or they will fight over what your policy should be.
 *
 * > **Note:** `gcp.healthcare.FhirStoreIamBinding` resources **can be** used in conjunction with `gcp.healthcare.FhirStoreIamMember` resources **only if** they do not grant privilege to the same role.
 */
export class FhirStoreIamPolicy extends pulumi.CustomResource {
    /**
     * Get an existing FhirStoreIamPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FhirStoreIamPolicyState, opts?: pulumi.CustomResourceOptions): FhirStoreIamPolicy {
        return new FhirStoreIamPolicy(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:healthcare/fhirStoreIamPolicy:FhirStoreIamPolicy';

    /**
     * Returns true if the given object is an instance of FhirStoreIamPolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FhirStoreIamPolicy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FhirStoreIamPolicy.__pulumiType;
    }

    /**
     * (Computed) The etag of the FHIR store's IAM policy.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * The FHIR store ID, in the form
     * `{project_id}/{location_name}/{dataset_name}/{fhir_store_name}` or
     * `{location_name}/{dataset_name}/{fhir_store_name}`. In the second form, the provider's
     * project setting will be used as a fallback.
     */
    public readonly fhirStoreId!: pulumi.Output<string>;
    /**
     * The policy data generated by
     * a `gcp.organizations.getIAMPolicy` data source.
     */
    public readonly policyData!: pulumi.Output<string>;

    /**
     * Create a FhirStoreIamPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FhirStoreIamPolicyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FhirStoreIamPolicyArgs | FhirStoreIamPolicyState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as FhirStoreIamPolicyState | undefined;
            inputs["etag"] = state ? state.etag : undefined;
            inputs["fhirStoreId"] = state ? state.fhirStoreId : undefined;
            inputs["policyData"] = state ? state.policyData : undefined;
        } else {
            const args = argsOrState as FhirStoreIamPolicyArgs | undefined;
            if (!args || args.fhirStoreId === undefined) {
                throw new Error("Missing required property 'fhirStoreId'");
            }
            if (!args || args.policyData === undefined) {
                throw new Error("Missing required property 'policyData'");
            }
            inputs["fhirStoreId"] = args ? args.fhirStoreId : undefined;
            inputs["policyData"] = args ? args.policyData : undefined;
            inputs["etag"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(FhirStoreIamPolicy.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering FhirStoreIamPolicy resources.
 */
export interface FhirStoreIamPolicyState {
    /**
     * (Computed) The etag of the FHIR store's IAM policy.
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * The FHIR store ID, in the form
     * `{project_id}/{location_name}/{dataset_name}/{fhir_store_name}` or
     * `{location_name}/{dataset_name}/{fhir_store_name}`. In the second form, the provider's
     * project setting will be used as a fallback.
     */
    readonly fhirStoreId?: pulumi.Input<string>;
    /**
     * The policy data generated by
     * a `gcp.organizations.getIAMPolicy` data source.
     */
    readonly policyData?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a FhirStoreIamPolicy resource.
 */
export interface FhirStoreIamPolicyArgs {
    /**
     * The FHIR store ID, in the form
     * `{project_id}/{location_name}/{dataset_name}/{fhir_store_name}` or
     * `{location_name}/{dataset_name}/{fhir_store_name}`. In the second form, the provider's
     * project setting will be used as a fallback.
     */
    readonly fhirStoreId: pulumi.Input<string>;
    /**
     * The policy data generated by
     * a `gcp.organizations.getIAMPolicy` data source.
     */
    readonly policyData: pulumi.Input<string>;
}
