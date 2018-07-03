# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class BucketACL(pulumi.CustomResource):
    """
    Creates a new bucket ACL in Google cloud storage service (GCS). For more information see 
    [the official documentation](https://cloud.google.com/storage/docs/access-control/lists) 
    and 
    [API](https://cloud.google.com/storage/docs/json_api/v1/bucketAccessControls).
    """
    def __init__(__self__, __name__, __opts__=None, bucket=None, default_acl=None, predefined_acl=None, role_entities=None):
        """Create a BucketACL resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not bucket:
            raise TypeError('Missing required property bucket')
        elif not isinstance(bucket, basestring):
            raise TypeError('Expected property bucket to be a basestring')
        __self__.bucket = bucket
        """
        The name of the bucket it applies to.
        """
        __props__['bucket'] = bucket

        if default_acl and not isinstance(default_acl, basestring):
            raise TypeError('Expected property default_acl to be a basestring')
        __self__.default_acl = default_acl
        """
        Configure this ACL to be the default ACL.
        """
        __props__['defaultAcl'] = default_acl

        if predefined_acl and not isinstance(predefined_acl, basestring):
            raise TypeError('Expected property predefined_acl to be a basestring')
        __self__.predefined_acl = predefined_acl
        """
        The [canned GCS ACL](https://cloud.google.com/storage/docs/access-control/lists#predefined-acl) to apply. Must be set if `role_entity` is not.
        """
        __props__['predefinedAcl'] = predefined_acl

        if role_entities and not isinstance(role_entities, list):
            raise TypeError('Expected property role_entities to be a list')
        __self__.role_entities = role_entities
        """
        List of role/entity pairs in the form `ROLE:entity`. See [GCS Bucket ACL documentation](https://cloud.google.com/storage/docs/json_api/v1/bucketAccessControls)  for more details. Must be set if `predefined_acl` is not.
        """
        __props__['roleEntities'] = role_entities

        super(BucketACL, __self__).__init__(
            'gcp:storage/bucketACL:BucketACL',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'bucket' in outs:
            self.bucket = outs['bucket']
        if 'defaultAcl' in outs:
            self.default_acl = outs['defaultAcl']
        if 'predefinedAcl' in outs:
            self.predefined_acl = outs['predefinedAcl']
        if 'roleEntities' in outs:
            self.role_entities = outs['roleEntities']
