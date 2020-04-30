// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Firebase
{
    public static class GetWebApp
    {
        /// <summary>
        /// A Google Cloud Firebase web application instance
        /// </summary>
        public static Task<GetWebAppResult> InvokeAsync(GetWebAppArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetWebAppResult>("gcp:firebase/getWebApp:getWebApp", args ?? new GetWebAppArgs(), options.WithVersion());
    }


    public sealed class GetWebAppArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The app_ip of name of the Firebase webApp.
        /// </summary>
        [Input("appId", required: true)]
        public string AppId { get; set; } = null!;

        public GetWebAppArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetWebAppResult
    {
        public readonly string AppId;
        public readonly string DisplayName;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        public readonly string Project;

        [OutputConstructor]
        private GetWebAppResult(
            string appId,

            string displayName,

            string id,

            string name,

            string project)
        {
            AppId = appId;
            DisplayName = displayName;
            Id = id;
            Name = name;
            Project = project;
        }
    }
}
