# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['KeyRingImportJob']


class KeyRingImportJob(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 import_job_id: Optional[pulumi.Input[str]] = None,
                 import_method: Optional[pulumi.Input[str]] = None,
                 key_ring: Optional[pulumi.Input[str]] = None,
                 protection_level: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        A `KeyRingImportJob` can be used to create `CryptoKeys` and `CryptoKeyVersions` using pre-existing
        key material, generated outside of Cloud KMS. A `KeyRingImportJob` expires 3 days after it is created.
        Once expired, Cloud KMS will no longer be able to import or unwrap any key material that
        was wrapped with the `KeyRingImportJob`'s public key.

        > **Note:** KeyRingImportJobs cannot be deleted from Google Cloud Platform.
        Destroying a KeyRingImportJob will remove it from state but
        *will not delete the resource on the server.*

        To get more information about KeyRingImportJob, see:

        * [API documentation](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyRings.importJobs)
        * How-to Guides
            * [Importing a key](https://cloud.google.com/kms/docs/importing-a-key)

        ## Example Usage

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] import_job_id: It must be unique within a KeyRing and match the regular expression [a-zA-Z0-9_-]{1,63}
        :param pulumi.Input[str] import_method: The wrapping method to be used for incoming key material.
               Possible values are `RSA_OAEP_3072_SHA1_AES_256` and `RSA_OAEP_4096_SHA1_AES_256`.
        :param pulumi.Input[str] key_ring: The KeyRing that this import job belongs to.
               Format: `'projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}'`.
        :param pulumi.Input[str] protection_level: The protection level of the ImportJob. This must match the protectionLevel of the
               versionTemplate on the CryptoKey you attempt to import into.
               Possible values are `SOFTWARE`, `HSM`, and `EXTERNAL`.
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
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            if import_job_id is None:
                raise TypeError("Missing required property 'import_job_id'")
            __props__['import_job_id'] = import_job_id
            if import_method is None:
                raise TypeError("Missing required property 'import_method'")
            __props__['import_method'] = import_method
            if key_ring is None:
                raise TypeError("Missing required property 'key_ring'")
            __props__['key_ring'] = key_ring
            if protection_level is None:
                raise TypeError("Missing required property 'protection_level'")
            __props__['protection_level'] = protection_level
            __props__['attestation'] = None
            __props__['expire_time'] = None
            __props__['name'] = None
            __props__['public_key'] = None
            __props__['state'] = None
        super(KeyRingImportJob, __self__).__init__(
            'gcp:kms/keyRingImportJob:KeyRingImportJob',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            attestation: Optional[pulumi.Input[pulumi.InputType['KeyRingImportJobAttestationArgs']]] = None,
            expire_time: Optional[pulumi.Input[str]] = None,
            import_job_id: Optional[pulumi.Input[str]] = None,
            import_method: Optional[pulumi.Input[str]] = None,
            key_ring: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            protection_level: Optional[pulumi.Input[str]] = None,
            public_key: Optional[pulumi.Input[pulumi.InputType['KeyRingImportJobPublicKeyArgs']]] = None,
            state: Optional[pulumi.Input[str]] = None) -> 'KeyRingImportJob':
        """
        Get an existing KeyRingImportJob resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['KeyRingImportJobAttestationArgs']] attestation: Statement that was generated and signed by the key creator (for example, an HSM) at key creation time. Use this
               statement to verify attributes of the key as stored on the HSM, independently of Google. Only present if the chosen
               ImportMethod is one with a protection level of HSM.
        :param pulumi.Input[str] expire_time: The time at which this resource is scheduled for expiration and can no longer be used. This is in RFC3339 text format.
        :param pulumi.Input[str] import_job_id: It must be unique within a KeyRing and match the regular expression [a-zA-Z0-9_-]{1,63}
        :param pulumi.Input[str] import_method: The wrapping method to be used for incoming key material.
               Possible values are `RSA_OAEP_3072_SHA1_AES_256` and `RSA_OAEP_4096_SHA1_AES_256`.
        :param pulumi.Input[str] key_ring: The KeyRing that this import job belongs to.
               Format: `'projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}'`.
        :param pulumi.Input[str] name: The resource name for this ImportJob in the format projects/*/locations/*/keyRings/*/importJobs/*.
        :param pulumi.Input[str] protection_level: The protection level of the ImportJob. This must match the protectionLevel of the
               versionTemplate on the CryptoKey you attempt to import into.
               Possible values are `SOFTWARE`, `HSM`, and `EXTERNAL`.
        :param pulumi.Input[pulumi.InputType['KeyRingImportJobPublicKeyArgs']] public_key: The public key with which to wrap key material prior to import. Only returned if state is 'ACTIVE'.
        :param pulumi.Input[str] state: The current state of the ImportJob, indicating if it can be used.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["attestation"] = attestation
        __props__["expire_time"] = expire_time
        __props__["import_job_id"] = import_job_id
        __props__["import_method"] = import_method
        __props__["key_ring"] = key_ring
        __props__["name"] = name
        __props__["protection_level"] = protection_level
        __props__["public_key"] = public_key
        __props__["state"] = state
        return KeyRingImportJob(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def attestation(self) -> pulumi.Output['outputs.KeyRingImportJobAttestation']:
        """
        Statement that was generated and signed by the key creator (for example, an HSM) at key creation time. Use this
        statement to verify attributes of the key as stored on the HSM, independently of Google. Only present if the chosen
        ImportMethod is one with a protection level of HSM.
        """
        return pulumi.get(self, "attestation")

    @property
    @pulumi.getter(name="expireTime")
    def expire_time(self) -> pulumi.Output[str]:
        """
        The time at which this resource is scheduled for expiration and can no longer be used. This is in RFC3339 text format.
        """
        return pulumi.get(self, "expire_time")

    @property
    @pulumi.getter(name="importJobId")
    def import_job_id(self) -> pulumi.Output[str]:
        """
        It must be unique within a KeyRing and match the regular expression [a-zA-Z0-9_-]{1,63}
        """
        return pulumi.get(self, "import_job_id")

    @property
    @pulumi.getter(name="importMethod")
    def import_method(self) -> pulumi.Output[str]:
        """
        The wrapping method to be used for incoming key material.
        Possible values are `RSA_OAEP_3072_SHA1_AES_256` and `RSA_OAEP_4096_SHA1_AES_256`.
        """
        return pulumi.get(self, "import_method")

    @property
    @pulumi.getter(name="keyRing")
    def key_ring(self) -> pulumi.Output[str]:
        """
        The KeyRing that this import job belongs to.
        Format: `'projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}'`.
        """
        return pulumi.get(self, "key_ring")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The resource name for this ImportJob in the format projects/*/locations/*/keyRings/*/importJobs/*.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="protectionLevel")
    def protection_level(self) -> pulumi.Output[str]:
        """
        The protection level of the ImportJob. This must match the protectionLevel of the
        versionTemplate on the CryptoKey you attempt to import into.
        Possible values are `SOFTWARE`, `HSM`, and `EXTERNAL`.
        """
        return pulumi.get(self, "protection_level")

    @property
    @pulumi.getter(name="publicKey")
    def public_key(self) -> pulumi.Output['outputs.KeyRingImportJobPublicKey']:
        """
        The public key with which to wrap key material prior to import. Only returned if state is 'ACTIVE'.
        """
        return pulumi.get(self, "public_key")

    @property
    @pulumi.getter
    def state(self) -> pulumi.Output[str]:
        """
        The current state of the ImportJob, indicating if it can be used.
        """
        return pulumi.get(self, "state")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

