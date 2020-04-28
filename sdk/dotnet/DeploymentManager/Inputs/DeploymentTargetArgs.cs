// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.DeploymentManager.Inputs
{

    public sealed class DeploymentTargetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The root configuration file to use for this deployment.  Structure is documented below.
        /// </summary>
        [Input("config", required: true)]
        public Input<Inputs.DeploymentTargetConfigArgs> Config { get; set; } = null!;

        [Input("imports")]
        private InputList<Inputs.DeploymentTargetImportArgs>? _imports;

        /// <summary>
        /// Specifies import files for this configuration. This can be
        /// used to import templates or other files. For example, you might
        /// import a text file in order to use the file in a template.  Structure is documented below.
        /// </summary>
        public InputList<Inputs.DeploymentTargetImportArgs> Imports
        {
            get => _imports ?? (_imports = new InputList<Inputs.DeploymentTargetImportArgs>());
            set => _imports = value;
        }

        public DeploymentTargetArgs()
        {
        }
    }
}
