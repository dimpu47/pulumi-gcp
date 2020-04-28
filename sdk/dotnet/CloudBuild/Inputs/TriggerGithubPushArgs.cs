// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.CloudBuild.Inputs
{

    public sealed class TriggerGithubPushArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Regex of branches to match.  Specify only one of branch or tag.
        /// </summary>
        [Input("branch")]
        public Input<string>? Branch { get; set; }

        /// <summary>
        /// Regex of tags to match.  Specify only one of branch or tag.
        /// </summary>
        [Input("tag")]
        public Input<string>? Tag { get; set; }

        public TriggerGithubPushArgs()
        {
        }
    }
}
