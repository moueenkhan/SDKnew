// <copyright file="TeamMembersCreateSchema.cs" company="APIMatic">
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
    /// TeamMembersCreateSchema.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "schemaOption")]
    [JsonSubtypes.KnownSubType(typeof(TeamMembersWithOrgAccessCreateSchema), "With_Org-Access")]
    [JsonSubtypes.KnownSubType(typeof(TeamMembersWithoutOrgAccessCreateSchema), "Without_Org-Access")]
    public class TeamMembersCreateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersCreateSchema"/> class.
        /// </summary>
        public TeamMembersCreateSchema()
        {
            this.SchemaOption = "TeamMembers_Create_Schema";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersCreateSchema"/> class.
        /// </summary>
        /// <param name="schemaOption">schemaOption.</param>
        public TeamMembersCreateSchema(
            string schemaOption = "TeamMembers_Create_Schema")
        {
            this.SchemaOption = schemaOption;
        }

        /// <summary>
        /// Gets or sets SchemaOption.
        /// </summary>
        [JsonProperty("schemaOption", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaOption { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TeamMembersCreateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is TeamMembersCreateSchema other &&
                ((this.SchemaOption == null && other.SchemaOption == null) || (this.SchemaOption?.Equals(other.SchemaOption) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SchemaOption = {(this.SchemaOption == null ? "null" : this.SchemaOption == string.Empty ? "" : this.SchemaOption)}");
        }
    }
}