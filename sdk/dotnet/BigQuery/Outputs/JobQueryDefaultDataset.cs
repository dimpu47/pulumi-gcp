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
    public sealed class JobQueryDefaultDataset
    {
        /// <summary>
        /// The ID of the dataset containing this model.
        /// </summary>
        public readonly string DatasetId;
        /// <summary>
        /// The ID of the project containing this model.
        /// </summary>
        public readonly string? ProjectId;

        [OutputConstructor]
        private JobQueryDefaultDataset(
            string datasetId,

            string? projectId)
        {
            DatasetId = datasetId;
            ProjectId = projectId;
        }
    }
}
