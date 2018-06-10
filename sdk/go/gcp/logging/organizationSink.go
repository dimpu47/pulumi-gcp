// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package logging

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a organization-level logging sink. For more information see
// [the official documentation](https://cloud.google.com/logging/docs/) and
// [Exporting Logs in the API](https://cloud.google.com/logging/docs/api/tasks/exporting-logs).
// 
// Note that you must have the "Logs Configuration Writer" IAM role (`roles/logging.configWriter`)
// granted to the credentials used with terraform.
type OrganizationSink struct {
	s *pulumi.ResourceState
}

// NewOrganizationSink registers a new resource with the given unique name, arguments, and options.
func NewOrganizationSink(ctx *pulumi.Context,
	name string, args *OrganizationSinkArgs, opts ...pulumi.ResourceOpt) (*OrganizationSink, error) {
	if args == nil || args.Destination == nil {
		return nil, errors.New("missing required argument 'Destination'")
	}
	if args == nil || args.OrgId == nil {
		return nil, errors.New("missing required argument 'OrgId'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["destination"] = nil
		inputs["filter"] = nil
		inputs["includeChildren"] = nil
		inputs["name"] = nil
		inputs["orgId"] = nil
	} else {
		inputs["destination"] = args.Destination
		inputs["filter"] = args.Filter
		inputs["includeChildren"] = args.IncludeChildren
		inputs["name"] = args.Name
		inputs["orgId"] = args.OrgId
	}
	inputs["writerIdentity"] = nil
	s, err := ctx.RegisterResource("gcp:logging/organizationSink:OrganizationSink", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &OrganizationSink{s: s}, nil
}

// GetOrganizationSink gets an existing OrganizationSink resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOrganizationSink(ctx *pulumi.Context,
	name string, id pulumi.ID, state *OrganizationSinkState, opts ...pulumi.ResourceOpt) (*OrganizationSink, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["destination"] = state.Destination
		inputs["filter"] = state.Filter
		inputs["includeChildren"] = state.IncludeChildren
		inputs["name"] = state.Name
		inputs["orgId"] = state.OrgId
		inputs["writerIdentity"] = state.WriterIdentity
	}
	s, err := ctx.ReadResource("gcp:logging/organizationSink:OrganizationSink", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &OrganizationSink{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *OrganizationSink) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *OrganizationSink) ID() *pulumi.IDOutput {
	return r.s.ID
}

// The destination of the sink (or, in other words, where logs are written to). Can be a
// Cloud Storage bucket, a PubSub topic, or a BigQuery dataset. Examples:
// ```
// "storage.googleapis.com/[GCS_BUCKET]"
// "bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET]"
// "pubsub.googleapis.com/projects/[PROJECT_ID]/topics/[TOPIC_ID]"
// ```
// The writer associated with the sink must have access to write to the above resource.
func (r *OrganizationSink) Destination() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["destination"])
}

// The filter to apply when exporting logs. Only log entries that match the filter are exported.
// See [Advanced Log Filters](https://cloud.google.com/logging/docs/view/advanced_filters) for information on how to
// write a filter.
func (r *OrganizationSink) Filter() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["filter"])
}

// Whether or not to include children organizations in the sink export. If true, logs
// associated with child projects are also exported; otherwise only logs relating to the provided organization are included.
func (r *OrganizationSink) IncludeChildren() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["includeChildren"])
}

// The name of the logging sink.
func (r *OrganizationSink) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The numeric ID of the organization to be exported to the sink.
func (r *OrganizationSink) OrgId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["orgId"])
}

// The identity associated with this sink. This identity must be granted write access to the
// configured `destination`.
func (r *OrganizationSink) WriterIdentity() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["writerIdentity"])
}

// Input properties used for looking up and filtering OrganizationSink resources.
type OrganizationSinkState struct {
	// The destination of the sink (or, in other words, where logs are written to). Can be a
	// Cloud Storage bucket, a PubSub topic, or a BigQuery dataset. Examples:
	// ```
	// "storage.googleapis.com/[GCS_BUCKET]"
	// "bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET]"
	// "pubsub.googleapis.com/projects/[PROJECT_ID]/topics/[TOPIC_ID]"
	// ```
	// The writer associated with the sink must have access to write to the above resource.
	Destination interface{}
	// The filter to apply when exporting logs. Only log entries that match the filter are exported.
	// See [Advanced Log Filters](https://cloud.google.com/logging/docs/view/advanced_filters) for information on how to
	// write a filter.
	Filter interface{}
	// Whether or not to include children organizations in the sink export. If true, logs
	// associated with child projects are also exported; otherwise only logs relating to the provided organization are included.
	IncludeChildren interface{}
	// The name of the logging sink.
	Name interface{}
	// The numeric ID of the organization to be exported to the sink.
	OrgId interface{}
	// The identity associated with this sink. This identity must be granted write access to the
	// configured `destination`.
	WriterIdentity interface{}
}

// The set of arguments for constructing a OrganizationSink resource.
type OrganizationSinkArgs struct {
	// The destination of the sink (or, in other words, where logs are written to). Can be a
	// Cloud Storage bucket, a PubSub topic, or a BigQuery dataset. Examples:
	// ```
	// "storage.googleapis.com/[GCS_BUCKET]"
	// "bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET]"
	// "pubsub.googleapis.com/projects/[PROJECT_ID]/topics/[TOPIC_ID]"
	// ```
	// The writer associated with the sink must have access to write to the above resource.
	Destination interface{}
	// The filter to apply when exporting logs. Only log entries that match the filter are exported.
	// See [Advanced Log Filters](https://cloud.google.com/logging/docs/view/advanced_filters) for information on how to
	// write a filter.
	Filter interface{}
	// Whether or not to include children organizations in the sink export. If true, logs
	// associated with child projects are also exported; otherwise only logs relating to the provided organization are included.
	IncludeChildren interface{}
	// The name of the logging sink.
	Name interface{}
	// The numeric ID of the organization to be exported to the sink.
	OrgId interface{}
}
