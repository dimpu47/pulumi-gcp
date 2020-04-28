// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.AppEngine.Outputs
{

    [OutputType]
    public sealed class ApplicationUrlDispatchRulesDispatchRule
    {
        /// <summary>
        /// Domain name to match against. The wildcard "*" is supported if specified before a period: "*.".
        /// Defaults to matching all domains: "*".
        /// </summary>
        public readonly string? Domain;
        /// <summary>
        /// Pathname within the host. Must start with a "/". A single "*" can be included at the end of the path.
        /// The sum of the lengths of the domain and path may not exceed 100 characters.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// Pathname within the host. Must start with a "/". A single "*" can be included at the end of the path.
        /// The sum of the lengths of the domain and path may not exceed 100 characters.
        /// </summary>
        public readonly string Service;

        [OutputConstructor]
        private ApplicationUrlDispatchRulesDispatchRule(
            string? domain,

            string path,

            string service)
        {
            Domain = domain;
            Path = path;
            Service = service;
        }
    }
}
