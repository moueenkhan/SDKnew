// <copyright file="Data93.cs" company="APIMatic">
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
    /// Data93.
    /// </summary>
    public class Data93
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data93"/> class.
        /// </summary>
        public Data93()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data93"/> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="idType">idType.</param>
        /// <param name="id">id.</param>
        public Data93(
            Models.Credentials3 credentials = null,
            Models.IntegrationLevelEnum? idType = null,
            string id = null)
        {
            this.Credentials = credentials;
            this.IdType = idType;
            this.Id = id;
        }

        /// <summary>
        /// Gets or sets Credentials.
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Credentials3 Credentials { get; set; }

        /// <summary>
        /// Gets or sets IdType.
        /// </summary>
        [JsonProperty("idType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.IntegrationLevelEnum? IdType { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data93 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data93 other &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true)) &&
                ((this.IdType == null && other.IdType == null) || (this.IdType?.Equals(other.IdType) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Credentials = {(this.Credentials == null ? "null" : this.Credentials.ToString())}");
            toStringOutput.Add($"this.IdType = {(this.IdType == null ? "null" : this.IdType.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
        }
    }
}