// <copyright file="Data49.cs" company="APIMatic">
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
    /// Data49.
    /// </summary>
    public class Data49
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data49"/> class.
        /// </summary>
        public Data49()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data49"/> class.
        /// </summary>
        /// <param name="insertKey">insertKey.</param>
        /// <param name="accountId">accountId.</param>
        public Data49(
            string insertKey = null,
            double? accountId = null)
        {
            this.InsertKey = insertKey;
            this.AccountId = accountId;
        }

        /// <summary>
        /// Gets or sets InsertKey.
        /// </summary>
        [JsonProperty("insertKey", NullValueHandling = NullValueHandling.Ignore)]
        public string InsertKey { get; set; }

        /// <summary>
        /// Gets or sets AccountId.
        /// </summary>
        [JsonProperty("accountId", NullValueHandling = NullValueHandling.Ignore)]
        public double? AccountId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data49 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data49 other &&
                ((this.InsertKey == null && other.InsertKey == null) || (this.InsertKey?.Equals(other.InsertKey) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InsertKey = {(this.InsertKey == null ? "null" : this.InsertKey == string.Empty ? "" : this.InsertKey)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
        }
    }
}