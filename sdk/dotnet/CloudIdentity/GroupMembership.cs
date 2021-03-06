// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.CloudIdentity
{
    /// <summary>
    /// A Membership defines a relationship between a Group and an entity belonging to that Group, referred to as a "member".
    /// 
    /// ## Example Usage
    /// </summary>
    public partial class GroupMembership : Pulumi.CustomResource
    {
        /// <summary>
        /// The time when the Membership was created.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// The name of the Group to create this membership in.
        /// </summary>
        [Output("group")]
        public Output<string> Group { get; private set; } = null!;

        /// <summary>
        /// EntityKey of the member.
        /// Structure is documented below.
        /// </summary>
        [Output("memberKey")]
        public Output<Outputs.GroupMembershipMemberKey> MemberKey { get; private set; } = null!;

        /// <summary>
        /// The name of the MembershipRole. Must be one of OWNER, MANAGER, MEMBER.
        /// Possible values are `OWNER`, `MANAGER`, and `MEMBER`.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// EntityKey of the member.
        /// Structure is documented below.
        /// </summary>
        [Output("preferredMemberKey")]
        public Output<Outputs.GroupMembershipPreferredMemberKey> PreferredMemberKey { get; private set; } = null!;

        /// <summary>
        /// The MembershipRoles that apply to the Membership.
        /// Must not contain duplicate MembershipRoles with the same name.
        /// Structure is documented below.
        /// </summary>
        [Output("roles")]
        public Output<ImmutableArray<Outputs.GroupMembershipRole>> Roles { get; private set; } = null!;

        /// <summary>
        /// The type of the membership.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The time when the Membership was last updated.
        /// </summary>
        [Output("updateTime")]
        public Output<string> UpdateTime { get; private set; } = null!;


        /// <summary>
        /// Create a GroupMembership resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GroupMembership(string name, GroupMembershipArgs args, CustomResourceOptions? options = null)
            : base("gcp:cloudidentity/groupMembership:GroupMembership", name, args ?? new GroupMembershipArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GroupMembership(string name, Input<string> id, GroupMembershipState? state = null, CustomResourceOptions? options = null)
            : base("gcp:cloudidentity/groupMembership:GroupMembership", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing GroupMembership resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GroupMembership Get(string name, Input<string> id, GroupMembershipState? state = null, CustomResourceOptions? options = null)
        {
            return new GroupMembership(name, id, state, options);
        }
    }

    public sealed class GroupMembershipArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Group to create this membership in.
        /// </summary>
        [Input("group", required: true)]
        public Input<string> Group { get; set; } = null!;

        /// <summary>
        /// EntityKey of the member.
        /// Structure is documented below.
        /// </summary>
        [Input("memberKey")]
        public Input<Inputs.GroupMembershipMemberKeyArgs>? MemberKey { get; set; }

        /// <summary>
        /// EntityKey of the member.
        /// Structure is documented below.
        /// </summary>
        [Input("preferredMemberKey")]
        public Input<Inputs.GroupMembershipPreferredMemberKeyArgs>? PreferredMemberKey { get; set; }

        [Input("roles", required: true)]
        private InputList<Inputs.GroupMembershipRoleArgs>? _roles;

        /// <summary>
        /// The MembershipRoles that apply to the Membership.
        /// Must not contain duplicate MembershipRoles with the same name.
        /// Structure is documented below.
        /// </summary>
        public InputList<Inputs.GroupMembershipRoleArgs> Roles
        {
            get => _roles ?? (_roles = new InputList<Inputs.GroupMembershipRoleArgs>());
            set => _roles = value;
        }

        public GroupMembershipArgs()
        {
        }
    }

    public sealed class GroupMembershipState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The time when the Membership was created.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// The name of the Group to create this membership in.
        /// </summary>
        [Input("group")]
        public Input<string>? Group { get; set; }

        /// <summary>
        /// EntityKey of the member.
        /// Structure is documented below.
        /// </summary>
        [Input("memberKey")]
        public Input<Inputs.GroupMembershipMemberKeyGetArgs>? MemberKey { get; set; }

        /// <summary>
        /// The name of the MembershipRole. Must be one of OWNER, MANAGER, MEMBER.
        /// Possible values are `OWNER`, `MANAGER`, and `MEMBER`.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// EntityKey of the member.
        /// Structure is documented below.
        /// </summary>
        [Input("preferredMemberKey")]
        public Input<Inputs.GroupMembershipPreferredMemberKeyGetArgs>? PreferredMemberKey { get; set; }

        [Input("roles")]
        private InputList<Inputs.GroupMembershipRoleGetArgs>? _roles;

        /// <summary>
        /// The MembershipRoles that apply to the Membership.
        /// Must not contain duplicate MembershipRoles with the same name.
        /// Structure is documented below.
        /// </summary>
        public InputList<Inputs.GroupMembershipRoleGetArgs> Roles
        {
            get => _roles ?? (_roles = new InputList<Inputs.GroupMembershipRoleGetArgs>());
            set => _roles = value;
        }

        /// <summary>
        /// The type of the membership.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// The time when the Membership was last updated.
        /// </summary>
        [Input("updateTime")]
        public Input<string>? UpdateTime { get; set; }

        public GroupMembershipState()
        {
        }
    }
}
