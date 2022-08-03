// <copyright file="TeamMembersWithOrgAccessCreateSchema.cs" company="APIMatic">
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
    /// TeamMembersWithOrgAccessCreateSchema.
    /// </summary>
    public class TeamMembersWithOrgAccessCreateSchema : TeamMembersCreateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersWithOrgAccessCreateSchema"/> class.
        /// </summary>
        public TeamMembersWithOrgAccessCreateSchema()
        {
            this.SchemaOption = "With_Org-Access";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersWithOrgAccessCreateSchema"/> class.
        /// </summary>
        /// <param name="props">props.</param>
        /// <param name="orgAdmin">orgAdmin.</param>
        /// <param name="orgUser">orgUser.</param>
        /// <param name="adminRoleAccounts">adminRoleAccounts.</param>
        /// <param name="userRoleAccounts">userRoleAccounts.</param>
        /// <param name="userEnabled">userEnabled.</param>
        /// <param name="userName">userName.</param>
        /// <param name="schemaOption">schemaOption.</param>
        public TeamMembersWithOrgAccessCreateSchema(
            Models.Props24 props,
            bool orgAdmin,
            bool orgUser,
            List<string> adminRoleAccounts,
            List<string> userRoleAccounts,
            Models.UserEnabledEnum userEnabled,
            string userName,
            string schemaOption = "With_Org-Access")
            : base(
                schemaOption)
        {
            this.Props = props;
            this.OrgAdmin = orgAdmin;
            this.OrgUser = orgUser;
            this.AdminRoleAccounts = adminRoleAccounts;
            this.UserRoleAccounts = userRoleAccounts;
            this.UserEnabled = userEnabled;
            this.UserName = userName;
        }

        /// <summary>
        /// Gets or sets Props.
        /// </summary>
        [JsonProperty("props")]
        public Models.Props24 Props { get; set; }

        /// <summary>
        /// should this user be the org admin of this org, adminRoleAccounts and userRoleAccounts list will be ignored
        /// </summary>
        [JsonProperty("orgAdmin")]
        public bool OrgAdmin { get; set; }

        /// <summary>
        /// should this user be the org user of this org, userRoleAccounts list will be ignored
        /// </summary>
        [JsonProperty("orgUser")]
        public bool OrgUser { get; set; }

        /// <summary>
        /// list of account names that this user will be admin
        /// </summary>
        [JsonProperty("adminRoleAccounts")]
        public List<string> AdminRoleAccounts { get; set; }

        /// <summary>
        /// list of account names that this user will be user
        /// </summary>
        [JsonProperty("userRoleAccounts")]
        public List<string> UserRoleAccounts { get; set; }

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

            return $"TeamMembersWithOrgAccessCreateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is TeamMembersWithOrgAccessCreateSchema other &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true)) &&
                this.OrgAdmin.Equals(other.OrgAdmin) &&
                this.OrgUser.Equals(other.OrgUser) &&
                ((this.AdminRoleAccounts == null && other.AdminRoleAccounts == null) || (this.AdminRoleAccounts?.Equals(other.AdminRoleAccounts) == true)) &&
                ((this.UserRoleAccounts == null && other.UserRoleAccounts == null) || (this.UserRoleAccounts?.Equals(other.UserRoleAccounts) == true)) &&
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
            toStringOutput.Add($"this.OrgAdmin = {this.OrgAdmin}");
            toStringOutput.Add($"this.OrgUser = {this.OrgUser}");
            toStringOutput.Add($"this.AdminRoleAccounts = {(this.AdminRoleAccounts == null ? "null" : $"[{string.Join(", ", this.AdminRoleAccounts)} ]")}");
            toStringOutput.Add($"this.UserRoleAccounts = {(this.UserRoleAccounts == null ? "null" : $"[{string.Join(", ", this.UserRoleAccounts)} ]")}");
            toStringOutput.Add($"this.UserEnabled = {this.UserEnabled}");
            toStringOutput.Add($"this.UserName = {(this.UserName == null ? "null" : this.UserName == string.Empty ? "" : this.UserName)}");

            base.ToString(toStringOutput);
        }
    }
}