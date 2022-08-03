// <copyright file="Props11.cs" company="APIMatic">
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
    /// Props11.
    /// </summary>
    public class Props11
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Props11"/> class.
        /// </summary>
        public Props11()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Props11"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="tenant">tenant.</param>
        /// <param name="subscriptions">subscriptions.</param>
        public Props11(
            string description = null,
            string tenant = null,
            List<string> subscriptions = null)
        {
            this.Description = description;
            this.Tenant = tenant;
            this.Subscriptions = subscriptions;
        }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Tenant.
        /// </summary>
        [JsonProperty("tenant", NullValueHandling = NullValueHandling.Ignore)]
        public string Tenant { get; set; }

        /// <summary>
        /// Gets or sets Subscriptions.
        /// </summary>
        [JsonProperty("subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Subscriptions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Props11 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Props11 other &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Tenant == null && other.Tenant == null) || (this.Tenant?.Equals(other.Tenant) == true)) &&
                ((this.Subscriptions == null && other.Subscriptions == null) || (this.Subscriptions?.Equals(other.Subscriptions) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Tenant = {(this.Tenant == null ? "null" : this.Tenant == string.Empty ? "" : this.Tenant)}");
            toStringOutput.Add($"this.Subscriptions = {(this.Subscriptions == null ? "null" : $"[{string.Join(", ", this.Subscriptions)} ]")}");
        }
    }
}