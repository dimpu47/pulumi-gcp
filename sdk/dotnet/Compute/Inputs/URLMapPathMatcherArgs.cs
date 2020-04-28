// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class URLMapPathMatcherArgs : Pulumi.ResourceArgs
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
        public Input<Inputs.URLMapPathMatcherHeaderActionArgs>? HeaderAction { get; set; }

        /// <summary>
        /// The name of the query parameter to match. The query parameter must exist in the
        /// request, in the absence of which the request match fails.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("pathRules")]
        private InputList<Inputs.URLMapPathMatcherPathRuleArgs>? _pathRules;

        /// <summary>
        /// The list of path rules. Use this list instead of routeRules when routing based
        /// on simple path matching is all that's required. The order by which path rules
        /// are specified does not matter. Matches are always done on the longest-path-first
        /// basis. For example: a pathRule with a path /a/b/c/* will match before /a/b/*
        /// irrespective of the order in which those paths appear in this list. Within a
        /// given pathMatcher, only one of pathRules or routeRules must be set.  Structure is documented below.
        /// </summary>
        public InputList<Inputs.URLMapPathMatcherPathRuleArgs> PathRules
        {
            get => _pathRules ?? (_pathRules = new InputList<Inputs.URLMapPathMatcherPathRuleArgs>());
            set => _pathRules = value;
        }

        [Input("routeRules")]
        private InputList<Inputs.URLMapPathMatcherRouteRuleArgs>? _routeRules;

        /// <summary>
        /// The list of ordered HTTP route rules. Use this list instead of pathRules when
        /// advanced route matching and routing actions are desired. The order of specifying
        /// routeRules matters: the first rule that matches will cause its specified routing
        /// action to take effect. Within a given pathMatcher, only one of pathRules or
        /// routeRules must be set. routeRules are not supported in UrlMaps intended for
        /// External load balancers.  Structure is documented below.
        /// </summary>
        public InputList<Inputs.URLMapPathMatcherRouteRuleArgs> RouteRules
        {
            get => _routeRules ?? (_routeRules = new InputList<Inputs.URLMapPathMatcherRouteRuleArgs>());
            set => _routeRules = value;
        }

        public URLMapPathMatcherArgs()
        {
        }
    }
}
