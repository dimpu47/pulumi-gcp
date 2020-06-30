// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package redis

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Get information about a Google Cloud Redis instance. For more information see
// the [official documentation](https://cloud.google.com/memorystore/docs/redis)
// and [API](https://cloud.google.com/memorystore/docs/redis/apis).
func LookupInstance(ctx *pulumi.Context, args *LookupInstanceArgs, opts ...pulumi.InvokeOption) (*LookupInstanceResult, error) {
	var rv LookupInstanceResult
	err := ctx.Invoke("gcp:redis/getInstance:getInstance", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getInstance.
type LookupInstanceArgs struct {
	// The name of a Redis instance.
	Name string `pulumi:"name"`
	// The project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project *string `pulumi:"project"`
	// The region in which the resource belongs. If it
	// is not provided, the provider region is used.
	Region *string `pulumi:"region"`
}

// A collection of values returned by getInstance.
type LookupInstanceResult struct {
	AlternativeLocationId string `pulumi:"alternativeLocationId"`
	AuthorizedNetwork     string `pulumi:"authorizedNetwork"`
	ConnectMode           string `pulumi:"connectMode"`
	CreateTime            string `pulumi:"createTime"`
	CurrentLocationId     string `pulumi:"currentLocationId"`
	DisplayName           string `pulumi:"displayName"`
	// Hostname or IP address of the exposed Redis endpoint used by clients
	// to connect to the service.
	Host string `pulumi:"host"`
	// The provider-assigned unique ID for this managed resource.
	Id           string            `pulumi:"id"`
	Labels       map[string]string `pulumi:"labels"`
	LocationId   string            `pulumi:"locationId"`
	MemorySizeGb int               `pulumi:"memorySizeGb"`
	Name         string            `pulumi:"name"`
	// The port number of the exposed Redis endpoint.
	Port            int               `pulumi:"port"`
	Project         *string           `pulumi:"project"`
	RedisConfigs    map[string]string `pulumi:"redisConfigs"`
	RedisVersion    string            `pulumi:"redisVersion"`
	Region          *string           `pulumi:"region"`
	ReservedIpRange string            `pulumi:"reservedIpRange"`
	Tier            string            `pulumi:"tier"`
}
