// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.AppEngine.Inputs
{

    public sealed class FlexibleAppVersionDeploymentContainerGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// URI to the hosted container image in Google Container Registry. The URI must be fully qualified and include a tag or digest.
        /// Examples: "gcr.io/my-project/image:tag" or "gcr.io/my-project/image@digest"
        /// </summary>
        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        public FlexibleAppVersionDeploymentContainerGetArgs()
        {
        }
    }
}
