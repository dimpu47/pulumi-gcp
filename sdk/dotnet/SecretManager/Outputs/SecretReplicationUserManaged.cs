// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.SecretManager.Outputs
{

    [OutputType]
    public sealed class SecretReplicationUserManaged
    {
        /// <summary>
        /// The list of Replicas for this Secret. Cannot be empty.  Structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.SecretReplicationUserManagedReplica> Replicas;

        [OutputConstructor]
        private SecretReplicationUserManaged(ImmutableArray<Outputs.SecretReplicationUserManagedReplica> replicas)
        {
            Replicas = replicas;
        }
    }
}
