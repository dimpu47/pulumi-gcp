// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Logging.Outputs
{

    [OutputType]
    public sealed class MetricBucketOptionsLinearBuckets
    {
        /// <summary>
        /// Must be greater than 0.
        /// </summary>
        public readonly int? NumFiniteBuckets;
        /// <summary>
        /// Lower bound of the first bucket.
        /// </summary>
        public readonly double? Offset;
        /// <summary>
        /// Must be greater than 0.
        /// </summary>
        public readonly int? Width;

        [OutputConstructor]
        private MetricBucketOptionsLinearBuckets(
            int? numFiniteBuckets,

            double? offset,

            int? width)
        {
            NumFiniteBuckets = numFiniteBuckets;
            Offset = offset;
            Width = width;
        }
    }
}
