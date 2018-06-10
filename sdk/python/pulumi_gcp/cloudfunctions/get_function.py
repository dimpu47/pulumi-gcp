# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class GetFunctionResult(object):
    """
    A collection of values returned by getFunction.
    """
    def __init__(__self__, available_memory_mb=None, description=None, entry_point=None, https_trigger_url=None, labels=None, retry_on_failure=None, source_archive_bucket=None, source_archive_object=None, timeout=None, trigger_bucket=None, trigger_http=None, trigger_topic=None):
        if not available_memory_mb:
            raise TypeError('Missing required argument available_memory_mb')
        elif not isinstance(available_memory_mb, int):
            raise TypeError('Expected argument available_memory_mb to be a int')
        __self__.available_memory_mb = available_memory_mb
        """
        Available memory (in MB) to the function.
        """
        if not description:
            raise TypeError('Missing required argument description')
        elif not isinstance(description, basestring):
            raise TypeError('Expected argument description to be a basestring')
        __self__.description = description
        """
        Description of the function.
        """
        if not entry_point:
            raise TypeError('Missing required argument entry_point')
        elif not isinstance(entry_point, basestring):
            raise TypeError('Expected argument entry_point to be a basestring')
        __self__.entry_point = entry_point
        """
        Name of a JavaScript function that will be executed when the Google Cloud Function is triggered.
        """
        if not https_trigger_url:
            raise TypeError('Missing required argument https_trigger_url')
        elif not isinstance(https_trigger_url, basestring):
            raise TypeError('Expected argument https_trigger_url to be a basestring')
        __self__.https_trigger_url = https_trigger_url
        """
        If function is triggered by HTTP, trigger URL is set here.
        """
        if not labels:
            raise TypeError('Missing required argument labels')
        elif not isinstance(labels, dict):
            raise TypeError('Expected argument labels to be a dict')
        __self__.labels = labels
        """
        A map of labels applied to this function.
        """
        if not retry_on_failure:
            raise TypeError('Missing required argument retry_on_failure')
        elif not isinstance(retry_on_failure, bool):
            raise TypeError('Expected argument retry_on_failure to be a bool')
        __self__.retry_on_failure = retry_on_failure
        if not source_archive_bucket:
            raise TypeError('Missing required argument source_archive_bucket')
        elif not isinstance(source_archive_bucket, basestring):
            raise TypeError('Expected argument source_archive_bucket to be a basestring')
        __self__.source_archive_bucket = source_archive_bucket
        """
        The GCS bucket containing the zip archive which contains the function.
        """
        if not source_archive_object:
            raise TypeError('Missing required argument source_archive_object')
        elif not isinstance(source_archive_object, basestring):
            raise TypeError('Expected argument source_archive_object to be a basestring')
        __self__.source_archive_object = source_archive_object
        """
        The source archive object (file) in archive bucket.
        """
        if not timeout:
            raise TypeError('Missing required argument timeout')
        elif not isinstance(timeout, int):
            raise TypeError('Expected argument timeout to be a int')
        __self__.timeout = timeout
        """
        Function execution timeout (in seconds).
        """
        if not trigger_bucket:
            raise TypeError('Missing required argument trigger_bucket')
        elif not isinstance(trigger_bucket, basestring):
            raise TypeError('Expected argument trigger_bucket to be a basestring')
        __self__.trigger_bucket = trigger_bucket
        """
        If function is triggered by bucket, bucket name is set here.
        """
        if not trigger_http:
            raise TypeError('Missing required argument trigger_http')
        elif not isinstance(trigger_http, bool):
            raise TypeError('Expected argument trigger_http to be a bool')
        __self__.trigger_http = trigger_http
        """
        If function is triggered by HTTP, this boolean is set.
        """
        if not trigger_topic:
            raise TypeError('Missing required argument trigger_topic')
        elif not isinstance(trigger_topic, basestring):
            raise TypeError('Expected argument trigger_topic to be a basestring')
        __self__.trigger_topic = trigger_topic
        """
        If function is triggered by Pub/Sub topic, name of topic is set here.
        """

def get_function(name=None, project=None, region=None):
    """
    Get information about a Google Cloud Function. For more information see
    the [official documentation](https://cloud.google.com/functions/docs/)
    and [API](https://cloud.google.com/functions/docs/apis).
    """
    __args__ = dict()

    __args__['name'] = name
    __args__['project'] = project
    __args__['region'] = region
    __ret__ = pulumi.runtime.invoke('gcp:cloudfunctions/getFunction:getFunction', __args__)

    return GetFunctionResult(
        available_memory_mb=__ret__['availableMemoryMb'],
        description=__ret__['description'],
        entry_point=__ret__['entryPoint'],
        https_trigger_url=__ret__['httpsTriggerUrl'],
        labels=__ret__['labels'],
        retry_on_failure=__ret__['retryOnFailure'],
        source_archive_bucket=__ret__['sourceArchiveBucket'],
        source_archive_object=__ret__['sourceArchiveObject'],
        timeout=__ret__['timeout'],
        trigger_bucket=__ret__['triggerBucket'],
        trigger_http=__ret__['triggerHttp'],
        trigger_topic=__ret__['triggerTopic'])