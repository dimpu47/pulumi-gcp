// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.BigQuery.Outputs
{

    [OutputType]
    public sealed class JobLoadTimePartitioning
    {
        /// <summary>
        /// Number of milliseconds for which to keep the storage for a partition. A wrapper is used here because 0 is an invalid value.
        /// </summary>
        public readonly string? ExpirationMs;
        /// <summary>
        /// If not set, the table is partitioned by pseudo column '_PARTITIONTIME'; if set, the table is partitioned by this field.
        /// The field must be a top-level TIMESTAMP or DATE field. Its mode must be NULLABLE or REQUIRED.
        /// A wrapper is used here because an empty string is an invalid value.
        /// </summary>
        public readonly string? Field;
        /// <summary>
        /// The only type supported is DAY, which will generate one partition per day. Providing an empty string used to cause an error,
        /// but in OnePlatform the field will be treated as unset.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private JobLoadTimePartitioning(
            string? expirationMs,

            string? field,

            string type)
        {
            ExpirationMs = expirationMs;
            Field = field;
            Type = type;
        }
    }
}
