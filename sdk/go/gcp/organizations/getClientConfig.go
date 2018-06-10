// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package organizations

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access the configuration of the Google Cloud provider.
func LookupClientConfig(ctx *pulumi.Context) (*GetClientConfigResult, error) {
	outputs, err := ctx.Invoke("gcp:organizations/getClientConfig:getClientConfig", nil)
	if err != nil {
		return nil, err
	}
	return &GetClientConfigResult{
		AccessToken: outputs["accessToken"],
	}
		Project: outputs["project"],
	}
		Region: outputs["region"],
	}
	}, nil
}

// A collection of values returned by getClientConfig.
type GetClientConfigResult struct {
	// The OAuth2 access token used by the client to authenticate against the Google Cloud API.
	AccessToken interface{}
	// The ID of the project to apply any resources to.
	Project interface{}
	// The region to operate under.
	Region interface{}
}
