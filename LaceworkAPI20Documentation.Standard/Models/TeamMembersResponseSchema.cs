// <copyright file="TeamMembersResponseSchema.cs" company="APIMatic">
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
    /// TeamMembersResponseSchema.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "schemaOption")]
    [JsonSubtypes.KnownSubType(typeof(TeamMembersWithOrgAccessResponseSchema), "With_Org-Access")]
    [JsonSubtypes.KnownSubType(typeof(TeamMembersWithoutOrgAccessResponseSchema), "Without_Org-Access")]
    public class TeamMembersResponseSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersResponseSchema"/> class.
        /// </summary>
        public TeamMembersResponseSchema()
        {
            this.SchemaOption = "TeamMembers_Response_Schema";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersResponseSchema"/> class.
        /// </summary>
        /// <param name="schemaOption">schemaOption.</param>
        public TeamMembersResponseSchema(
            string schemaOption = "TeamMembers_Response_Schema")
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

            return $"TeamMembersResponseSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is TeamMembersResponseSchema other &&
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