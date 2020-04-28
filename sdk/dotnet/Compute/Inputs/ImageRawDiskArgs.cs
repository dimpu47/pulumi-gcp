// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class ImageRawDiskArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The format used to encode and transmit the block device, which
        /// should be TAR. This is just a container and transmission format
        /// and not a runtime format. Provided by the client when the disk
        /// image is created.
        /// </summary>
        [Input("containerType")]
        public Input<string>? ContainerType { get; set; }

        /// <summary>
        /// An optional SHA1 checksum of the disk image before unpackaging.
        /// This is provided by the client when the disk image is created.
        /// </summary>
        [Input("sha1")]
        public Input<string>? Sha1 { get; set; }

        /// <summary>
        /// The full Google Cloud Storage URL where disk storage is stored
        /// You must provide either this property or the sourceDisk property
        /// but not both.
        /// </summary>
        [Input("source", required: true)]
        public Input<string> Source { get; set; } = null!;

        public ImageRawDiskArgs()
        {
        }
    }
}
