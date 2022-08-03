// <copyright file="Credentials4.cs" company="APIMatic">
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
    /// Credentials4.
    /// </summary>
    public class Credentials4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Credentials4"/> class.
        /// </summary>
        public Credentials4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Credentials4"/> class.
        /// </summary>
        /// <param name="clientId">clientId.</param>
        /// <param name="clientSecret">clientSecret.</param>
        public Credentials4(
            string clientId,
            string clientSecret)
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
        }

        /// <summary>
        /// Gets or sets ClientId.
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets ClientSecret.
        /// </summary>
        [JsonProperty("clientSecret")]
        public string ClientSecret { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Credentials4 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Credentials4 other &&
                ((this.ClientId == null && other.ClientId == null) || (this.ClientId?.Equals(other.ClientId) == true)) &&
                ((this.ClientSecret == null && other.ClientSecret == null) || (this.ClientSecret?.Equals(other.ClientSecret) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClientId = {(this.ClientId == null ? "null" : this.ClientId == string.Empty ? "" : this.ClientId)}");
            toStringOutput.Add($"this.ClientSecret = {(this.ClientSecret == null ? "null" : this.ClientSecret == string.Empty ? "" : this.ClientSecret)}");
        }
    }
}