// <copyright file="CloudAccountsAwsCfgUpdateSchema.cs" company="APIMatic">
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
    /// CloudAccountsAwsCfgUpdateSchema.
    /// </summary>
    public class CloudAccountsAwsCfgUpdateSchema : CloudAccountsUpdateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudAccountsAwsCfgUpdateSchema"/> class.
        /// </summary>
        public CloudAccountsAwsCfgUpdateSchema()
        {
            this.Type = "AwsCfg";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudAccountsAwsCfgUpdateSchema"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="name">name.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="data">data.</param>
        public CloudAccountsAwsCfgUpdateSchema(
            string type = "AwsCfg",
            string name = null,
            double? enabled = null,
            Models.Data72 data = null)
            : base(
                type)
        {
            this.Name = name;
            this.Enabled = enabled;
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Enabled.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public double? Enabled { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Data72 Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CloudAccountsAwsCfgUpdateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is CloudAccountsAwsCfgUpdateSchema other &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Enabled == null && other.Enabled == null) || (this.Enabled?.Equals(other.Enabled) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                base.Equals(obj);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}