// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class URLMapPathMatcherRouteRuleRouteActionCorsPolicyGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// In response to a preflight request, setting this to true indicates that the
        /// actual request can include user credentials. This translates to the Access-
        /// Control-Allow-Credentials header. Defaults to false.
        /// </summary>
        [Input("allowCredentials")]
        public Input<bool>? AllowCredentials { get; set; }

        [Input("allowHeaders")]
        private InputList<string>? _allowHeaders;

        /// <summary>
        /// Specifies the content for the Access-Control-Allow-Headers header.
        /// </summary>
        public InputList<string> AllowHeaders
        {
            get => _allowHeaders ?? (_allowHeaders = new InputList<string>());
            set => _allowHeaders = value;
        }

        [Input("allowMethods")]
        private InputList<string>? _allowMethods;

        /// <summary>
        /// Specifies the content for the Access-Control-Allow-Methods header.
        /// </summary>
        public InputList<string> AllowMethods
        {
            get => _allowMethods ?? (_allowMethods = new InputList<string>());
            set => _allowMethods = value;
        }

        [Input("allowOriginRegexes")]
        private InputList<string>? _allowOriginRegexes;

        /// <summary>
        /// Specifies the regualar expression patterns that match allowed origins. For
        /// regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript
        /// An origin is allowed if it matches either allow_origins or allow_origin_regex.
        /// </summary>
        public InputList<string> AllowOriginRegexes
        {
            get => _allowOriginRegexes ?? (_allowOriginRegexes = new InputList<string>());
            set => _allowOriginRegexes = value;
        }

        [Input("allowOrigins")]
        private InputList<string>? _allowOrigins;

        /// <summary>
        /// Specifies the list of origins that will be allowed to do CORS requests. An
        /// origin is allowed if it matches either allow_origins or allow_origin_regex.
        /// </summary>
        public InputList<string> AllowOrigins
        {
            get => _allowOrigins ?? (_allowOrigins = new InputList<string>());
            set => _allowOrigins = value;
        }

        /// <summary>
        /// If true, specifies the CORS policy is disabled.
        /// which indicates that the CORS policy is in effect. Defaults to false.
        /// </summary>
        [Input("disabled")]
        public Input<bool>? Disabled { get; set; }

        [Input("exposeHeaders")]
        private InputList<string>? _exposeHeaders;

        /// <summary>
        /// Specifies the content for the Access-Control-Expose-Headers header.
        /// </summary>
        public InputList<string> ExposeHeaders
        {
            get => _exposeHeaders ?? (_exposeHeaders = new InputList<string>());
            set => _exposeHeaders = value;
        }

        /// <summary>
        /// Specifies how long the results of a preflight request can be cached. This
        /// translates to the content for the Access-Control-Max-Age header.
        /// </summary>
        [Input("maxAge")]
        public Input<int>? MaxAge { get; set; }

        public URLMapPathMatcherRouteRuleRouteActionCorsPolicyGetArgs()
        {
        }
    }
}
