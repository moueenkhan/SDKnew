// <copyright file="Data61.cs" company="APIMatic">
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
    /// Data61.
    /// </summary>
    public class Data61
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data61"/> class.
        /// </summary>
        public Data61()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data61"/> class.
        /// </summary>
        /// <param name="webhookUrl">webhookUrl.</param>
        public Data61(
            string webhookUrl = null)
        {
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Gets or sets WebhookUrl.
        /// </summary>
        [JsonProperty("webhookUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string WebhookUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data61 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data61 other &&
                ((this.WebhookUrl == null && other.WebhookUrl == null) || (this.WebhookUrl?.Equals(other.WebhookUrl) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.WebhookUrl = {(this.WebhookUrl == null ? "null" : this.WebhookUrl == string.Empty ? "" : this.WebhookUrl)}");
        }
    }
}