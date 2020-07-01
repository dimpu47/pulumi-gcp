# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables


class Address(pulumi.CustomResource):
    address: pulumi.Output[str]
    """
    The static external IP address represented by this resource. Only
    IPv4 is supported. An address may only be specified for INTERNAL
    address types. The IP address must be inside the specified subnetwork,
    if any.
    """
    address_type: pulumi.Output[str]
    """
    The type of address to reserve.
    """
    creation_timestamp: pulumi.Output[str]
    """
    Creation timestamp in RFC3339 text format.
    """
    description: pulumi.Output[str]
    """
    An optional description of this resource.
    """
    label_fingerprint: pulumi.Output[str]
    """
    The fingerprint used for optimistic locking of this resource. Used internally during updates.
    """
    labels: pulumi.Output[dict]
    """
    Labels to apply to this address.  A list of key->value pairs.
    """
    name: pulumi.Output[str]
    """
    Name of the resource. The name must be 1-63 characters long, and
    comply with RFC1035. Specifically, the name must be 1-63 characters
    long and match the regular expression `a-z?`
    which means the first character must be a lowercase letter, and all
    following characters must be a dash, lowercase letter, or digit,
    except the last character, which cannot be a dash.
    """
    network_tier: pulumi.Output[str]
    """
    The networking tier used for configuring this address. If this field is not
    specified, it is assumed to be PREMIUM.
    """
    project: pulumi.Output[str]
    """
    The ID of the project in which the resource belongs.
    If it is not provided, the provider project is used.
    """
    purpose: pulumi.Output[str]
    """
    The purpose of this resource, which can be one of the following values:
    - GCE_ENDPOINT for addresses that are used by VM instances, alias IP ranges, internal load balancers, and similar resources.
    - SHARED_LOADBALANCER_VIP for an address that can be used by multiple internal load balancers
    This should only be set when using an Internal address.
    """
    region: pulumi.Output[str]
    """
    The Region in which the created address should reside.
    If it is not provided, the provider region is used.
    """
    self_link: pulumi.Output[str]
    """
    The URI of the created resource.
    """
    subnetwork: pulumi.Output[str]
    """
    The URL of the subnetwork in which to reserve the address. If an IP
    address is specified, it must be within the subnetwork's IP range.
    This field can only be used with INTERNAL type with
    GCE_ENDPOINT/DNS_RESOLVER purposes.
    """
    users: pulumi.Output[list]
    """
    The URLs of the resources that are using this address.
    """
    def __init__(__self__, resource_name, opts=None, address=None, address_type=None, description=None, labels=None, name=None, network_tier=None, project=None, purpose=None, region=None, subnetwork=None, __props__=None, __name__=None, __opts__=None):
        """
        Represents an Address resource.

        Each virtual machine instance has an ephemeral internal IP address and,
        optionally, an external IP address. To communicate between instances on
        the same network, you can use an instance's internal IP address. To
        communicate with the Internet and instances outside of the same network,
        you must specify the instance's external IP address.

        Internal IP addresses are ephemeral and only belong to an instance for
        the lifetime of the instance; if the instance is deleted and recreated,
        the instance is assigned a new internal IP address, either by Compute
        Engine or by you. External IP addresses can be either ephemeral or
        static.

        To get more information about Address, see:

        * [API documentation](https://cloud.google.com/compute/docs/reference/beta/addresses)
        * How-to Guides
            * [Reserving a Static External IP Address](https://cloud.google.com/compute/docs/instances-and-network)
            * [Reserving a Static Internal IP Address](https://cloud.google.com/compute/docs/ip-addresses/reserve-static-internal-ip-address)

        ## Example Usage

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] address: The static external IP address represented by this resource. Only
               IPv4 is supported. An address may only be specified for INTERNAL
               address types. The IP address must be inside the specified subnetwork,
               if any.
        :param pulumi.Input[str] address_type: The type of address to reserve.
        :param pulumi.Input[str] description: An optional description of this resource.
        :param pulumi.Input[dict] labels: Labels to apply to this address.  A list of key->value pairs.
        :param pulumi.Input[str] name: Name of the resource. The name must be 1-63 characters long, and
               comply with RFC1035. Specifically, the name must be 1-63 characters
               long and match the regular expression `a-z?`
               which means the first character must be a lowercase letter, and all
               following characters must be a dash, lowercase letter, or digit,
               except the last character, which cannot be a dash.
        :param pulumi.Input[str] network_tier: The networking tier used for configuring this address. If this field is not
               specified, it is assumed to be PREMIUM.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[str] purpose: The purpose of this resource, which can be one of the following values:
               - GCE_ENDPOINT for addresses that are used by VM instances, alias IP ranges, internal load balancers, and similar resources.
               - SHARED_LOADBALANCER_VIP for an address that can be used by multiple internal load balancers
               This should only be set when using an Internal address.
        :param pulumi.Input[str] region: The Region in which the created address should reside.
               If it is not provided, the provider region is used.
        :param pulumi.Input[str] subnetwork: The URL of the subnetwork in which to reserve the address. If an IP
               address is specified, it must be within the subnetwork's IP range.
               This field can only be used with INTERNAL type with
               GCE_ENDPOINT/DNS_RESOLVER purposes.
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

            __props__['address'] = address
            __props__['address_type'] = address_type
            __props__['description'] = description
            __props__['labels'] = labels
            __props__['name'] = name
            __props__['network_tier'] = network_tier
            __props__['project'] = project
            __props__['purpose'] = purpose
            __props__['region'] = region
            __props__['subnetwork'] = subnetwork
            __props__['creation_timestamp'] = None
            __props__['label_fingerprint'] = None
            __props__['self_link'] = None
            __props__['users'] = None
        super(Address, __self__).__init__(
            'gcp:compute/address:Address',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, address=None, address_type=None, creation_timestamp=None, description=None, label_fingerprint=None, labels=None, name=None, network_tier=None, project=None, purpose=None, region=None, self_link=None, subnetwork=None, users=None):
        """
        Get an existing Address resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] address: The static external IP address represented by this resource. Only
               IPv4 is supported. An address may only be specified for INTERNAL
               address types. The IP address must be inside the specified subnetwork,
               if any.
        :param pulumi.Input[str] address_type: The type of address to reserve.
        :param pulumi.Input[str] creation_timestamp: Creation timestamp in RFC3339 text format.
        :param pulumi.Input[str] description: An optional description of this resource.
        :param pulumi.Input[str] label_fingerprint: The fingerprint used for optimistic locking of this resource. Used internally during updates.
        :param pulumi.Input[dict] labels: Labels to apply to this address.  A list of key->value pairs.
        :param pulumi.Input[str] name: Name of the resource. The name must be 1-63 characters long, and
               comply with RFC1035. Specifically, the name must be 1-63 characters
               long and match the regular expression `a-z?`
               which means the first character must be a lowercase letter, and all
               following characters must be a dash, lowercase letter, or digit,
               except the last character, which cannot be a dash.
        :param pulumi.Input[str] network_tier: The networking tier used for configuring this address. If this field is not
               specified, it is assumed to be PREMIUM.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[str] purpose: The purpose of this resource, which can be one of the following values:
               - GCE_ENDPOINT for addresses that are used by VM instances, alias IP ranges, internal load balancers, and similar resources.
               - SHARED_LOADBALANCER_VIP for an address that can be used by multiple internal load balancers
               This should only be set when using an Internal address.
        :param pulumi.Input[str] region: The Region in which the created address should reside.
               If it is not provided, the provider region is used.
        :param pulumi.Input[str] self_link: The URI of the created resource.
        :param pulumi.Input[str] subnetwork: The URL of the subnetwork in which to reserve the address. If an IP
               address is specified, it must be within the subnetwork's IP range.
               This field can only be used with INTERNAL type with
               GCE_ENDPOINT/DNS_RESOLVER purposes.
        :param pulumi.Input[list] users: The URLs of the resources that are using this address.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["address"] = address
        __props__["address_type"] = address_type
        __props__["creation_timestamp"] = creation_timestamp
        __props__["description"] = description
        __props__["label_fingerprint"] = label_fingerprint
        __props__["labels"] = labels
        __props__["name"] = name
        __props__["network_tier"] = network_tier
        __props__["project"] = project
        __props__["purpose"] = purpose
        __props__["region"] = region
        __props__["self_link"] = self_link
        __props__["subnetwork"] = subnetwork
        __props__["users"] = users
        return Address(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
