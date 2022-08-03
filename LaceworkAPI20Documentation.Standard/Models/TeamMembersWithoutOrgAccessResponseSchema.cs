// <copyright file="TeamMembersWithoutOrgAccessResponseSchema.cs" company="APIMatic">
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
    /// TeamMembersWithoutOrgAccessResponseSchema.
    /// </summary>
    public class TeamMembersWithoutOrgAccessResponseSchema : TeamMembersResponseSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersWithoutOrgAccessResponseSchema"/> class.
        /// </summary>
        public TeamMembersWithoutOrgAccessResponseSchema()
        {
            this.SchemaOption = "Without_Org-Access";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersWithoutOrgAccessResponseSchema"/> class.
        /// </summary>
        /// <param name="props">props.</param>
        /// <param name="userEnabled">userEnabled.</param>
        /// <param name="userName">userName.</param>
        /// <param name="schemaOption">schemaOption.</param>
        /// <param name="userGuid">userGuid.</param>
        /// <param name="custGuid">custGuid.</param>
        public TeamMembersWithoutOrgAccessResponseSchema(
            Models.Props24 props,
            Models.UserEnabledEnum userEnabled,
            string userName,
            string schemaOption = "Without_Org-Access",
            string userGuid = null,
            string custGuid = null)
            : base(
                schemaOption)
        {
            this.Props = props;
            this.UserEnabled = userEnabled;
            this.UserName = userName;
            this.UserGuid = userGuid;
            this.CustGuid = custGuid;
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

        /// <summary>
        /// user guid
        /// </summary>
        [JsonProperty("userGuid", NullValueHandling = NullValueHandling.Ignore)]
        public string UserGuid { get; set; }

        /// <summary>
        /// customer guid
        /// </summary>
        [JsonProperty("custGuid", NullValueHandling = NullValueHandling.Ignore)]
        public string CustGuid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TeamMembersWithoutOrgAccessResponseSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is TeamMembersWithoutOrgAccessResponseSchema other &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true)) &&
                this.UserEnabled.Equals(other.UserEnabled) &&
                ((this.UserName == null && other.UserName == null) || (this.UserName?.Equals(other.UserName) == true)) &&
                ((this.UserGuid == null && other.UserGuid == null) || (this.UserGuid?.Equals(other.UserGuid) == true)) &&
                ((this.CustGuid == null && other.CustGuid == null) || (this.CustGuid?.Equals(other.CustGuid) == true)) &&
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
            toStringOutput.Add($"this.UserGuid = {(this.UserGuid == null ? "null" : this.UserGuid == string.Empty ? "" : this.UserGuid)}");
            toStringOutput.Add($"this.CustGuid = {(this.CustGuid == null ? "null" : this.CustGuid == string.Empty ? "" : this.CustGuid)}");

            base.ToString(toStringOutput);
        }
    }
}