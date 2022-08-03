// <copyright file="Props21.cs" company="APIMatic">
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
    /// Props21.
    /// </summary>
    public class Props21
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Props21"/> class.
        /// </summary>
        public Props21()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Props21"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="lwAccounts">lwAccounts.</param>
        public Props21(
            string description = null,
            List<string> lwAccounts = null)
        {
            this.Description = description;
            this.LwAccounts = lwAccounts;
        }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets LwAccounts.
        /// </summary>
        [JsonProperty("lwAccounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LwAccounts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Props21 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Props21 other &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.LwAccounts == null && other.LwAccounts == null) || (this.LwAccounts?.Equals(other.LwAccounts) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.LwAccounts = {(this.LwAccounts == null ? "null" : $"[{string.Join(", ", this.LwAccounts)} ]")}");
        }
    }
}