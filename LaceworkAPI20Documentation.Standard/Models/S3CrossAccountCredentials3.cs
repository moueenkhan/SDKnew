// <copyright file="S3CrossAccountCredentials3.cs" company="APIMatic">
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
    /// S3CrossAccountCredentials3.
    /// </summary>
    public class S3CrossAccountCredentials3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3CrossAccountCredentials3"/> class.
        /// </summary>
        public S3CrossAccountCredentials3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="S3CrossAccountCredentials3"/> class.
        /// </summary>
        /// <param name="externalId">externalId.</param>
        /// <param name="roleArn">roleArn.</param>
        /// <param name="bucketArn">bucketArn.</param>
        public S3CrossAccountCredentials3(
            string externalId = null,
            string roleArn = null,
            string bucketArn = null)
        {
            this.ExternalId = externalId;
            this.RoleArn = roleArn;
            this.BucketArn = bucketArn;
        }

        /// <summary>
        /// Gets or sets ExternalId.
        /// </summary>
        [JsonProperty("externalId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or sets RoleArn.
        /// </summary>
        [JsonProperty("roleArn", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Gets or sets BucketArn.
        /// </summary>
        [JsonProperty("bucketArn", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketArn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"S3CrossAccountCredentials3 : ({string.Join(", ", toStringOutput)})";
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

            return obj is S3CrossAccountCredentials3 other &&
                ((this.ExternalId == null && other.ExternalId == null) || (this.ExternalId?.Equals(other.ExternalId) == true)) &&
                ((this.RoleArn == null && other.RoleArn == null) || (this.RoleArn?.Equals(other.RoleArn) == true)) &&
                ((this.BucketArn == null && other.BucketArn == null) || (this.BucketArn?.Equals(other.BucketArn) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExternalId = {(this.ExternalId == null ? "null" : this.ExternalId == string.Empty ? "" : this.ExternalId)}");
            toStringOutput.Add($"this.RoleArn = {(this.RoleArn == null ? "null" : this.RoleArn == string.Empty ? "" : this.RoleArn)}");
            toStringOutput.Add($"this.BucketArn = {(this.BucketArn == null ? "null" : this.BucketArn == string.Empty ? "" : this.BucketArn)}");
        }
    }
}