// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Outputs
{

    [OutputType]
    public sealed class RegionHealthCheckGrpcHealthCheck
    {
        /// <summary>
        /// The gRPC service name for the health check.
        /// The value of grpcServiceName has the following meanings by convention:
        /// - Empty serviceName means the overall status of all services at the backend.
        /// - Non-empty serviceName means the health of that gRPC service, as defined by the owner of the service.
        /// The grpcServiceName can only be ASCII.
        /// </summary>
        public readonly string? GrpcServiceName;
        /// <summary>
        /// The port number for the health check request.
        /// Must be specified if portName and portSpecification are not set
        /// or if port_specification is USE_FIXED_PORT. Valid values are 1 through 65535.
        /// </summary>
        public readonly int? Port;
        /// <summary>
        /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
        /// port_name are defined, port takes precedence.
        /// </summary>
        public readonly string? PortName;
        /// <summary>
        /// Specifies how port is selected for health checking, can be one of the
        /// following values:
        /// * `USE_FIXED_PORT`: The port number in `port` is used for health checking.
        /// * `USE_NAMED_PORT`: The `portName` is used for health checking.
        /// * `USE_SERVING_PORT`: For NetworkEndpointGroup, the port specified for each
        /// network endpoint is used for health checking. For other backends, the
        /// port or named port specified in the Backend Service is used for health
        /// checking.
        /// If not specified, gRPC health check follows behavior specified in `port` and
        /// `portName` fields.
        /// Possible values are `USE_FIXED_PORT`, `USE_NAMED_PORT`, and `USE_SERVING_PORT`.
        /// </summary>
        public readonly string? PortSpecification;

        [OutputConstructor]
        private RegionHealthCheckGrpcHealthCheck(
            string? grpcServiceName,

            int? port,

            string? portName,

            string? portSpecification)
        {
            GrpcServiceName = grpcServiceName;
            Port = port;
            PortName = portName;
            PortSpecification = portSpecification;
        }
    }
}