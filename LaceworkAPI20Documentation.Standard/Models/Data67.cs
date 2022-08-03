// <copyright file="Data67.cs" company="APIMatic">
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
    /// Data67.
    /// </summary>
    public class Data67
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data67"/> class.
        /// </summary>
        public Data67()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data67"/> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="tenantId">tenantId.</param>
        public Data67(
            Models.Credentials4 credentials,
            string tenantId)
        {
            this.Credentials = credentials;
            this.TenantId = tenantId;
        }

        /// <summary>
        /// Gets or sets Credentials.
        /// </summary>
        [JsonProperty("credentials")]
        public Models.Credentials4 Credentials { get; set; }

        /// <summary>
        /// Gets or sets TenantId.
        /// </summary>
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data67 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data67 other &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true)) &&
                ((this.TenantId == null && other.TenantId == null) || (this.TenantId?.Equals(other.TenantId) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Credentials = {(this.Credentials == null ? "null" : this.Credentials.ToString())}");
            toStringOutput.Add($"this.TenantId = {(this.TenantId == null ? "null" : this.TenantId == string.Empty ? "" : this.TenantId)}");
        }
    }
}