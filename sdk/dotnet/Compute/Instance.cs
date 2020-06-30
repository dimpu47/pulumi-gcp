// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute
{
    /// <summary>
    /// Manages a VM instance resource within GCE. For more information see
    /// [the official documentation](https://cloud.google.com/compute/docs/instances)
    /// and
    /// [API](https://cloud.google.com/compute/docs/reference/latest/instances).
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Gcp = Pulumi.Gcp;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var @default = new Gcp.Compute.Instance("default", new Gcp.Compute.InstanceArgs
    ///         {
    ///             BootDisk = new Gcp.Compute.Inputs.InstanceBootDiskArgs
    ///             {
    ///                 InitializeParams = new Gcp.Compute.Inputs.InstanceBootDiskInitializeParamsArgs
    ///                 {
    ///                     Image = "debian-cloud/debian-9",
    ///                 },
    ///             },
    ///             MachineType = "n1-standard-1",
    ///             Metadata = 
    ///             {
    ///                 { "foo", "bar" },
    ///             },
    ///             MetadataStartupScript = "echo hi &gt; /test.txt",
    ///             NetworkInterfaces = 
    ///             {
    ///                 new Gcp.Compute.Inputs.InstanceNetworkInterfaceArgs
    ///                 {
    ///                     AccessConfig = 
    ///                     {
    ///                         ,
    ///                     },
    ///                     Network = "default",
    ///                 },
    ///             },
    ///             ScratchDisks = 
    ///             {
    ///                 new Gcp.Compute.Inputs.InstanceScratchDiskArgs
    ///                 {
    ///                     Interface = "SCSI",
    ///                 },
    ///             },
    ///             ServiceAccount = new Gcp.Compute.Inputs.InstanceServiceAccountArgs
    ///             {
    ///                 Scopes = 
    ///                 {
    ///                     "userinfo-email",
    ///                     "compute-ro",
    ///                     "storage-ro",
    ///                 },
    ///             },
    ///             Tags = 
    ///             {
    ///                 "foo",
    ///                 "bar",
    ///             },
    ///             Zone = "us-central1-a",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class Instance : Pulumi.CustomResource
    {
        /// <summary>
        /// If true, allows this prvider to stop the instance to update its properties.
        /// If you try to update a property that requires stopping the instance without setting this field, the update will fail.
        /// </summary>
        [Output("allowStoppingForUpdate")]
        public Output<bool?> AllowStoppingForUpdate { get; private set; } = null!;

        /// <summary>
        /// Additional disks to attach to the instance. Can be repeated multiple times for multiple disks. Structure is documented below.
        /// </summary>
        [Output("attachedDisks")]
        public Output<ImmutableArray<Outputs.InstanceAttachedDisk>> AttachedDisks { get; private set; } = null!;

        /// <summary>
        /// The boot disk for the instance.
        /// Structure is documented below.
        /// </summary>
        [Output("bootDisk")]
        public Output<Outputs.InstanceBootDisk> BootDisk { get; private set; } = null!;

        /// <summary>
        /// Whether to allow sending and receiving of
        /// packets with non-matching source or destination IPs.
        /// This defaults to false.
        /// </summary>
        [Output("canIpForward")]
        public Output<bool?> CanIpForward { get; private set; } = null!;

        /// <summary>
        /// The CPU platform used by this instance.
        /// </summary>
        [Output("cpuPlatform")]
        public Output<string> CpuPlatform { get; private set; } = null!;

        /// <summary>
        /// Current status of the instance.
        /// </summary>
        [Output("currentStatus")]
        public Output<string> CurrentStatus { get; private set; } = null!;

        /// <summary>
        /// Enable deletion protection on this instance. Defaults to false.
        /// **Note:** you must disable deletion protection before removing the resource (e.g., via `pulumi destroy`), or the instance cannot be deleted and the provider run will not complete successfully.
        /// </summary>
        [Output("deletionProtection")]
        public Output<bool?> DeletionProtection { get; private set; } = null!;

        /// <summary>
        /// A brief description of this resource.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Desired status of the instance. Either
        /// `"RUNNING"` or `"TERMINATED"`.
        /// </summary>
        [Output("desiredStatus")]
        public Output<string?> DesiredStatus { get; private set; } = null!;

        /// <summary>
        /// Enable [Virtual Displays](https://cloud.google.com/compute/docs/instances/enable-instance-virtual-display#verify_display_driver) on this instance.
        /// **Note**: `allow_stopping_for_update` must be set to true or your instance must have a `desired_status` of `TERMINATED` in order to update this field.
        /// </summary>
        [Output("enableDisplay")]
        public Output<bool?> EnableDisplay { get; private set; } = null!;

        /// <summary>
        /// List of the type and count of accelerator cards attached to the instance. Structure documented below.
        /// **Note:** GPU accelerators can only be used with `on_host_maintenance` option set to TERMINATE.
        /// </summary>
        [Output("guestAccelerators")]
        public Output<ImmutableArray<Outputs.InstanceGuestAccelerator>> GuestAccelerators { get; private set; } = null!;

        /// <summary>
        /// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid.
        /// Valid format is a series of labels 1-63 characters long matching the regular expression `a-z`, concatenated with periods.
        /// The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
        /// </summary>
        [Output("hostname")]
        public Output<string?> Hostname { get; private set; } = null!;

        /// <summary>
        /// The server-assigned unique identifier of this instance.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;

        /// <summary>
        /// The unique fingerprint of the labels.
        /// </summary>
        [Output("labelFingerprint")]
        public Output<string> LabelFingerprint { get; private set; } = null!;

        /// <summary>
        /// A map of key/value label pairs to assign to the instance.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        /// <summary>
        /// The machine type to create.
        /// </summary>
        [Output("machineType")]
        public Output<string> MachineType { get; private set; } = null!;

        /// <summary>
        /// Metadata key/value pairs to make available from
        /// within the instance. Ssh keys attached in the Cloud Console will be removed.
        /// Add them to your config in order to keep them attached to your instance.
        /// </summary>
        [Output("metadata")]
        public Output<ImmutableDictionary<string, string>?> Metadata { get; private set; } = null!;

        /// <summary>
        /// The unique fingerprint of the metadata.
        /// </summary>
        [Output("metadataFingerprint")]
        public Output<string> MetadataFingerprint { get; private set; } = null!;

        /// <summary>
        /// An alternative to using the
        /// startup-script metadata key, except this one forces the instance to be
        /// recreated (thus re-running the script) if it is changed. This replaces the
        /// startup-script metadata key on the created instance and thus the two
        /// mechanisms are not allowed to be used simultaneously.  Users are free to use
        /// either mechanism - the only distinction is that this separate attribute
        /// willl cause a recreate on modification.  On import, `metadata_startup_script`
        /// will be set, but `metadata.startup-script` will not - if you choose to use the
        /// other mechanism, you will see a diff immediately after import, which will cause a
        /// destroy/recreate operation.  You may want to modify your state file manually
        /// using `pulumi stack` commands, depending on your use case.
        /// </summary>
        [Output("metadataStartupScript")]
        public Output<string?> MetadataStartupScript { get; private set; } = null!;

        /// <summary>
        /// Specifies a minimum CPU platform for the VM instance. Applicable values are the friendly names of CPU platforms, such as
        /// `Intel Haswell` or `Intel Skylake`. See the complete list [here](https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform).
        /// **Note**: `allow_stopping_for_update` must be set to true or your instance must have a `desired_status` of `TERMINATED` in order to update this field.
        /// </summary>
        [Output("minCpuPlatform")]
        public Output<string> MinCpuPlatform { get; private set; } = null!;

        /// <summary>
        /// A unique name for the resource, required by GCE.
        /// Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Networks to attach to the instance. This can
        /// be specified multiple times. Structure is documented below.
        /// </summary>
        [Output("networkInterfaces")]
        public Output<ImmutableArray<Outputs.InstanceNetworkInterface>> NetworkInterfaces { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// -- A list of short names or self_links of resource policies to attach to the instance. Modifying this list will cause the instance to recreate. Currently a max of 1 resource policy is supported.
        /// </summary>
        [Output("resourcePolicies")]
        public Output<string?> ResourcePolicies { get; private set; } = null!;

        /// <summary>
        /// The scheduling strategy to use. More details about
        /// this configuration option are detailed below.
        /// </summary>
        [Output("scheduling")]
        public Output<Outputs.InstanceScheduling> Scheduling { get; private set; } = null!;

        /// <summary>
        /// Scratch disks to attach to the instance. This can be
        /// specified multiple times for multiple scratch disks. Structure is documented below.
        /// </summary>
        [Output("scratchDisks")]
        public Output<ImmutableArray<Outputs.InstanceScratchDisk>> ScratchDisks { get; private set; } = null!;

        /// <summary>
        /// The URI of the created resource.
        /// </summary>
        [Output("selfLink")]
        public Output<string> SelfLink { get; private set; } = null!;

        /// <summary>
        /// Service account to attach to the instance.
        /// Structure is documented below.
        /// **Note**: `allow_stopping_for_update` must be set to true or your instance must have a `desired_status` of `TERMINATED` in order to update this field.
        /// </summary>
        [Output("serviceAccount")]
        public Output<Outputs.InstanceServiceAccount?> ServiceAccount { get; private set; } = null!;

        /// <summary>
        /// Enable [Shielded VM](https://cloud.google.com/security/shielded-cloud/shielded-vm) on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below.
        /// **Note**: `shielded_instance_config` can only be used with boot images with shielded vm support. See the complete list [here](https://cloud.google.com/compute/docs/images#shielded-images).
        /// </summary>
        [Output("shieldedInstanceConfig")]
        public Output<Outputs.InstanceShieldedInstanceConfig> ShieldedInstanceConfig { get; private set; } = null!;

        /// <summary>
        /// A list of network tags to attach to the instance.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        /// <summary>
        /// The unique fingerprint of the tags.
        /// </summary>
        [Output("tagsFingerprint")]
        public Output<string> TagsFingerprint { get; private set; } = null!;

        /// <summary>
        /// The zone that the machine should be created in.
        /// </summary>
        [Output("zone")]
        public Output<string> Zone { get; private set; } = null!;


        /// <summary>
        /// Create a Instance resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Instance(string name, InstanceArgs args, CustomResourceOptions? options = null)
            : base("gcp:compute/instance:Instance", name, args ?? new InstanceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Instance(string name, Input<string> id, InstanceState? state = null, CustomResourceOptions? options = null)
            : base("gcp:compute/instance:Instance", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Instance resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Instance Get(string name, Input<string> id, InstanceState? state = null, CustomResourceOptions? options = null)
        {
            return new Instance(name, id, state, options);
        }
    }

    public sealed class InstanceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If true, allows this prvider to stop the instance to update its properties.
        /// If you try to update a property that requires stopping the instance without setting this field, the update will fail.
        /// </summary>
        [Input("allowStoppingForUpdate")]
        public Input<bool>? AllowStoppingForUpdate { get; set; }

        [Input("attachedDisks")]
        private InputList<Inputs.InstanceAttachedDiskArgs>? _attachedDisks;

        /// <summary>
        /// Additional disks to attach to the instance. Can be repeated multiple times for multiple disks. Structure is documented below.
        /// </summary>
        public InputList<Inputs.InstanceAttachedDiskArgs> AttachedDisks
        {
            get => _attachedDisks ?? (_attachedDisks = new InputList<Inputs.InstanceAttachedDiskArgs>());
            set => _attachedDisks = value;
        }

        /// <summary>
        /// The boot disk for the instance.
        /// Structure is documented below.
        /// </summary>
        [Input("bootDisk", required: true)]
        public Input<Inputs.InstanceBootDiskArgs> BootDisk { get; set; } = null!;

        /// <summary>
        /// Whether to allow sending and receiving of
        /// packets with non-matching source or destination IPs.
        /// This defaults to false.
        /// </summary>
        [Input("canIpForward")]
        public Input<bool>? CanIpForward { get; set; }

        /// <summary>
        /// Enable deletion protection on this instance. Defaults to false.
        /// **Note:** you must disable deletion protection before removing the resource (e.g., via `pulumi destroy`), or the instance cannot be deleted and the provider run will not complete successfully.
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// A brief description of this resource.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Desired status of the instance. Either
        /// `"RUNNING"` or `"TERMINATED"`.
        /// </summary>
        [Input("desiredStatus")]
        public Input<string>? DesiredStatus { get; set; }

        /// <summary>
        /// Enable [Virtual Displays](https://cloud.google.com/compute/docs/instances/enable-instance-virtual-display#verify_display_driver) on this instance.
        /// **Note**: `allow_stopping_for_update` must be set to true or your instance must have a `desired_status` of `TERMINATED` in order to update this field.
        /// </summary>
        [Input("enableDisplay")]
        public Input<bool>? EnableDisplay { get; set; }

        [Input("guestAccelerators")]
        private InputList<Inputs.InstanceGuestAcceleratorArgs>? _guestAccelerators;

        /// <summary>
        /// List of the type and count of accelerator cards attached to the instance. Structure documented below.
        /// **Note:** GPU accelerators can only be used with `on_host_maintenance` option set to TERMINATE.
        /// </summary>
        public InputList<Inputs.InstanceGuestAcceleratorArgs> GuestAccelerators
        {
            get => _guestAccelerators ?? (_guestAccelerators = new InputList<Inputs.InstanceGuestAcceleratorArgs>());
            set => _guestAccelerators = value;
        }

        /// <summary>
        /// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid.
        /// Valid format is a series of labels 1-63 characters long matching the regular expression `a-z`, concatenated with periods.
        /// The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A map of key/value label pairs to assign to the instance.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// The machine type to create.
        /// </summary>
        [Input("machineType", required: true)]
        public Input<string> MachineType { get; set; } = null!;

        [Input("metadata")]
        private InputMap<string>? _metadata;

        /// <summary>
        /// Metadata key/value pairs to make available from
        /// within the instance. Ssh keys attached in the Cloud Console will be removed.
        /// Add them to your config in order to keep them attached to your instance.
        /// </summary>
        public InputMap<string> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<string>());
            set => _metadata = value;
        }

        /// <summary>
        /// An alternative to using the
        /// startup-script metadata key, except this one forces the instance to be
        /// recreated (thus re-running the script) if it is changed. This replaces the
        /// startup-script metadata key on the created instance and thus the two
        /// mechanisms are not allowed to be used simultaneously.  Users are free to use
        /// either mechanism - the only distinction is that this separate attribute
        /// willl cause a recreate on modification.  On import, `metadata_startup_script`
        /// will be set, but `metadata.startup-script` will not - if you choose to use the
        /// other mechanism, you will see a diff immediately after import, which will cause a
        /// destroy/recreate operation.  You may want to modify your state file manually
        /// using `pulumi stack` commands, depending on your use case.
        /// </summary>
        [Input("metadataStartupScript")]
        public Input<string>? MetadataStartupScript { get; set; }

        /// <summary>
        /// Specifies a minimum CPU platform for the VM instance. Applicable values are the friendly names of CPU platforms, such as
        /// `Intel Haswell` or `Intel Skylake`. See the complete list [here](https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform).
        /// **Note**: `allow_stopping_for_update` must be set to true or your instance must have a `desired_status` of `TERMINATED` in order to update this field.
        /// </summary>
        [Input("minCpuPlatform")]
        public Input<string>? MinCpuPlatform { get; set; }

        /// <summary>
        /// A unique name for the resource, required by GCE.
        /// Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("networkInterfaces", required: true)]
        private InputList<Inputs.InstanceNetworkInterfaceArgs>? _networkInterfaces;

        /// <summary>
        /// Networks to attach to the instance. This can
        /// be specified multiple times. Structure is documented below.
        /// </summary>
        public InputList<Inputs.InstanceNetworkInterfaceArgs> NetworkInterfaces
        {
            get => _networkInterfaces ?? (_networkInterfaces = new InputList<Inputs.InstanceNetworkInterfaceArgs>());
            set => _networkInterfaces = value;
        }

        /// <summary>
        /// The ID of the project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// -- A list of short names or self_links of resource policies to attach to the instance. Modifying this list will cause the instance to recreate. Currently a max of 1 resource policy is supported.
        /// </summary>
        [Input("resourcePolicies")]
        public Input<string>? ResourcePolicies { get; set; }

        /// <summary>
        /// The scheduling strategy to use. More details about
        /// this configuration option are detailed below.
        /// </summary>
        [Input("scheduling")]
        public Input<Inputs.InstanceSchedulingArgs>? Scheduling { get; set; }

        [Input("scratchDisks")]
        private InputList<Inputs.InstanceScratchDiskArgs>? _scratchDisks;

        /// <summary>
        /// Scratch disks to attach to the instance. This can be
        /// specified multiple times for multiple scratch disks. Structure is documented below.
        /// </summary>
        public InputList<Inputs.InstanceScratchDiskArgs> ScratchDisks
        {
            get => _scratchDisks ?? (_scratchDisks = new InputList<Inputs.InstanceScratchDiskArgs>());
            set => _scratchDisks = value;
        }

        /// <summary>
        /// Service account to attach to the instance.
        /// Structure is documented below.
        /// **Note**: `allow_stopping_for_update` must be set to true or your instance must have a `desired_status` of `TERMINATED` in order to update this field.
        /// </summary>
        [Input("serviceAccount")]
        public Input<Inputs.InstanceServiceAccountArgs>? ServiceAccount { get; set; }

        /// <summary>
        /// Enable [Shielded VM](https://cloud.google.com/security/shielded-cloud/shielded-vm) on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below.
        /// **Note**: `shielded_instance_config` can only be used with boot images with shielded vm support. See the complete list [here](https://cloud.google.com/compute/docs/images#shielded-images).
        /// </summary>
        [Input("shieldedInstanceConfig")]
        public Input<Inputs.InstanceShieldedInstanceConfigArgs>? ShieldedInstanceConfig { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// A list of network tags to attach to the instance.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The zone that the machine should be created in.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public InstanceArgs()
        {
        }
    }

    public sealed class InstanceState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If true, allows this prvider to stop the instance to update its properties.
        /// If you try to update a property that requires stopping the instance without setting this field, the update will fail.
        /// </summary>
        [Input("allowStoppingForUpdate")]
        public Input<bool>? AllowStoppingForUpdate { get; set; }

        [Input("attachedDisks")]
        private InputList<Inputs.InstanceAttachedDiskGetArgs>? _attachedDisks;

        /// <summary>
        /// Additional disks to attach to the instance. Can be repeated multiple times for multiple disks. Structure is documented below.
        /// </summary>
        public InputList<Inputs.InstanceAttachedDiskGetArgs> AttachedDisks
        {
            get => _attachedDisks ?? (_attachedDisks = new InputList<Inputs.InstanceAttachedDiskGetArgs>());
            set => _attachedDisks = value;
        }

        /// <summary>
        /// The boot disk for the instance.
        /// Structure is documented below.
        /// </summary>
        [Input("bootDisk")]
        public Input<Inputs.InstanceBootDiskGetArgs>? BootDisk { get; set; }

        /// <summary>
        /// Whether to allow sending and receiving of
        /// packets with non-matching source or destination IPs.
        /// This defaults to false.
        /// </summary>
        [Input("canIpForward")]
        public Input<bool>? CanIpForward { get; set; }

        /// <summary>
        /// The CPU platform used by this instance.
        /// </summary>
        [Input("cpuPlatform")]
        public Input<string>? CpuPlatform { get; set; }

        /// <summary>
        /// Current status of the instance.
        /// </summary>
        [Input("currentStatus")]
        public Input<string>? CurrentStatus { get; set; }

        /// <summary>
        /// Enable deletion protection on this instance. Defaults to false.
        /// **Note:** you must disable deletion protection before removing the resource (e.g., via `pulumi destroy`), or the instance cannot be deleted and the provider run will not complete successfully.
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// A brief description of this resource.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Desired status of the instance. Either
        /// `"RUNNING"` or `"TERMINATED"`.
        /// </summary>
        [Input("desiredStatus")]
        public Input<string>? DesiredStatus { get; set; }

        /// <summary>
        /// Enable [Virtual Displays](https://cloud.google.com/compute/docs/instances/enable-instance-virtual-display#verify_display_driver) on this instance.
        /// **Note**: `allow_stopping_for_update` must be set to true or your instance must have a `desired_status` of `TERMINATED` in order to update this field.
        /// </summary>
        [Input("enableDisplay")]
        public Input<bool>? EnableDisplay { get; set; }

        [Input("guestAccelerators")]
        private InputList<Inputs.InstanceGuestAcceleratorGetArgs>? _guestAccelerators;

        /// <summary>
        /// List of the type and count of accelerator cards attached to the instance. Structure documented below.
        /// **Note:** GPU accelerators can only be used with `on_host_maintenance` option set to TERMINATE.
        /// </summary>
        public InputList<Inputs.InstanceGuestAcceleratorGetArgs> GuestAccelerators
        {
            get => _guestAccelerators ?? (_guestAccelerators = new InputList<Inputs.InstanceGuestAcceleratorGetArgs>());
            set => _guestAccelerators = value;
        }

        /// <summary>
        /// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid.
        /// Valid format is a series of labels 1-63 characters long matching the regular expression `a-z`, concatenated with periods.
        /// The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        /// <summary>
        /// The server-assigned unique identifier of this instance.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// The unique fingerprint of the labels.
        /// </summary>
        [Input("labelFingerprint")]
        public Input<string>? LabelFingerprint { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A map of key/value label pairs to assign to the instance.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// The machine type to create.
        /// </summary>
        [Input("machineType")]
        public Input<string>? MachineType { get; set; }

        [Input("metadata")]
        private InputMap<string>? _metadata;

        /// <summary>
        /// Metadata key/value pairs to make available from
        /// within the instance. Ssh keys attached in the Cloud Console will be removed.
        /// Add them to your config in order to keep them attached to your instance.
        /// </summary>
        public InputMap<string> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<string>());
            set => _metadata = value;
        }

        /// <summary>
        /// The unique fingerprint of the metadata.
        /// </summary>
        [Input("metadataFingerprint")]
        public Input<string>? MetadataFingerprint { get; set; }

        /// <summary>
        /// An alternative to using the
        /// startup-script metadata key, except this one forces the instance to be
        /// recreated (thus re-running the script) if it is changed. This replaces the
        /// startup-script metadata key on the created instance and thus the two
        /// mechanisms are not allowed to be used simultaneously.  Users are free to use
        /// either mechanism - the only distinction is that this separate attribute
        /// willl cause a recreate on modification.  On import, `metadata_startup_script`
        /// will be set, but `metadata.startup-script` will not - if you choose to use the
        /// other mechanism, you will see a diff immediately after import, which will cause a
        /// destroy/recreate operation.  You may want to modify your state file manually
        /// using `pulumi stack` commands, depending on your use case.
        /// </summary>
        [Input("metadataStartupScript")]
        public Input<string>? MetadataStartupScript { get; set; }

        /// <summary>
        /// Specifies a minimum CPU platform for the VM instance. Applicable values are the friendly names of CPU platforms, such as
        /// `Intel Haswell` or `Intel Skylake`. See the complete list [here](https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform).
        /// **Note**: `allow_stopping_for_update` must be set to true or your instance must have a `desired_status` of `TERMINATED` in order to update this field.
        /// </summary>
        [Input("minCpuPlatform")]
        public Input<string>? MinCpuPlatform { get; set; }

        /// <summary>
        /// A unique name for the resource, required by GCE.
        /// Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("networkInterfaces")]
        private InputList<Inputs.InstanceNetworkInterfaceGetArgs>? _networkInterfaces;

        /// <summary>
        /// Networks to attach to the instance. This can
        /// be specified multiple times. Structure is documented below.
        /// </summary>
        public InputList<Inputs.InstanceNetworkInterfaceGetArgs> NetworkInterfaces
        {
            get => _networkInterfaces ?? (_networkInterfaces = new InputList<Inputs.InstanceNetworkInterfaceGetArgs>());
            set => _networkInterfaces = value;
        }

        /// <summary>
        /// The ID of the project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// -- A list of short names or self_links of resource policies to attach to the instance. Modifying this list will cause the instance to recreate. Currently a max of 1 resource policy is supported.
        /// </summary>
        [Input("resourcePolicies")]
        public Input<string>? ResourcePolicies { get; set; }

        /// <summary>
        /// The scheduling strategy to use. More details about
        /// this configuration option are detailed below.
        /// </summary>
        [Input("scheduling")]
        public Input<Inputs.InstanceSchedulingGetArgs>? Scheduling { get; set; }

        [Input("scratchDisks")]
        private InputList<Inputs.InstanceScratchDiskGetArgs>? _scratchDisks;

        /// <summary>
        /// Scratch disks to attach to the instance. This can be
        /// specified multiple times for multiple scratch disks. Structure is documented below.
        /// </summary>
        public InputList<Inputs.InstanceScratchDiskGetArgs> ScratchDisks
        {
            get => _scratchDisks ?? (_scratchDisks = new InputList<Inputs.InstanceScratchDiskGetArgs>());
            set => _scratchDisks = value;
        }

        /// <summary>
        /// The URI of the created resource.
        /// </summary>
        [Input("selfLink")]
        public Input<string>? SelfLink { get; set; }

        /// <summary>
        /// Service account to attach to the instance.
        /// Structure is documented below.
        /// **Note**: `allow_stopping_for_update` must be set to true or your instance must have a `desired_status` of `TERMINATED` in order to update this field.
        /// </summary>
        [Input("serviceAccount")]
        public Input<Inputs.InstanceServiceAccountGetArgs>? ServiceAccount { get; set; }

        /// <summary>
        /// Enable [Shielded VM](https://cloud.google.com/security/shielded-cloud/shielded-vm) on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below.
        /// **Note**: `shielded_instance_config` can only be used with boot images with shielded vm support. See the complete list [here](https://cloud.google.com/compute/docs/images#shielded-images).
        /// </summary>
        [Input("shieldedInstanceConfig")]
        public Input<Inputs.InstanceShieldedInstanceConfigGetArgs>? ShieldedInstanceConfig { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// A list of network tags to attach to the instance.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The unique fingerprint of the tags.
        /// </summary>
        [Input("tagsFingerprint")]
        public Input<string>? TagsFingerprint { get; set; }

        /// <summary>
        /// The zone that the machine should be created in.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public InstanceState()
        {
        }
    }
}
