// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Storage
{
    /// <summary>
    /// Authoritatively manages the default object ACLs for a Google Cloud Storage bucket
    /// without managing the bucket itself.
    /// 
    /// &gt; Note that for each object, its creator will have the `"OWNER"` role in addition
    /// to the default ACL that has been defined.
    /// 
    /// For more information see
    /// [the official documentation](https://cloud.google.com/storage/docs/access-control/lists)
    /// and
    /// [API](https://cloud.google.com/storage/docs/json_api/v1/defaultObjectAccessControls).
    /// 
    /// &gt; Want fine-grained control over default object ACLs? Use `gcp.storage.DefaultObjectAccessControl`
    /// to control individual role entity pairs.
    /// </summary>
    public partial class DefaultObjectACL : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the bucket it applies to.
        /// </summary>
        [Output("bucket")]
        public Output<string> Bucket { get; private set; } = null!;

        /// <summary>
        /// List of role/entity pairs in the form `ROLE:entity`.
        /// See [GCS Object ACL documentation](https://cloud.google.com/storage/docs/json_api/v1/objectAccessControls) for more details.
        /// Omitting the field is the same as providing an empty list.
        /// </summary>
        [Output("roleEntities")]
        public Output<ImmutableArray<string>> RoleEntities { get; private set; } = null!;


        /// <summary>
        /// Create a DefaultObjectACL resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DefaultObjectACL(string name, DefaultObjectACLArgs args, CustomResourceOptions? options = null)
            : base("gcp:storage/defaultObjectACL:DefaultObjectACL", name, args ?? new DefaultObjectACLArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DefaultObjectACL(string name, Input<string> id, DefaultObjectACLState? state = null, CustomResourceOptions? options = null)
            : base("gcp:storage/defaultObjectACL:DefaultObjectACL", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DefaultObjectACL resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DefaultObjectACL Get(string name, Input<string> id, DefaultObjectACLState? state = null, CustomResourceOptions? options = null)
        {
            return new DefaultObjectACL(name, id, state, options);
        }
    }

    public sealed class DefaultObjectACLArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the bucket it applies to.
        /// </summary>
        [Input("bucket", required: true)]
        public Input<string> Bucket { get; set; } = null!;

        [Input("roleEntities")]
        private InputList<string>? _roleEntities;

        /// <summary>
        /// List of role/entity pairs in the form `ROLE:entity`.
        /// See [GCS Object ACL documentation](https://cloud.google.com/storage/docs/json_api/v1/objectAccessControls) for more details.
        /// Omitting the field is the same as providing an empty list.
        /// </summary>
        public InputList<string> RoleEntities
        {
            get => _roleEntities ?? (_roleEntities = new InputList<string>());
            set => _roleEntities = value;
        }

        public DefaultObjectACLArgs()
        {
        }
    }

    public sealed class DefaultObjectACLState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the bucket it applies to.
        /// </summary>
        [Input("bucket")]
        public Input<string>? Bucket { get; set; }

        [Input("roleEntities")]
        private InputList<string>? _roleEntities;

        /// <summary>
        /// List of role/entity pairs in the form `ROLE:entity`.
        /// See [GCS Object ACL documentation](https://cloud.google.com/storage/docs/json_api/v1/objectAccessControls) for more details.
        /// Omitting the field is the same as providing an empty list.
        /// </summary>
        public InputList<string> RoleEntities
        {
            get => _roleEntities ?? (_roleEntities = new InputList<string>());
            set => _roleEntities = value;
        }

        public DefaultObjectACLState()
        {
        }
    }
}
