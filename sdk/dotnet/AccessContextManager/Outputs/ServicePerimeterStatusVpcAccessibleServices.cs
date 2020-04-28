// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.AccessContextManager.Outputs
{

    [OutputType]
    public sealed class ServicePerimeterStatusVpcAccessibleServices
    {
        /// <summary>
        /// The list of APIs usable within the Service Perimeter.
        /// Must be empty unless `enableRestriction` is True.
        /// </summary>
        public readonly ImmutableArray<string> AllowedServices;
        /// <summary>
        /// Whether to restrict API calls within the Service Perimeter to the
        /// list of APIs specified in 'allowedServices'.
        /// </summary>
        public readonly bool? EnableRestriction;

        [OutputConstructor]
        private ServicePerimeterStatusVpcAccessibleServices(
            ImmutableArray<string> allowedServices,

            bool? enableRestriction)
        {
            AllowedServices = allowedServices;
            EnableRestriction = enableRestriction;
        }
    }
}
