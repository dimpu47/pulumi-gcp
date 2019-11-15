// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Bigquery
{
    /// <summary>
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/bigquery_dataset.html.markdown.
    /// </summary>
    public partial class Dataset : Pulumi.CustomResource
    {
        /// <summary>
        /// An array of objects that define dataset access for one or more entities.
        /// </summary>
        [Output("accesses")]
        public Output<ImmutableArray<Outputs.DatasetAccesses>> Accesses { get; private set; } = null!;

        /// <summary>
        /// The time when this dataset was created, in milliseconds since the epoch.
        /// </summary>
        [Output("creationTime")]
        public Output<int> CreationTime { get; private set; } = null!;

        /// <summary>
        /// A unique ID for this dataset, without the project name. The ID must contain only letters (a-z, A-Z), numbers
        /// (0-9), or underscores (_). The maximum length is 1,024 characters.
        /// </summary>
        [Output("datasetId")]
        public Output<string> DatasetId { get; private set; } = null!;

        /// <summary>
        /// The default encryption key for all tables in the dataset. Once this property is set, all newly-created
        /// partitioned tables in the dataset will have encryption key set to this value, unless table creation request
        /// (or query) overrides the key.
        /// </summary>
        [Output("defaultEncryptionConfiguration")]
        public Output<Outputs.DatasetDefaultEncryptionConfiguration?> DefaultEncryptionConfiguration { get; private set; } = null!;

        /// <summary>
        /// The default partition expiration for all partitioned tables in the dataset, in milliseconds. Once this
        /// property is set, all newly-created partitioned tables in the dataset will have an 'expirationMs' property in
        /// the 'timePartitioning' settings set to this value, and changing the value will only affect new tables, not
        /// existing ones. The storage in a partition will have an expiration time of its partition time plus this
        /// value. Setting this property overrides the use of 'defaultTableExpirationMs' for partitioned tables: only
        /// one of 'defaultTableExpirationMs' and 'defaultPartitionExpirationMs' will be used for any new partitioned
        /// table. If you provide an explicit 'timePartitioning.expirationMs' when creating or updating a partitioned
        /// table, that value takes precedence over the default partition expiration time indicated by this property.
        /// </summary>
        [Output("defaultPartitionExpirationMs")]
        public Output<int?> DefaultPartitionExpirationMs { get; private set; } = null!;

        /// <summary>
        /// The default lifetime of all tables in the dataset, in milliseconds. The minimum value is 3600000
        /// milliseconds (one hour). Once this property is set, all newly-created tables in the dataset will have an
        /// 'expirationTime' property set to the creation time plus the value in this property, and changing the value
        /// will only affect new tables, not existing ones. When the 'expirationTime' for a given table is reached, that
        /// table will be deleted automatically. If a table's 'expirationTime' is modified or removed before the table
        /// expires, or if you provide an explicit 'expirationTime' when creating a table, that value takes precedence
        /// over the default expiration time indicated by this property.
        /// </summary>
        [Output("defaultTableExpirationMs")]
        public Output<int?> DefaultTableExpirationMs { get; private set; } = null!;

        /// <summary>
        /// If set to `true`, delete all the tables in the
        /// dataset when destroying the resource; otherwise,
        /// destroying the resource will fail if tables are present.
        /// </summary>
        [Output("deleteContentsOnDestroy")]
        public Output<bool?> DeleteContentsOnDestroy { get; private set; } = null!;

        /// <summary>
        /// A user-friendly description of the dataset
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// A hash of the resource.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// A descriptive name for the dataset
        /// </summary>
        [Output("friendlyName")]
        public Output<string?> FriendlyName { get; private set; } = null!;

        /// <summary>
        /// The labels associated with this dataset. You can use these to organize and group your datasets
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        /// <summary>
        /// The date when this dataset or any of its tables was last modified, in milliseconds since the epoch.
        /// </summary>
        [Output("lastModifiedTime")]
        public Output<int> LastModifiedTime { get; private set; } = null!;

        /// <summary>
        /// The geographic location where the dataset should reside. See [official
        /// docs](https://cloud.google.com/bigquery/docs/dataset-locations). There are two types of locations, regional
        /// or multi-regional. A regional location is a specific geographic place, such as Tokyo, and a multi-regional
        /// location is a large geographic area, such as the United States, that contains at least two geographic
        /// places. Possible regional values include: 'asia-east1', 'asia-northeast1', 'asia-southeast1',
        /// 'australia-southeast1', 'europe-north1', 'europe-west2' and 'us-east4'. Possible multi-regional values: 'EU'
        /// and 'US'. The default value is multi-regional location 'US'. Changing this forces a new resource to be
        /// created.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// The URI of the created resource.
        /// </summary>
        [Output("selfLink")]
        public Output<string> SelfLink { get; private set; } = null!;


        /// <summary>
        /// Create a Dataset resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Dataset(string name, DatasetArgs args, CustomResourceOptions? options = null)
            : base("gcp:bigquery/dataset:Dataset", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Dataset(string name, Input<string> id, DatasetState? state = null, CustomResourceOptions? options = null)
            : base("gcp:bigquery/dataset:Dataset", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Dataset resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Dataset Get(string name, Input<string> id, DatasetState? state = null, CustomResourceOptions? options = null)
        {
            return new Dataset(name, id, state, options);
        }
    }

    public sealed class DatasetArgs : Pulumi.ResourceArgs
    {
        [Input("accesses")]
        private InputList<Inputs.DatasetAccessesArgs>? _accesses;

        /// <summary>
        /// An array of objects that define dataset access for one or more entities.
        /// </summary>
        public InputList<Inputs.DatasetAccessesArgs> Accesses
        {
            get => _accesses ?? (_accesses = new InputList<Inputs.DatasetAccessesArgs>());
            set => _accesses = value;
        }

        /// <summary>
        /// A unique ID for this dataset, without the project name. The ID must contain only letters (a-z, A-Z), numbers
        /// (0-9), or underscores (_). The maximum length is 1,024 characters.
        /// </summary>
        [Input("datasetId", required: true)]
        public Input<string> DatasetId { get; set; } = null!;

        /// <summary>
        /// The default encryption key for all tables in the dataset. Once this property is set, all newly-created
        /// partitioned tables in the dataset will have encryption key set to this value, unless table creation request
        /// (or query) overrides the key.
        /// </summary>
        [Input("defaultEncryptionConfiguration")]
        public Input<Inputs.DatasetDefaultEncryptionConfigurationArgs>? DefaultEncryptionConfiguration { get; set; }

        /// <summary>
        /// The default partition expiration for all partitioned tables in the dataset, in milliseconds. Once this
        /// property is set, all newly-created partitioned tables in the dataset will have an 'expirationMs' property in
        /// the 'timePartitioning' settings set to this value, and changing the value will only affect new tables, not
        /// existing ones. The storage in a partition will have an expiration time of its partition time plus this
        /// value. Setting this property overrides the use of 'defaultTableExpirationMs' for partitioned tables: only
        /// one of 'defaultTableExpirationMs' and 'defaultPartitionExpirationMs' will be used for any new partitioned
        /// table. If you provide an explicit 'timePartitioning.expirationMs' when creating or updating a partitioned
        /// table, that value takes precedence over the default partition expiration time indicated by this property.
        /// </summary>
        [Input("defaultPartitionExpirationMs")]
        public Input<int>? DefaultPartitionExpirationMs { get; set; }

        /// <summary>
        /// The default lifetime of all tables in the dataset, in milliseconds. The minimum value is 3600000
        /// milliseconds (one hour). Once this property is set, all newly-created tables in the dataset will have an
        /// 'expirationTime' property set to the creation time plus the value in this property, and changing the value
        /// will only affect new tables, not existing ones. When the 'expirationTime' for a given table is reached, that
        /// table will be deleted automatically. If a table's 'expirationTime' is modified or removed before the table
        /// expires, or if you provide an explicit 'expirationTime' when creating a table, that value takes precedence
        /// over the default expiration time indicated by this property.
        /// </summary>
        [Input("defaultTableExpirationMs")]
        public Input<int>? DefaultTableExpirationMs { get; set; }

        /// <summary>
        /// If set to `true`, delete all the tables in the
        /// dataset when destroying the resource; otherwise,
        /// destroying the resource will fail if tables are present.
        /// </summary>
        [Input("deleteContentsOnDestroy")]
        public Input<bool>? DeleteContentsOnDestroy { get; set; }

        /// <summary>
        /// A user-friendly description of the dataset
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// A descriptive name for the dataset
        /// </summary>
        [Input("friendlyName")]
        public Input<string>? FriendlyName { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// The labels associated with this dataset. You can use these to organize and group your datasets
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// The geographic location where the dataset should reside. See [official
        /// docs](https://cloud.google.com/bigquery/docs/dataset-locations). There are two types of locations, regional
        /// or multi-regional. A regional location is a specific geographic place, such as Tokyo, and a multi-regional
        /// location is a large geographic area, such as the United States, that contains at least two geographic
        /// places. Possible regional values include: 'asia-east1', 'asia-northeast1', 'asia-southeast1',
        /// 'australia-southeast1', 'europe-north1', 'europe-west2' and 'us-east4'. Possible multi-regional values: 'EU'
        /// and 'US'. The default value is multi-regional location 'US'. Changing this forces a new resource to be
        /// created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        public DatasetArgs()
        {
        }
    }

    public sealed class DatasetState : Pulumi.ResourceArgs
    {
        [Input("accesses")]
        private InputList<Inputs.DatasetAccessesGetArgs>? _accesses;

        /// <summary>
        /// An array of objects that define dataset access for one or more entities.
        /// </summary>
        public InputList<Inputs.DatasetAccessesGetArgs> Accesses
        {
            get => _accesses ?? (_accesses = new InputList<Inputs.DatasetAccessesGetArgs>());
            set => _accesses = value;
        }

        /// <summary>
        /// The time when this dataset was created, in milliseconds since the epoch.
        /// </summary>
        [Input("creationTime")]
        public Input<int>? CreationTime { get; set; }

        /// <summary>
        /// A unique ID for this dataset, without the project name. The ID must contain only letters (a-z, A-Z), numbers
        /// (0-9), or underscores (_). The maximum length is 1,024 characters.
        /// </summary>
        [Input("datasetId")]
        public Input<string>? DatasetId { get; set; }

        /// <summary>
        /// The default encryption key for all tables in the dataset. Once this property is set, all newly-created
        /// partitioned tables in the dataset will have encryption key set to this value, unless table creation request
        /// (or query) overrides the key.
        /// </summary>
        [Input("defaultEncryptionConfiguration")]
        public Input<Inputs.DatasetDefaultEncryptionConfigurationGetArgs>? DefaultEncryptionConfiguration { get; set; }

        /// <summary>
        /// The default partition expiration for all partitioned tables in the dataset, in milliseconds. Once this
        /// property is set, all newly-created partitioned tables in the dataset will have an 'expirationMs' property in
        /// the 'timePartitioning' settings set to this value, and changing the value will only affect new tables, not
        /// existing ones. The storage in a partition will have an expiration time of its partition time plus this
        /// value. Setting this property overrides the use of 'defaultTableExpirationMs' for partitioned tables: only
        /// one of 'defaultTableExpirationMs' and 'defaultPartitionExpirationMs' will be used for any new partitioned
        /// table. If you provide an explicit 'timePartitioning.expirationMs' when creating or updating a partitioned
        /// table, that value takes precedence over the default partition expiration time indicated by this property.
        /// </summary>
        [Input("defaultPartitionExpirationMs")]
        public Input<int>? DefaultPartitionExpirationMs { get; set; }

        /// <summary>
        /// The default lifetime of all tables in the dataset, in milliseconds. The minimum value is 3600000
        /// milliseconds (one hour). Once this property is set, all newly-created tables in the dataset will have an
        /// 'expirationTime' property set to the creation time plus the value in this property, and changing the value
        /// will only affect new tables, not existing ones. When the 'expirationTime' for a given table is reached, that
        /// table will be deleted automatically. If a table's 'expirationTime' is modified or removed before the table
        /// expires, or if you provide an explicit 'expirationTime' when creating a table, that value takes precedence
        /// over the default expiration time indicated by this property.
        /// </summary>
        [Input("defaultTableExpirationMs")]
        public Input<int>? DefaultTableExpirationMs { get; set; }

        /// <summary>
        /// If set to `true`, delete all the tables in the
        /// dataset when destroying the resource; otherwise,
        /// destroying the resource will fail if tables are present.
        /// </summary>
        [Input("deleteContentsOnDestroy")]
        public Input<bool>? DeleteContentsOnDestroy { get; set; }

        /// <summary>
        /// A user-friendly description of the dataset
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// A hash of the resource.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// A descriptive name for the dataset
        /// </summary>
        [Input("friendlyName")]
        public Input<string>? FriendlyName { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// The labels associated with this dataset. You can use these to organize and group your datasets
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// The date when this dataset or any of its tables was last modified, in milliseconds since the epoch.
        /// </summary>
        [Input("lastModifiedTime")]
        public Input<int>? LastModifiedTime { get; set; }

        /// <summary>
        /// The geographic location where the dataset should reside. See [official
        /// docs](https://cloud.google.com/bigquery/docs/dataset-locations). There are two types of locations, regional
        /// or multi-regional. A regional location is a specific geographic place, such as Tokyo, and a multi-regional
        /// location is a large geographic area, such as the United States, that contains at least two geographic
        /// places. Possible regional values include: 'asia-east1', 'asia-northeast1', 'asia-southeast1',
        /// 'australia-southeast1', 'europe-north1', 'europe-west2' and 'us-east4'. Possible multi-regional values: 'EU'
        /// and 'US'. The default value is multi-regional location 'US'. Changing this forces a new resource to be
        /// created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// The URI of the created resource.
        /// </summary>
        [Input("selfLink")]
        public Input<string>? SelfLink { get; set; }

        public DatasetState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class DatasetAccessesArgs : Pulumi.ResourceArgs
    {
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        [Input("groupByEmail")]
        public Input<string>? GroupByEmail { get; set; }

        [Input("role")]
        public Input<string>? Role { get; set; }

        [Input("specialGroup")]
        public Input<string>? SpecialGroup { get; set; }

        [Input("userByEmail")]
        public Input<string>? UserByEmail { get; set; }

        [Input("view")]
        public Input<DatasetAccessesViewArgs>? View { get; set; }

        public DatasetAccessesArgs()
        {
        }
    }

    public sealed class DatasetAccessesGetArgs : Pulumi.ResourceArgs
    {
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        [Input("groupByEmail")]
        public Input<string>? GroupByEmail { get; set; }

        [Input("role")]
        public Input<string>? Role { get; set; }

        [Input("specialGroup")]
        public Input<string>? SpecialGroup { get; set; }

        [Input("userByEmail")]
        public Input<string>? UserByEmail { get; set; }

        [Input("view")]
        public Input<DatasetAccessesViewGetArgs>? View { get; set; }

        public DatasetAccessesGetArgs()
        {
        }
    }

    public sealed class DatasetAccessesViewArgs : Pulumi.ResourceArgs
    {
        [Input("datasetId", required: true)]
        public Input<string> DatasetId { get; set; } = null!;

        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        [Input("tableId", required: true)]
        public Input<string> TableId { get; set; } = null!;

        public DatasetAccessesViewArgs()
        {
        }
    }

    public sealed class DatasetAccessesViewGetArgs : Pulumi.ResourceArgs
    {
        [Input("datasetId", required: true)]
        public Input<string> DatasetId { get; set; } = null!;

        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        [Input("tableId", required: true)]
        public Input<string> TableId { get; set; } = null!;

        public DatasetAccessesViewGetArgs()
        {
        }
    }

    public sealed class DatasetDefaultEncryptionConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("kmsKeyName", required: true)]
        public Input<string> KmsKeyName { get; set; } = null!;

        public DatasetDefaultEncryptionConfigurationArgs()
        {
        }
    }

    public sealed class DatasetDefaultEncryptionConfigurationGetArgs : Pulumi.ResourceArgs
    {
        [Input("kmsKeyName", required: true)]
        public Input<string> KmsKeyName { get; set; } = null!;

        public DatasetDefaultEncryptionConfigurationGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class DatasetAccesses
    {
        public readonly string? Domain;
        public readonly string? GroupByEmail;
        public readonly string? Role;
        public readonly string? SpecialGroup;
        public readonly string? UserByEmail;
        public readonly DatasetAccessesView? View;

        [OutputConstructor]
        private DatasetAccesses(
            string? domain,
            string? groupByEmail,
            string? role,
            string? specialGroup,
            string? userByEmail,
            DatasetAccessesView? view)
        {
            Domain = domain;
            GroupByEmail = groupByEmail;
            Role = role;
            SpecialGroup = specialGroup;
            UserByEmail = userByEmail;
            View = view;
        }
    }

    [OutputType]
    public sealed class DatasetAccessesView
    {
        public readonly string DatasetId;
        public readonly string ProjectId;
        public readonly string TableId;

        [OutputConstructor]
        private DatasetAccessesView(
            string datasetId,
            string projectId,
            string tableId)
        {
            DatasetId = datasetId;
            ProjectId = projectId;
            TableId = tableId;
        }
    }

    [OutputType]
    public sealed class DatasetDefaultEncryptionConfiguration
    {
        public readonly string KmsKeyName;

        [OutputConstructor]
        private DatasetDefaultEncryptionConfiguration(string kmsKeyName)
        {
            KmsKeyName = kmsKeyName;
        }
    }
    }
}
