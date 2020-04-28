// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.IdentityPlatform
{
    /// <summary>
    /// Inbound SAML configuration for a Identity Toolkit project.
    /// 
    /// You must enable the
    /// [Google Identity Platform](https://console.cloud.google.com/marketplace/details/google-cloud-platform/customer-identity) in
    /// the marketplace prior to using this resource.
    /// </summary>
    public partial class InboundSamlConfig : Pulumi.CustomResource
    {
        /// <summary>
        /// Human friendly display name.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// If this config allows users to sign in with the provider.
        /// </summary>
        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        /// <summary>
        /// SAML IdP configuration when the project acts as the relying party  Structure is documented below.
        /// </summary>
        [Output("idpConfig")]
        public Output<Outputs.InboundSamlConfigIdpConfig> IdpConfig { get; private set; } = null!;

        /// <summary>
        /// The name of the InboundSamlConfig resource. Must start with 'saml.' and can only have alphanumeric characters,
        /// hyphens, underscores or periods. The part after 'saml.' must also start with a lowercase letter, end with an
        /// alphanumeric character, and have at least 2 characters.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// SAML SP (Service Provider) configuration when the project acts as the relying party to receive
        /// and accept an authentication assertion issued by a SAML identity provider.  Structure is documented below.
        /// </summary>
        [Output("spConfig")]
        public Output<Outputs.InboundSamlConfigSpConfig> SpConfig { get; private set; } = null!;


        /// <summary>
        /// Create a InboundSamlConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public InboundSamlConfig(string name, InboundSamlConfigArgs args, CustomResourceOptions? options = null)
            : base("gcp:identityplatform/inboundSamlConfig:InboundSamlConfig", name, args ?? new InboundSamlConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private InboundSamlConfig(string name, Input<string> id, InboundSamlConfigState? state = null, CustomResourceOptions? options = null)
            : base("gcp:identityplatform/inboundSamlConfig:InboundSamlConfig", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing InboundSamlConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static InboundSamlConfig Get(string name, Input<string> id, InboundSamlConfigState? state = null, CustomResourceOptions? options = null)
        {
            return new InboundSamlConfig(name, id, state, options);
        }
    }

    public sealed class InboundSamlConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Human friendly display name.
        /// </summary>
        [Input("displayName", required: true)]
        public Input<string> DisplayName { get; set; } = null!;

        /// <summary>
        /// If this config allows users to sign in with the provider.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// SAML IdP configuration when the project acts as the relying party  Structure is documented below.
        /// </summary>
        [Input("idpConfig", required: true)]
        public Input<Inputs.InboundSamlConfigIdpConfigArgs> IdpConfig { get; set; } = null!;

        /// <summary>
        /// The name of the InboundSamlConfig resource. Must start with 'saml.' and can only have alphanumeric characters,
        /// hyphens, underscores or periods. The part after 'saml.' must also start with a lowercase letter, end with an
        /// alphanumeric character, and have at least 2 characters.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// SAML SP (Service Provider) configuration when the project acts as the relying party to receive
        /// and accept an authentication assertion issued by a SAML identity provider.  Structure is documented below.
        /// </summary>
        [Input("spConfig", required: true)]
        public Input<Inputs.InboundSamlConfigSpConfigArgs> SpConfig { get; set; } = null!;

        public InboundSamlConfigArgs()
        {
        }
    }

    public sealed class InboundSamlConfigState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Human friendly display name.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// If this config allows users to sign in with the provider.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// SAML IdP configuration when the project acts as the relying party  Structure is documented below.
        /// </summary>
        [Input("idpConfig")]
        public Input<Inputs.InboundSamlConfigIdpConfigGetArgs>? IdpConfig { get; set; }

        /// <summary>
        /// The name of the InboundSamlConfig resource. Must start with 'saml.' and can only have alphanumeric characters,
        /// hyphens, underscores or periods. The part after 'saml.' must also start with a lowercase letter, end with an
        /// alphanumeric character, and have at least 2 characters.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// SAML SP (Service Provider) configuration when the project acts as the relying party to receive
        /// and accept an authentication assertion issued by a SAML identity provider.  Structure is documented below.
        /// </summary>
        [Input("spConfig")]
        public Input<Inputs.InboundSamlConfigSpConfigGetArgs>? SpConfig { get; set; }

        public InboundSamlConfigState()
        {
        }
    }
}
