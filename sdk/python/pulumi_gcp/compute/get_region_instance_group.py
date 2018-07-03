# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class GetRegionInstanceGroupResult(object):
    """
    A collection of values returned by getRegionInstanceGroup.
    """
    def __init__(__self__, instances=None, name=None, project=None, region=None, self_link=None, size=None, id=None):
        if instances and not isinstance(instances, list):
            raise TypeError('Expected argument instances to be a list')
        __self__.instances = instances
        """
        List of instances in the group, as a list of resources, each containing:
        """
        if name and not isinstance(name, basestring):
            raise TypeError('Expected argument name to be a basestring')
        __self__.name = name
        """
        String port name
        """
        if project and not isinstance(project, basestring):
            raise TypeError('Expected argument project to be a basestring')
        __self__.project = project
        if region and not isinstance(region, basestring):
            raise TypeError('Expected argument region to be a basestring')
        __self__.region = region
        if self_link and not isinstance(self_link, basestring):
            raise TypeError('Expected argument self_link to be a basestring')
        __self__.self_link = self_link
        if size and not isinstance(size, int):
            raise TypeError('Expected argument size to be a int')
        __self__.size = size
        """
        The number of instances in the group.
        """
        if id and not isinstance(id, basestring):
            raise TypeError('Expected argument id to be a basestring')
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

def get_region_instance_group(name=None, project=None, region=None, self_link=None):
    """
    Get a Compute Region Instance Group within GCE.
    For more information, see [the official documentation](https://cloud.google.com/compute/docs/instance-groups/distributing-instances-with-regional-instance-groups) and [API](https://cloud.google.com/compute/docs/reference/latest/regionInstanceGroups).
    
    ```
    data "google_compute_region_instance_group" "group" {
    	name = "instance-group-name"
    }
    ```
    
    The most common use of this datasource will be to fetch information about the instances inside regional managed instance groups, for instance:
    
    ```
    resource "google_compute_region_instance_group_manager" "foo" {
    	name = "some_name"
        ...
    	base_instance_name = "foo"
        ...
    	instance_template = "${google_compute_instance_template.foo.self_link}"
    	target_pools = ["${google_compute_target_pool.foo.self_link}"]
        ...
    }
    
    data "google_compute_region_instance_group" "data_source" {
    	self_link = "${google_compute_region_instance_group_manager.foo.instance_group}"
    }
    
    ```
    """
    __args__ = dict()

    __args__['name'] = name
    __args__['project'] = project
    __args__['region'] = region
    __args__['selfLink'] = self_link
    __ret__ = pulumi.runtime.invoke('gcp:compute/getRegionInstanceGroup:getRegionInstanceGroup', __args__)

    return GetRegionInstanceGroupResult(
        instances=__ret__.get('instances'),
        name=__ret__.get('name'),
        project=__ret__.get('project'),
        region=__ret__.get('region'),
        self_link=__ret__.get('selfLink'),
        size=__ret__.get('size'),
        id=__ret__.get('id'))
