// <copyright file="Data68.cs" company="APIMatic">
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
    /// Data68.
    /// </summary>
    public class Data68
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data68"/> class.
        /// </summary>
        public Data68()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data68"/> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="idType">idType.</param>
        /// <param name="id">id.</param>
        /// <param name="subscriptionName">subscriptionName.</param>
        public Data68(
            Models.Credentials6 credentials,
            Models.IntegrationLevelEnum idType,
            string id,
            string subscriptionName)
        {
            this.Credentials = credentials;
            this.IdType = idType;
            this.Id = id;
            this.SubscriptionName = subscriptionName;
        }

        /// <summary>
        /// Gets or sets Credentials.
        /// </summary>
        [JsonProperty("credentials")]
        public Models.Credentials6 Credentials { get; set; }

        /// <summary>
        /// Gets or sets IdType.
        /// </summary>
        [JsonProperty("idType", ItemConverterType = typeof(StringEnumConverter))]
        public Models.IntegrationLevelEnum IdType { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionName.
        /// </summary>
        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data68 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data68 other &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true)) &&
                this.IdType.Equals(other.IdType) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.SubscriptionName == null && other.SubscriptionName == null) || (this.SubscriptionName?.Equals(other.SubscriptionName) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Credentials = {(this.Credentials == null ? "null" : this.Credentials.ToString())}");
            toStringOutput.Add($"this.IdType = {this.IdType}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.SubscriptionName = {(this.SubscriptionName == null ? "null" : this.SubscriptionName == string.Empty ? "" : this.SubscriptionName)}");
        }
    }
}