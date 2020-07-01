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
    /// Tenant configuration in a multi-tenant project.
    /// 
    /// You must enable the
    /// [Google Identity Platform](https://console.cloud.google.com/marketplace/details/google-cloud-platform/customer-identity) in
    /// the marketplace prior to using this resource.
    /// 
    /// You must [enable multi-tenancy](https://cloud.google.com/identity-platform/docs/multi-tenancy-quickstart) via
    /// the Cloud Console prior to creating tenants.
    /// 
    /// ## Example Usage
    /// </summary>
    public partial class Tenant : Pulumi.CustomResource
    {
        /// <summary>
        /// Whether to allow email/password user authentication.
        /// </summary>
        [Output("allowPasswordSignup")]
        public Output<bool?> AllowPasswordSignup { get; private set; } = null!;

        /// <summary>
        /// Whether authentication is disabled for the tenant. If true, the users under
        /// the disabled tenant are not allowed to sign-in. Admins of the disabled tenant
        /// are not able to manage its users.
        /// </summary>
        [Output("disableAuth")]
        public Output<bool?> DisableAuth { get; private set; } = null!;

        /// <summary>
        /// Human friendly display name of the tenant.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// Whether to enable email link user authentication.
        /// </summary>
        [Output("enableEmailLinkSignin")]
        public Output<bool?> EnableEmailLinkSignin { get; private set; } = null!;

        /// <summary>
        /// The name of the tenant that is generated by the server
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
        /// Create a Tenant resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Tenant(string name, TenantArgs args, CustomResourceOptions? options = null)
            : base("gcp:identityplatform/tenant:Tenant", name, args ?? new TenantArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Tenant(string name, Input<string> id, TenantState? state = null, CustomResourceOptions? options = null)
            : base("gcp:identityplatform/tenant:Tenant", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Tenant resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Tenant Get(string name, Input<string> id, TenantState? state = null, CustomResourceOptions? options = null)
        {
            return new Tenant(name, id, state, options);
        }
    }

    public sealed class TenantArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to allow email/password user authentication.
        /// </summary>
        [Input("allowPasswordSignup")]
        public Input<bool>? AllowPasswordSignup { get; set; }

        /// <summary>
        /// Whether authentication is disabled for the tenant. If true, the users under
        /// the disabled tenant are not allowed to sign-in. Admins of the disabled tenant
        /// are not able to manage its users.
        /// </summary>
        [Input("disableAuth")]
        public Input<bool>? DisableAuth { get; set; }

        /// <summary>
        /// Human friendly display name of the tenant.
        /// </summary>
        [Input("displayName", required: true)]
        public Input<string> DisplayName { get; set; } = null!;

        /// <summary>
        /// Whether to enable email link user authentication.
        /// </summary>
        [Input("enableEmailLinkSignin")]
        public Input<bool>? EnableEmailLinkSignin { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        public TenantArgs()
        {
        }
    }

    public sealed class TenantState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to allow email/password user authentication.
        /// </summary>
        [Input("allowPasswordSignup")]
        public Input<bool>? AllowPasswordSignup { get; set; }

        /// <summary>
        /// Whether authentication is disabled for the tenant. If true, the users under
        /// the disabled tenant are not allowed to sign-in. Admins of the disabled tenant
        /// are not able to manage its users.
        /// </summary>
        [Input("disableAuth")]
        public Input<bool>? DisableAuth { get; set; }

        /// <summary>
        /// Human friendly display name of the tenant.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Whether to enable email link user authentication.
        /// </summary>
        [Input("enableEmailLinkSignin")]
        public Input<bool>? EnableEmailLinkSignin { get; set; }

        /// <summary>
        /// The name of the tenant that is generated by the server
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        public TenantState()
        {
        }
    }
}
