// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.CloudRun.Outputs
{

    [OutputType]
    public sealed class ServiceTraffic
    {
        /// <summary>
        /// LatestRevision may be optionally provided to indicate that the latest ready
        /// Revision of the Configuration should be used for this traffic target. When
        /// provided LatestRevision must be true if RevisionName is empty; it must be
        /// false when RevisionName is non-empty.
        /// </summary>
        public readonly bool? LatestRevision;
        /// <summary>
        /// Percent specifies percent of the traffic to this Revision or Configuration.
        /// </summary>
        public readonly int Percent;
        /// <summary>
        /// RevisionName of a specific revision to which to send this portion of traffic.
        /// </summary>
        public readonly string? RevisionName;

        [OutputConstructor]
        private ServiceTraffic(
            bool? latestRevision,

            int percent,

            string? revisionName)
        {
            LatestRevision = latestRevision;
            Percent = percent;
            RevisionName = revisionName;
        }
    }
}
