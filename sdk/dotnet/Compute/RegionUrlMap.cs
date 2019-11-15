// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute
{
    /// <summary>
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_region_url_map.html.markdown.
    /// </summary>
    public partial class RegionUrlMap : Pulumi.CustomResource
    {
        /// <summary>
        /// Creation timestamp in RFC3339 text format.
        /// </summary>
        [Output("creationTimestamp")]
        public Output<string> CreationTimestamp { get; private set; } = null!;

        /// <summary>
        /// A reference to RegionBackendService resource if none of the hostRules match.
        /// </summary>
        [Output("defaultService")]
        public Output<string> DefaultService { get; private set; } = null!;

        /// <summary>
        /// An optional description of this resource. Provide this property when you create the resource.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Fingerprint of this resource. This field is used internally during updates of this resource.
        /// </summary>
        [Output("fingerprint")]
        public Output<string> Fingerprint { get; private set; } = null!;

        /// <summary>
        /// The list of HostRules to use against the URL.
        /// </summary>
        [Output("hostRules")]
        public Output<ImmutableArray<Outputs.RegionUrlMapHostRules>> HostRules { get; private set; } = null!;

        /// <summary>
        /// The unique identifier for the resource.
        /// </summary>
        [Output("mapId")]
        public Output<int> MapId { get; private set; } = null!;

        /// <summary>
        /// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters
        /// long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular
        /// expression '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be
        /// a dash.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The list of named PathMatchers to use against the URL.
        /// </summary>
        [Output("pathMatchers")]
        public Output<ImmutableArray<Outputs.RegionUrlMapPathMatchers>> PathMatchers { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// The Region in which the url map should reside. If it is not provided, the provider region is used.
        /// </summary>
        [Output("region")]
        public Output<string> Region { get; private set; } = null!;

        /// <summary>
        /// The URI of the created resource.
        /// </summary>
        [Output("selfLink")]
        public Output<string> SelfLink { get; private set; } = null!;

        /// <summary>
        /// The list of expected URL mappings. Requests to update this UrlMap will succeed only if all of the test cases
        /// pass.
        /// </summary>
        [Output("tests")]
        public Output<ImmutableArray<Outputs.RegionUrlMapTests>> Tests { get; private set; } = null!;


        /// <summary>
        /// Create a RegionUrlMap resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RegionUrlMap(string name, RegionUrlMapArgs args, CustomResourceOptions? options = null)
            : base("gcp:compute/regionUrlMap:RegionUrlMap", name, args, MakeResourceOptions(options, ""))
        {
        }

        private RegionUrlMap(string name, Input<string> id, RegionUrlMapState? state = null, CustomResourceOptions? options = null)
            : base("gcp:compute/regionUrlMap:RegionUrlMap", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing RegionUrlMap resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RegionUrlMap Get(string name, Input<string> id, RegionUrlMapState? state = null, CustomResourceOptions? options = null)
        {
            return new RegionUrlMap(name, id, state, options);
        }
    }

    public sealed class RegionUrlMapArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A reference to RegionBackendService resource if none of the hostRules match.
        /// </summary>
        [Input("defaultService", required: true)]
        public Input<string> DefaultService { get; set; } = null!;

        /// <summary>
        /// An optional description of this resource. Provide this property when you create the resource.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("hostRules")]
        private InputList<Inputs.RegionUrlMapHostRulesArgs>? _hostRules;

        /// <summary>
        /// The list of HostRules to use against the URL.
        /// </summary>
        public InputList<Inputs.RegionUrlMapHostRulesArgs> HostRules
        {
            get => _hostRules ?? (_hostRules = new InputList<Inputs.RegionUrlMapHostRulesArgs>());
            set => _hostRules = value;
        }

        /// <summary>
        /// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters
        /// long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular
        /// expression '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be
        /// a dash.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("pathMatchers")]
        private InputList<Inputs.RegionUrlMapPathMatchersArgs>? _pathMatchers;

        /// <summary>
        /// The list of named PathMatchers to use against the URL.
        /// </summary>
        public InputList<Inputs.RegionUrlMapPathMatchersArgs> PathMatchers
        {
            get => _pathMatchers ?? (_pathMatchers = new InputList<Inputs.RegionUrlMapPathMatchersArgs>());
            set => _pathMatchers = value;
        }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// The Region in which the url map should reside. If it is not provided, the provider region is used.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        [Input("tests")]
        private InputList<Inputs.RegionUrlMapTestsArgs>? _tests;

        /// <summary>
        /// The list of expected URL mappings. Requests to update this UrlMap will succeed only if all of the test cases
        /// pass.
        /// </summary>
        public InputList<Inputs.RegionUrlMapTestsArgs> Tests
        {
            get => _tests ?? (_tests = new InputList<Inputs.RegionUrlMapTestsArgs>());
            set => _tests = value;
        }

        public RegionUrlMapArgs()
        {
        }
    }

    public sealed class RegionUrlMapState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Creation timestamp in RFC3339 text format.
        /// </summary>
        [Input("creationTimestamp")]
        public Input<string>? CreationTimestamp { get; set; }

        /// <summary>
        /// A reference to RegionBackendService resource if none of the hostRules match.
        /// </summary>
        [Input("defaultService")]
        public Input<string>? DefaultService { get; set; }

        /// <summary>
        /// An optional description of this resource. Provide this property when you create the resource.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Fingerprint of this resource. This field is used internally during updates of this resource.
        /// </summary>
        [Input("fingerprint")]
        public Input<string>? Fingerprint { get; set; }

        [Input("hostRules")]
        private InputList<Inputs.RegionUrlMapHostRulesGetArgs>? _hostRules;

        /// <summary>
        /// The list of HostRules to use against the URL.
        /// </summary>
        public InputList<Inputs.RegionUrlMapHostRulesGetArgs> HostRules
        {
            get => _hostRules ?? (_hostRules = new InputList<Inputs.RegionUrlMapHostRulesGetArgs>());
            set => _hostRules = value;
        }

        /// <summary>
        /// The unique identifier for the resource.
        /// </summary>
        [Input("mapId")]
        public Input<int>? MapId { get; set; }

        /// <summary>
        /// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters
        /// long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular
        /// expression '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be
        /// a dash.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("pathMatchers")]
        private InputList<Inputs.RegionUrlMapPathMatchersGetArgs>? _pathMatchers;

        /// <summary>
        /// The list of named PathMatchers to use against the URL.
        /// </summary>
        public InputList<Inputs.RegionUrlMapPathMatchersGetArgs> PathMatchers
        {
            get => _pathMatchers ?? (_pathMatchers = new InputList<Inputs.RegionUrlMapPathMatchersGetArgs>());
            set => _pathMatchers = value;
        }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// The Region in which the url map should reside. If it is not provided, the provider region is used.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// The URI of the created resource.
        /// </summary>
        [Input("selfLink")]
        public Input<string>? SelfLink { get; set; }

        [Input("tests")]
        private InputList<Inputs.RegionUrlMapTestsGetArgs>? _tests;

        /// <summary>
        /// The list of expected URL mappings. Requests to update this UrlMap will succeed only if all of the test cases
        /// pass.
        /// </summary>
        public InputList<Inputs.RegionUrlMapTestsGetArgs> Tests
        {
            get => _tests ?? (_tests = new InputList<Inputs.RegionUrlMapTestsGetArgs>());
            set => _tests = value;
        }

        public RegionUrlMapState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class RegionUrlMapHostRulesArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("hosts", required: true)]
        private InputList<string>? _hosts;
        public InputList<string> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<string>());
            set => _hosts = value;
        }

        [Input("pathMatcher", required: true)]
        public Input<string> PathMatcher { get; set; } = null!;

        public RegionUrlMapHostRulesArgs()
        {
        }
    }

    public sealed class RegionUrlMapHostRulesGetArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("hosts", required: true)]
        private InputList<string>? _hosts;
        public InputList<string> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<string>());
            set => _hosts = value;
        }

        [Input("pathMatcher", required: true)]
        public Input<string> PathMatcher { get; set; } = null!;

        public RegionUrlMapHostRulesGetArgs()
        {
        }
    }

    public sealed class RegionUrlMapPathMatchersArgs : Pulumi.ResourceArgs
    {
        [Input("defaultService", required: true)]
        public Input<string> DefaultService { get; set; } = null!;

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("pathRules")]
        private InputList<RegionUrlMapPathMatchersPathRulesArgs>? _pathRules;
        public InputList<RegionUrlMapPathMatchersPathRulesArgs> PathRules
        {
            get => _pathRules ?? (_pathRules = new InputList<RegionUrlMapPathMatchersPathRulesArgs>());
            set => _pathRules = value;
        }

        public RegionUrlMapPathMatchersArgs()
        {
        }
    }

    public sealed class RegionUrlMapPathMatchersGetArgs : Pulumi.ResourceArgs
    {
        [Input("defaultService", required: true)]
        public Input<string> DefaultService { get; set; } = null!;

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("pathRules")]
        private InputList<RegionUrlMapPathMatchersPathRulesGetArgs>? _pathRules;
        public InputList<RegionUrlMapPathMatchersPathRulesGetArgs> PathRules
        {
            get => _pathRules ?? (_pathRules = new InputList<RegionUrlMapPathMatchersPathRulesGetArgs>());
            set => _pathRules = value;
        }

        public RegionUrlMapPathMatchersGetArgs()
        {
        }
    }

    public sealed class RegionUrlMapPathMatchersPathRulesArgs : Pulumi.ResourceArgs
    {
        [Input("paths", required: true)]
        private InputList<string>? _paths;
        public InputList<string> Paths
        {
            get => _paths ?? (_paths = new InputList<string>());
            set => _paths = value;
        }

        [Input("service", required: true)]
        public Input<string> Service { get; set; } = null!;

        public RegionUrlMapPathMatchersPathRulesArgs()
        {
        }
    }

    public sealed class RegionUrlMapPathMatchersPathRulesGetArgs : Pulumi.ResourceArgs
    {
        [Input("paths", required: true)]
        private InputList<string>? _paths;
        public InputList<string> Paths
        {
            get => _paths ?? (_paths = new InputList<string>());
            set => _paths = value;
        }

        [Input("service", required: true)]
        public Input<string> Service { get; set; } = null!;

        public RegionUrlMapPathMatchersPathRulesGetArgs()
        {
        }
    }

    public sealed class RegionUrlMapTestsArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("host", required: true)]
        public Input<string> Host { get; set; } = null!;

        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        [Input("service", required: true)]
        public Input<string> Service { get; set; } = null!;

        public RegionUrlMapTestsArgs()
        {
        }
    }

    public sealed class RegionUrlMapTestsGetArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("host", required: true)]
        public Input<string> Host { get; set; } = null!;

        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        [Input("service", required: true)]
        public Input<string> Service { get; set; } = null!;

        public RegionUrlMapTestsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class RegionUrlMapHostRules
    {
        public readonly string? Description;
        public readonly ImmutableArray<string> Hosts;
        public readonly string PathMatcher;

        [OutputConstructor]
        private RegionUrlMapHostRules(
            string? description,
            ImmutableArray<string> hosts,
            string pathMatcher)
        {
            Description = description;
            Hosts = hosts;
            PathMatcher = pathMatcher;
        }
    }

    [OutputType]
    public sealed class RegionUrlMapPathMatchers
    {
        public readonly string DefaultService;
        public readonly string? Description;
        public readonly string Name;
        public readonly ImmutableArray<RegionUrlMapPathMatchersPathRules> PathRules;

        [OutputConstructor]
        private RegionUrlMapPathMatchers(
            string defaultService,
            string? description,
            string name,
            ImmutableArray<RegionUrlMapPathMatchersPathRules> pathRules)
        {
            DefaultService = defaultService;
            Description = description;
            Name = name;
            PathRules = pathRules;
        }
    }

    [OutputType]
    public sealed class RegionUrlMapPathMatchersPathRules
    {
        public readonly ImmutableArray<string> Paths;
        public readonly string Service;

        [OutputConstructor]
        private RegionUrlMapPathMatchersPathRules(
            ImmutableArray<string> paths,
            string service)
        {
            Paths = paths;
            Service = service;
        }
    }

    [OutputType]
    public sealed class RegionUrlMapTests
    {
        public readonly string? Description;
        public readonly string Host;
        public readonly string Path;
        public readonly string Service;

        [OutputConstructor]
        private RegionUrlMapTests(
            string? description,
            string host,
            string path,
            string service)
        {
            Description = description;
            Host = host;
            Path = path;
            Service = service;
        }
    }
    }
}
