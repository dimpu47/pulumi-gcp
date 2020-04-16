// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Composer.Outputs
{

    [OutputType]
    public sealed class EnvironmentConfigNodeConfigIpAllocationPolicy
    {
        public readonly string? ClusterIpv4CidrBlock;
        public readonly string? ClusterSecondaryRangeName;
        public readonly string? ServicesIpv4CidrBlock;
        public readonly string? ServicesSecondaryRangeName;
        public readonly bool UseIpAliases;

        [OutputConstructor]
        private EnvironmentConfigNodeConfigIpAllocationPolicy(
            string? clusterIpv4CidrBlock,

            string? clusterSecondaryRangeName,

            string? servicesIpv4CidrBlock,

            string? servicesSecondaryRangeName,

            bool useIpAliases)
        {
            ClusterIpv4CidrBlock = clusterIpv4CidrBlock;
            ClusterSecondaryRangeName = clusterSecondaryRangeName;
            ServicesIpv4CidrBlock = servicesIpv4CidrBlock;
            ServicesSecondaryRangeName = servicesSecondaryRangeName;
            UseIpAliases = useIpAliases;
        }
    }
}