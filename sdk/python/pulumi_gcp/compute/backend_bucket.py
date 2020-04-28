# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class BackendBucket(pulumi.CustomResource):
    bucket_name: pulumi.Output[str]
    """
    Cloud Storage bucket name.
    """
    cdn_policy: pulumi.Output[dict]
    """
    Cloud CDN configuration for this Backend Bucket.  Structure is documented below.

      * `signedUrlCacheMaxAgeSec` (`float`) - Maximum number of seconds the response to a signed URL request will
        be considered fresh. After this time period,
        the response will be revalidated before being served.
        When serving responses to signed URL requests,
        Cloud CDN will internally behave as though
        all responses from this backend had a "Cache-Control: public,
        max-age=[TTL]" header, regardless of any existing Cache-Control
        header. The actual headers served in responses will not be altered.
    """
    creation_timestamp: pulumi.Output[str]
    """
    Creation timestamp in RFC3339 text format.
    """
    description: pulumi.Output[str]
    """
    An optional textual description of the resource; provided by the
    client when the resource is created.
    """
    enable_cdn: pulumi.Output[bool]
    """
    If true, enable Cloud CDN for this BackendBucket.
    """
    name: pulumi.Output[str]
    """
    Name of the resource. Provided by the client when the resource is
    created. The name must be 1-63 characters long, and comply with
    RFC1035.  Specifically, the name must be 1-63 characters long and
    match the regular expression `a-z?` which means
    the first character must be a lowercase letter, and all following
    characters must be a dash, lowercase letter, or digit, except the
    last character, which cannot be a dash.
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
    def __init__(__self__, resource_name, opts=None, bucket_name=None, cdn_policy=None, description=None, enable_cdn=None, name=None, project=None, __props__=None, __name__=None, __opts__=None):
        """
        Backend buckets allow you to use Google Cloud Storage buckets with HTTP(S)
        load balancing.

        An HTTP(S) load balancer can direct traffic to specified URLs to a
        backend bucket rather than a backend service. It can send requests for
        static content to a Cloud Storage bucket and requests for dynamic content
        to a virtual machine instance.


        To get more information about BackendBucket, see:

        * [API documentation](https://cloud.google.com/compute/docs/reference/v1/backendBuckets)
        * How-to Guides
            * [Using a Cloud Storage bucket as a load balancer backend](https://cloud.google.com/compute/docs/load-balancing/http/backend-bucket)

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] bucket_name: Cloud Storage bucket name.
        :param pulumi.Input[dict] cdn_policy: Cloud CDN configuration for this Backend Bucket.  Structure is documented below.
        :param pulumi.Input[str] description: An optional textual description of the resource; provided by the
               client when the resource is created.
        :param pulumi.Input[bool] enable_cdn: If true, enable Cloud CDN for this BackendBucket.
        :param pulumi.Input[str] name: Name of the resource. Provided by the client when the resource is
               created. The name must be 1-63 characters long, and comply with
               RFC1035.  Specifically, the name must be 1-63 characters long and
               match the regular expression `a-z?` which means
               the first character must be a lowercase letter, and all following
               characters must be a dash, lowercase letter, or digit, except the
               last character, which cannot be a dash.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.

        The **cdn_policy** object supports the following:

          * `signedUrlCacheMaxAgeSec` (`pulumi.Input[float]`) - Maximum number of seconds the response to a signed URL request will
            be considered fresh. After this time period,
            the response will be revalidated before being served.
            When serving responses to signed URL requests,
            Cloud CDN will internally behave as though
            all responses from this backend had a "Cache-Control: public,
            max-age=[TTL]" header, regardless of any existing Cache-Control
            header. The actual headers served in responses will not be altered.
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

            if bucket_name is None:
                raise TypeError("Missing required property 'bucket_name'")
            __props__['bucket_name'] = bucket_name
            __props__['cdn_policy'] = cdn_policy
            __props__['description'] = description
            __props__['enable_cdn'] = enable_cdn
            __props__['name'] = name
            __props__['project'] = project
            __props__['creation_timestamp'] = None
            __props__['self_link'] = None
        super(BackendBucket, __self__).__init__(
            'gcp:compute/backendBucket:BackendBucket',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, bucket_name=None, cdn_policy=None, creation_timestamp=None, description=None, enable_cdn=None, name=None, project=None, self_link=None):
        """
        Get an existing BackendBucket resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] bucket_name: Cloud Storage bucket name.
        :param pulumi.Input[dict] cdn_policy: Cloud CDN configuration for this Backend Bucket.  Structure is documented below.
        :param pulumi.Input[str] creation_timestamp: Creation timestamp in RFC3339 text format.
        :param pulumi.Input[str] description: An optional textual description of the resource; provided by the
               client when the resource is created.
        :param pulumi.Input[bool] enable_cdn: If true, enable Cloud CDN for this BackendBucket.
        :param pulumi.Input[str] name: Name of the resource. Provided by the client when the resource is
               created. The name must be 1-63 characters long, and comply with
               RFC1035.  Specifically, the name must be 1-63 characters long and
               match the regular expression `a-z?` which means
               the first character must be a lowercase letter, and all following
               characters must be a dash, lowercase letter, or digit, except the
               last character, which cannot be a dash.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[str] self_link: The URI of the created resource.

        The **cdn_policy** object supports the following:

          * `signedUrlCacheMaxAgeSec` (`pulumi.Input[float]`) - Maximum number of seconds the response to a signed URL request will
            be considered fresh. After this time period,
            the response will be revalidated before being served.
            When serving responses to signed URL requests,
            Cloud CDN will internally behave as though
            all responses from this backend had a "Cache-Control: public,
            max-age=[TTL]" header, regardless of any existing Cache-Control
            header. The actual headers served in responses will not be altered.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["bucket_name"] = bucket_name
        __props__["cdn_policy"] = cdn_policy
        __props__["creation_timestamp"] = creation_timestamp
        __props__["description"] = description
        __props__["enable_cdn"] = enable_cdn
        __props__["name"] = name
        __props__["project"] = project
        __props__["self_link"] = self_link
        return BackendBucket(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

