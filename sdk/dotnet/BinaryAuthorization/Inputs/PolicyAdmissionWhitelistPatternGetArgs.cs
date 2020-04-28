// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.BinaryAuthorization.Inputs
{

    public sealed class PolicyAdmissionWhitelistPatternGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// An image name pattern to whitelist, in the form
        /// `registry/path/to/image`. This supports a trailing * as a
        /// wildcard, but this is allowed only in text after the registry/
        /// part.
        /// </summary>
        [Input("namePattern", required: true)]
        public Input<string> NamePattern { get; set; } = null!;

        public PolicyAdmissionWhitelistPatternGetArgs()
        {
        }
    }
}
