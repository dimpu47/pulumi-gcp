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
    /// UrlMaps are used to route requests to a backend service based on rules
    /// that you define for the host and path of an incoming URL.
    /// 
    /// 
    /// To get more information about UrlMap, see:
    /// 
    /// * [API documentation](https://cloud.google.com/compute/docs/reference/rest/v1/urlMaps)
    /// </summary>
    public partial class URLMap : Pulumi.CustomResource
    {
        /// <summary>
        /// Creation timestamp in RFC3339 text format.
        /// </summary>
        [Output("creationTimestamp")]
        public Output<string> CreationTimestamp { get; private set; } = null!;

        /// <summary>
        /// The backend service or backend bucket to use when none of the given paths match.
        /// </summary>
        [Output("defaultService")]
        public Output<string?> DefaultService { get; private set; } = null!;

        /// <summary>
        /// Description of this test case.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking.
        /// </summary>
        [Output("fingerprint")]
        public Output<string> Fingerprint { get; private set; } = null!;

        /// <summary>
        /// Specifies changes to request and response headers that need to take effect for
        /// the selected backendService. headerAction specified here take effect before
        /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.  Structure is documented below.
        /// </summary>
        [Output("headerAction")]
        public Output<Outputs.URLMapHeaderAction?> HeaderAction { get; private set; } = null!;

        /// <summary>
        /// The list of HostRules to use against the URL.  Structure is documented below.
        /// </summary>
        [Output("hostRules")]
        public Output<ImmutableArray<Outputs.URLMapHostRule>> HostRules { get; private set; } = null!;

        /// <summary>
        /// The unique identifier for the resource.
        /// </summary>
        [Output("mapId")]
        public Output<int> MapId { get; private set; } = null!;

        /// <summary>
        /// The name of the query parameter to match. The query parameter must exist in the
        /// request, in the absence of which the request match fails.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the PathMatcher to use to match the path portion of the URL if the
        /// hostRule matches the URL's host portion.
        /// </summary>
        [Output("pathMatchers")]
        public Output<ImmutableArray<Outputs.URLMapPathMatcher>> PathMatchers { get; private set; } = null!;

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
        /// The list of expected URL mapping tests. Request to update this UrlMap will
        /// succeed only if all of the test cases pass. You can specify a maximum of 100
        /// tests per UrlMap.  Structure is documented below.
        /// </summary>
        [Output("tests")]
        public Output<ImmutableArray<Outputs.URLMapTest>> Tests { get; private set; } = null!;


        /// <summary>
        /// Create a URLMap resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public URLMap(string name, URLMapArgs? args = null, CustomResourceOptions? options = null)
            : base("gcp:compute/uRLMap:URLMap", name, args ?? new URLMapArgs(), MakeResourceOptions(options, ""))
        {
        }

        private URLMap(string name, Input<string> id, URLMapState? state = null, CustomResourceOptions? options = null)
            : base("gcp:compute/uRLMap:URLMap", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing URLMap resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static URLMap Get(string name, Input<string> id, URLMapState? state = null, CustomResourceOptions? options = null)
        {
            return new URLMap(name, id, state, options);
        }
    }

    public sealed class URLMapArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The backend service or backend bucket to use when none of the given paths match.
        /// </summary>
        [Input("defaultService")]
        public Input<string>? DefaultService { get; set; }

        /// <summary>
        /// Description of this test case.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Specifies changes to request and response headers that need to take effect for
        /// the selected backendService. headerAction specified here take effect before
        /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.  Structure is documented below.
        /// </summary>
        [Input("headerAction")]
        public Input<Inputs.URLMapHeaderActionArgs>? HeaderAction { get; set; }

        [Input("hostRules")]
        private InputList<Inputs.URLMapHostRuleArgs>? _hostRules;

        /// <summary>
        /// The list of HostRules to use against the URL.  Structure is documented below.
        /// </summary>
        public InputList<Inputs.URLMapHostRuleArgs> HostRules
        {
            get => _hostRules ?? (_hostRules = new InputList<Inputs.URLMapHostRuleArgs>());
            set => _hostRules = value;
        }

        /// <summary>
        /// The name of the query parameter to match. The query parameter must exist in the
        /// request, in the absence of which the request match fails.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("pathMatchers")]
        private InputList<Inputs.URLMapPathMatcherArgs>? _pathMatchers;

        /// <summary>
        /// The name of the PathMatcher to use to match the path portion of the URL if the
        /// hostRule matches the URL's host portion.
        /// </summary>
        public InputList<Inputs.URLMapPathMatcherArgs> PathMatchers
        {
            get => _pathMatchers ?? (_pathMatchers = new InputList<Inputs.URLMapPathMatcherArgs>());
            set => _pathMatchers = value;
        }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        [Input("tests")]
        private InputList<Inputs.URLMapTestArgs>? _tests;

        /// <summary>
        /// The list of expected URL mapping tests. Request to update this UrlMap will
        /// succeed only if all of the test cases pass. You can specify a maximum of 100
        /// tests per UrlMap.  Structure is documented below.
        /// </summary>
        public InputList<Inputs.URLMapTestArgs> Tests
        {
            get => _tests ?? (_tests = new InputList<Inputs.URLMapTestArgs>());
            set => _tests = value;
        }

        public URLMapArgs()
        {
        }
    }

    public sealed class URLMapState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Creation timestamp in RFC3339 text format.
        /// </summary>
        [Input("creationTimestamp")]
        public Input<string>? CreationTimestamp { get; set; }

        /// <summary>
        /// The backend service or backend bucket to use when none of the given paths match.
        /// </summary>
        [Input("defaultService")]
        public Input<string>? DefaultService { get; set; }

        /// <summary>
        /// Description of this test case.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking.
        /// </summary>
        [Input("fingerprint")]
        public Input<string>? Fingerprint { get; set; }

        /// <summary>
        /// Specifies changes to request and response headers that need to take effect for
        /// the selected backendService. headerAction specified here take effect before
        /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.  Structure is documented below.
        /// </summary>
        [Input("headerAction")]
        public Input<Inputs.URLMapHeaderActionGetArgs>? HeaderAction { get; set; }

        [Input("hostRules")]
        private InputList<Inputs.URLMapHostRuleGetArgs>? _hostRules;

        /// <summary>
        /// The list of HostRules to use against the URL.  Structure is documented below.
        /// </summary>
        public InputList<Inputs.URLMapHostRuleGetArgs> HostRules
        {
            get => _hostRules ?? (_hostRules = new InputList<Inputs.URLMapHostRuleGetArgs>());
            set => _hostRules = value;
        }

        /// <summary>
        /// The unique identifier for the resource.
        /// </summary>
        [Input("mapId")]
        public Input<int>? MapId { get; set; }

        /// <summary>
        /// The name of the query parameter to match. The query parameter must exist in the
        /// request, in the absence of which the request match fails.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("pathMatchers")]
        private InputList<Inputs.URLMapPathMatcherGetArgs>? _pathMatchers;

        /// <summary>
        /// The name of the PathMatcher to use to match the path portion of the URL if the
        /// hostRule matches the URL's host portion.
        /// </summary>
        public InputList<Inputs.URLMapPathMatcherGetArgs> PathMatchers
        {
            get => _pathMatchers ?? (_pathMatchers = new InputList<Inputs.URLMapPathMatcherGetArgs>());
            set => _pathMatchers = value;
        }

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

        [Input("tests")]
        private InputList<Inputs.URLMapTestGetArgs>? _tests;

        /// <summary>
        /// The list of expected URL mapping tests. Request to update this UrlMap will
        /// succeed only if all of the test cases pass. You can specify a maximum of 100
        /// tests per UrlMap.  Structure is documented below.
        /// </summary>
        public InputList<Inputs.URLMapTestGetArgs> Tests
        {
            get => _tests ?? (_tests = new InputList<Inputs.URLMapTestGetArgs>());
            set => _tests = value;
        }

        public URLMapState()
        {
        }
    }
}
