// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Healthcare.Inputs
{

    public sealed class Hl7StoreParserConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Determines whether messages with no header are allowed.
        /// </summary>
        [Input("allowNullHeader")]
        public Input<bool>? AllowNullHeader { get; set; }

        /// <summary>
        /// Byte(s) to be used as the segment terminator. If this is unset, '\r' will be used as segment terminator.
        /// A base64-encoded string.
        /// </summary>
        [Input("segmentTerminator")]
        public Input<string>? SegmentTerminator { get; set; }

        public Hl7StoreParserConfigArgs()
        {
        }
    }
}
