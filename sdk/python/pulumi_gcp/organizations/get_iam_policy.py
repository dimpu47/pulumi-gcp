# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class GetIAMPolicyResult:
    """
    A collection of values returned by getIAMPolicy.
    """
    def __init__(__self__, audit_configs=None, bindings=None, policy_data=None, id=None):
        if audit_configs and not isinstance(audit_configs, list):
            raise TypeError("Expected argument 'audit_configs' to be a list")
        __self__.audit_configs = audit_configs
        if bindings and not isinstance(bindings, list):
            raise TypeError("Expected argument 'bindings' to be a list")
        __self__.bindings = bindings
        if policy_data and not isinstance(policy_data, str):
            raise TypeError("Expected argument 'policy_data' to be a str")
        __self__.policy_data = policy_data
        """
        The above bindings serialized in a format suitable for
        referencing from a resource that supports IAM.
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return self

    __iter__ = __await__

def get_iam_policy(audit_configs=None,bindings=None,opts=None):
    """
    Generates an IAM policy document that may be referenced by and applied to
    other Google Cloud Platform resources, such as the `google_project` resource.
    
    
    This data source is used to define IAM policies to apply to other resources.
    Currently, defining a policy through a datasource and referencing that policy
    from another resource is the only way to apply an IAM policy to a resource.
    
    **Note:** Several restrictions apply when setting IAM policies through this API.
    See the [setIamPolicy docs](https://cloud.google.com/resource-manager/reference/rest/v1/projects/setIamPolicy)
    for a list of these restrictions.

    > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/d/iam_policy.html.markdown.
    """
    __args__ = dict()

    __args__['auditConfigs'] = audit_configs
    __args__['bindings'] = bindings
    if opts is None:
        opts = pulumi.ResourceOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('gcp:organizations/getIAMPolicy:getIAMPolicy', __args__, opts=opts).value

    return GetIAMPolicyResult(
        audit_configs=__ret__.get('auditConfigs'),
        bindings=__ret__.get('bindings'),
        policy_data=__ret__.get('policyData'),
        id=__ret__.get('id'))
