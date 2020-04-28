# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class TargetSSLProxy(pulumi.CustomResource):
    backend_service: pulumi.Output[str]
    """
    A reference to the BackendService resource.
    """
    creation_timestamp: pulumi.Output[str]
    """
    Creation timestamp in RFC3339 text format.
    """
    description: pulumi.Output[str]
    """
    An optional description of this resource.
    """
    name: pulumi.Output[str]
    """
    Name of the resource. Provided by the client when the resource is
    created. The name must be 1-63 characters long, and comply with
    RFC1035. Specifically, the name must be 1-63 characters long and match
    the regular expression `a-z?` which means the
    first character must be a lowercase letter, and all following
    characters must be a dash, lowercase letter, or digit, except the last
    character, which cannot be a dash.
    """
    project: pulumi.Output[str]
    """
    The ID of the project in which the resource belongs.
    If it is not provided, the provider project is used.
    """
    proxy_header: pulumi.Output[str]
    """
    Specifies the type of proxy header to append before sending data to
    the backend, either NONE or PROXY_V1. The default is NONE.
    """
    proxy_id: pulumi.Output[float]
    """
    The unique identifier for the resource.
    """
    self_link: pulumi.Output[str]
    """
    The URI of the created resource.
    """
    ssl_certificates: pulumi.Output[str]
    """
    A list of SslCertificate resources that are used to authenticate
    connections between users and the load balancer. Currently, exactly
    one SSL certificate must be specified.
    """
    ssl_policy: pulumi.Output[str]
    """
    A reference to the SslPolicy resource that will be associated with
    the TargetSslProxy resource. If not set, the TargetSslProxy
    resource will not have any SSL policy configured.
    """
    def __init__(__self__, resource_name, opts=None, backend_service=None, description=None, name=None, project=None, proxy_header=None, ssl_certificates=None, ssl_policy=None, __props__=None, __name__=None, __opts__=None):
        """
        Represents a TargetSslProxy resource, which is used by one or more
        global forwarding rule to route incoming SSL requests to a backend
        service.


        To get more information about TargetSslProxy, see:

        * [API documentation](https://cloud.google.com/compute/docs/reference/v1/targetSslProxies)
        * How-to Guides
            * [Setting Up SSL proxy for Google Cloud Load Balancing](https://cloud.google.com/compute/docs/load-balancing/tcp-ssl/)

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] backend_service: A reference to the BackendService resource.
        :param pulumi.Input[str] description: An optional description of this resource.
        :param pulumi.Input[str] name: Name of the resource. Provided by the client when the resource is
               created. The name must be 1-63 characters long, and comply with
               RFC1035. Specifically, the name must be 1-63 characters long and match
               the regular expression `a-z?` which means the
               first character must be a lowercase letter, and all following
               characters must be a dash, lowercase letter, or digit, except the last
               character, which cannot be a dash.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[str] proxy_header: Specifies the type of proxy header to append before sending data to
               the backend, either NONE or PROXY_V1. The default is NONE.
        :param pulumi.Input[str] ssl_certificates: A list of SslCertificate resources that are used to authenticate
               connections between users and the load balancer. Currently, exactly
               one SSL certificate must be specified.
        :param pulumi.Input[str] ssl_policy: A reference to the SslPolicy resource that will be associated with
               the TargetSslProxy resource. If not set, the TargetSslProxy
               resource will not have any SSL policy configured.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            if backend_service is None:
                raise TypeError("Missing required property 'backend_service'")
            __props__['backend_service'] = backend_service
            __props__['description'] = description
            __props__['name'] = name
            __props__['project'] = project
            __props__['proxy_header'] = proxy_header
            if ssl_certificates is None:
                raise TypeError("Missing required property 'ssl_certificates'")
            __props__['ssl_certificates'] = ssl_certificates
            __props__['ssl_policy'] = ssl_policy
            __props__['creation_timestamp'] = None
            __props__['proxy_id'] = None
            __props__['self_link'] = None
        super(TargetSSLProxy, __self__).__init__(
            'gcp:compute/targetSSLProxy:TargetSSLProxy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, backend_service=None, creation_timestamp=None, description=None, name=None, project=None, proxy_header=None, proxy_id=None, self_link=None, ssl_certificates=None, ssl_policy=None):
        """
        Get an existing TargetSSLProxy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] backend_service: A reference to the BackendService resource.
        :param pulumi.Input[str] creation_timestamp: Creation timestamp in RFC3339 text format.
        :param pulumi.Input[str] description: An optional description of this resource.
        :param pulumi.Input[str] name: Name of the resource. Provided by the client when the resource is
               created. The name must be 1-63 characters long, and comply with
               RFC1035. Specifically, the name must be 1-63 characters long and match
               the regular expression `a-z?` which means the
               first character must be a lowercase letter, and all following
               characters must be a dash, lowercase letter, or digit, except the last
               character, which cannot be a dash.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[str] proxy_header: Specifies the type of proxy header to append before sending data to
               the backend, either NONE or PROXY_V1. The default is NONE.
        :param pulumi.Input[float] proxy_id: The unique identifier for the resource.
        :param pulumi.Input[str] self_link: The URI of the created resource.
        :param pulumi.Input[str] ssl_certificates: A list of SslCertificate resources that are used to authenticate
               connections between users and the load balancer. Currently, exactly
               one SSL certificate must be specified.
        :param pulumi.Input[str] ssl_policy: A reference to the SslPolicy resource that will be associated with
               the TargetSslProxy resource. If not set, the TargetSslProxy
               resource will not have any SSL policy configured.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["backend_service"] = backend_service
        __props__["creation_timestamp"] = creation_timestamp
        __props__["description"] = description
        __props__["name"] = name
        __props__["project"] = project
        __props__["proxy_header"] = proxy_header
        __props__["proxy_id"] = proxy_id
        __props__["self_link"] = self_link
        __props__["ssl_certificates"] = ssl_certificates
        __props__["ssl_policy"] = ssl_policy
        return TargetSSLProxy(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

