// <copyright file="AccessKeyCredentials10.cs" company="APIMatic">
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
    /// AccessKeyCredentials10.
    /// </summary>
    public class AccessKeyCredentials10
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessKeyCredentials10"/> class.
        /// </summary>
        public AccessKeyCredentials10()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessKeyCredentials10"/> class.
        /// </summary>
        /// <param name="accessKeyId">accessKeyId.</param>
        /// <param name="secretAccessKey">secretAccessKey.</param>
        public AccessKeyCredentials10(
            string accessKeyId = null,
            string secretAccessKey = null)
        {
            this.AccessKeyId = accessKeyId;
            this.SecretAccessKey = secretAccessKey;
        }

        /// <summary>
        /// Gets or sets AccessKeyId.
        /// </summary>
        [JsonProperty("accessKeyId", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Gets or sets SecretAccessKey.
        /// </summary>
        [JsonProperty("secretAccessKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretAccessKey { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccessKeyCredentials10 : ({string.Join(", ", toStringOutput)})";
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

            return obj is AccessKeyCredentials10 other &&
                ((this.AccessKeyId == null && other.AccessKeyId == null) || (this.AccessKeyId?.Equals(other.AccessKeyId) == true)) &&
                ((this.SecretAccessKey == null && other.SecretAccessKey == null) || (this.SecretAccessKey?.Equals(other.SecretAccessKey) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccessKeyId = {(this.AccessKeyId == null ? "null" : this.AccessKeyId == string.Empty ? "" : this.AccessKeyId)}");
            toStringOutput.Add($"this.SecretAccessKey = {(this.SecretAccessKey == null ? "null" : this.SecretAccessKey == string.Empty ? "" : this.SecretAccessKey)}");
        }
    }
}