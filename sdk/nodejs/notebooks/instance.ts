// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export class Instance extends pulumi.CustomResource {
    /**
     * Get an existing Instance resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: InstanceState, opts?: pulumi.CustomResourceOptions): Instance {
        return new Instance(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:notebooks/instance:Instance';

    /**
     * Returns true if the given object is an instance of Instance.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Instance {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Instance.__pulumiType;
    }

    /**
     * The hardware accelerator used on this instance. If you use accelerators,
     * make sure that your configuration has enough vCPUs and memory to support the
     * machineType you have selected.  Structure is documented below.
     */
    public readonly acceleratorConfig!: pulumi.Output<outputs.notebooks.InstanceAcceleratorConfig | undefined>;
    /**
     * The size of the boot disk in GB attached to this instance,
     * up to a maximum of 64000 GB (64 TB). The minimum recommended value is 100 GB.
     * If not specified, this defaults to 100.
     */
    public readonly bootDiskSizeGb!: pulumi.Output<number | undefined>;
    /**
     * Possible disk types for notebook instances.
     */
    public readonly bootDiskType!: pulumi.Output<string | undefined>;
    /**
     * Use a container image to start the notebook instance.  Structure is documented below.
     */
    public readonly containerImage!: pulumi.Output<outputs.notebooks.InstanceContainerImage | undefined>;
    /**
     * Instance creation time
     */
    public readonly createTime!: pulumi.Output<string>;
    /**
     * Specify a custom Cloud Storage path where the GPU driver is stored.
     * If not specified, we'll automatically choose from official GPU drivers.
     */
    public readonly customGpuDriverPath!: pulumi.Output<string | undefined>;
    /**
     * The size of the data disk in GB attached to this instance,
     * up to a maximum of 64000 GB (64 TB).
     * You can choose the size of the data disk based on how big your notebooks and data are.
     * If not specified, this defaults to 100.
     */
    public readonly dataDiskSizeGb!: pulumi.Output<number | undefined>;
    /**
     * Possible disk types for notebook instances.
     */
    public readonly dataDiskType!: pulumi.Output<string | undefined>;
    /**
     * Disk encryption method used on the boot and data disks, defaults to GMEK.
     */
    public readonly diskEncryption!: pulumi.Output<string | undefined>;
    /**
     * Indicates that this is a boot disk. The virtual machine will
     * use the first partition of the disk for its root filesystem.
     */
    public readonly installGpuDriver!: pulumi.Output<boolean | undefined>;
    /**
     * The owner of this instance after creation.
     * Format: alias@example.com.
     * Currently supports one owner only.
     * If not specified, all of the service account users of
     * your VM instance's service account can use the instance.
     */
    public readonly instanceOwners!: pulumi.Output<string | undefined>;
    /**
     * The KMS key used to encrypt the disks, only applicable if diskEncryption is CMEK.
     * Format: projects/{project_id}/locations/{location}/keyRings/{key_ring_id}/cryptoKeys/{key_id}
     */
    public readonly kmsKey!: pulumi.Output<string | undefined>;
    /**
     * Labels to apply to this instance. These can be later modified by the setLabels method.
     * An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * A reference to the zone where the machine resides.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * A reference to a machine type which defines VM kind.
     */
    public readonly machineType!: pulumi.Output<string>;
    /**
     * Custom metadata to apply to this instance.
     * An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
     */
    public readonly metadata!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The name specified for the Notebook instance.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The name of the VPC that this instance is in.
     * Format: projects/{project_id}/global/networks/{network_id}
     */
    public readonly network!: pulumi.Output<string>;
    /**
     * the notebook instance will not register with the proxy..
     */
    public readonly noProxyAccess!: pulumi.Output<boolean | undefined>;
    /**
     * no public IP will be assigned to this instance.
     */
    public readonly noPublicIp!: pulumi.Output<boolean | undefined>;
    /**
     * If true, the data disk will not be auto deleted when deleting the instance.
     */
    public readonly noRemoveDataDisk!: pulumi.Output<boolean | undefined>;
    /**
     * Path to a Bash script that automatically runs after a
     * notebook instance fully boots up. The path must be a URL
     * or Cloud Storage path (gs://path-to-file/file-name).
     */
    public readonly postStartupScript!: pulumi.Output<string | undefined>;
    /**
     * The name of the Google Cloud project that this VM image belongs to.
     * Format: projects/{project_id}
     */
    public readonly project!: pulumi.Output<string>;
    /**
     * The proxy endpoint that is used to access the Jupyter notebook.
     */
    public /*out*/ readonly proxyUri!: pulumi.Output<string>;
    /**
     * The service account on this instance, giving access to other
     * Google Cloud services. You can use any service account within
     * the same project, but you must have the service account user
     * permission to use the instance. If not specified,
     * the Compute Engine default service account is used.
     */
    public readonly serviceAccount!: pulumi.Output<string>;
    /**
     * The state of this instance.
     */
    public /*out*/ readonly state!: pulumi.Output<string>;
    /**
     * The name of the subnet that this instance is in.
     * Format: projects/{project_id}/regions/{region}/subnetworks/{subnetwork_id}
     */
    public readonly subnet!: pulumi.Output<string>;
    /**
     * Instance update time.
     */
    public readonly updateTime!: pulumi.Output<string>;
    /**
     * Use a Compute Engine VM image to start the notebook instance.  Structure is documented below.
     */
    public readonly vmImage!: pulumi.Output<outputs.notebooks.InstanceVmImage | undefined>;

    /**
     * Create a Instance resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: InstanceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: InstanceArgs | InstanceState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as InstanceState | undefined;
            inputs["acceleratorConfig"] = state ? state.acceleratorConfig : undefined;
            inputs["bootDiskSizeGb"] = state ? state.bootDiskSizeGb : undefined;
            inputs["bootDiskType"] = state ? state.bootDiskType : undefined;
            inputs["containerImage"] = state ? state.containerImage : undefined;
            inputs["createTime"] = state ? state.createTime : undefined;
            inputs["customGpuDriverPath"] = state ? state.customGpuDriverPath : undefined;
            inputs["dataDiskSizeGb"] = state ? state.dataDiskSizeGb : undefined;
            inputs["dataDiskType"] = state ? state.dataDiskType : undefined;
            inputs["diskEncryption"] = state ? state.diskEncryption : undefined;
            inputs["installGpuDriver"] = state ? state.installGpuDriver : undefined;
            inputs["instanceOwners"] = state ? state.instanceOwners : undefined;
            inputs["kmsKey"] = state ? state.kmsKey : undefined;
            inputs["labels"] = state ? state.labels : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["machineType"] = state ? state.machineType : undefined;
            inputs["metadata"] = state ? state.metadata : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["network"] = state ? state.network : undefined;
            inputs["noProxyAccess"] = state ? state.noProxyAccess : undefined;
            inputs["noPublicIp"] = state ? state.noPublicIp : undefined;
            inputs["noRemoveDataDisk"] = state ? state.noRemoveDataDisk : undefined;
            inputs["postStartupScript"] = state ? state.postStartupScript : undefined;
            inputs["project"] = state ? state.project : undefined;
            inputs["proxyUri"] = state ? state.proxyUri : undefined;
            inputs["serviceAccount"] = state ? state.serviceAccount : undefined;
            inputs["state"] = state ? state.state : undefined;
            inputs["subnet"] = state ? state.subnet : undefined;
            inputs["updateTime"] = state ? state.updateTime : undefined;
            inputs["vmImage"] = state ? state.vmImage : undefined;
        } else {
            const args = argsOrState as InstanceArgs | undefined;
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.machineType === undefined) {
                throw new Error("Missing required property 'machineType'");
            }
            inputs["acceleratorConfig"] = args ? args.acceleratorConfig : undefined;
            inputs["bootDiskSizeGb"] = args ? args.bootDiskSizeGb : undefined;
            inputs["bootDiskType"] = args ? args.bootDiskType : undefined;
            inputs["containerImage"] = args ? args.containerImage : undefined;
            inputs["createTime"] = args ? args.createTime : undefined;
            inputs["customGpuDriverPath"] = args ? args.customGpuDriverPath : undefined;
            inputs["dataDiskSizeGb"] = args ? args.dataDiskSizeGb : undefined;
            inputs["dataDiskType"] = args ? args.dataDiskType : undefined;
            inputs["diskEncryption"] = args ? args.diskEncryption : undefined;
            inputs["installGpuDriver"] = args ? args.installGpuDriver : undefined;
            inputs["instanceOwners"] = args ? args.instanceOwners : undefined;
            inputs["kmsKey"] = args ? args.kmsKey : undefined;
            inputs["labels"] = args ? args.labels : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["machineType"] = args ? args.machineType : undefined;
            inputs["metadata"] = args ? args.metadata : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["network"] = args ? args.network : undefined;
            inputs["noProxyAccess"] = args ? args.noProxyAccess : undefined;
            inputs["noPublicIp"] = args ? args.noPublicIp : undefined;
            inputs["noRemoveDataDisk"] = args ? args.noRemoveDataDisk : undefined;
            inputs["postStartupScript"] = args ? args.postStartupScript : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["serviceAccount"] = args ? args.serviceAccount : undefined;
            inputs["subnet"] = args ? args.subnet : undefined;
            inputs["updateTime"] = args ? args.updateTime : undefined;
            inputs["vmImage"] = args ? args.vmImage : undefined;
            inputs["proxyUri"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Instance.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Instance resources.
 */
export interface InstanceState {
    /**
     * The hardware accelerator used on this instance. If you use accelerators,
     * make sure that your configuration has enough vCPUs and memory to support the
     * machineType you have selected.  Structure is documented below.
     */
    readonly acceleratorConfig?: pulumi.Input<inputs.notebooks.InstanceAcceleratorConfig>;
    /**
     * The size of the boot disk in GB attached to this instance,
     * up to a maximum of 64000 GB (64 TB). The minimum recommended value is 100 GB.
     * If not specified, this defaults to 100.
     */
    readonly bootDiskSizeGb?: pulumi.Input<number>;
    /**
     * Possible disk types for notebook instances.
     */
    readonly bootDiskType?: pulumi.Input<string>;
    /**
     * Use a container image to start the notebook instance.  Structure is documented below.
     */
    readonly containerImage?: pulumi.Input<inputs.notebooks.InstanceContainerImage>;
    /**
     * Instance creation time
     */
    readonly createTime?: pulumi.Input<string>;
    /**
     * Specify a custom Cloud Storage path where the GPU driver is stored.
     * If not specified, we'll automatically choose from official GPU drivers.
     */
    readonly customGpuDriverPath?: pulumi.Input<string>;
    /**
     * The size of the data disk in GB attached to this instance,
     * up to a maximum of 64000 GB (64 TB).
     * You can choose the size of the data disk based on how big your notebooks and data are.
     * If not specified, this defaults to 100.
     */
    readonly dataDiskSizeGb?: pulumi.Input<number>;
    /**
     * Possible disk types for notebook instances.
     */
    readonly dataDiskType?: pulumi.Input<string>;
    /**
     * Disk encryption method used on the boot and data disks, defaults to GMEK.
     */
    readonly diskEncryption?: pulumi.Input<string>;
    /**
     * Indicates that this is a boot disk. The virtual machine will
     * use the first partition of the disk for its root filesystem.
     */
    readonly installGpuDriver?: pulumi.Input<boolean>;
    /**
     * The owner of this instance after creation.
     * Format: alias@example.com.
     * Currently supports one owner only.
     * If not specified, all of the service account users of
     * your VM instance's service account can use the instance.
     */
    readonly instanceOwners?: pulumi.Input<string>;
    /**
     * The KMS key used to encrypt the disks, only applicable if diskEncryption is CMEK.
     * Format: projects/{project_id}/locations/{location}/keyRings/{key_ring_id}/cryptoKeys/{key_id}
     */
    readonly kmsKey?: pulumi.Input<string>;
    /**
     * Labels to apply to this instance. These can be later modified by the setLabels method.
     * An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
     */
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * A reference to the zone where the machine resides.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * A reference to a machine type which defines VM kind.
     */
    readonly machineType?: pulumi.Input<string>;
    /**
     * Custom metadata to apply to this instance.
     * An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
     */
    readonly metadata?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name specified for the Notebook instance.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the VPC that this instance is in.
     * Format: projects/{project_id}/global/networks/{network_id}
     */
    readonly network?: pulumi.Input<string>;
    /**
     * the notebook instance will not register with the proxy..
     */
    readonly noProxyAccess?: pulumi.Input<boolean>;
    /**
     * no public IP will be assigned to this instance.
     */
    readonly noPublicIp?: pulumi.Input<boolean>;
    /**
     * If true, the data disk will not be auto deleted when deleting the instance.
     */
    readonly noRemoveDataDisk?: pulumi.Input<boolean>;
    /**
     * Path to a Bash script that automatically runs after a
     * notebook instance fully boots up. The path must be a URL
     * or Cloud Storage path (gs://path-to-file/file-name).
     */
    readonly postStartupScript?: pulumi.Input<string>;
    /**
     * The name of the Google Cloud project that this VM image belongs to.
     * Format: projects/{project_id}
     */
    readonly project?: pulumi.Input<string>;
    /**
     * The proxy endpoint that is used to access the Jupyter notebook.
     */
    readonly proxyUri?: pulumi.Input<string>;
    /**
     * The service account on this instance, giving access to other
     * Google Cloud services. You can use any service account within
     * the same project, but you must have the service account user
     * permission to use the instance. If not specified,
     * the Compute Engine default service account is used.
     */
    readonly serviceAccount?: pulumi.Input<string>;
    /**
     * The state of this instance.
     */
    readonly state?: pulumi.Input<string>;
    /**
     * The name of the subnet that this instance is in.
     * Format: projects/{project_id}/regions/{region}/subnetworks/{subnetwork_id}
     */
    readonly subnet?: pulumi.Input<string>;
    /**
     * Instance update time.
     */
    readonly updateTime?: pulumi.Input<string>;
    /**
     * Use a Compute Engine VM image to start the notebook instance.  Structure is documented below.
     */
    readonly vmImage?: pulumi.Input<inputs.notebooks.InstanceVmImage>;
}

/**
 * The set of arguments for constructing a Instance resource.
 */
export interface InstanceArgs {
    /**
     * The hardware accelerator used on this instance. If you use accelerators,
     * make sure that your configuration has enough vCPUs and memory to support the
     * machineType you have selected.  Structure is documented below.
     */
    readonly acceleratorConfig?: pulumi.Input<inputs.notebooks.InstanceAcceleratorConfig>;
    /**
     * The size of the boot disk in GB attached to this instance,
     * up to a maximum of 64000 GB (64 TB). The minimum recommended value is 100 GB.
     * If not specified, this defaults to 100.
     */
    readonly bootDiskSizeGb?: pulumi.Input<number>;
    /**
     * Possible disk types for notebook instances.
     */
    readonly bootDiskType?: pulumi.Input<string>;
    /**
     * Use a container image to start the notebook instance.  Structure is documented below.
     */
    readonly containerImage?: pulumi.Input<inputs.notebooks.InstanceContainerImage>;
    /**
     * Instance creation time
     */
    readonly createTime?: pulumi.Input<string>;
    /**
     * Specify a custom Cloud Storage path where the GPU driver is stored.
     * If not specified, we'll automatically choose from official GPU drivers.
     */
    readonly customGpuDriverPath?: pulumi.Input<string>;
    /**
     * The size of the data disk in GB attached to this instance,
     * up to a maximum of 64000 GB (64 TB).
     * You can choose the size of the data disk based on how big your notebooks and data are.
     * If not specified, this defaults to 100.
     */
    readonly dataDiskSizeGb?: pulumi.Input<number>;
    /**
     * Possible disk types for notebook instances.
     */
    readonly dataDiskType?: pulumi.Input<string>;
    /**
     * Disk encryption method used on the boot and data disks, defaults to GMEK.
     */
    readonly diskEncryption?: pulumi.Input<string>;
    /**
     * Indicates that this is a boot disk. The virtual machine will
     * use the first partition of the disk for its root filesystem.
     */
    readonly installGpuDriver?: pulumi.Input<boolean>;
    /**
     * The owner of this instance after creation.
     * Format: alias@example.com.
     * Currently supports one owner only.
     * If not specified, all of the service account users of
     * your VM instance's service account can use the instance.
     */
    readonly instanceOwners?: pulumi.Input<string>;
    /**
     * The KMS key used to encrypt the disks, only applicable if diskEncryption is CMEK.
     * Format: projects/{project_id}/locations/{location}/keyRings/{key_ring_id}/cryptoKeys/{key_id}
     */
    readonly kmsKey?: pulumi.Input<string>;
    /**
     * Labels to apply to this instance. These can be later modified by the setLabels method.
     * An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
     */
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * A reference to the zone where the machine resides.
     */
    readonly location: pulumi.Input<string>;
    /**
     * A reference to a machine type which defines VM kind.
     */
    readonly machineType: pulumi.Input<string>;
    /**
     * Custom metadata to apply to this instance.
     * An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
     */
    readonly metadata?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name specified for the Notebook instance.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the VPC that this instance is in.
     * Format: projects/{project_id}/global/networks/{network_id}
     */
    readonly network?: pulumi.Input<string>;
    /**
     * the notebook instance will not register with the proxy..
     */
    readonly noProxyAccess?: pulumi.Input<boolean>;
    /**
     * no public IP will be assigned to this instance.
     */
    readonly noPublicIp?: pulumi.Input<boolean>;
    /**
     * If true, the data disk will not be auto deleted when deleting the instance.
     */
    readonly noRemoveDataDisk?: pulumi.Input<boolean>;
    /**
     * Path to a Bash script that automatically runs after a
     * notebook instance fully boots up. The path must be a URL
     * or Cloud Storage path (gs://path-to-file/file-name).
     */
    readonly postStartupScript?: pulumi.Input<string>;
    /**
     * The name of the Google Cloud project that this VM image belongs to.
     * Format: projects/{project_id}
     */
    readonly project?: pulumi.Input<string>;
    /**
     * The service account on this instance, giving access to other
     * Google Cloud services. You can use any service account within
     * the same project, but you must have the service account user
     * permission to use the instance. If not specified,
     * the Compute Engine default service account is used.
     */
    readonly serviceAccount?: pulumi.Input<string>;
    /**
     * The name of the subnet that this instance is in.
     * Format: projects/{project_id}/regions/{region}/subnetworks/{subnetwork_id}
     */
    readonly subnet?: pulumi.Input<string>;
    /**
     * Instance update time.
     */
    readonly updateTime?: pulumi.Input<string>;
    /**
     * Use a Compute Engine VM image to start the notebook instance.  Structure is documented below.
     */
    readonly vmImage?: pulumi.Input<inputs.notebooks.InstanceVmImage>;
}
