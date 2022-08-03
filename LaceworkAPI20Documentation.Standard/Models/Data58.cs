// <copyright file="Data58.cs" company="APIMatic">
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
    /// Data58.
    /// </summary>
    public class Data58
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data58"/> class.
        /// </summary>
        public Data58()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data58"/> class.
        /// </summary>
        /// <param name="slackUrl">slackUrl.</param>
        public Data58(
            string slackUrl = null)
        {
            this.SlackUrl = slackUrl;
        }

        /// <summary>
        /// Gets or sets SlackUrl.
        /// </summary>
        [JsonProperty("slackUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string SlackUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data58 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data58 other &&
                ((this.SlackUrl == null && other.SlackUrl == null) || (this.SlackUrl?.Equals(other.SlackUrl) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SlackUrl = {(this.SlackUrl == null ? "null" : this.SlackUrl == string.Empty ? "" : this.SlackUrl)}");
        }
    }
}