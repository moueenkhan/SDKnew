// <copyright file="Data20.cs" company="APIMatic">
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
    /// Data20.
    /// </summary>
    public class Data20
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data20"/> class.
        /// </summary>
        public Data20()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data20"/> class.
        /// </summary>
        /// <param name="webhook">webhook.</param>
        public Data20(
            string webhook = null)
        {
            this.Webhook = webhook;
        }

        /// <summary>
        /// Gets or sets Webhook.
        /// </summary>
        [JsonProperty("webhook", NullValueHandling = NullValueHandling.Ignore)]
        public string Webhook { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data20 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data20 other &&
                ((this.Webhook == null && other.Webhook == null) || (this.Webhook?.Equals(other.Webhook) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Webhook = {(this.Webhook == null ? "null" : this.Webhook == string.Empty ? "" : this.Webhook)}");
        }
    }
}