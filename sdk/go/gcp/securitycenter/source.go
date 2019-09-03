// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package securitycenter

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// A Cloud Security Command Center's (Cloud SCC) finding source. A finding
// source is an entity or a mechanism that can produce a finding. A source is
// like a container of findings that come from the same scanner, logger,
// monitor, etc.
// 
// 
// To get more information about Source, see:
// 
// * [API documentation](https://cloud.google.com/security-command-center/docs/reference/rest/v1beta1/organizations.sources)
// * How-to Guides
//     * [Official Documentation](https://cloud.google.com/binary-authorization/)
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/scc_source.html.markdown.
type Source struct {
	s *pulumi.ResourceState
}

// NewSource registers a new resource with the given unique name, arguments, and options.
func NewSource(ctx *pulumi.Context,
	name string, args *SourceArgs, opts ...pulumi.ResourceOpt) (*Source, error) {
	if args == nil || args.DisplayName == nil {
		return nil, errors.New("missing required argument 'DisplayName'")
	}
	if args == nil || args.Organization == nil {
		return nil, errors.New("missing required argument 'Organization'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["description"] = nil
		inputs["displayName"] = nil
		inputs["organization"] = nil
	} else {
		inputs["description"] = args.Description
		inputs["displayName"] = args.DisplayName
		inputs["organization"] = args.Organization
	}
	inputs["name"] = nil
	s, err := ctx.RegisterResource("gcp:securitycenter/source:Source", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Source{s: s}, nil
}

// GetSource gets an existing Source resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSource(ctx *pulumi.Context,
	name string, id pulumi.ID, state *SourceState, opts ...pulumi.ResourceOpt) (*Source, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["description"] = state.Description
		inputs["displayName"] = state.DisplayName
		inputs["name"] = state.Name
		inputs["organization"] = state.Organization
	}
	s, err := ctx.ReadResource("gcp:securitycenter/source:Source", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Source{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Source) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Source) ID() *pulumi.IDOutput {
	return r.s.ID()
}

func (r *Source) Description() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["description"])
}

func (r *Source) DisplayName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["displayName"])
}

func (r *Source) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

func (r *Source) Organization() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["organization"])
}

// Input properties used for looking up and filtering Source resources.
type SourceState struct {
	Description interface{}
	DisplayName interface{}
	Name interface{}
	Organization interface{}
}

// The set of arguments for constructing a Source resource.
type SourceArgs struct {
	Description interface{}
	DisplayName interface{}
	Organization interface{}
}
