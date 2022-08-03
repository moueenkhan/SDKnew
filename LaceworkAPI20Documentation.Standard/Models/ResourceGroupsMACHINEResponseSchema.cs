// <copyright file="ResourceGroupsMACHINEResponseSchema.cs" company="APIMatic">
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
    /// ResourceGroupsMACHINEResponseSchema.
    /// </summary>
    public class ResourceGroupsMACHINEResponseSchema : ResourceGroupsResponseSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceGroupsMACHINEResponseSchema"/> class.
        /// </summary>
        public ResourceGroupsMACHINEResponseSchema()
        {
            this.ResourceType = "MACHINE";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceGroupsMACHINEResponseSchema"/> class.
        /// </summary>
        /// <param name="resourceName">resourceName.</param>
        /// <param name="props">props.</param>
        /// <param name="resourceType">resourceType.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="resourceGuid">resourceGuid.</param>
        /// <param name="guid">guid.</param>
        /// <param name="isDefault">isDefault.</param>
        public ResourceGroupsMACHINEResponseSchema(
            string resourceName,
            Models.Props16 props,
            string resourceType = "MACHINE",
            Models.EnabledEnum? enabled = null,
            string resourceGuid = null,
            string guid = null,
            double? isDefault = null)
            : base(
                resourceType)
        {
            this.ResourceName = resourceName;
            this.Enabled = enabled;
            this.Props = props;
            this.ResourceGuid = resourceGuid;
            this.Guid = guid;
            this.IsDefault = isDefault;
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
        public Models.Props16 Props { get; set; }

        /// <summary>
        /// Gets or sets ResourceGuid.
        /// </summary>
        [JsonProperty("resourceGuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets or sets Guid.
        /// </summary>
        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or sets IsDefault.
        /// </summary>
        [JsonProperty("isDefault", NullValueHandling = NullValueHandling.Ignore)]
        public double? IsDefault { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResourceGroupsMACHINEResponseSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is ResourceGroupsMACHINEResponseSchema other &&
                ((this.ResourceName == null && other.ResourceName == null) || (this.ResourceName?.Equals(other.ResourceName) == true)) &&
                ((this.Enabled == null && other.Enabled == null) || (this.Enabled?.Equals(other.Enabled) == true)) &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true)) &&
                ((this.ResourceGuid == null && other.ResourceGuid == null) || (this.ResourceGuid?.Equals(other.ResourceGuid) == true)) &&
                ((this.Guid == null && other.Guid == null) || (this.Guid?.Equals(other.Guid) == true)) &&
                ((this.IsDefault == null && other.IsDefault == null) || (this.IsDefault?.Equals(other.IsDefault) == true)) &&
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
            toStringOutput.Add($"this.ResourceGuid = {(this.ResourceGuid == null ? "null" : this.ResourceGuid == string.Empty ? "" : this.ResourceGuid)}");
            toStringOutput.Add($"this.Guid = {(this.Guid == null ? "null" : this.Guid == string.Empty ? "" : this.Guid)}");
            toStringOutput.Add($"this.IsDefault = {(this.IsDefault == null ? "null" : this.IsDefault.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}