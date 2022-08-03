// <copyright file="Data60.cs" company="APIMatic">
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
    /// Data60.
    /// </summary>
    public class Data60
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data60"/> class.
        /// </summary>
        public Data60()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data60"/> class.
        /// </summary>
        /// <param name="intgUrl">intgUrl.</param>
        public Data60(
            string intgUrl = null)
        {
            this.IntgUrl = intgUrl;
        }

        /// <summary>
        /// Gets or sets IntgUrl.
        /// </summary>
        [JsonProperty("intgUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string IntgUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data60 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data60 other &&
                ((this.IntgUrl == null && other.IntgUrl == null) || (this.IntgUrl?.Equals(other.IntgUrl) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IntgUrl = {(this.IntgUrl == null ? "null" : this.IntgUrl == string.Empty ? "" : this.IntgUrl)}");
        }
    }
}