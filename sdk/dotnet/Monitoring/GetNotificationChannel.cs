// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Monitoring
{
    public static partial class Invokes
    {
        public static Task<GetNotificationChannelResult> GetNotificationChannel(GetNotificationChannelArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetNotificationChannelResult>("gcp:monitoring/getNotificationChannel:getNotificationChannel", args ?? InvokeArgs.Empty, options.WithVersion());
    }

    public sealed class GetNotificationChannelArgs : Pulumi.InvokeArgs
    {
        [Input("displayName")]
        public string? DisplayName { get; set; }

        [Input("labels")]
        private Dictionary<string, string>? _labels;
        public Dictionary<string, string> Labels
        {
            get => _labels ?? (_labels = new Dictionary<string, string>());
            set => _labels = value;
        }

        [Input("project")]
        public string? Project { get; set; }

        [Input("type")]
        public string? Type { get; set; }

        [Input("userLabels")]
        private Dictionary<string, string>? _userLabels;
        public Dictionary<string, string> UserLabels
        {
            get => _userLabels ?? (_userLabels = new Dictionary<string, string>());
            set => _userLabels = value;
        }

        public GetNotificationChannelArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetNotificationChannelResult
    {
        public readonly string Description;
        public readonly string? DisplayName;
        public readonly bool Enabled;
        public readonly ImmutableDictionary<string, string>? Labels;
        public readonly string Name;
        public readonly string? Project;
        public readonly string? Type;
        public readonly ImmutableDictionary<string, string>? UserLabels;
        public readonly string VerificationStatus;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetNotificationChannelResult(
            string description,
            string? displayName,
            bool enabled,
            ImmutableDictionary<string, string>? labels,
            string name,
            string? project,
            string? type,
            ImmutableDictionary<string, string>? userLabels,
            string verificationStatus,
            string id)
        {
            Description = description;
            DisplayName = displayName;
            Enabled = enabled;
            Labels = labels;
            Name = name;
            Project = project;
            Type = type;
            UserLabels = userLabels;
            VerificationStatus = verificationStatus;
            Id = id;
        }
    }
}
