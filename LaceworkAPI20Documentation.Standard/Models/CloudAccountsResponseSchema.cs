// <copyright file="CloudAccountsResponseSchema.cs" company="APIMatic">
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
    /// CloudAccountsResponseSchema.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAwsCfgResponseSchema), "AwsCfg")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAwsCtSqsResponseSchema), "AwsCtSqs")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAwsUsGovCfgResponseSchema), "AwsUsGovCfg")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAwsUsGovCtSqsResponseSchema), "AwsUsGovCtSqs")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAzureAlSeqResponseSchema), "AzureAlSeq")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAzureCfgResponseSchema), "AzureCfg")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsGcpAtSesResponseSchema), "GcpAtSes")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsGcpCfgResponseSchema), "GcpCfg")]
    public class CloudAccountsResponseSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudAccountsResponseSchema"/> class.
        /// </summary>
        public CloudAccountsResponseSchema()
        {
            this.Type = "CloudAccounts_Response_Schema";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudAccountsResponseSchema"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        public CloudAccountsResponseSchema(
            string type = "CloudAccounts_Response_Schema")
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

            return $"CloudAccountsResponseSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is CloudAccountsResponseSchema other &&
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