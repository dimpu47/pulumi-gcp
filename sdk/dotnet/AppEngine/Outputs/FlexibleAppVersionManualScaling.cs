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
    public sealed class FlexibleAppVersionManualScaling
    {
        /// <summary>
        /// Number of instances to assign to the service at the start. This number can later be altered by using the Modules API set_num_instances() function.
        /// </summary>
        public readonly int Instances;

        [OutputConstructor]
        private FlexibleAppVersionManualScaling(int instances)
        {
            Instances = instances;
        }
    }
}
