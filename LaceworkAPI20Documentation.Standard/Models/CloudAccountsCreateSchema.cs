// <copyright file="CloudAccountsCreateSchema.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace LaceworkAPI20Documentation.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using LaceworkAPI20Documentation.Standard;
    using LaceworkAPI20Documentation.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CloudAccountsCreateSchema.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAwsCfgCreateSchema), "AwsCfg")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAwsCtSqsCreateSchema), "AwsCtSqs")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAwsUsGovCfgCreateSchema), "AwsUsGovCfg")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAwsUsGovCtSqsCreateSchema), "AwsUsGovCtSqs")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAzureAlSeqCreateSchema), "AzureAlSeq")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAzureCfgCreateSchema), "AzureCfg")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsGcpAtSesCreateSchema), "GcpAtSes")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsGcpCfgCreateSchema), "GcpCfg")]
    public class CloudAccountsCreateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudAccountsCreateSchema"/> class.
        /// </summary>
        public CloudAccountsCreateSchema()
        {
            this.Type = "CloudAccounts_Create_Schema";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudAccountsCreateSchema"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        public CloudAccountsCreateSchema(
            string type = "CloudAccounts_Create_Schema")
        {
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CloudAccountsCreateSchema : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is CloudAccountsCreateSchema other &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
        }
    }
}