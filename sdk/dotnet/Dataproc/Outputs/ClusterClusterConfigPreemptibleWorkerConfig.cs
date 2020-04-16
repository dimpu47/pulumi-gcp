// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Dataproc.Outputs
{

    [OutputType]
    public sealed class ClusterClusterConfigPreemptibleWorkerConfig
    {
        /// <summary>
        /// Disk Config
        /// </summary>
        public readonly Outputs.ClusterClusterConfigPreemptibleWorkerConfigDiskConfig? DiskConfig;
        public readonly ImmutableArray<string> InstanceNames;
        public readonly int? NumInstances;

        [OutputConstructor]
        private ClusterClusterConfigPreemptibleWorkerConfig(
            Outputs.ClusterClusterConfigPreemptibleWorkerConfigDiskConfig? diskConfig,

            ImmutableArray<string> instanceNames,

            int? numInstances)
        {
            DiskConfig = diskConfig;
            InstanceNames = instanceNames;
            NumInstances = numInstances;
        }
    }
}