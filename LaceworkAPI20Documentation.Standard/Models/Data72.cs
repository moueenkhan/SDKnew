// <copyright file="Data72.cs" company="APIMatic">
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
    /// Data72.
    /// </summary>
    public class Data72
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data72"/> class.
        /// </summary>
        public Data72()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data72"/> class.
        /// </summary>
        /// <param name="awsAccountId">awsAccountId.</param>
        /// <param name="crossAccountCredentials">crossAccountCredentials.</param>
        public Data72(
            string awsAccountId = null,
            Models.CrossAccountCredentials4 crossAccountCredentials = null)
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
        [JsonProperty("crossAccountCredentials", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CrossAccountCredentials4 CrossAccountCredentials { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data72 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data72 other &&
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