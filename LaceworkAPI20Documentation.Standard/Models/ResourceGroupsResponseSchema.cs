// <copyright file="ResourceGroupsResponseSchema.cs" company="APIMatic">
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
    /// ResourceGroupsResponseSchema.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "resourceType")]
    [JsonSubtypes.KnownSubType(typeof(ResourceGroupsAWSResponseSchema), "AWS")]
    [JsonSubtypes.KnownSubType(typeof(ResourceGroupsAZUREResponseSchema), "AZURE")]
    [JsonSubtypes.KnownSubType(typeof(ResourceGroupsCONTAINERResponseSchema), "CONTAINER")]
    [JsonSubtypes.KnownSubType(typeof(ResourceGroupsGCPResponseSchema), "GCP")]
    [JsonSubtypes.KnownSubType(typeof(ResourceGroupsLWACCOUNTResponseSchema), "LW_ACCOUNT")]
    [JsonSubtypes.KnownSubType(typeof(ResourceGroupsMACHINEResponseSchema), "MACHINE")]
    public class ResourceGroupsResponseSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceGroupsResponseSchema"/> class.
        /// </summary>
        public ResourceGroupsResponseSchema()
        {
            this.ResourceType = "ResourceGroups_Response_Schema";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceGroupsResponseSchema"/> class.
        /// </summary>
        /// <param name="resourceType">resourceType.</param>
        public ResourceGroupsResponseSchema(
            string resourceType = "ResourceGroups_Response_Schema")
        {
            this.ResourceType = resourceType;
        }

        /// <summary>
        /// Gets or sets ResourceType.
        /// </summary>
        [JsonProperty("resourceType", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResourceGroupsResponseSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is ResourceGroupsResponseSchema other &&
                ((this.ResourceType == null && other.ResourceType == null) || (this.ResourceType?.Equals(other.ResourceType) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ResourceType = {(this.ResourceType == null ? "null" : this.ResourceType == string.Empty ? "" : this.ResourceType)}");
        }
    }
}