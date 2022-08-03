// <copyright file="CloudAccountsUpdateSchema.cs" company="APIMatic">
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
    /// CloudAccountsUpdateSchema.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAwsCfgUpdateSchema), "AwsCfg")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAwsCtSqsUpdateSchema), "AwsCtSqs")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAwsUsGovCfgUpdateSchema), "AwsUsGovCfg")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAwsUsGovCtSqsUpdateSchema), "AwsUsGovCtSqs")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAzureAlSeqUpdateSchema), "AzureAlSeq")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsAzureCfgUpdateSchema), "AzureCfg")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsGcpAtSesUpdateSchema), "GcpAtSes")]
    [JsonSubtypes.KnownSubType(typeof(CloudAccountsGcpCfgUpdateSchema), "GcpCfg")]
    public class CloudAccountsUpdateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudAccountsUpdateSchema"/> class.
        /// </summary>
        public CloudAccountsUpdateSchema()
        {
            this.Type = "CloudAccounts_Update_Schema";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudAccountsUpdateSchema"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        public CloudAccountsUpdateSchema(
            string type = "CloudAccounts_Update_Schema")
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

            return $"CloudAccountsUpdateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is CloudAccountsUpdateSchema other &&
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