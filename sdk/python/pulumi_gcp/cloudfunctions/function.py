# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class Function(pulumi.CustomResource):
    available_memory_mb: pulumi.Output[float]
    """
    Memory (in MB), available to the function. Default value is 256MB. Allowed values are: 128MB, 256MB, 512MB, 1024MB, and 2048MB.
    """
    description: pulumi.Output[str]
    """
    Description of the function.
    """
    entry_point: pulumi.Output[str]
    """
    Name of the function that will be executed when the Google Cloud Function is triggered.
    """
    environment_variables: pulumi.Output[dict]
    """
    A set of key/value environment variable pairs to assign to the function.
    """
    event_trigger: pulumi.Output[dict]
    """
    A source that fires events in response to a condition in another service. Structure is documented below. Cannot be used with `trigger_http`.
    
      * `eventType` (`str`)
      * `failurePolicy` (`dict`)
    
        * `retry` (`bool`)
    
      * `resource` (`str`)
    """
    https_trigger_url: pulumi.Output[str]
    """
    URL which triggers function execution. Returned only if `trigger_http` is used.
    """
    labels: pulumi.Output[dict]
    """
    A set of key/value label pairs to assign to the function.
    """
    max_instances: pulumi.Output[float]
    """
    The limit on the maximum number of function instances that may coexist at a given time.
    """
    name: pulumi.Output[str]
    """
    A user-defined name of the function. Function names must be unique globally.
    """
    project: pulumi.Output[str]
    """
    Project of the function. If it is not provided, the provider project is used.
    """
    region: pulumi.Output[str]
    """
    Region of function. Currently can be only "us-central1". If it is not provided, the provider region is used.
    """
    runtime: pulumi.Output[str]
    """
    The runtime in which the function is going to run. One
    of `"nodejs6"`, `"nodejs8"`, `"nodejs10"`, `"python37"`, `"go111"`. If empty,
    defaults to `"nodejs6"`. It's recommended that you override the default, as
    `"nodejs6"` is deprecated.
    """
    service_account_email: pulumi.Output[str]
    """
    If provided, the self-provided service account to run the function with.
    """
    source_archive_bucket: pulumi.Output[str]
    """
    The GCS bucket containing the zip archive which contains the function.
    """
    source_archive_object: pulumi.Output[str]
    """
    The source archive object (file) in archive bucket.
    """
    source_repository: pulumi.Output[dict]
    """
    Represents parameters related to source repository where a function is hosted.
    Cannot be set alongside `source_archive_bucket` or `source_archive_object`. Structure is documented below.
    
      * `deployedUrl` (`str`)
      * `url` (`str`)
    """
    timeout: pulumi.Output[float]
    """
    Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.
    """
    trigger_http: pulumi.Output[bool]
    """
    Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as `https_trigger_url`. Cannot be used with `trigger_bucket` and `trigger_topic`.
    """
    vpc_connector: pulumi.Output[str]
    """
    The VPC Network Connector that this cloud function can connect to. It can be either the fully-qualified URI, or the short name of the network connector resource. The format of this field is `projects/*/locations/*/connectors/*`.
    """
    def __init__(__self__, resource_name, opts=None, available_memory_mb=None, description=None, entry_point=None, environment_variables=None, event_trigger=None, https_trigger_url=None, labels=None, max_instances=None, name=None, project=None, region=None, runtime=None, service_account_email=None, source_archive_bucket=None, source_archive_object=None, source_repository=None, timeout=None, trigger_http=None, vpc_connector=None, __props__=None, __name__=None, __opts__=None):
        """
        Creates a new Cloud Function. For more information see
        [the official documentation](https://cloud.google.com/functions/docs/)
        and
        [API](https://cloud.google.com/functions/docs/apis).
        
        > **Warning:** As of November 1, 2019, newly created Functions are
        private-by-default and will require [appropriate IAM permissions](https://cloud.google.com/functions/docs/reference/iam/roles)
        to be invoked. See below examples for how to set up the appropriate permissions,
        or view the [Cloud Functions IAM resources](https://www.terraform.io/docs/r/cloudfunctions_cloud_function_iam.html)
        for Cloud Functions.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[float] available_memory_mb: Memory (in MB), available to the function. Default value is 256MB. Allowed values are: 128MB, 256MB, 512MB, 1024MB, and 2048MB.
        :param pulumi.Input[str] description: Description of the function.
        :param pulumi.Input[str] entry_point: Name of the function that will be executed when the Google Cloud Function is triggered.
        :param pulumi.Input[dict] environment_variables: A set of key/value environment variable pairs to assign to the function.
        :param pulumi.Input[dict] event_trigger: A source that fires events in response to a condition in another service. Structure is documented below. Cannot be used with `trigger_http`.
        :param pulumi.Input[str] https_trigger_url: URL which triggers function execution. Returned only if `trigger_http` is used.
        :param pulumi.Input[dict] labels: A set of key/value label pairs to assign to the function.
        :param pulumi.Input[float] max_instances: The limit on the maximum number of function instances that may coexist at a given time.
        :param pulumi.Input[str] name: A user-defined name of the function. Function names must be unique globally.
        :param pulumi.Input[str] project: Project of the function. If it is not provided, the provider project is used.
        :param pulumi.Input[str] region: Region of function. Currently can be only "us-central1". If it is not provided, the provider region is used.
        :param pulumi.Input[str] runtime: The runtime in which the function is going to run. One
               of `"nodejs6"`, `"nodejs8"`, `"nodejs10"`, `"python37"`, `"go111"`. If empty,
               defaults to `"nodejs6"`. It's recommended that you override the default, as
               `"nodejs6"` is deprecated.
        :param pulumi.Input[str] service_account_email: If provided, the self-provided service account to run the function with.
        :param pulumi.Input[str] source_archive_bucket: The GCS bucket containing the zip archive which contains the function.
        :param pulumi.Input[str] source_archive_object: The source archive object (file) in archive bucket.
        :param pulumi.Input[dict] source_repository: Represents parameters related to source repository where a function is hosted.
               Cannot be set alongside `source_archive_bucket` or `source_archive_object`. Structure is documented below.
        :param pulumi.Input[float] timeout: Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.
        :param pulumi.Input[bool] trigger_http: Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as `https_trigger_url`. Cannot be used with `trigger_bucket` and `trigger_topic`.
        :param pulumi.Input[str] vpc_connector: The VPC Network Connector that this cloud function can connect to. It can be either the fully-qualified URI, or the short name of the network connector resource. The format of this field is `projects/*/locations/*/connectors/*`.
        
        The **event_trigger** object supports the following:
        
          * `eventType` (`pulumi.Input[str]`)
          * `failurePolicy` (`pulumi.Input[dict]`)
        
            * `retry` (`pulumi.Input[bool]`)
        
          * `resource` (`pulumi.Input[str]`)
        
        The **source_repository** object supports the following:
        
          * `deployedUrl` (`pulumi.Input[str]`)
          * `url` (`pulumi.Input[str]`)

        > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/cloudfunctions_function.html.markdown.
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

            __props__['available_memory_mb'] = available_memory_mb
            __props__['description'] = description
            __props__['entry_point'] = entry_point
            __props__['environment_variables'] = environment_variables
            __props__['event_trigger'] = event_trigger
            __props__['https_trigger_url'] = https_trigger_url
            __props__['labels'] = labels
            __props__['max_instances'] = max_instances
            __props__['name'] = name
            __props__['project'] = project
            __props__['region'] = region
            __props__['runtime'] = runtime
            __props__['service_account_email'] = service_account_email
            __props__['source_archive_bucket'] = source_archive_bucket
            __props__['source_archive_object'] = source_archive_object
            __props__['source_repository'] = source_repository
            __props__['timeout'] = timeout
            __props__['trigger_http'] = trigger_http
            __props__['vpc_connector'] = vpc_connector
        super(Function, __self__).__init__(
            'gcp:cloudfunctions/function:Function',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, available_memory_mb=None, description=None, entry_point=None, environment_variables=None, event_trigger=None, https_trigger_url=None, labels=None, max_instances=None, name=None, project=None, region=None, runtime=None, service_account_email=None, source_archive_bucket=None, source_archive_object=None, source_repository=None, timeout=None, trigger_http=None, vpc_connector=None):
        """
        Get an existing Function resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[float] available_memory_mb: Memory (in MB), available to the function. Default value is 256MB. Allowed values are: 128MB, 256MB, 512MB, 1024MB, and 2048MB.
        :param pulumi.Input[str] description: Description of the function.
        :param pulumi.Input[str] entry_point: Name of the function that will be executed when the Google Cloud Function is triggered.
        :param pulumi.Input[dict] environment_variables: A set of key/value environment variable pairs to assign to the function.
        :param pulumi.Input[dict] event_trigger: A source that fires events in response to a condition in another service. Structure is documented below. Cannot be used with `trigger_http`.
        :param pulumi.Input[str] https_trigger_url: URL which triggers function execution. Returned only if `trigger_http` is used.
        :param pulumi.Input[dict] labels: A set of key/value label pairs to assign to the function.
        :param pulumi.Input[float] max_instances: The limit on the maximum number of function instances that may coexist at a given time.
        :param pulumi.Input[str] name: A user-defined name of the function. Function names must be unique globally.
        :param pulumi.Input[str] project: Project of the function. If it is not provided, the provider project is used.
        :param pulumi.Input[str] region: Region of function. Currently can be only "us-central1". If it is not provided, the provider region is used.
        :param pulumi.Input[str] runtime: The runtime in which the function is going to run. One
               of `"nodejs6"`, `"nodejs8"`, `"nodejs10"`, `"python37"`, `"go111"`. If empty,
               defaults to `"nodejs6"`. It's recommended that you override the default, as
               `"nodejs6"` is deprecated.
        :param pulumi.Input[str] service_account_email: If provided, the self-provided service account to run the function with.
        :param pulumi.Input[str] source_archive_bucket: The GCS bucket containing the zip archive which contains the function.
        :param pulumi.Input[str] source_archive_object: The source archive object (file) in archive bucket.
        :param pulumi.Input[dict] source_repository: Represents parameters related to source repository where a function is hosted.
               Cannot be set alongside `source_archive_bucket` or `source_archive_object`. Structure is documented below.
        :param pulumi.Input[float] timeout: Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.
        :param pulumi.Input[bool] trigger_http: Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as `https_trigger_url`. Cannot be used with `trigger_bucket` and `trigger_topic`.
        :param pulumi.Input[str] vpc_connector: The VPC Network Connector that this cloud function can connect to. It can be either the fully-qualified URI, or the short name of the network connector resource. The format of this field is `projects/*/locations/*/connectors/*`.
        
        The **event_trigger** object supports the following:
        
          * `eventType` (`pulumi.Input[str]`)
          * `failurePolicy` (`pulumi.Input[dict]`)
        
            * `retry` (`pulumi.Input[bool]`)
        
          * `resource` (`pulumi.Input[str]`)
        
        The **source_repository** object supports the following:
        
          * `deployedUrl` (`pulumi.Input[str]`)
          * `url` (`pulumi.Input[str]`)

        > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/cloudfunctions_function.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["available_memory_mb"] = available_memory_mb
        __props__["description"] = description
        __props__["entry_point"] = entry_point
        __props__["environment_variables"] = environment_variables
        __props__["event_trigger"] = event_trigger
        __props__["https_trigger_url"] = https_trigger_url
        __props__["labels"] = labels
        __props__["max_instances"] = max_instances
        __props__["name"] = name
        __props__["project"] = project
        __props__["region"] = region
        __props__["runtime"] = runtime
        __props__["service_account_email"] = service_account_email
        __props__["source_archive_bucket"] = source_archive_bucket
        __props__["source_archive_object"] = source_archive_object
        __props__["source_repository"] = source_repository
        __props__["timeout"] = timeout
        __props__["trigger_http"] = trigger_http
        __props__["vpc_connector"] = vpc_connector
        return Function(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

