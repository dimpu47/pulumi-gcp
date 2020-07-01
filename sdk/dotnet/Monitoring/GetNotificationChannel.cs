// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Monitoring
{
    public static class GetNotificationChannel
    {
        /// <summary>
        /// A NotificationChannel is a medium through which an alert is delivered
        /// when a policy violation is detected. Examples of channels include email, SMS,
        /// and third-party messaging applications. Fields containing sensitive information
        /// like authentication tokens or contact info are only partially populated on retrieval.
        /// 
        /// 
        /// To get more information about NotificationChannel, see:
        /// 
        /// * [API documentation](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.notificationChannels)
        /// * How-to Guides
        ///     * [Notification Options](https://cloud.google.com/monitoring/support/notification-options)
        ///     * [Monitoring API Documentation](https://cloud.google.com/monitoring/api/v3/)
        /// 
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetNotificationChannelResult> InvokeAsync(GetNotificationChannelArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetNotificationChannelResult>("gcp:monitoring/getNotificationChannel:getNotificationChannel", args ?? new GetNotificationChannelArgs(), options.WithVersion());
    }


    public sealed class GetNotificationChannelArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The display name for this notification channel.
        /// </summary>
        [Input("displayName")]
        public string? DisplayName { get; set; }

        [Input("labels")]
        private Dictionary<string, string>? _labels;

        /// <summary>
        /// Labels (corresponding to the
        /// NotificationChannelDescriptor schema) to filter the notification channels by.
        /// </summary>
        public Dictionary<string, string> Labels
        {
            get => _labels ?? (_labels = new Dictionary<string, string>());
            set => _labels = value;
        }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public string? Project { get; set; }

        /// <summary>
        /// The type of the notification channel.
        /// </summary>
        [Input("type")]
        public string? Type { get; set; }

        [Input("userLabels")]
        private Dictionary<string, string>? _userLabels;

        /// <summary>
        /// User-provided key-value labels to filter by.
        /// </summary>
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
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string>? Labels;
        public readonly string Name;
        public readonly string? Project;
        public readonly ImmutableArray<Outputs.GetNotificationChannelSensitiveLabelResult> SensitiveLabels;
        public readonly string? Type;
        public readonly ImmutableDictionary<string, string>? UserLabels;
        public readonly string VerificationStatus;

        [OutputConstructor]
        private GetNotificationChannelResult(
            string description,

            string? displayName,

            bool enabled,

            string id,

            ImmutableDictionary<string, string>? labels,

            string name,

            string? project,

            ImmutableArray<Outputs.GetNotificationChannelSensitiveLabelResult> sensitiveLabels,

            string? type,

            ImmutableDictionary<string, string>? userLabels,

            string verificationStatus)
        {
            Description = description;
            DisplayName = displayName;
            Enabled = enabled;
            Id = id;
            Labels = labels;
            Name = name;
            Project = project;
            SensitiveLabels = sensitiveLabels;
            Type = type;
            UserLabels = userLabels;
            VerificationStatus = verificationStatus;
        }
    }
}
