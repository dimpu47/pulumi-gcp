# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables


class TagTemplate(pulumi.CustomResource):
    display_name: pulumi.Output[str]
    """
    The display name for this template.
    """
    fields: pulumi.Output[list]
    """
    Set of tag template field IDs and the settings for the field. This set is an exhaustive list of the allowed fields. This set must contain at least one field and at most 500 fields.  Structure is documented below.

      * `display_name` (`str`) - The display name for this template.
      * `fieldId` (`str`) - The identifier for this object. Format specified above.
      * `isRequired` (`bool`) - Whether this is a required field. Defaults to false.
      * `name` (`str`) - -
        The resource name of the tag template field in URL format. Example: projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}/fields/{field}
      * `order` (`float`) - The order of this field with respect to other fields in this tag template.
        A higher value indicates a more important field. The value can be negative.
        Multiple fields can have the same order, and field orders within a tag do not have to be sequential.
      * `type` (`dict`) - The type of value this tag field can contain.  Structure is documented below.
        * `enumType` (`dict`) - Represents an enum type.
          Exactly one of `primitive_type` or `enum_type` must be set  Structure is documented below.
          * `allowedValues` (`list`) - The set of allowed values for this enum. The display names of the
            values must be case-insensitively unique within this set. Currently,
            enum values can only be added to the list of allowed values. Deletion
            and renaming of enum values are not supported.
            Can have up to 500 allowed values.  Structure is documented below.
            * `display_name` (`str`) - The display name for this template.

        * `primitiveType` (`str`) - Represents primitive types - string, bool etc.
          Exactly one of `primitive_type` or `enum_type` must be set
    """
    force_delete: pulumi.Output[bool]
    """
    This confirms the deletion of any possible tags using this template. Must be set to true in order to delete the tag template.
    """
    name: pulumi.Output[str]
    """
    -
    The resource name of the tag template field in URL format. Example: projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}/fields/{field}
    """
    project: pulumi.Output[str]
    """
    The ID of the project in which the resource belongs.
    If it is not provided, the provider project is used.
    """
    region: pulumi.Output[str]
    """
    Template location region.
    """
    tag_template_id: pulumi.Output[str]
    """
    The id of the tag template to create.
    """
    def __init__(__self__, resource_name, opts=None, display_name=None, fields=None, force_delete=None, project=None, region=None, tag_template_id=None, __props__=None, __name__=None, __opts__=None):
        """
        A tag template defines a tag, which can have one or more typed fields.
        The template is used to create and attach the tag to GCP resources.

        To get more information about TagTemplate, see:

        * [API documentation](https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.tagTemplates)
        * How-to Guides
            * [Official Documentation](https://cloud.google.com/data-catalog/docs)

        ## Example Usage

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] display_name: The display name for this template.
        :param pulumi.Input[list] fields: Set of tag template field IDs and the settings for the field. This set is an exhaustive list of the allowed fields. This set must contain at least one field and at most 500 fields.  Structure is documented below.
        :param pulumi.Input[bool] force_delete: This confirms the deletion of any possible tags using this template. Must be set to true in order to delete the tag template.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[str] region: Template location region.
        :param pulumi.Input[str] tag_template_id: The id of the tag template to create.

        The **fields** object supports the following:

          * `display_name` (`pulumi.Input[str]`) - The display name for this template.
          * `fieldId` (`pulumi.Input[str]`) - The identifier for this object. Format specified above.
          * `isRequired` (`pulumi.Input[bool]`) - Whether this is a required field. Defaults to false.
          * `name` (`pulumi.Input[str]`) - -
            The resource name of the tag template field in URL format. Example: projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}/fields/{field}
          * `order` (`pulumi.Input[float]`) - The order of this field with respect to other fields in this tag template.
            A higher value indicates a more important field. The value can be negative.
            Multiple fields can have the same order, and field orders within a tag do not have to be sequential.
          * `type` (`pulumi.Input[dict]`) - The type of value this tag field can contain.  Structure is documented below.
            * `enumType` (`pulumi.Input[dict]`) - Represents an enum type.
              Exactly one of `primitive_type` or `enum_type` must be set  Structure is documented below.
              * `allowedValues` (`pulumi.Input[list]`) - The set of allowed values for this enum. The display names of the
                values must be case-insensitively unique within this set. Currently,
                enum values can only be added to the list of allowed values. Deletion
                and renaming of enum values are not supported.
                Can have up to 500 allowed values.  Structure is documented below.
                * `display_name` (`pulumi.Input[str]`) - The display name for this template.

            * `primitiveType` (`pulumi.Input[str]`) - Represents primitive types - string, bool etc.
              Exactly one of `primitive_type` or `enum_type` must be set
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

            __props__['display_name'] = display_name
            if fields is None:
                raise TypeError("Missing required property 'fields'")
            __props__['fields'] = fields
            __props__['force_delete'] = force_delete
            __props__['project'] = project
            __props__['region'] = region
            if tag_template_id is None:
                raise TypeError("Missing required property 'tag_template_id'")
            __props__['tag_template_id'] = tag_template_id
            __props__['name'] = None
        super(TagTemplate, __self__).__init__(
            'gcp:datacatalog/tagTemplate:TagTemplate',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, display_name=None, fields=None, force_delete=None, name=None, project=None, region=None, tag_template_id=None):
        """
        Get an existing TagTemplate resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] display_name: The display name for this template.
        :param pulumi.Input[list] fields: Set of tag template field IDs and the settings for the field. This set is an exhaustive list of the allowed fields. This set must contain at least one field and at most 500 fields.  Structure is documented below.
        :param pulumi.Input[bool] force_delete: This confirms the deletion of any possible tags using this template. Must be set to true in order to delete the tag template.
        :param pulumi.Input[str] name: -
               The resource name of the tag template field in URL format. Example: projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}/fields/{field}
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[str] region: Template location region.
        :param pulumi.Input[str] tag_template_id: The id of the tag template to create.

        The **fields** object supports the following:

          * `display_name` (`pulumi.Input[str]`) - The display name for this template.
          * `fieldId` (`pulumi.Input[str]`) - The identifier for this object. Format specified above.
          * `isRequired` (`pulumi.Input[bool]`) - Whether this is a required field. Defaults to false.
          * `name` (`pulumi.Input[str]`) - -
            The resource name of the tag template field in URL format. Example: projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}/fields/{field}
          * `order` (`pulumi.Input[float]`) - The order of this field with respect to other fields in this tag template.
            A higher value indicates a more important field. The value can be negative.
            Multiple fields can have the same order, and field orders within a tag do not have to be sequential.
          * `type` (`pulumi.Input[dict]`) - The type of value this tag field can contain.  Structure is documented below.
            * `enumType` (`pulumi.Input[dict]`) - Represents an enum type.
              Exactly one of `primitive_type` or `enum_type` must be set  Structure is documented below.
              * `allowedValues` (`pulumi.Input[list]`) - The set of allowed values for this enum. The display names of the
                values must be case-insensitively unique within this set. Currently,
                enum values can only be added to the list of allowed values. Deletion
                and renaming of enum values are not supported.
                Can have up to 500 allowed values.  Structure is documented below.
                * `display_name` (`pulumi.Input[str]`) - The display name for this template.

            * `primitiveType` (`pulumi.Input[str]`) - Represents primitive types - string, bool etc.
              Exactly one of `primitive_type` or `enum_type` must be set
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["display_name"] = display_name
        __props__["fields"] = fields
        __props__["force_delete"] = force_delete
        __props__["name"] = name
        __props__["project"] = project
        __props__["region"] = region
        __props__["tag_template_id"] = tag_template_id
        return TagTemplate(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
