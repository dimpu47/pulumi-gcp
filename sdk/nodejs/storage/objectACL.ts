// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Authoritatively manages the access control list (ACL) for an object in a Google
 * Cloud Storage (GCS) bucket. Removing a `google_storage_object_acl` sets the
 * acl to the `private` [predefined ACL](https://cloud.google.com/storage/docs/access-control#predefined-acl).
 * 
 * For more information see
 * [the official documentation](https://cloud.google.com/storage/docs/access-control/lists) 
 * and 
 * [API](https://cloud.google.com/storage/docs/json_api/v1/objectAccessControls).
 * 
 * > Want fine-grained control over object ACLs? Use `google_storage_object_access_control` to control individual
 * role entity pairs.
 * 
 * ## Example Usage
 * 
 * Create an object ACL with one owner and one reader.
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as gcp from "@pulumi/gcp";
 * 
 * const image_store = new gcp.storage.Bucket("image-store", {
 *     location: "EU",
 * });
 * const image = new gcp.storage.BucketObject("image", {
 *     bucket: image_store.name,
 *     source: new pulumi.asset.FileArchive("image1.jpg"),
 * });
 * const image_store_acl = new gcp.storage.ObjectACL("image-store-acl", {
 *     bucket: image_store.name,
 *     object: image.outputName,
 *     roleEntities: [
 *         "OWNER:user-my.email@gmail.com",
 *         "READER:group-mygroup",
 *     ],
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/storage_object_acl.html.markdown.
 */
export class ObjectACL extends pulumi.CustomResource {
    /**
     * Get an existing ObjectACL resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ObjectACLState, opts?: pulumi.CustomResourceOptions): ObjectACL {
        return new ObjectACL(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:storage/objectACL:ObjectACL';

    /**
     * Returns true if the given object is an instance of ObjectACL.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ObjectACL {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ObjectACL.__pulumiType;
    }

    /**
     * The name of the bucket the object is stored in.
     */
    public readonly bucket!: pulumi.Output<string>;
    /**
     * The name of the object to apply the acl to.
     */
    public readonly object!: pulumi.Output<string>;
    /**
     * The "canned" [predefined ACL](https://cloud.google.com/storage/docs/access-control#predefined-acl) to apply. Must be set if `role_entity` is not.
     */
    public readonly predefinedAcl!: pulumi.Output<string | undefined>;
    /**
     * List of role/entity pairs in the form `ROLE:entity`. See [GCS Object ACL documentation](https://cloud.google.com/storage/docs/json_api/v1/objectAccessControls) for more details.
     * Must be set if `predefined_acl` is not.
     */
    public readonly roleEntities!: pulumi.Output<string[]>;

    /**
     * Create a ObjectACL resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ObjectACLArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ObjectACLArgs | ObjectACLState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ObjectACLState | undefined;
            inputs["bucket"] = state ? state.bucket : undefined;
            inputs["object"] = state ? state.object : undefined;
            inputs["predefinedAcl"] = state ? state.predefinedAcl : undefined;
            inputs["roleEntities"] = state ? state.roleEntities : undefined;
        } else {
            const args = argsOrState as ObjectACLArgs | undefined;
            if (!args || args.bucket === undefined) {
                throw new Error("Missing required property 'bucket'");
            }
            if (!args || args.object === undefined) {
                throw new Error("Missing required property 'object'");
            }
            inputs["bucket"] = args ? args.bucket : undefined;
            inputs["object"] = args ? args.object : undefined;
            inputs["predefinedAcl"] = args ? args.predefinedAcl : undefined;
            inputs["roleEntities"] = args ? args.roleEntities : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(ObjectACL.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ObjectACL resources.
 */
export interface ObjectACLState {
    /**
     * The name of the bucket the object is stored in.
     */
    readonly bucket?: pulumi.Input<string>;
    /**
     * The name of the object to apply the acl to.
     */
    readonly object?: pulumi.Input<string>;
    /**
     * The "canned" [predefined ACL](https://cloud.google.com/storage/docs/access-control#predefined-acl) to apply. Must be set if `role_entity` is not.
     */
    readonly predefinedAcl?: pulumi.Input<string>;
    /**
     * List of role/entity pairs in the form `ROLE:entity`. See [GCS Object ACL documentation](https://cloud.google.com/storage/docs/json_api/v1/objectAccessControls) for more details.
     * Must be set if `predefined_acl` is not.
     */
    readonly roleEntities?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a ObjectACL resource.
 */
export interface ObjectACLArgs {
    /**
     * The name of the bucket the object is stored in.
     */
    readonly bucket: pulumi.Input<string>;
    /**
     * The name of the object to apply the acl to.
     */
    readonly object: pulumi.Input<string>;
    /**
     * The "canned" [predefined ACL](https://cloud.google.com/storage/docs/access-control#predefined-acl) to apply. Must be set if `role_entity` is not.
     */
    readonly predefinedAcl?: pulumi.Input<string>;
    /**
     * List of role/entity pairs in the form `ROLE:entity`. See [GCS Object ACL documentation](https://cloud.google.com/storage/docs/json_api/v1/objectAccessControls) for more details.
     * Must be set if `predefined_acl` is not.
     */
    readonly roleEntities?: pulumi.Input<pulumi.Input<string>[]>;
}
