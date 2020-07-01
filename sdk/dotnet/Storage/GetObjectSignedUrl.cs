// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Storage
{
    public static class GetObjectSignedUrl
    {
        /// <summary>
        /// The Google Cloud storage signed URL data source generates a signed URL for a given storage object. Signed URLs provide a way to give time-limited read or write access to anyone in possession of the URL, regardless of whether they have a Google account.
        /// 
        /// For more info about signed URL's is available [here](https://cloud.google.com/storage/docs/access-control/signed-urls).
        /// </summary>
        public static Task<GetObjectSignedUrlResult> InvokeAsync(GetObjectSignedUrlArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetObjectSignedUrlResult>("gcp:storage/getObjectSignedUrl:getObjectSignedUrl", args ?? new GetObjectSignedUrlArgs(), options.WithVersion());
    }


    public sealed class GetObjectSignedUrlArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the bucket to read the object from
        /// </summary>
        [Input("bucket", required: true)]
        public string Bucket { get; set; } = null!;

        /// <summary>
        /// The [MD5 digest](https://cloud.google.com/storage/docs/hashes-etags#_MD5) value in Base64.
        /// Typically retrieved from `google_storage_bucket_object.object.md5hash` attribute.
        /// If you provide this in the datasource, the client (e.g. browser, curl) must provide the `Content-MD5` HTTP header with this same value in its request.
        /// </summary>
        [Input("contentMd5")]
        public string? ContentMd5 { get; set; }

        /// <summary>
        /// If you specify this in the datasource, the client must provide the `Content-Type` HTTP header with the same value in its request.
        /// </summary>
        [Input("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// What Google service account credentials json should be used to sign the URL.
        /// This data source checks the following locations for credentials, in order of preference: data source `credentials` attribute, provider `credentials` attribute and finally the GOOGLE_APPLICATION_CREDENTIALS environment variable.
        /// </summary>
        [Input("credentials")]
        public string? Credentials { get; set; }

        /// <summary>
        /// For how long shall the signed URL be valid (defaults to 1 hour - i.e. `1h`).
        /// See [here](https://golang.org/pkg/time/#ParseDuration) for info on valid duration formats.
        /// </summary>
        [Input("duration")]
        public string? Duration { get; set; }

        [Input("extensionHeaders")]
        private Dictionary<string, string>? _extensionHeaders;

        /// <summary>
        /// As needed. The server checks to make sure that the client provides matching values in requests using the signed URL.
        /// Any header starting with `x-goog-` is accepted but see the [Google Docs](https://cloud.google.com/storage/docs/xml-api/reference-headers) for list of headers that are supported by Google.
        /// </summary>
        public Dictionary<string, string> ExtensionHeaders
        {
            get => _extensionHeaders ?? (_extensionHeaders = new Dictionary<string, string>());
            set => _extensionHeaders = value;
        }

        /// <summary>
        /// What HTTP Method will the signed URL allow (defaults to `GET`)
        /// </summary>
        [Input("httpMethod")]
        public string? HttpMethod { get; set; }

        /// <summary>
        /// The full path to the object inside the bucket
        /// </summary>
        [Input("path", required: true)]
        public string Path { get; set; } = null!;

        public GetObjectSignedUrlArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetObjectSignedUrlResult
    {
        public readonly string Bucket;
        public readonly string? ContentMd5;
        public readonly string? ContentType;
        public readonly string? Credentials;
        public readonly string? Duration;
        public readonly ImmutableDictionary<string, string>? ExtensionHeaders;
        public readonly string? HttpMethod;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Path;
        /// <summary>
        /// The signed URL that can be used to access the storage object without authentication.
        /// </summary>
        public readonly string SignedUrl;

        [OutputConstructor]
        private GetObjectSignedUrlResult(
            string bucket,

            string? contentMd5,

            string? contentType,

            string? credentials,

            string? duration,

            ImmutableDictionary<string, string>? extensionHeaders,

            string? httpMethod,

            string id,

            string path,

            string signedUrl)
        {
            Bucket = bucket;
            ContentMd5 = contentMd5;
            ContentType = contentType;
            Credentials = credentials;
            Duration = duration;
            ExtensionHeaders = extensionHeaders;
            HttpMethod = httpMethod;
            Id = id;
            Path = path;
            SignedUrl = signedUrl;
        }
    }
}
