# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class IAMCustomRole(pulumi.CustomResource):
    """
    Allows management of a customized Cloud IAM organization role. For more information see
    [the official documentation](https://cloud.google.com/iam/docs/understanding-custom-roles)
    and
    [API](https://cloud.google.com/iam/reference/rest/v1/organizations.roles).
    """
    def __init__(__self__, __name__, __opts__=None, deleted=None, description=None, org_id=None, permissions=None, role_id=None, stage=None, title=None):
        """Create a IAMCustomRole resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if deleted and not isinstance(deleted, bool):
            raise TypeError('Expected property deleted to be a bool')
        __self__.deleted = deleted
        """
        The current deleted state of the role. Defaults to `false`.
        """
        __props__['deleted'] = deleted

        if description and not isinstance(description, basestring):
            raise TypeError('Expected property description to be a basestring')
        __self__.description = description
        """
        A human-readable description for the role.
        """
        __props__['description'] = description

        if not org_id:
            raise TypeError('Missing required property org_id')
        elif not isinstance(org_id, basestring):
            raise TypeError('Expected property org_id to be a basestring')
        __self__.org_id = org_id
        """
        The numeric ID of the organization in which you want to create a custom role.
        """
        __props__['orgId'] = org_id

        if not permissions:
            raise TypeError('Missing required property permissions')
        elif not isinstance(permissions, list):
            raise TypeError('Expected property permissions to be a list')
        __self__.permissions = permissions
        """
        The names of the permissions this role grants when bound in an IAM policy. At least one permission must be specified.
        """
        __props__['permissions'] = permissions

        if not role_id:
            raise TypeError('Missing required property role_id')
        elif not isinstance(role_id, basestring):
            raise TypeError('Expected property role_id to be a basestring')
        __self__.role_id = role_id
        """
        The role id to use for this role.
        """
        __props__['roleId'] = role_id

        if stage and not isinstance(stage, basestring):
            raise TypeError('Expected property stage to be a basestring')
        __self__.stage = stage
        """
        The current launch stage of the role.
        Defaults to `GA`.
        List of possible stages is [here](https://cloud.google.com/iam/reference/rest/v1/organizations.roles#Role.RoleLaunchStage).
        """
        __props__['stage'] = stage

        if not title:
            raise TypeError('Missing required property title')
        elif not isinstance(title, basestring):
            raise TypeError('Expected property title to be a basestring')
        __self__.title = title
        """
        A human-readable title for the role.
        """
        __props__['title'] = title

        super(IAMCustomRole, __self__).__init__(
            'gcp:organizations/iAMCustomRole:IAMCustomRole',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'deleted' in outs:
            self.deleted = outs['deleted']
        if 'description' in outs:
            self.description = outs['description']
        if 'orgId' in outs:
            self.org_id = outs['orgId']
        if 'permissions' in outs:
            self.permissions = outs['permissions']
        if 'roleId' in outs:
            self.role_id = outs['roleId']
        if 'stage' in outs:
            self.stage = outs['stage']
        if 'title' in outs:
            self.title = outs['title']
