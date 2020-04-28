// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Composer.Inputs
{

    public sealed class EnvironmentConfigSoftwareConfigArgs : Pulumi.ResourceArgs
    {
        [Input("airflowConfigOverrides")]
        private InputMap<string>? _airflowConfigOverrides;

        /// <summary>
        /// -
        /// (Optional) Apache Airflow configuration properties to override. Property keys contain the section and property names,
        /// separated by a hyphen, for example "core-dags_are_paused_at_creation".
        /// </summary>
        public InputMap<string> AirflowConfigOverrides
        {
            get => _airflowConfigOverrides ?? (_airflowConfigOverrides = new InputMap<string>());
            set => _airflowConfigOverrides = value;
        }

        [Input("envVariables")]
        private InputMap<string>? _envVariables;

        /// <summary>
        /// Additional environment variables to provide to the Apache Airflow scheduler, worker, and webserver processes.
        /// Environment variable names must match the regular expression `[a-zA-Z_][a-zA-Z0-9_]*`.
        /// They cannot specify Apache Airflow software configuration overrides (they cannot match the regular expression
        /// `AIRFLOW__[A-Z0-9_]+__[A-Z0-9_]+`), and they cannot match any of the following reserved names:
        /// ```
        /// AIRFLOW_HOME
        /// C_FORCE_ROOT
        /// CONTAINER_NAME
        /// DAGS_FOLDER
        /// GCP_PROJECT
        /// GCS_BUCKET
        /// GKE_CLUSTER_NAME
        /// SQL_DATABASE
        /// SQL_INSTANCE
        /// SQL_PASSWORD
        /// SQL_PROJECT
        /// SQL_REGION
        /// SQL_USER
        /// ```
        /// </summary>
        public InputMap<string> EnvVariables
        {
            get => _envVariables ?? (_envVariables = new InputMap<string>());
            set => _envVariables = value;
        }

        /// <summary>
        /// -
        /// The version of the software running in the environment. This encapsulates both the version of Cloud Composer
        /// functionality and the version of Apache Airflow. It must match the regular expression
        /// `composer-[0-9]+\.[0-9]+(\.[0-9]+)?-airflow-[0-9]+\.[0-9]+(\.[0-9]+.*)?`.
        /// The Cloud Composer portion of the version is a semantic version.
        /// The portion of the image version following 'airflow-' is an official Apache Airflow repository release name.
        /// See [documentation](https://cloud.google.com/composer/docs/reference/rest/v1beta1/projects.locations.environments#softwareconfig)
        /// for allowed release names.
        /// </summary>
        [Input("imageVersion")]
        public Input<string>? ImageVersion { get; set; }

        [Input("pypiPackages")]
        private InputMap<string>? _pypiPackages;

        /// <summary>
        /// Custom Python Package Index (PyPI) packages to be installed
        /// in the environment. Keys refer to the lowercase package name (e.g. "numpy"). Values are the lowercase extras and
        /// version specifier (e.g. "==1.12.0", "[devel,gcp_api]", "[devel]&gt;=1.8.2, &lt;1.9.2"). To specify a package without
        /// pinning it to a version specifier, use the empty string as the value.
        /// </summary>
        public InputMap<string> PypiPackages
        {
            get => _pypiPackages ?? (_pypiPackages = new InputMap<string>());
            set => _pypiPackages = value;
        }

        /// <summary>
        /// -
        /// The major version of Python used to run the Apache Airflow scheduler, worker, and webserver processes.
        /// Can be set to '2' or '3'. If not specified, the default is '2'. Cannot be updated.
        /// </summary>
        [Input("pythonVersion")]
        public Input<string>? PythonVersion { get; set; }

        public EnvironmentConfigSoftwareConfigArgs()
        {
        }
    }
}
