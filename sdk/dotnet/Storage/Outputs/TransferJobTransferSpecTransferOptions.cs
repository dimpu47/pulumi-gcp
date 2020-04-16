// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Storage.Outputs
{

    [OutputType]
    public sealed class TransferJobTransferSpecTransferOptions
    {
        /// <summary>
        /// Whether objects should be deleted from the source after they are transferred to the sink. Note that this option and `delete_objects_unique_in_sink` are mutually exclusive.
        /// </summary>
        public readonly bool? DeleteObjectsFromSourceAfterTransfer;
        /// <summary>
        /// Whether objects that exist only in the sink should be deleted. Note that this option and
        /// `delete_objects_from_source_after_transfer` are mutually exclusive.
        /// </summary>
        public readonly bool? DeleteObjectsUniqueInSink;
        /// <summary>
        /// Whether overwriting objects that already exist in the sink is allowed.
        /// </summary>
        public readonly bool? OverwriteObjectsAlreadyExistingInSink;

        [OutputConstructor]
        private TransferJobTransferSpecTransferOptions(
            bool? deleteObjectsFromSourceAfterTransfer,

            bool? deleteObjectsUniqueInSink,

            bool? overwriteObjectsAlreadyExistingInSink)
        {
            DeleteObjectsFromSourceAfterTransfer = deleteObjectsFromSourceAfterTransfer;
            DeleteObjectsUniqueInSink = deleteObjectsUniqueInSink;
            OverwriteObjectsAlreadyExistingInSink = overwriteObjectsAlreadyExistingInSink;
        }
    }
}