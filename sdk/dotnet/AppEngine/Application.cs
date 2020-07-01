// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.AppEngine
{
    /// <summary>
    /// Allows creation and management of an App Engine application.
    /// 
    /// &gt; App Engine applications cannot be deleted once they're created; you have to delete the
    ///    entire project to delete the application. This provider will report the application has been
    ///    successfully deleted; this is a limitation of the provider, and will go away in the future.
    ///    This provider is not able to delete App Engine applications.
    /// 
    /// &gt; **Warning:** All arguments including `iap.oauth2_client_secret` will be stored in the raw
    /// state as plain-text. [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
    /// </summary>
    public partial class Application : Pulumi.CustomResource
    {
        /// <summary>
        /// Identifier of the app, usually `{PROJECT_ID}`
        /// </summary>
        [Output("appId")]
        public Output<string> AppId { get; private set; } = null!;

        /// <summary>
        /// The domain to authenticate users with when using App Engine's User API.
        /// </summary>
        [Output("authDomain")]
        public Output<string> AuthDomain { get; private set; } = null!;

        /// <summary>
        /// The GCS bucket code is being stored in for this app.
        /// </summary>
        [Output("codeBucket")]
        public Output<string> CodeBucket { get; private set; } = null!;

        /// <summary>
        /// The type of the Cloud Firestore or Cloud Datastore database associated with this application.
        /// </summary>
        [Output("databaseType")]
        public Output<string> DatabaseType { get; private set; } = null!;

        /// <summary>
        /// The GCS bucket content is being stored in for this app.
        /// </summary>
        [Output("defaultBucket")]
        public Output<string> DefaultBucket { get; private set; } = null!;

        /// <summary>
        /// The default hostname for this app.
        /// </summary>
        [Output("defaultHostname")]
        public Output<string> DefaultHostname { get; private set; } = null!;

        /// <summary>
        /// A block of optional settings to configure specific App Engine features:
        /// </summary>
        [Output("featureSettings")]
        public Output<Outputs.ApplicationFeatureSettings> FeatureSettings { get; private set; } = null!;

        /// <summary>
        /// The GCR domain used for storing managed Docker images for this app.
        /// </summary>
        [Output("gcrDomain")]
        public Output<string> GcrDomain { get; private set; } = null!;

        /// <summary>
        /// Settings for enabling Cloud Identity Aware Proxy
        /// </summary>
        [Output("iap")]
        public Output<Outputs.ApplicationIap?> Iap { get; private set; } = null!;

        /// <summary>
        /// The [location](https://cloud.google.com/appengine/docs/locations)
        /// to serve the app from.
        /// </summary>
        [Output("locationId")]
        public Output<string> LocationId { get; private set; } = null!;

        /// <summary>
        /// Unique name of the app, usually `apps/{PROJECT_ID}`
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The project ID to create the application under.
        /// ~&gt;**NOTE**: GCP only accepts project ID, not project number. If you are using number,
        /// you may get a "Permission denied" error.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// The serving status of the app.
        /// </summary>
        [Output("servingStatus")]
        public Output<string> ServingStatus { get; private set; } = null!;

        /// <summary>
        /// A list of dispatch rule blocks. Each block has a `domain`, `path`, and `service` field.
        /// </summary>
        [Output("urlDispatchRules")]
        public Output<ImmutableArray<Outputs.ApplicationUrlDispatchRule>> UrlDispatchRules { get; private set; } = null!;


        /// <summary>
        /// Create a Application resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Application(string name, ApplicationArgs args, CustomResourceOptions? options = null)
            : base("gcp:appengine/application:Application", name, args ?? new ApplicationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Application(string name, Input<string> id, ApplicationState? state = null, CustomResourceOptions? options = null)
            : base("gcp:appengine/application:Application", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Application resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Application Get(string name, Input<string> id, ApplicationState? state = null, CustomResourceOptions? options = null)
        {
            return new Application(name, id, state, options);
        }
    }

    public sealed class ApplicationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The domain to authenticate users with when using App Engine's User API.
        /// </summary>
        [Input("authDomain")]
        public Input<string>? AuthDomain { get; set; }

        /// <summary>
        /// The type of the Cloud Firestore or Cloud Datastore database associated with this application.
        /// </summary>
        [Input("databaseType")]
        public Input<string>? DatabaseType { get; set; }

        /// <summary>
        /// A block of optional settings to configure specific App Engine features:
        /// </summary>
        [Input("featureSettings")]
        public Input<Inputs.ApplicationFeatureSettingsArgs>? FeatureSettings { get; set; }

        /// <summary>
        /// Settings for enabling Cloud Identity Aware Proxy
        /// </summary>
        [Input("iap")]
        public Input<Inputs.ApplicationIapArgs>? Iap { get; set; }

        /// <summary>
        /// The [location](https://cloud.google.com/appengine/docs/locations)
        /// to serve the app from.
        /// </summary>
        [Input("locationId", required: true)]
        public Input<string> LocationId { get; set; } = null!;

        /// <summary>
        /// The project ID to create the application under.
        /// ~&gt;**NOTE**: GCP only accepts project ID, not project number. If you are using number,
        /// you may get a "Permission denied" error.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// The serving status of the app.
        /// </summary>
        [Input("servingStatus")]
        public Input<string>? ServingStatus { get; set; }

        public ApplicationArgs()
        {
        }
    }

    public sealed class ApplicationState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Identifier of the app, usually `{PROJECT_ID}`
        /// </summary>
        [Input("appId")]
        public Input<string>? AppId { get; set; }

        /// <summary>
        /// The domain to authenticate users with when using App Engine's User API.
        /// </summary>
        [Input("authDomain")]
        public Input<string>? AuthDomain { get; set; }

        /// <summary>
        /// The GCS bucket code is being stored in for this app.
        /// </summary>
        [Input("codeBucket")]
        public Input<string>? CodeBucket { get; set; }

        /// <summary>
        /// The type of the Cloud Firestore or Cloud Datastore database associated with this application.
        /// </summary>
        [Input("databaseType")]
        public Input<string>? DatabaseType { get; set; }

        /// <summary>
        /// The GCS bucket content is being stored in for this app.
        /// </summary>
        [Input("defaultBucket")]
        public Input<string>? DefaultBucket { get; set; }

        /// <summary>
        /// The default hostname for this app.
        /// </summary>
        [Input("defaultHostname")]
        public Input<string>? DefaultHostname { get; set; }

        /// <summary>
        /// A block of optional settings to configure specific App Engine features:
        /// </summary>
        [Input("featureSettings")]
        public Input<Inputs.ApplicationFeatureSettingsGetArgs>? FeatureSettings { get; set; }

        /// <summary>
        /// The GCR domain used for storing managed Docker images for this app.
        /// </summary>
        [Input("gcrDomain")]
        public Input<string>? GcrDomain { get; set; }

        /// <summary>
        /// Settings for enabling Cloud Identity Aware Proxy
        /// </summary>
        [Input("iap")]
        public Input<Inputs.ApplicationIapGetArgs>? Iap { get; set; }

        /// <summary>
        /// The [location](https://cloud.google.com/appengine/docs/locations)
        /// to serve the app from.
        /// </summary>
        [Input("locationId")]
        public Input<string>? LocationId { get; set; }

        /// <summary>
        /// Unique name of the app, usually `apps/{PROJECT_ID}`
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The project ID to create the application under.
        /// ~&gt;**NOTE**: GCP only accepts project ID, not project number. If you are using number,
        /// you may get a "Permission denied" error.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// The serving status of the app.
        /// </summary>
        [Input("servingStatus")]
        public Input<string>? ServingStatus { get; set; }

        [Input("urlDispatchRules")]
        private InputList<Inputs.ApplicationUrlDispatchRuleGetArgs>? _urlDispatchRules;

        /// <summary>
        /// A list of dispatch rule blocks. Each block has a `domain`, `path`, and `service` field.
        /// </summary>
        public InputList<Inputs.ApplicationUrlDispatchRuleGetArgs> UrlDispatchRules
        {
            get => _urlDispatchRules ?? (_urlDispatchRules = new InputList<Inputs.ApplicationUrlDispatchRuleGetArgs>());
            set => _urlDispatchRules = value;
        }

        public ApplicationState()
        {
        }
    }
}
