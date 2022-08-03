// <copyright file="ResourceGroupsCreateSchema.cs" company="APIMatic">
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
    /// ResourceGroupsCreateSchema.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "resourceType")]
    [JsonSubtypes.KnownSubType(typeof(ResourceGroupsAWSCreateSchema), "AWS")]
    [JsonSubtypes.KnownSubType(typeof(ResourceGroupsAZURECreateSchema), "AZURE")]
    [JsonSubtypes.KnownSubType(typeof(ResourceGroupsCONTAINERCreateSchema), "CONTAINER")]
    [JsonSubtypes.KnownSubType(typeof(ResourceGroupsGCPCreateSchema), "GCP")]
    [JsonSubtypes.KnownSubType(typeof(ResourceGroupsLWACCOUNTCreateSchema), "LW_ACCOUNT")]
    [JsonSubtypes.KnownSubType(typeof(ResourceGroupsMACHINECreateSchema), "MACHINE")]
    public class ResourceGroupsCreateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceGroupsCreateSchema"/> class.
        /// </summary>
        public ResourceGroupsCreateSchema()
        {
            this.ResourceType = "ResourceGroups_Create_Schema";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceGroupsCreateSchema"/> class.
        /// </summary>
        /// <param name="resourceType">resourceType.</param>
        public ResourceGroupsCreateSchema(
            string resourceType = "ResourceGroups_Create_Schema")
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

            return $"ResourceGroupsCreateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is ResourceGroupsCreateSchema other &&
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