// <copyright file="ResourceGroupsCONTAINERCreateSchema.cs" company="APIMatic">
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
    /// ResourceGroupsCONTAINERCreateSchema.
    /// </summary>
    public class ResourceGroupsCONTAINERCreateSchema : ResourceGroupsCreateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceGroupsCONTAINERCreateSchema"/> class.
        /// </summary>
        public ResourceGroupsCONTAINERCreateSchema()
        {
            this.ResourceType = "CONTAINER";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceGroupsCONTAINERCreateSchema"/> class.
        /// </summary>
        /// <param name="resourceName">resourceName.</param>
        /// <param name="props">props.</param>
        /// <param name="resourceType">resourceType.</param>
        /// <param name="enabled">enabled.</param>
        public ResourceGroupsCONTAINERCreateSchema(
            string resourceName,
            Models.Props12 props,
            string resourceType = "CONTAINER",
            Models.EnabledEnum? enabled = null)
            : base(
                resourceType)
        {
            this.ResourceName = resourceName;
            this.Enabled = enabled;
            this.Props = props;
        }

        /// <summary>
        /// Gets or sets ResourceName.
        /// </summary>
        [JsonProperty("resourceName")]
        public string ResourceName { get; set; }

        /// <summary>
        /// Gets or sets Enabled.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EnabledEnum? Enabled { get; set; }

        /// <summary>
        /// Gets or sets Props.
        /// </summary>
        [JsonProperty("props")]
        public Models.Props12 Props { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResourceGroupsCONTAINERCreateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is ResourceGroupsCONTAINERCreateSchema other &&
                ((this.ResourceName == null && other.ResourceName == null) || (this.ResourceName?.Equals(other.ResourceName) == true)) &&
                ((this.Enabled == null && other.Enabled == null) || (this.Enabled?.Equals(other.Enabled) == true)) &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true)) &&
                base.Equals(obj);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ResourceName = {(this.ResourceName == null ? "null" : this.ResourceName == string.Empty ? "" : this.ResourceName)}");
            toStringOutput.Add($"this.Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"this.Props = {(this.Props == null ? "null" : this.Props.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}