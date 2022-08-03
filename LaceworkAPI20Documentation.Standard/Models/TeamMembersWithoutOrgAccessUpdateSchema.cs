// <copyright file="TeamMembersWithoutOrgAccessUpdateSchema.cs" company="APIMatic">
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
    /// TeamMembersWithoutOrgAccessUpdateSchema.
    /// </summary>
    public class TeamMembersWithoutOrgAccessUpdateSchema : TeamMembersUpdateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersWithoutOrgAccessUpdateSchema"/> class.
        /// </summary>
        public TeamMembersWithoutOrgAccessUpdateSchema()
        {
            this.SchemaOption = "Without_Org-Access";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersWithoutOrgAccessUpdateSchema"/> class.
        /// </summary>
        /// <param name="schemaOption">schemaOption.</param>
        /// <param name="props">props.</param>
        /// <param name="userEnabled">userEnabled.</param>
        public TeamMembersWithoutOrgAccessUpdateSchema(
            string schemaOption = "Without_Org-Access",
            Models.Props30 props = null,
            Models.UserEnabledEnum? userEnabled = null)
            : base(
                schemaOption)
        {
            this.Props = props;
            this.UserEnabled = userEnabled;
        }

        /// <summary>
        /// Gets or sets Props.
        /// </summary>
        [JsonProperty("props", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Props30 Props { get; set; }

        /// <summary>
        /// Gets or sets UserEnabled.
        /// </summary>
        [JsonProperty("userEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UserEnabledEnum? UserEnabled { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TeamMembersWithoutOrgAccessUpdateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is TeamMembersWithoutOrgAccessUpdateSchema other &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true)) &&
                ((this.UserEnabled == null && other.UserEnabled == null) || (this.UserEnabled?.Equals(other.UserEnabled) == true)) &&
                base.Equals(obj);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Props = {(this.Props == null ? "null" : this.Props.ToString())}");
            toStringOutput.Add($"this.UserEnabled = {(this.UserEnabled == null ? "null" : this.UserEnabled.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}