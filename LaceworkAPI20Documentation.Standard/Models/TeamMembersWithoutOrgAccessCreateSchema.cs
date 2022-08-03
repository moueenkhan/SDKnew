// <copyright file="TeamMembersWithoutOrgAccessCreateSchema.cs" company="APIMatic">
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
    /// TeamMembersWithoutOrgAccessCreateSchema.
    /// </summary>
    public class TeamMembersWithoutOrgAccessCreateSchema : TeamMembersCreateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersWithoutOrgAccessCreateSchema"/> class.
        /// </summary>
        public TeamMembersWithoutOrgAccessCreateSchema()
        {
            this.SchemaOption = "Without_Org-Access";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersWithoutOrgAccessCreateSchema"/> class.
        /// </summary>
        /// <param name="props">props.</param>
        /// <param name="userEnabled">userEnabled.</param>
        /// <param name="userName">userName.</param>
        /// <param name="schemaOption">schemaOption.</param>
        public TeamMembersWithoutOrgAccessCreateSchema(
            Models.Props24 props,
            Models.UserEnabledEnum userEnabled,
            string userName,
            string schemaOption = "Without_Org-Access")
            : base(
                schemaOption)
        {
            this.Props = props;
            this.UserEnabled = userEnabled;
            this.UserName = userName;
        }

        /// <summary>
        /// Gets or sets Props.
        /// </summary>
        [JsonProperty("props")]
        public Models.Props24 Props { get; set; }

        /// <summary>
        /// Gets or sets UserEnabled.
        /// </summary>
        [JsonProperty("userEnabled")]
        public Models.UserEnabledEnum UserEnabled { get; set; }

        /// <summary>
        /// user email address
        /// </summary>
        [JsonProperty("userName")]
        public string UserName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TeamMembersWithoutOrgAccessCreateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is TeamMembersWithoutOrgAccessCreateSchema other &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true)) &&
                this.UserEnabled.Equals(other.UserEnabled) &&
                ((this.UserName == null && other.UserName == null) || (this.UserName?.Equals(other.UserName) == true)) &&
                base.Equals(obj);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Props = {(this.Props == null ? "null" : this.Props.ToString())}");
            toStringOutput.Add($"this.UserEnabled = {this.UserEnabled}");
            toStringOutput.Add($"this.UserName = {(this.UserName == null ? "null" : this.UserName == string.Empty ? "" : this.UserName)}");

            base.ToString(toStringOutput);
        }
    }
}