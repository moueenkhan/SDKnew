// <copyright file="Data38.cs" company="APIMatic">
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
    /// Data38.
    /// </summary>
    public class Data38
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data38"/> class.
        /// </summary>
        public Data38()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data38"/> class.
        /// </summary>
        /// <param name="datadogType">datadogType.</param>
        /// <param name="datadogSite">datadogSite.</param>
        /// <param name="apiKey">apiKey.</param>
        public Data38(
            Models.DatadogServiceEnum? datadogType = Models.DatadogServiceEnum.EnumLogsDetail,
            Models.DatadogSiteEnum? datadogSite = Models.DatadogSiteEnum.Com,
            string apiKey = null)
        {
            this.DatadogType = datadogType;
            this.DatadogSite = datadogSite;
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Gets or sets DatadogType.
        /// </summary>
        [JsonProperty("datadogType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.DatadogServiceEnum? DatadogType { get; set; }

        /// <summary>
        /// Gets or sets DatadogSite.
        /// </summary>
        [JsonProperty("datadogSite", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.DatadogSiteEnum? DatadogSite { get; set; }

        /// <summary>
        /// Gets or sets ApiKey.
        /// </summary>
        [JsonProperty("apiKey", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiKey { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data38 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data38 other &&
                ((this.DatadogType == null && other.DatadogType == null) || (this.DatadogType?.Equals(other.DatadogType) == true)) &&
                ((this.DatadogSite == null && other.DatadogSite == null) || (this.DatadogSite?.Equals(other.DatadogSite) == true)) &&
                ((this.ApiKey == null && other.ApiKey == null) || (this.ApiKey?.Equals(other.ApiKey) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DatadogType = {(this.DatadogType == null ? "null" : this.DatadogType.ToString())}");
            toStringOutput.Add($"this.DatadogSite = {(this.DatadogSite == null ? "null" : this.DatadogSite.ToString())}");
            toStringOutput.Add($"this.ApiKey = {(this.ApiKey == null ? "null" : this.ApiKey == string.Empty ? "" : this.ApiKey)}");
        }
    }
}