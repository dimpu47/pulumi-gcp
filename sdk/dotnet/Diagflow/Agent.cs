// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Diagflow
{
    /// <summary>
    /// A Dialogflow agent is a virtual agent that handles conversations with your end-users. It is a natural language
    /// understanding module that understands the nuances of human language. Dialogflow translates end-user text or audio
    /// during a conversation to structured data that your apps and services can understand. You design and build a Dialogflow
    /// agent to handle the types of conversations required for your system.
    /// 
    /// To get more information about Agent, see:
    /// 
    /// * [API documentation](https://cloud.google.com/dialogflow/docs/reference/rest/v2/projects/agent)
    /// * How-to Guides
    ///     * [Official Documentation](https://cloud.google.com/dialogflow/docs/)
    /// 
    /// ## Example Usage
    /// </summary>
    public partial class Agent : Pulumi.CustomResource
    {
        /// <summary>
        /// API version displayed in Dialogflow console. If not specified, V2 API is assumed. Clients are free to query
        /// different service endpoints for different API versions. However, bots connectors and webhook calls will follow
        /// the specified API version.
        /// * API_VERSION_V1: Legacy V1 API.
        /// * API_VERSION_V2: V2 API.
        /// * API_VERSION_V2_BETA_1: V2beta1 API.
        /// </summary>
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        /// <summary>
        /// The URI of the agent's avatar, which are used throughout the Dialogflow console. When an image URL is entered
        /// into this field, the Dialogflow will save the image in the backend. The address of the backend image returned
        /// from the API will be shown in the [avatarUriBackend] field.
        /// </summary>
        [Output("avatarUri")]
        public Output<string?> AvatarUri { get; private set; } = null!;

        /// <summary>
        /// The URI of the agent's avatar as returned from the API. Output only. To provide an image URL for the agent avatar, the
        /// [avatarUri] field can be used.
        /// </summary>
        [Output("avatarUriBackend")]
        public Output<string> AvatarUriBackend { get; private set; } = null!;

        /// <summary>
        /// To filter out false positive results and still get variety in matched natural language inputs for your agent,
        /// you can tune the machine learning classification threshold. If the returned score value is less than the threshold
        /// value, then a fallback intent will be triggered or, if there are no fallback intents defined, no intent will be
        /// triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the
        /// default of 0.3 is used.
        /// </summary>
        [Output("classificationThreshold")]
        public Output<double?> ClassificationThreshold { get; private set; } = null!;

        /// <summary>
        /// The default language of the agent as a language tag. [See Language Support](https://cloud.google.com/dialogflow/docs/reference/language)
        /// for a list of the currently supported language codes. This field cannot be updated after creation.
        /// </summary>
        [Output("defaultLanguageCode")]
        public Output<string> DefaultLanguageCode { get; private set; } = null!;

        /// <summary>
        /// The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The name of this agent.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// Determines whether this agent should log conversation queries.
        /// </summary>
        [Output("enableLogging")]
        public Output<bool?> EnableLogging { get; private set; } = null!;

        /// <summary>
        /// Determines how intents are detected from user queries.
        /// * MATCH_MODE_HYBRID: Best for agents with a small number of examples in intents and/or wide use of templates
        /// syntax and composite entities.
        /// * MATCH_MODE_ML_ONLY: Can be used for agents with a large number of examples in intents, especially the ones
        /// using @sys.any or very large developer entities.
        /// </summary>
        [Output("matchMode")]
        public Output<string> MatchMode { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// The list of all languages supported by this agent (except for the defaultLanguageCode).
        /// </summary>
        [Output("supportedLanguageCodes")]
        public Output<ImmutableArray<string>> SupportedLanguageCodes { get; private set; } = null!;

        /// <summary>
        /// The agent tier. If not specified, TIER_STANDARD is assumed.
        /// * TIER_STANDARD: Standard tier.
        /// * TIER_ENTERPRISE: Enterprise tier (Essentials).
        /// * TIER_ENTERPRISE_PLUS: Enterprise tier (Plus).
        /// NOTE: Due to consistency issues, the provider will not read this field from the API. Drift is possible between
        /// the the provider state and Dialogflow if the agent tier is changed outside of the provider.
        /// </summary>
        [Output("tier")]
        public Output<string?> Tier { get; private set; } = null!;

        /// <summary>
        /// The time zone of this agent from the [time zone database](https://www.iana.org/time-zones), e.g., America/New_York,
        /// Europe/Paris.
        /// </summary>
        [Output("timeZone")]
        public Output<string> TimeZone { get; private set; } = null!;


        /// <summary>
        /// Create a Agent resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Agent(string name, AgentArgs args, CustomResourceOptions? options = null)
            : base("gcp:diagflow/agent:Agent", name, args ?? new AgentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Agent(string name, Input<string> id, AgentState? state = null, CustomResourceOptions? options = null)
            : base("gcp:diagflow/agent:Agent", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Agent resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Agent Get(string name, Input<string> id, AgentState? state = null, CustomResourceOptions? options = null)
        {
            return new Agent(name, id, state, options);
        }
    }

    public sealed class AgentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// API version displayed in Dialogflow console. If not specified, V2 API is assumed. Clients are free to query
        /// different service endpoints for different API versions. However, bots connectors and webhook calls will follow
        /// the specified API version.
        /// * API_VERSION_V1: Legacy V1 API.
        /// * API_VERSION_V2: V2 API.
        /// * API_VERSION_V2_BETA_1: V2beta1 API.
        /// </summary>
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        /// <summary>
        /// The URI of the agent's avatar, which are used throughout the Dialogflow console. When an image URL is entered
        /// into this field, the Dialogflow will save the image in the backend. The address of the backend image returned
        /// from the API will be shown in the [avatarUriBackend] field.
        /// </summary>
        [Input("avatarUri")]
        public Input<string>? AvatarUri { get; set; }

        /// <summary>
        /// To filter out false positive results and still get variety in matched natural language inputs for your agent,
        /// you can tune the machine learning classification threshold. If the returned score value is less than the threshold
        /// value, then a fallback intent will be triggered or, if there are no fallback intents defined, no intent will be
        /// triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the
        /// default of 0.3 is used.
        /// </summary>
        [Input("classificationThreshold")]
        public Input<double>? ClassificationThreshold { get; set; }

        /// <summary>
        /// The default language of the agent as a language tag. [See Language Support](https://cloud.google.com/dialogflow/docs/reference/language)
        /// for a list of the currently supported language codes. This field cannot be updated after creation.
        /// </summary>
        [Input("defaultLanguageCode", required: true)]
        public Input<string> DefaultLanguageCode { get; set; } = null!;

        /// <summary>
        /// The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The name of this agent.
        /// </summary>
        [Input("displayName", required: true)]
        public Input<string> DisplayName { get; set; } = null!;

        /// <summary>
        /// Determines whether this agent should log conversation queries.
        /// </summary>
        [Input("enableLogging")]
        public Input<bool>? EnableLogging { get; set; }

        /// <summary>
        /// Determines how intents are detected from user queries.
        /// * MATCH_MODE_HYBRID: Best for agents with a small number of examples in intents and/or wide use of templates
        /// syntax and composite entities.
        /// * MATCH_MODE_ML_ONLY: Can be used for agents with a large number of examples in intents, especially the ones
        /// using @sys.any or very large developer entities.
        /// </summary>
        [Input("matchMode")]
        public Input<string>? MatchMode { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        [Input("supportedLanguageCodes")]
        private InputList<string>? _supportedLanguageCodes;

        /// <summary>
        /// The list of all languages supported by this agent (except for the defaultLanguageCode).
        /// </summary>
        public InputList<string> SupportedLanguageCodes
        {
            get => _supportedLanguageCodes ?? (_supportedLanguageCodes = new InputList<string>());
            set => _supportedLanguageCodes = value;
        }

        /// <summary>
        /// The agent tier. If not specified, TIER_STANDARD is assumed.
        /// * TIER_STANDARD: Standard tier.
        /// * TIER_ENTERPRISE: Enterprise tier (Essentials).
        /// * TIER_ENTERPRISE_PLUS: Enterprise tier (Plus).
        /// NOTE: Due to consistency issues, the provider will not read this field from the API. Drift is possible between
        /// the the provider state and Dialogflow if the agent tier is changed outside of the provider.
        /// </summary>
        [Input("tier")]
        public Input<string>? Tier { get; set; }

        /// <summary>
        /// The time zone of this agent from the [time zone database](https://www.iana.org/time-zones), e.g., America/New_York,
        /// Europe/Paris.
        /// </summary>
        [Input("timeZone", required: true)]
        public Input<string> TimeZone { get; set; } = null!;

        public AgentArgs()
        {
        }
    }

    public sealed class AgentState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// API version displayed in Dialogflow console. If not specified, V2 API is assumed. Clients are free to query
        /// different service endpoints for different API versions. However, bots connectors and webhook calls will follow
        /// the specified API version.
        /// * API_VERSION_V1: Legacy V1 API.
        /// * API_VERSION_V2: V2 API.
        /// * API_VERSION_V2_BETA_1: V2beta1 API.
        /// </summary>
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        /// <summary>
        /// The URI of the agent's avatar, which are used throughout the Dialogflow console. When an image URL is entered
        /// into this field, the Dialogflow will save the image in the backend. The address of the backend image returned
        /// from the API will be shown in the [avatarUriBackend] field.
        /// </summary>
        [Input("avatarUri")]
        public Input<string>? AvatarUri { get; set; }

        /// <summary>
        /// The URI of the agent's avatar as returned from the API. Output only. To provide an image URL for the agent avatar, the
        /// [avatarUri] field can be used.
        /// </summary>
        [Input("avatarUriBackend")]
        public Input<string>? AvatarUriBackend { get; set; }

        /// <summary>
        /// To filter out false positive results and still get variety in matched natural language inputs for your agent,
        /// you can tune the machine learning classification threshold. If the returned score value is less than the threshold
        /// value, then a fallback intent will be triggered or, if there are no fallback intents defined, no intent will be
        /// triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the
        /// default of 0.3 is used.
        /// </summary>
        [Input("classificationThreshold")]
        public Input<double>? ClassificationThreshold { get; set; }

        /// <summary>
        /// The default language of the agent as a language tag. [See Language Support](https://cloud.google.com/dialogflow/docs/reference/language)
        /// for a list of the currently supported language codes. This field cannot be updated after creation.
        /// </summary>
        [Input("defaultLanguageCode")]
        public Input<string>? DefaultLanguageCode { get; set; }

        /// <summary>
        /// The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The name of this agent.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Determines whether this agent should log conversation queries.
        /// </summary>
        [Input("enableLogging")]
        public Input<bool>? EnableLogging { get; set; }

        /// <summary>
        /// Determines how intents are detected from user queries.
        /// * MATCH_MODE_HYBRID: Best for agents with a small number of examples in intents and/or wide use of templates
        /// syntax and composite entities.
        /// * MATCH_MODE_ML_ONLY: Can be used for agents with a large number of examples in intents, especially the ones
        /// using @sys.any or very large developer entities.
        /// </summary>
        [Input("matchMode")]
        public Input<string>? MatchMode { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        [Input("supportedLanguageCodes")]
        private InputList<string>? _supportedLanguageCodes;

        /// <summary>
        /// The list of all languages supported by this agent (except for the defaultLanguageCode).
        /// </summary>
        public InputList<string> SupportedLanguageCodes
        {
            get => _supportedLanguageCodes ?? (_supportedLanguageCodes = new InputList<string>());
            set => _supportedLanguageCodes = value;
        }

        /// <summary>
        /// The agent tier. If not specified, TIER_STANDARD is assumed.
        /// * TIER_STANDARD: Standard tier.
        /// * TIER_ENTERPRISE: Enterprise tier (Essentials).
        /// * TIER_ENTERPRISE_PLUS: Enterprise tier (Plus).
        /// NOTE: Due to consistency issues, the provider will not read this field from the API. Drift is possible between
        /// the the provider state and Dialogflow if the agent tier is changed outside of the provider.
        /// </summary>
        [Input("tier")]
        public Input<string>? Tier { get; set; }

        /// <summary>
        /// The time zone of this agent from the [time zone database](https://www.iana.org/time-zones), e.g., America/New_York,
        /// Europe/Paris.
        /// </summary>
        [Input("timeZone")]
        public Input<string>? TimeZone { get; set; }

        public AgentState()
        {
        }
    }
}
