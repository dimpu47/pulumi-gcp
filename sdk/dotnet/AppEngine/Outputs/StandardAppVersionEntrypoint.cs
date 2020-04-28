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
    public sealed class StandardAppVersionEntrypoint
    {
        /// <summary>
        /// The format should be a shell command that can be fed to bash -c.
        /// </summary>
        public readonly string Shell;

        [OutputConstructor]
        private StandardAppVersionEntrypoint(string shell)
        {
            Shell = shell;
        }
    }
}
