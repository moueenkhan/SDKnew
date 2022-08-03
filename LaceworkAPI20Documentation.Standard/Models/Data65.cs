// <copyright file="Data65.cs" company="APIMatic">
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
    /// Data65.
    /// </summary>
    public class Data65
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data65"/> class.
        /// </summary>
        public Data65()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data65"/> class.
        /// </summary>
        /// <param name="accessKeyCredentials">accessKeyCredentials.</param>
        /// <param name="queueUrl">queueUrl.</param>
        public Data65(
            Models.AccessKeyCredentials accessKeyCredentials,
            string queueUrl)
        {
            this.AccessKeyCredentials = accessKeyCredentials;
            this.QueueUrl = queueUrl;
        }

        /// <summary>
        /// Gets or sets AccessKeyCredentials.
        /// </summary>
        [JsonProperty("accessKeyCredentials")]
        public Models.AccessKeyCredentials AccessKeyCredentials { get; set; }

        /// <summary>
        /// Gets or sets QueueUrl.
        /// </summary>
        [JsonProperty("queueUrl")]
        public string QueueUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data65 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data65 other &&
                ((this.AccessKeyCredentials == null && other.AccessKeyCredentials == null) || (this.AccessKeyCredentials?.Equals(other.AccessKeyCredentials) == true)) &&
                ((this.QueueUrl == null && other.QueueUrl == null) || (this.QueueUrl?.Equals(other.QueueUrl) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccessKeyCredentials = {(this.AccessKeyCredentials == null ? "null" : this.AccessKeyCredentials.ToString())}");
            toStringOutput.Add($"this.QueueUrl = {(this.QueueUrl == null ? "null" : this.QueueUrl == string.Empty ? "" : this.QueueUrl)}");
        }
    }
}