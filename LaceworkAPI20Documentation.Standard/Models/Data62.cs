// <copyright file="Data62.cs" company="APIMatic">
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
    /// Data62.
    /// </summary>
    public class Data62
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data62"/> class.
        /// </summary>
        public Data62()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data62"/> class.
        /// </summary>
        /// <param name="crossAccountCredentials">crossAccountCredentials.</param>
        /// <param name="awsAccountId">awsAccountId.</param>
        public Data62(
            Models.CrossAccountCredentials crossAccountCredentials,
            string awsAccountId = null)
        {
            this.AwsAccountId = awsAccountId;
            this.CrossAccountCredentials = crossAccountCredentials;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data62 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data62 other &&
                ((this.AwsAccountId == null && other.AwsAccountId == null) || (this.AwsAccountId?.Equals(other.AwsAccountId) == true)) &&
                ((this.CrossAccountCredentials == null && other.CrossAccountCredentials == null) || (this.CrossAccountCredentials?.Equals(other.CrossAccountCredentials) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AwsAccountId = {(this.AwsAccountId == null ? "null" : this.AwsAccountId == string.Empty ? "" : this.AwsAccountId)}");
            toStringOutput.Add($"this.CrossAccountCredentials = {(this.CrossAccountCredentials == null ? "null" : this.CrossAccountCredentials.ToString())}");
        }
    }
}