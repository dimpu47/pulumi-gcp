// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.BigQuery.Outputs
{

    [OutputType]
    public sealed class JobLoad
    {
        /// <summary>
        /// Accept rows that are missing trailing optional columns. The missing values are treated as nulls.
        /// If false, records with missing trailing columns are treated as bad records, and if there are too many bad records,
        /// an invalid error is returned in the job result. The default value is false. Only applicable to CSV, ignored for other formats.
        /// </summary>
        public readonly bool? AllowJaggedRows;
        /// <summary>
        /// Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file.
        /// The default value is false.
        /// </summary>
        public readonly bool? AllowQuotedNewlines;
        /// <summary>
        /// Indicates if we should automatically infer the options and schema for CSV and JSON sources.
        /// </summary>
        public readonly bool? Autodetect;
        /// <summary>
        /// Specifies whether the job is allowed to create new tables. The following values are supported:
        /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
        /// CREATE_NEVER: The table must already exist. If it does not, a 'notFound' error is returned in the job result.
        /// The default value is CREATE_IF_NEEDED. Creation, truncation and append actions occur as one atomic update upon job completion
        /// </summary>
        public readonly string? CreateDisposition;
        /// <summary>
        /// Custom encryption configuration (e.g., Cloud KMS keys)  Structure is documented below.
        /// </summary>
        public readonly Outputs.JobLoadDestinationEncryptionConfiguration? DestinationEncryptionConfiguration;
        /// <summary>
        /// The destination table.  Structure is documented below.
        /// </summary>
        public readonly Outputs.JobLoadDestinationTable DestinationTable;
        /// <summary>
        /// The character encoding of the data. The supported values are UTF-8 or ISO-8859-1.
        /// The default value is UTF-8. BigQuery decodes the data after the raw, binary data
        /// has been split using the values of the quote and fieldDelimiter properties.
        /// </summary>
        public readonly string? Encoding;
        /// <summary>
        /// When extracting data in CSV format, this defines the delimiter to use between fields in the exported data.
        /// Default is ','
        /// </summary>
        public readonly string? FieldDelimiter;
        /// <summary>
        /// Indicates if BigQuery should allow extra values that are not represented in the table schema.
        /// If true, the extra values are ignored. If false, records with extra columns are treated as bad records,
        /// and if there are too many bad records, an invalid error is returned in the job result.
        /// The default value is false. The sourceFormat property determines what BigQuery treats as an extra value:
        /// CSV: Trailing columns
        /// JSON: Named values that don't match any column names
        /// </summary>
        public readonly bool? IgnoreUnknownValues;
        /// <summary>
        /// The maximum number of bad records that BigQuery can ignore when running the job. If the number of bad records exceeds this value,
        /// an invalid error is returned in the job result. The default value is 0, which requires that all records are valid.
        /// </summary>
        public readonly int? MaxBadRecords;
        /// <summary>
        /// Specifies a string that represents a null value in a CSV file. The default value is the empty string. If you set this
        /// property to a custom value, BigQuery throws an error if an
        /// empty string is present for all data types except for STRING and BYTE. For STRING and BYTE columns, BigQuery interprets the empty string as
        /// an empty value.
        /// </summary>
        public readonly string? NullMarker;
        /// <summary>
        /// If sourceFormat is set to "DATASTORE_BACKUP", indicates which entity properties to load into BigQuery from a Cloud Datastore backup.
        /// Property names are case sensitive and must be top-level properties. If no properties are specified, BigQuery loads all properties.
        /// If any named property isn't found in the Cloud Datastore backup, an invalid error is returned in the job result.
        /// </summary>
        public readonly ImmutableArray<string> ProjectionFields;
        /// <summary>
        /// The value that is used to quote data sections in a CSV file. BigQuery converts the string to ISO-8859-1 encoding,
        /// and then uses the first byte of the encoded string to split the data in its raw, binary state.
        /// The default value is a double-quote ('"'). If your data does not contain quoted sections, set the property value to an empty string.
        /// If your data contains quoted newline characters, you must also set the allowQuotedNewlines property to true.
        /// </summary>
        public readonly string? Quote;
        /// <summary>
        /// Allows the schema of the destination table to be updated as a side effect of the load job if a schema is autodetected or
        /// supplied in the job configuration. Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND;
        /// when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators.
        /// For normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are specified:
        /// ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema.
        /// ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.
        /// </summary>
        public readonly ImmutableArray<string> SchemaUpdateOptions;
        /// <summary>
        /// The number of rows at the top of a CSV file that BigQuery will skip when loading the data.
        /// The default value is 0. This property is useful if you have header rows in the file that should be skipped.
        /// When autodetect is on, the behavior is the following:
        /// skipLeadingRows unspecified - Autodetect tries to detect headers in the first row. If they are not detected,
        /// the row is read as data. Otherwise data is read starting from the second row.
        /// skipLeadingRows is 0 - Instructs autodetect that there are no headers and data should be read starting from the first row.
        /// skipLeadingRows = N &gt; 0 - Autodetect skips N-1 rows and tries to detect headers in row N. If headers are not detected,
        /// row N is just skipped. Otherwise row N is used to extract column names for the detected schema.
        /// </summary>
        public readonly int? SkipLeadingRows;
        /// <summary>
        /// The format of the data files. For CSV files, specify "CSV". For datastore backups, specify "DATASTORE_BACKUP".
        /// For newline-delimited JSON, specify "NEWLINE_DELIMITED_JSON". For Avro, specify "AVRO". For parquet, specify "PARQUET".
        /// For orc, specify "ORC". The default value is CSV.
        /// </summary>
        public readonly string? SourceFormat;
        /// <summary>
        /// The fully-qualified URIs that point to your data in Google Cloud.
        /// For Google Cloud Storage URIs: Each URI can contain one '*' wildcard character
        /// and it must come after the 'bucket' name. Size limits related to load jobs apply
        /// to external data sources. For Google Cloud Bigtable URIs: Exactly one URI can be
        /// specified and it has be a fully specified and valid HTTPS URL for a Google Cloud Bigtable table.
        /// For Google Cloud Datastore backups: Exactly one URI can be specified. Also, the '*' wildcard character is not allowed.
        /// </summary>
        public readonly ImmutableArray<string> SourceUris;
        /// <summary>
        /// Time-based partitioning specification for the destination table.  Structure is documented below.
        /// </summary>
        public readonly Outputs.JobLoadTimePartitioning? TimePartitioning;
        /// <summary>
        /// Specifies the action that occurs if the destination table already exists. The following values are supported:
        /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
        /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
        /// WRITE_EMPTY: If the table already exists and contains data, a 'duplicate' error is returned in the job result.
        /// The default value is WRITE_EMPTY. Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
        /// Creation, truncation and append actions occur as one atomic update upon job completion.
        /// </summary>
        public readonly string? WriteDisposition;

        [OutputConstructor]
        private JobLoad(
            bool? allowJaggedRows,

            bool? allowQuotedNewlines,

            bool? autodetect,

            string? createDisposition,

            Outputs.JobLoadDestinationEncryptionConfiguration? destinationEncryptionConfiguration,

            Outputs.JobLoadDestinationTable destinationTable,

            string? encoding,

            string? fieldDelimiter,

            bool? ignoreUnknownValues,

            int? maxBadRecords,

            string? nullMarker,

            ImmutableArray<string> projectionFields,

            string? quote,

            ImmutableArray<string> schemaUpdateOptions,

            int? skipLeadingRows,

            string? sourceFormat,

            ImmutableArray<string> sourceUris,

            Outputs.JobLoadTimePartitioning? timePartitioning,

            string? writeDisposition)
        {
            AllowJaggedRows = allowJaggedRows;
            AllowQuotedNewlines = allowQuotedNewlines;
            Autodetect = autodetect;
            CreateDisposition = createDisposition;
            DestinationEncryptionConfiguration = destinationEncryptionConfiguration;
            DestinationTable = destinationTable;
            Encoding = encoding;
            FieldDelimiter = fieldDelimiter;
            IgnoreUnknownValues = ignoreUnknownValues;
            MaxBadRecords = maxBadRecords;
            NullMarker = nullMarker;
            ProjectionFields = projectionFields;
            Quote = quote;
            SchemaUpdateOptions = schemaUpdateOptions;
            SkipLeadingRows = skipLeadingRows;
            SourceFormat = sourceFormat;
            SourceUris = sourceUris;
            TimePartitioning = timePartitioning;
            WriteDisposition = writeDisposition;
        }
    }
}
