// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class SecurityScanConfigAuthenticationCustomAccountArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The login form URL of the website.
        /// </summary>
        [Input("loginUrl", required: true)]
        public Input<string> LoginUrl { get; set; } = null!;

        /// <summary>
        /// The password of the custom account. The credential is stored encrypted
        /// in GCP.
        /// </summary>
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        /// <summary>
        /// The user name of the custom account.
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public SecurityScanConfigAuthenticationCustomAccountArgs()
        {
        }
    }
}
