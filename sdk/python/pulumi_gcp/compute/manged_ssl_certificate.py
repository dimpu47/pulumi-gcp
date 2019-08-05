# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class MangedSslCertificate(pulumi.CustomResource):
    certificate_id: pulumi.Output[float]
    creation_timestamp: pulumi.Output[str]
    description: pulumi.Output[str]
    expire_time: pulumi.Output[str]
    managed: pulumi.Output[dict]
    name: pulumi.Output[str]
    project: pulumi.Output[str]
    """
    The ID of the project in which the resource belongs.
    If it is not provided, the provider project is used.
    """
    self_link: pulumi.Output[str]
    """
    The URI of the created resource.
    """
    subject_alternative_names: pulumi.Output[list]
    type: pulumi.Output[str]
    def __init__(__self__, resource_name, opts=None, certificate_id=None, description=None, managed=None, name=None, project=None, type=None, __name__=None, __opts__=None):
        """
        An SslCertificate resource, used for HTTPS load balancing.  This resource
        represents a certificate for which the certificate secrets are created and
        managed by Google.
        
        For a resource where you provide the key, see the
        SSL Certificate resource.
        
        To get more information about ManagedSslCertificate, see:
        
        * [API documentation](https://cloud.google.com/compute/docs/reference/rest/v1/sslCertificates)
        * How-to Guides
            * [Official Documentation](https://cloud.google.com/load-balancing/docs/ssl-certificates)
        
        > **Warning:** This resource should be used with extreme caution!  Provisioning an SSL
        certificate is complex.  Ensure that you understand the lifecycle of a
        certificate before attempting complex tasks like cert rotation automatically.
        This resource will "return" as soon as the certificate object is created,
        but post-creation the certificate object will go through a "provisioning"
        process.  The provisioning process can complete only when the domain name
        for which the certificate is created points to a target pool which, itself,
        points at the certificate.  Depending on your DNS provider, this may take
        some time, and migrating from self-managed certificates to Google-managed
        certificates may entail some downtime while the certificate provisions.
        
        In conclusion: Be extremely cautious.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_managed_ssl_certificate.html.markdown.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if not resource_name:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(resource_name, str):
            raise TypeError('Expected resource name to be a string')
        if opts and not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        __props__['certificate_id'] = certificate_id

        __props__['description'] = description

        __props__['managed'] = managed

        __props__['name'] = name

        __props__['project'] = project

        __props__['type'] = type

        __props__['creation_timestamp'] = None
        __props__['expire_time'] = None
        __props__['self_link'] = None
        __props__['subject_alternative_names'] = None

        if opts is None:
            opts = pulumi.ResourceOptions()
        if opts.version is None:
            opts.version = utilities.get_version()
        super(MangedSslCertificate, __self__).__init__(
            'gcp:compute/mangedSslCertificate:MangedSslCertificate',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

