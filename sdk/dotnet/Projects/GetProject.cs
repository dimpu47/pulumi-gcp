// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Projects
{
    public static partial class Invokes
    {
        /// <summary>
        /// Retrieve information about a set of projects based on a filter. See the
        /// [REST API](https://cloud.google.com/resource-manager/reference/rest/v1/projects/list)
        /// for more details.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/d/google_projects.html.markdown.
        /// </summary>
        public static Task<GetProjectResult> GetProject(GetProjectArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetProjectResult>("gcp:projects/getProject:getProject", args ?? InvokeArgs.Empty, options.WithVersion());
    }

    public sealed class GetProjectArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// A string filter as defined in the [REST API](https://cloud.google.com/resource-manager/reference/rest/v1/projects/list#query-parameters).
        /// </summary>
        [Input("filter", required: true)]
        public string Filter { get; set; } = null!;

        public GetProjectArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetProjectResult
    {
        public readonly string Filter;
        /// <summary>
        /// A list of projects matching the provided filter. Structure is defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectProjectsResult> Projects;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetProjectResult(
            string filter,
            ImmutableArray<Outputs.GetProjectProjectsResult> projects,
            string id)
        {
            Filter = filter;
            Projects = projects;
            Id = id;
        }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetProjectProjectsResult
    {
        /// <summary>
        /// The project id of the project.
        /// </summary>
        public readonly string ProjectId;

        [OutputConstructor]
        private GetProjectProjectsResult(string projectId)
        {
            ProjectId = projectId;
        }
    }
    }
}
