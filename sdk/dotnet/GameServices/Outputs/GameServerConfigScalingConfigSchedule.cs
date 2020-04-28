// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.GameServices.Outputs
{

    [OutputType]
    public sealed class GameServerConfigScalingConfigSchedule
    {
        /// <summary>
        /// The duration for the cron job event. The duration of the event is effective
        /// after the cron job's start time.
        /// A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".
        /// </summary>
        public readonly string? CronJobDuration;
        /// <summary>
        /// The cron definition of the scheduled event. See
        /// https://en.wikipedia.org/wiki/Cron. Cron spec specifies the local time as
        /// defined by the realm.
        /// </summary>
        public readonly string? CronSpec;
        /// <summary>
        /// The end time of the event.
        /// A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
        /// </summary>
        public readonly string? EndTime;
        /// <summary>
        /// The start time of the event.
        /// A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
        /// </summary>
        public readonly string? StartTime;

        [OutputConstructor]
        private GameServerConfigScalingConfigSchedule(
            string? cronJobDuration,

            string? cronSpec,

            string? endTime,

            string? startTime)
        {
            CronJobDuration = cronJobDuration;
            CronSpec = cronSpec;
            EndTime = endTime;
            StartTime = startTime;
        }
    }
}
