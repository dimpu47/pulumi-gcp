// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Persistent disks are durable storage devices that function similarly to
 * the physical disks in a desktop or a server. Compute Engine manages the
 * hardware behind these devices to ensure data redundancy and optimize
 * performance for you. Persistent disks are available as either standard
 * hard disk drives (HDD) or solid-state drives (SSD).
 *
 * Persistent disks are located independently from your virtual machine
 * instances, so you can detach or move persistent disks to keep your data
 * even after you delete your instances. Persistent disk performance scales
 * automatically with size, so you can resize your existing persistent disks
 * or add more persistent disks to an instance to meet your performance and
 * storage space requirements.
 *
 * Add a persistent disk to your instance when you need reliable and
 * affordable storage with consistent performance characteristics.
 *
 * To get more information about Disk, see:
 *
 * * [API documentation](https://cloud.google.com/compute/docs/reference/v1/disks)
 * * How-to Guides
 *     * [Adding a persistent disk](https://cloud.google.com/compute/docs/disks/add-persistent-disk)
 *
 * > **Warning:** All arguments including `disk_encryption_key.raw_key` will be stored in the raw
 * state as plain-text. [Read more about secrets in state](https://www.pulumi.com/docs/intro/concepts/programming-model/#secrets).
 *
 * ## Example Usage
 */
export class Disk extends pulumi.CustomResource {
    /**
     * Get an existing Disk resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DiskState, opts?: pulumi.CustomResourceOptions): Disk {
        return new Disk(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:compute/disk:Disk';

    /**
     * Returns true if the given object is an instance of Disk.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Disk {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Disk.__pulumiType;
    }

    /**
     * Creation timestamp in RFC3339 text format.
     */
    public /*out*/ readonly creationTimestamp!: pulumi.Output<string>;
    /**
     * An optional description of this resource. Provide this property when
     * you create the resource.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Encrypts the disk using a customer-supplied encryption key.
     * After you encrypt a disk with a customer-supplied key, you must
     * provide the same key if you use the disk later (e.g. to create a disk
     * snapshot or an image, or to attach the disk to a virtual machine).
     * Customer-supplied encryption keys do not protect access to metadata of
     * the disk.
     * If you do not provide an encryption key when creating the disk, then
     * the disk will be encrypted using an automatically generated key and
     * you do not need to provide a key to use the disk later.  Structure is documented below.
     */
    public readonly diskEncryptionKey!: pulumi.Output<outputs.compute.DiskDiskEncryptionKey | undefined>;
    /**
     * The image from which to initialize this disk. This can be
     * one of: the image's `selfLink`, `projects/{project}/global/images/{image}`,
     * `projects/{project}/global/images/family/{family}`, `global/images/{image}`,
     * `global/images/family/{family}`, `family/{family}`, `{project}/{family}`,
     * `{project}/{image}`, `{family}`, or `{image}`. If referred by family, the
     * images names must include the family name. If they don't, use the
     * [gcp.compute.Image data source](https://www.terraform.io/docs/providers/google/d/datasource_compute_image.html).
     * For instance, the image `centos-6-v20180104` includes its family name `centos-6`.
     * These images can be referred by family name here.
     */
    public readonly image!: pulumi.Output<string | undefined>;
    /**
     * The fingerprint used for optimistic locking of this resource. Used internally during updates.
     */
    public /*out*/ readonly labelFingerprint!: pulumi.Output<string>;
    /**
     * Labels to apply to this disk.  A list of key->value pairs.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Last attach timestamp in RFC3339 text format.
     */
    public /*out*/ readonly lastAttachTimestamp!: pulumi.Output<string>;
    /**
     * Last detach timestamp in RFC3339 text format.
     */
    public /*out*/ readonly lastDetachTimestamp!: pulumi.Output<string>;
    /**
     * Name of the resource. Provided by the client when the resource is
     * created. The name must be 1-63 characters long, and comply with
     * RFC1035. Specifically, the name must be 1-63 characters long and match
     * the regular expression `a-z?` which means the
     * first character must be a lowercase letter, and all following
     * characters must be a dash, lowercase letter, or digit, except the last
     * character, which cannot be a dash.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Physical block size of the persistent disk, in bytes. If not present
     * in a request, a default value is used. Currently supported sizes
     * are 4096 and 16384, other sizes may be added in the future.
     * If an unsupported value is requested, the error message will list
     * the supported values for the caller's project.
     */
    public readonly physicalBlockSizeBytes!: pulumi.Output<number>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    public readonly project!: pulumi.Output<string>;
    /**
     * Resource policies applied to this disk for automatic snapshot creations. ~>**NOTE** This value does not support updating
     * the resource policy, as resource policies can not be updated more than one at a time. Use
     * ['google_compute_disk_resource_policy_attachment'](https://www.terraform.io/docs/providers/google/r/compute_disk_resource_policy_attachment.html)
     * to allow for updating the resource policy attached to the disk.
     */
    public readonly resourcePolicies!: pulumi.Output<string[]>;
    /**
     * The URI of the created resource.
     */
    public /*out*/ readonly selfLink!: pulumi.Output<string>;
    /**
     * Size of the persistent disk, specified in GB. You can specify this
     * field when creating a persistent disk using the `image` or
     * `snapshot` parameter, or specify it alone to create an empty
     * persistent disk.
     * If you specify this field along with `image` or `snapshot`,
     * the value must not be less than the size of the image
     * or the size of the snapshot.
     */
    public readonly size!: pulumi.Output<number>;
    /**
     * The source snapshot used to create this disk. You can provide this as
     * a partial or full URL to the resource. If the snapshot is in another
     * project than this disk, you must supply a full URL. For example, the
     * following are valid values:
     * * `https://www.googleapis.com/compute/v1/projects/project/global/snapshots/snapshot`
     * * `projects/project/global/snapshots/snapshot`
     * * `global/snapshots/snapshot`
     * * `snapshot`
     */
    public readonly snapshot!: pulumi.Output<string | undefined>;
    /**
     * The customer-supplied encryption key of the source image. Required if
     * the source image is protected by a customer-supplied encryption key.  Structure is documented below.
     */
    public readonly sourceImageEncryptionKey!: pulumi.Output<outputs.compute.DiskSourceImageEncryptionKey | undefined>;
    /**
     * The ID value of the image used to create this disk. This value identifies the exact image that was used to create this
     * persistent disk. For example, if you created the persistent disk from an image that was later deleted and recreated
     * under the same name, the source image ID would identify the exact version of the image that was used.
     */
    public /*out*/ readonly sourceImageId!: pulumi.Output<string>;
    /**
     * The customer-supplied encryption key of the source snapshot. Required
     * if the source snapshot is protected by a customer-supplied encryption
     * key.  Structure is documented below.
     */
    public readonly sourceSnapshotEncryptionKey!: pulumi.Output<outputs.compute.DiskSourceSnapshotEncryptionKey | undefined>;
    /**
     * The unique ID of the snapshot used to create this disk. This value identifies the exact snapshot that was used to create
     * this persistent disk. For example, if you created the persistent disk from a snapshot that was later deleted and
     * recreated under the same name, the source snapshot ID would identify the exact version of the snapshot that was used.
     */
    public /*out*/ readonly sourceSnapshotId!: pulumi.Output<string>;
    /**
     * URL of the disk type resource describing which disk type to use to
     * create the disk. Provide this when creating the disk.
     */
    public readonly type!: pulumi.Output<string | undefined>;
    /**
     * Links to the users of the disk (attached instances) in form: project/zones/zone/instances/instance
     */
    public /*out*/ readonly users!: pulumi.Output<string[]>;
    /**
     * A reference to the zone where the disk resides.
     */
    public readonly zone!: pulumi.Output<string>;

    /**
     * Create a Disk resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: DiskArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DiskArgs | DiskState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as DiskState | undefined;
            inputs["creationTimestamp"] = state ? state.creationTimestamp : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["diskEncryptionKey"] = state ? state.diskEncryptionKey : undefined;
            inputs["image"] = state ? state.image : undefined;
            inputs["labelFingerprint"] = state ? state.labelFingerprint : undefined;
            inputs["labels"] = state ? state.labels : undefined;
            inputs["lastAttachTimestamp"] = state ? state.lastAttachTimestamp : undefined;
            inputs["lastDetachTimestamp"] = state ? state.lastDetachTimestamp : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["physicalBlockSizeBytes"] = state ? state.physicalBlockSizeBytes : undefined;
            inputs["project"] = state ? state.project : undefined;
            inputs["resourcePolicies"] = state ? state.resourcePolicies : undefined;
            inputs["selfLink"] = state ? state.selfLink : undefined;
            inputs["size"] = state ? state.size : undefined;
            inputs["snapshot"] = state ? state.snapshot : undefined;
            inputs["sourceImageEncryptionKey"] = state ? state.sourceImageEncryptionKey : undefined;
            inputs["sourceImageId"] = state ? state.sourceImageId : undefined;
            inputs["sourceSnapshotEncryptionKey"] = state ? state.sourceSnapshotEncryptionKey : undefined;
            inputs["sourceSnapshotId"] = state ? state.sourceSnapshotId : undefined;
            inputs["type"] = state ? state.type : undefined;
            inputs["users"] = state ? state.users : undefined;
            inputs["zone"] = state ? state.zone : undefined;
        } else {
            const args = argsOrState as DiskArgs | undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["diskEncryptionKey"] = args ? args.diskEncryptionKey : undefined;
            inputs["image"] = args ? args.image : undefined;
            inputs["labels"] = args ? args.labels : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["physicalBlockSizeBytes"] = args ? args.physicalBlockSizeBytes : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["resourcePolicies"] = args ? args.resourcePolicies : undefined;
            inputs["size"] = args ? args.size : undefined;
            inputs["snapshot"] = args ? args.snapshot : undefined;
            inputs["sourceImageEncryptionKey"] = args ? args.sourceImageEncryptionKey : undefined;
            inputs["sourceSnapshotEncryptionKey"] = args ? args.sourceSnapshotEncryptionKey : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["zone"] = args ? args.zone : undefined;
            inputs["creationTimestamp"] = undefined /*out*/;
            inputs["labelFingerprint"] = undefined /*out*/;
            inputs["lastAttachTimestamp"] = undefined /*out*/;
            inputs["lastDetachTimestamp"] = undefined /*out*/;
            inputs["selfLink"] = undefined /*out*/;
            inputs["sourceImageId"] = undefined /*out*/;
            inputs["sourceSnapshotId"] = undefined /*out*/;
            inputs["users"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Disk.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Disk resources.
 */
export interface DiskState {
    /**
     * Creation timestamp in RFC3339 text format.
     */
    readonly creationTimestamp?: pulumi.Input<string>;
    /**
     * An optional description of this resource. Provide this property when
     * you create the resource.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Encrypts the disk using a customer-supplied encryption key.
     * After you encrypt a disk with a customer-supplied key, you must
     * provide the same key if you use the disk later (e.g. to create a disk
     * snapshot or an image, or to attach the disk to a virtual machine).
     * Customer-supplied encryption keys do not protect access to metadata of
     * the disk.
     * If you do not provide an encryption key when creating the disk, then
     * the disk will be encrypted using an automatically generated key and
     * you do not need to provide a key to use the disk later.  Structure is documented below.
     */
    readonly diskEncryptionKey?: pulumi.Input<inputs.compute.DiskDiskEncryptionKey>;
    /**
     * The image from which to initialize this disk. This can be
     * one of: the image's `selfLink`, `projects/{project}/global/images/{image}`,
     * `projects/{project}/global/images/family/{family}`, `global/images/{image}`,
     * `global/images/family/{family}`, `family/{family}`, `{project}/{family}`,
     * `{project}/{image}`, `{family}`, or `{image}`. If referred by family, the
     * images names must include the family name. If they don't, use the
     * [gcp.compute.Image data source](https://www.terraform.io/docs/providers/google/d/datasource_compute_image.html).
     * For instance, the image `centos-6-v20180104` includes its family name `centos-6`.
     * These images can be referred by family name here.
     */
    readonly image?: pulumi.Input<string>;
    /**
     * The fingerprint used for optimistic locking of this resource. Used internally during updates.
     */
    readonly labelFingerprint?: pulumi.Input<string>;
    /**
     * Labels to apply to this disk.  A list of key->value pairs.
     */
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Last attach timestamp in RFC3339 text format.
     */
    readonly lastAttachTimestamp?: pulumi.Input<string>;
    /**
     * Last detach timestamp in RFC3339 text format.
     */
    readonly lastDetachTimestamp?: pulumi.Input<string>;
    /**
     * Name of the resource. Provided by the client when the resource is
     * created. The name must be 1-63 characters long, and comply with
     * RFC1035. Specifically, the name must be 1-63 characters long and match
     * the regular expression `a-z?` which means the
     * first character must be a lowercase letter, and all following
     * characters must be a dash, lowercase letter, or digit, except the last
     * character, which cannot be a dash.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Physical block size of the persistent disk, in bytes. If not present
     * in a request, a default value is used. Currently supported sizes
     * are 4096 and 16384, other sizes may be added in the future.
     * If an unsupported value is requested, the error message will list
     * the supported values for the caller's project.
     */
    readonly physicalBlockSizeBytes?: pulumi.Input<number>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    /**
     * Resource policies applied to this disk for automatic snapshot creations. ~>**NOTE** This value does not support updating
     * the resource policy, as resource policies can not be updated more than one at a time. Use
     * ['google_compute_disk_resource_policy_attachment'](https://www.terraform.io/docs/providers/google/r/compute_disk_resource_policy_attachment.html)
     * to allow for updating the resource policy attached to the disk.
     */
    readonly resourcePolicies?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The URI of the created resource.
     */
    readonly selfLink?: pulumi.Input<string>;
    /**
     * Size of the persistent disk, specified in GB. You can specify this
     * field when creating a persistent disk using the `image` or
     * `snapshot` parameter, or specify it alone to create an empty
     * persistent disk.
     * If you specify this field along with `image` or `snapshot`,
     * the value must not be less than the size of the image
     * or the size of the snapshot.
     */
    readonly size?: pulumi.Input<number>;
    /**
     * The source snapshot used to create this disk. You can provide this as
     * a partial or full URL to the resource. If the snapshot is in another
     * project than this disk, you must supply a full URL. For example, the
     * following are valid values:
     * * `https://www.googleapis.com/compute/v1/projects/project/global/snapshots/snapshot`
     * * `projects/project/global/snapshots/snapshot`
     * * `global/snapshots/snapshot`
     * * `snapshot`
     */
    readonly snapshot?: pulumi.Input<string>;
    /**
     * The customer-supplied encryption key of the source image. Required if
     * the source image is protected by a customer-supplied encryption key.  Structure is documented below.
     */
    readonly sourceImageEncryptionKey?: pulumi.Input<inputs.compute.DiskSourceImageEncryptionKey>;
    /**
     * The ID value of the image used to create this disk. This value identifies the exact image that was used to create this
     * persistent disk. For example, if you created the persistent disk from an image that was later deleted and recreated
     * under the same name, the source image ID would identify the exact version of the image that was used.
     */
    readonly sourceImageId?: pulumi.Input<string>;
    /**
     * The customer-supplied encryption key of the source snapshot. Required
     * if the source snapshot is protected by a customer-supplied encryption
     * key.  Structure is documented below.
     */
    readonly sourceSnapshotEncryptionKey?: pulumi.Input<inputs.compute.DiskSourceSnapshotEncryptionKey>;
    /**
     * The unique ID of the snapshot used to create this disk. This value identifies the exact snapshot that was used to create
     * this persistent disk. For example, if you created the persistent disk from a snapshot that was later deleted and
     * recreated under the same name, the source snapshot ID would identify the exact version of the snapshot that was used.
     */
    readonly sourceSnapshotId?: pulumi.Input<string>;
    /**
     * URL of the disk type resource describing which disk type to use to
     * create the disk. Provide this when creating the disk.
     */
    readonly type?: pulumi.Input<string>;
    /**
     * Links to the users of the disk (attached instances) in form: project/zones/zone/instances/instance
     */
    readonly users?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A reference to the zone where the disk resides.
     */
    readonly zone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Disk resource.
 */
export interface DiskArgs {
    /**
     * An optional description of this resource. Provide this property when
     * you create the resource.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Encrypts the disk using a customer-supplied encryption key.
     * After you encrypt a disk with a customer-supplied key, you must
     * provide the same key if you use the disk later (e.g. to create a disk
     * snapshot or an image, or to attach the disk to a virtual machine).
     * Customer-supplied encryption keys do not protect access to metadata of
     * the disk.
     * If you do not provide an encryption key when creating the disk, then
     * the disk will be encrypted using an automatically generated key and
     * you do not need to provide a key to use the disk later.  Structure is documented below.
     */
    readonly diskEncryptionKey?: pulumi.Input<inputs.compute.DiskDiskEncryptionKey>;
    /**
     * The image from which to initialize this disk. This can be
     * one of: the image's `selfLink`, `projects/{project}/global/images/{image}`,
     * `projects/{project}/global/images/family/{family}`, `global/images/{image}`,
     * `global/images/family/{family}`, `family/{family}`, `{project}/{family}`,
     * `{project}/{image}`, `{family}`, or `{image}`. If referred by family, the
     * images names must include the family name. If they don't, use the
     * [gcp.compute.Image data source](https://www.terraform.io/docs/providers/google/d/datasource_compute_image.html).
     * For instance, the image `centos-6-v20180104` includes its family name `centos-6`.
     * These images can be referred by family name here.
     */
    readonly image?: pulumi.Input<string>;
    /**
     * Labels to apply to this disk.  A list of key->value pairs.
     */
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Name of the resource. Provided by the client when the resource is
     * created. The name must be 1-63 characters long, and comply with
     * RFC1035. Specifically, the name must be 1-63 characters long and match
     * the regular expression `a-z?` which means the
     * first character must be a lowercase letter, and all following
     * characters must be a dash, lowercase letter, or digit, except the last
     * character, which cannot be a dash.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Physical block size of the persistent disk, in bytes. If not present
     * in a request, a default value is used. Currently supported sizes
     * are 4096 and 16384, other sizes may be added in the future.
     * If an unsupported value is requested, the error message will list
     * the supported values for the caller's project.
     */
    readonly physicalBlockSizeBytes?: pulumi.Input<number>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    /**
     * Resource policies applied to this disk for automatic snapshot creations. ~>**NOTE** This value does not support updating
     * the resource policy, as resource policies can not be updated more than one at a time. Use
     * ['google_compute_disk_resource_policy_attachment'](https://www.terraform.io/docs/providers/google/r/compute_disk_resource_policy_attachment.html)
     * to allow for updating the resource policy attached to the disk.
     */
    readonly resourcePolicies?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Size of the persistent disk, specified in GB. You can specify this
     * field when creating a persistent disk using the `image` or
     * `snapshot` parameter, or specify it alone to create an empty
     * persistent disk.
     * If you specify this field along with `image` or `snapshot`,
     * the value must not be less than the size of the image
     * or the size of the snapshot.
     */
    readonly size?: pulumi.Input<number>;
    /**
     * The source snapshot used to create this disk. You can provide this as
     * a partial or full URL to the resource. If the snapshot is in another
     * project than this disk, you must supply a full URL. For example, the
     * following are valid values:
     * * `https://www.googleapis.com/compute/v1/projects/project/global/snapshots/snapshot`
     * * `projects/project/global/snapshots/snapshot`
     * * `global/snapshots/snapshot`
     * * `snapshot`
     */
    readonly snapshot?: pulumi.Input<string>;
    /**
     * The customer-supplied encryption key of the source image. Required if
     * the source image is protected by a customer-supplied encryption key.  Structure is documented below.
     */
    readonly sourceImageEncryptionKey?: pulumi.Input<inputs.compute.DiskSourceImageEncryptionKey>;
    /**
     * The customer-supplied encryption key of the source snapshot. Required
     * if the source snapshot is protected by a customer-supplied encryption
     * key.  Structure is documented below.
     */
    readonly sourceSnapshotEncryptionKey?: pulumi.Input<inputs.compute.DiskSourceSnapshotEncryptionKey>;
    /**
     * URL of the disk type resource describing which disk type to use to
     * create the disk. Provide this when creating the disk.
     */
    readonly type?: pulumi.Input<string>;
    /**
     * A reference to the zone where the disk resides.
     */
    readonly zone?: pulumi.Input<string>;
}
