// <copyright file="Data63.cs" company="APIMatic">
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
    /// Data63.
    /// </summary>
    public class Data63
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data63"/> class.
        /// </summary>
        public Data63()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data63"/> class.
        /// </summary>
        /// <param name="crossAccountCredentials">crossAccountCredentials.</param>
        /// <param name="queueUrl">queueUrl.</param>
        /// <param name="awsAccountId">awsAccountId.</param>
        /// <param name="accountMappingFile">accountMappingFile.</param>
        /// <param name="accountMapping">accountMapping.</param>
        public Data63(
            Models.CrossAccountCredentials crossAccountCredentials,
            string queueUrl,
            string awsAccountId = null,
            Stream accountMappingFile = null,
            object accountMapping = null)
        {
            this.AwsAccountId = awsAccountId;
            this.CrossAccountCredentials = crossAccountCredentials;
            this.QueueUrl = queueUrl;
            this.AccountMappingFile = accountMappingFile;
            this.AccountMapping = accountMapping;
        }

        /// <summary>
        /// Gets or sets AwsAccountId.
        /// </summary>
        [JsonProperty("awsAccountId", NullValueHandling = NullValueHandling.Ignore)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Gets or sets CrossAccountCredentials.
        /// </summary>
        [JsonProperty("crossAccountCredentials")]
        public Models.CrossAccountCredentials CrossAccountCredentials { get; set; }

        /// <summary>
        /// Gets or sets QueueUrl.
        /// </summary>
        [JsonProperty("queueUrl")]
        public string QueueUrl { get; set; }

        /// <summary>
        /// Gets or sets AccountMappingFile.
        /// </summary>
        [JsonProperty("accountMappingFile", NullValueHandling = NullValueHandling.Ignore)]
        public Stream AccountMappingFile { get; set; }

        /// <summary>
        /// Gets or sets AccountMapping.
        /// </summary>
        [JsonProperty("accountMapping", NullValueHandling = NullValueHandling.Ignore)]
        public object AccountMapping { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data63 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data63 other &&
                ((this.AwsAccountId == null && other.AwsAccountId == null) || (this.AwsAccountId?.Equals(other.AwsAccountId) == true)) &&
                ((this.CrossAccountCredentials == null && other.CrossAccountCredentials == null) || (this.CrossAccountCredentials?.Equals(other.CrossAccountCredentials) == true)) &&
                ((this.QueueUrl == null && other.QueueUrl == null) || (this.QueueUrl?.Equals(other.QueueUrl) == true)) &&
                ((this.AccountMappingFile == null && other.AccountMappingFile == null) || (this.AccountMappingFile?.Equals(other.AccountMappingFile) == true)) &&
                ((this.AccountMapping == null && other.AccountMapping == null) || (this.AccountMapping?.Equals(other.AccountMapping) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AwsAccountId = {(this.AwsAccountId == null ? "null" : this.AwsAccountId == string.Empty ? "" : this.AwsAccountId)}");
            toStringOutput.Add($"this.CrossAccountCredentials = {(this.CrossAccountCredentials == null ? "null" : this.CrossAccountCredentials.ToString())}");
            toStringOutput.Add($"this.QueueUrl = {(this.QueueUrl == null ? "null" : this.QueueUrl == string.Empty ? "" : this.QueueUrl)}");
            toStringOutput.Add($"this.AccountMappingFile = {(this.AccountMappingFile == null ? "null" : this.AccountMappingFile.ToString())}");
            toStringOutput.Add($"AccountMapping = {(this.AccountMapping == null ? "null" : this.AccountMapping.ToString())}");
        }
    }
}