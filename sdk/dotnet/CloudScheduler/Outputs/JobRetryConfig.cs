// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.CloudScheduler.Outputs
{

    [OutputType]
    public sealed class JobRetryConfig
    {
        /// <summary>
        /// The maximum amount of time to wait before retrying a job after it fails.
        /// A duration in seconds with up to nine fractional digits, terminated by 's'.
        /// </summary>
        public readonly string? MaxBackoffDuration;
        /// <summary>
        /// The time between retries will double maxDoublings times.
        /// A job's retry interval starts at minBackoffDuration,
        /// then doubles maxDoublings times, then increases linearly,
        /// and finally retries retries at intervals of maxBackoffDuration up to retryCount times.
        /// </summary>
        public readonly int? MaxDoublings;
        /// <summary>
        /// The time limit for retrying a failed job, measured from time when an execution was first attempted.
        /// If specified with retryCount, the job will be retried until both limits are reached.
        /// A duration in seconds with up to nine fractional digits, terminated by 's'.
        /// </summary>
        public readonly string? MaxRetryDuration;
        /// <summary>
        /// The minimum amount of time to wait before retrying a job after it fails.
        /// A duration in seconds with up to nine fractional digits, terminated by 's'.
        /// </summary>
        public readonly string? MinBackoffDuration;
        /// <summary>
        /// The number of attempts that the system will make to run a
        /// job using the exponential backoff procedure described by maxDoublings.
        /// Values greater than 5 and negative values are not allowed.
        /// </summary>
        public readonly int? RetryCount;

        [OutputConstructor]
        private JobRetryConfig(
            string? maxBackoffDuration,

            int? maxDoublings,

            string? maxRetryDuration,

            string? minBackoffDuration,

            int? retryCount)
        {
            MaxBackoffDuration = maxBackoffDuration;
            MaxDoublings = maxDoublings;
            MaxRetryDuration = maxRetryDuration;
            MinBackoffDuration = minBackoffDuration;
            RetryCount = retryCount;
        }
    }
}
