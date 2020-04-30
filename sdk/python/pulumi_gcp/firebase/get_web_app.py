# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetWebAppResult:
    """
    A collection of values returned by getWebApp.
    """
    def __init__(__self__, app_id=None, display_name=None, id=None, name=None, project=None):
        if app_id and not isinstance(app_id, str):
            raise TypeError("Expected argument 'app_id' to be a str")
        __self__.app_id = app_id
        if display_name and not isinstance(display_name, str):
            raise TypeError("Expected argument 'display_name' to be a str")
        __self__.display_name = display_name
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if project and not isinstance(project, str):
            raise TypeError("Expected argument 'project' to be a str")
        __self__.project = project
class AwaitableGetWebAppResult(GetWebAppResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetWebAppResult(
            app_id=self.app_id,
            display_name=self.display_name,
            id=self.id,
            name=self.name,
            project=self.project)

def get_web_app(app_id=None,opts=None):
    """
    A Google Cloud Firebase web application instance


    :param str app_id: The app_ip of name of the Firebase webApp.
    """
    __args__ = dict()


    __args__['appId'] = app_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('gcp:firebase/getWebApp:getWebApp', __args__, opts=opts).value

    return AwaitableGetWebAppResult(
        app_id=__ret__.get('appId'),
        display_name=__ret__.get('displayName'),
        id=__ret__.get('id'),
        name=__ret__.get('name'),
        project=__ret__.get('project'))
