// <copyright file="AlertChannelsGcpPubsubCreateSchema.cs" company="APIMatic">
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
    /// AlertChannelsGcpPubsubCreateSchema.
    /// </summary>
    public class AlertChannelsGcpPubsubCreateSchema : AlertChannelsCreateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertChannelsGcpPubsubCreateSchema"/> class.
        /// </summary>
        public AlertChannelsGcpPubsubCreateSchema()
        {
            this.Type = "GcpPubsub";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertChannelsGcpPubsubCreateSchema"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="data">data.</param>
        /// <param name="type">type.</param>
        public AlertChannelsGcpPubsubCreateSchema(
            string name,
            double enabled,
            Models.Data5 data,
            string type = "GcpPubsub")
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
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public double Enabled { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public Models.Data5 Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AlertChannelsGcpPubsubCreateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is AlertChannelsGcpPubsubCreateSchema other &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                this.Enabled.Equals(other.Enabled) &&
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
            toStringOutput.Add($"this.Enabled = {this.Enabled}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}