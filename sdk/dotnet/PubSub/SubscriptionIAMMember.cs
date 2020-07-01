// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.PubSub
{
    /// <summary>
    /// Three different resources help you manage your IAM policy for pubsub subscription. Each of these resources serves a different use case:
    /// 
    /// * `gcp.pubsub.SubscriptionIAMPolicy`: Authoritative. Sets the IAM policy for the subscription and replaces any existing policy already attached.
    /// * `gcp.pubsub.SubscriptionIAMBinding`: Authoritative for a given role. Updates the IAM policy to grant a role to a list of members. Other roles within the IAM policy for the subscription are preserved.
    /// * `gcp.pubsub.SubscriptionIAMMember`: Non-authoritative. Updates the IAM policy to grant a role to a new member. Other members for the role for the subscription are preserved.
    /// 
    /// &gt; **Note:** `gcp.pubsub.SubscriptionIAMPolicy` **cannot** be used in conjunction with `gcp.pubsub.SubscriptionIAMBinding` and `gcp.pubsub.SubscriptionIAMMember` or they will fight over what your policy should be.
    /// 
    /// &gt; **Note:** `gcp.pubsub.SubscriptionIAMBinding` resources **can be** used in conjunction with `gcp.pubsub.SubscriptionIAMMember` resources **only if** they do not grant privilege to the same role.
    /// </summary>
    public partial class SubscriptionIAMMember : Pulumi.CustomResource
    {
        [Output("condition")]
        public Output<Outputs.SubscriptionIAMMemberCondition?> Condition { get; private set; } = null!;

        /// <summary>
        /// (Computed) The etag of the subscription's IAM policy.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        [Output("member")]
        public Output<string> Member { get; private set; } = null!;

        /// <summary>
        /// The project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// The role that should be applied. Only one
        /// `gcp.pubsub.SubscriptionIAMBinding` can be used per role. Note that custom roles must be of the format
        /// `[projects|organizations]/{parent-name}/roles/{role-name}`.
        /// </summary>
        [Output("role")]
        public Output<string> Role { get; private set; } = null!;

        /// <summary>
        /// The subscription name or id to bind to attach IAM policy to.
        /// </summary>
        [Output("subscription")]
        public Output<string> Subscription { get; private set; } = null!;


        /// <summary>
        /// Create a SubscriptionIAMMember resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SubscriptionIAMMember(string name, SubscriptionIAMMemberArgs args, CustomResourceOptions? options = null)
            : base("gcp:pubsub/subscriptionIAMMember:SubscriptionIAMMember", name, args ?? new SubscriptionIAMMemberArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SubscriptionIAMMember(string name, Input<string> id, SubscriptionIAMMemberState? state = null, CustomResourceOptions? options = null)
            : base("gcp:pubsub/subscriptionIAMMember:SubscriptionIAMMember", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SubscriptionIAMMember resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SubscriptionIAMMember Get(string name, Input<string> id, SubscriptionIAMMemberState? state = null, CustomResourceOptions? options = null)
        {
            return new SubscriptionIAMMember(name, id, state, options);
        }
    }

    public sealed class SubscriptionIAMMemberArgs : Pulumi.ResourceArgs
    {
        [Input("condition")]
        public Input<Inputs.SubscriptionIAMMemberConditionArgs>? Condition { get; set; }

        [Input("member", required: true)]
        public Input<string> Member { get; set; } = null!;

        /// <summary>
        /// The project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// The role that should be applied. Only one
        /// `gcp.pubsub.SubscriptionIAMBinding` can be used per role. Note that custom roles must be of the format
        /// `[projects|organizations]/{parent-name}/roles/{role-name}`.
        /// </summary>
        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        /// <summary>
        /// The subscription name or id to bind to attach IAM policy to.
        /// </summary>
        [Input("subscription", required: true)]
        public Input<string> Subscription { get; set; } = null!;

        public SubscriptionIAMMemberArgs()
        {
        }
    }

    public sealed class SubscriptionIAMMemberState : Pulumi.ResourceArgs
    {
        [Input("condition")]
        public Input<Inputs.SubscriptionIAMMemberConditionGetArgs>? Condition { get; set; }

        /// <summary>
        /// (Computed) The etag of the subscription's IAM policy.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        [Input("member")]
        public Input<string>? Member { get; set; }

        /// <summary>
        /// The project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// The role that should be applied. Only one
        /// `gcp.pubsub.SubscriptionIAMBinding` can be used per role. Note that custom roles must be of the format
        /// `[projects|organizations]/{parent-name}/roles/{role-name}`.
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        /// <summary>
        /// The subscription name or id to bind to attach IAM policy to.
        /// </summary>
        [Input("subscription")]
        public Input<string>? Subscription { get; set; }

        public SubscriptionIAMMemberState()
        {
        }
    }
}
