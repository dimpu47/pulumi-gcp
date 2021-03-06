// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.DataLoss.Outputs
{

    [OutputType]
    public sealed class PreventionJobTriggerInspectJobStorageConfigBigQueryOptionsTableReference
    {
        /// <summary>
        /// Dataset ID of the table.
        /// </summary>
        public readonly string DatasetId;
        /// <summary>
        /// The Google Cloud Platform project ID of the project containing the table.
        /// </summary>
        public readonly string ProjectId;
        /// <summary>
        /// Name of the table. If is not set a new one will be generated for you with the following format:
        /// `dlp_googleapis_yyyy_mm_dd_[dlp_job_id]`. Pacific timezone will be used for generating the date details.
        /// </summary>
        public readonly string TableId;

        [OutputConstructor]
        private PreventionJobTriggerInspectJobStorageConfigBigQueryOptionsTableReference(
            string datasetId,

            string projectId,

            string tableId)
        {
            DatasetId = datasetId;
            ProjectId = projectId;
            TableId = tableId;
        }
    }
}
