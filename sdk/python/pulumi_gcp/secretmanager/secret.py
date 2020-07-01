# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables


class Secret(pulumi.CustomResource):
    create_time: pulumi.Output[str]
    """
    The time at which the Secret was created.
    """
    labels: pulumi.Output[dict]
    """
    The labels assigned to this Secret.
    Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes,
    and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
    Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes,
    and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63}
    No more than 64 labels can be assigned to a given resource.
    An object containing a list of "key": value pairs. Example:
    { "name": "wrench", "mass": "1.3kg", "count": "3" }.
    """
    name: pulumi.Output[str]
    """
    The resource name of the Secret. Format: 'projects/{{project}}/secrets/{{secret_id}}'
    """
    project: pulumi.Output[str]
    """
    The ID of the project in which the resource belongs.
    If it is not provided, the provider project is used.
    """
    replication: pulumi.Output[dict]
    """
    The replication policy of the secret data attached to the Secret. It cannot be changed
    after the Secret has been created.  Structure is documented below.

      * `automatic` (`bool`) - The Secret will automatically be replicated without any restrictions.
      * `userManaged` (`dict`) - The Secret will automatically be replicated without any restrictions.  Structure is documented below.
        * `replicas` (`list`) - The list of Replicas for this Secret. Cannot be empty.  Structure is documented below.
          * `location` (`str`) - The canonical IDs of the location to replicate data. For example: "us-east1".
    """
    secret_id: pulumi.Output[str]
    """
    This must be unique within the project.
    """
    def __init__(__self__, resource_name, opts=None, labels=None, project=None, replication=None, secret_id=None, __props__=None, __name__=None, __opts__=None):
        """
        A Secret is a logical secret whose value and versions can be accessed.

        To get more information about Secret, see:

        * [API documentation](https://cloud.google.com/secret-manager/docs/reference/rest/v1/projects.secrets)

        ## Example Usage

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] labels: The labels assigned to this Secret.
               Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes,
               and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
               Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes,
               and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63}
               No more than 64 labels can be assigned to a given resource.
               An object containing a list of "key": value pairs. Example:
               { "name": "wrench", "mass": "1.3kg", "count": "3" }.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[dict] replication: The replication policy of the secret data attached to the Secret. It cannot be changed
               after the Secret has been created.  Structure is documented below.
        :param pulumi.Input[str] secret_id: This must be unique within the project.

        The **replication** object supports the following:

          * `automatic` (`pulumi.Input[bool]`) - The Secret will automatically be replicated without any restrictions.
          * `userManaged` (`pulumi.Input[dict]`) - The Secret will automatically be replicated without any restrictions.  Structure is documented below.
            * `replicas` (`pulumi.Input[list]`) - The list of Replicas for this Secret. Cannot be empty.  Structure is documented below.
              * `location` (`pulumi.Input[str]`) - The canonical IDs of the location to replicate data. For example: "us-east1".
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

            __props__['labels'] = labels
            __props__['project'] = project
            if replication is None:
                raise TypeError("Missing required property 'replication'")
            __props__['replication'] = replication
            if secret_id is None:
                raise TypeError("Missing required property 'secret_id'")
            __props__['secret_id'] = secret_id
            __props__['create_time'] = None
            __props__['name'] = None
        super(Secret, __self__).__init__(
            'gcp:secretmanager/secret:Secret',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, create_time=None, labels=None, name=None, project=None, replication=None, secret_id=None):
        """
        Get an existing Secret resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] create_time: The time at which the Secret was created.
        :param pulumi.Input[dict] labels: The labels assigned to this Secret.
               Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes,
               and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
               Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes,
               and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63}
               No more than 64 labels can be assigned to a given resource.
               An object containing a list of "key": value pairs. Example:
               { "name": "wrench", "mass": "1.3kg", "count": "3" }.
        :param pulumi.Input[str] name: The resource name of the Secret. Format: 'projects/{{project}}/secrets/{{secret_id}}'
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[dict] replication: The replication policy of the secret data attached to the Secret. It cannot be changed
               after the Secret has been created.  Structure is documented below.
        :param pulumi.Input[str] secret_id: This must be unique within the project.

        The **replication** object supports the following:

          * `automatic` (`pulumi.Input[bool]`) - The Secret will automatically be replicated without any restrictions.
          * `userManaged` (`pulumi.Input[dict]`) - The Secret will automatically be replicated without any restrictions.  Structure is documented below.
            * `replicas` (`pulumi.Input[list]`) - The list of Replicas for this Secret. Cannot be empty.  Structure is documented below.
              * `location` (`pulumi.Input[str]`) - The canonical IDs of the location to replicate data. For example: "us-east1".
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["create_time"] = create_time
        __props__["labels"] = labels
        __props__["name"] = name
        __props__["project"] = project
        __props__["replication"] = replication
        __props__["secret_id"] = secret_id
        return Secret(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
