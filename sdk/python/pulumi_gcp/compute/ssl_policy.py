# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class SSLPolicy(pulumi.CustomResource):
    creation_timestamp: pulumi.Output[str]
    """
    Creation timestamp in RFC3339 text format.
    """
    custom_features: pulumi.Output[list]
    """
    Profile specifies the set of SSL features that can be used by the load balancer when negotiating SSL with clients. This
    can be one of 'COMPATIBLE', 'MODERN', 'RESTRICTED', or 'CUSTOM'. If using 'CUSTOM', the set of SSL features to enable
    must be specified in the 'customFeatures' field. See the [official
    documentation](https://cloud.google.com/compute/docs/load-balancing/ssl-policies#profilefeaturesupport) for which
    ciphers are available to use. **Note**: this argument *must* be present when using the 'CUSTOM' profile. This argument
    *must not* be present when using any other profile.
    """
    description: pulumi.Output[str]
    """
    An optional description of this resource.
    """
    enabled_features: pulumi.Output[list]
    """
    The list of features enabled in the SSL policy.
    """
    fingerprint: pulumi.Output[str]
    """
    Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking.
    """
    min_tls_version: pulumi.Output[str]
    """
    The minimum version of SSL protocol that can be used by the clients to establish a connection with the load balancer.
    This can be one of 'TLS_1_0', 'TLS_1_1', 'TLS_1_2'. Default is 'TLS_1_0'.
    """
    name: pulumi.Output[str]
    """
    Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and
    comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
    '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
    must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
    """
    profile: pulumi.Output[str]
    """
    Profile specifies the set of SSL features that can be used by the load balancer when negotiating SSL with clients. This
    can be one of 'COMPATIBLE', 'MODERN', 'RESTRICTED', or 'CUSTOM'. If using 'CUSTOM', the set of SSL features to enable
    must be specified in the 'customFeatures' field. See the [official
    documentation](https://cloud.google.com/compute/docs/load-balancing/ssl-policies#profilefeaturesupport) for information
    on what cipher suites each profile provides. If 'CUSTOM' is used, the 'custom_features' attribute **must be set**.
    Default is 'COMPATIBLE'.
    """
    project: pulumi.Output[str]
    """
    The ID of the project in which the resource belongs.
    If it is not provided, the provider project is used.
    """
    self_link: pulumi.Output[str]
    """
    The URI of the created resource.
    """
    def __init__(__self__, resource_name, opts=None, custom_features=None, description=None, min_tls_version=None, name=None, profile=None, project=None, __props__=None, __name__=None, __opts__=None):
        """
        Create a SSLPolicy resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[list] custom_features: Profile specifies the set of SSL features that can be used by the load balancer when negotiating SSL with clients. This
               can be one of 'COMPATIBLE', 'MODERN', 'RESTRICTED', or 'CUSTOM'. If using 'CUSTOM', the set of SSL features to enable
               must be specified in the 'customFeatures' field. See the [official
               documentation](https://cloud.google.com/compute/docs/load-balancing/ssl-policies#profilefeaturesupport) for which
               ciphers are available to use. **Note**: this argument *must* be present when using the 'CUSTOM' profile. This argument
               *must not* be present when using any other profile.
        :param pulumi.Input[str] description: An optional description of this resource.
        :param pulumi.Input[str] min_tls_version: The minimum version of SSL protocol that can be used by the clients to establish a connection with the load balancer.
               This can be one of 'TLS_1_0', 'TLS_1_1', 'TLS_1_2'. Default is 'TLS_1_0'.
        :param pulumi.Input[str] name: Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and
               comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
               '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
               must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
        :param pulumi.Input[str] profile: Profile specifies the set of SSL features that can be used by the load balancer when negotiating SSL with clients. This
               can be one of 'COMPATIBLE', 'MODERN', 'RESTRICTED', or 'CUSTOM'. If using 'CUSTOM', the set of SSL features to enable
               must be specified in the 'customFeatures' field. See the [official
               documentation](https://cloud.google.com/compute/docs/load-balancing/ssl-policies#profilefeaturesupport) for information
               on what cipher suites each profile provides. If 'CUSTOM' is used, the 'custom_features' attribute **must be set**.
               Default is 'COMPATIBLE'.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
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

            __props__['custom_features'] = custom_features
            __props__['description'] = description
            __props__['min_tls_version'] = min_tls_version
            __props__['name'] = name
            __props__['profile'] = profile
            __props__['project'] = project
            __props__['creation_timestamp'] = None
            __props__['enabled_features'] = None
            __props__['fingerprint'] = None
            __props__['self_link'] = None
        super(SSLPolicy, __self__).__init__(
            'gcp:compute/sSLPolicy:SSLPolicy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, creation_timestamp=None, custom_features=None, description=None, enabled_features=None, fingerprint=None, min_tls_version=None, name=None, profile=None, project=None, self_link=None):
        """
        Get an existing SSLPolicy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] creation_timestamp: Creation timestamp in RFC3339 text format.
        :param pulumi.Input[list] custom_features: Profile specifies the set of SSL features that can be used by the load balancer when negotiating SSL with clients. This
               can be one of 'COMPATIBLE', 'MODERN', 'RESTRICTED', or 'CUSTOM'. If using 'CUSTOM', the set of SSL features to enable
               must be specified in the 'customFeatures' field. See the [official
               documentation](https://cloud.google.com/compute/docs/load-balancing/ssl-policies#profilefeaturesupport) for which
               ciphers are available to use. **Note**: this argument *must* be present when using the 'CUSTOM' profile. This argument
               *must not* be present when using any other profile.
        :param pulumi.Input[str] description: An optional description of this resource.
        :param pulumi.Input[list] enabled_features: The list of features enabled in the SSL policy.
        :param pulumi.Input[str] fingerprint: Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking.
        :param pulumi.Input[str] min_tls_version: The minimum version of SSL protocol that can be used by the clients to establish a connection with the load balancer.
               This can be one of 'TLS_1_0', 'TLS_1_1', 'TLS_1_2'. Default is 'TLS_1_0'.
        :param pulumi.Input[str] name: Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and
               comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
               '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
               must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
        :param pulumi.Input[str] profile: Profile specifies the set of SSL features that can be used by the load balancer when negotiating SSL with clients. This
               can be one of 'COMPATIBLE', 'MODERN', 'RESTRICTED', or 'CUSTOM'. If using 'CUSTOM', the set of SSL features to enable
               must be specified in the 'customFeatures' field. See the [official
               documentation](https://cloud.google.com/compute/docs/load-balancing/ssl-policies#profilefeaturesupport) for information
               on what cipher suites each profile provides. If 'CUSTOM' is used, the 'custom_features' attribute **must be set**.
               Default is 'COMPATIBLE'.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[str] self_link: The URI of the created resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["creation_timestamp"] = creation_timestamp
        __props__["custom_features"] = custom_features
        __props__["description"] = description
        __props__["enabled_features"] = enabled_features
        __props__["fingerprint"] = fingerprint
        __props__["min_tls_version"] = min_tls_version
        __props__["name"] = name
        __props__["profile"] = profile
        __props__["project"] = project
        __props__["self_link"] = self_link
        return SSLPolicy(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

