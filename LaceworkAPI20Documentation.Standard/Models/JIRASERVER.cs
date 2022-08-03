// <copyright file="JIRASERVER.cs" company="APIMatic">
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
    /// JIRASERVER.
    /// </summary>
    public class JIRASERVER : Data28
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JIRASERVER"/> class.
        /// </summary>
        public JIRASERVER()
        {
            this.JiraType = "JIRA_SERVER";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JIRASERVER"/> class.
        /// </summary>
        /// <param name="jiraUrl">jiraUrl.</param>
        /// <param name="projectId">projectId.</param>
        /// <param name="issueType">issueType.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="jiraType">jiraType.</param>
        /// <param name="issueGrouping">issueGrouping.</param>
        /// <param name="customTemplateFile">customTemplateFile.</param>
        public JIRASERVER(
            string jiraUrl,
            string projectId,
            string issueType,
            string username,
            string password,
            string jiraType = "JIRA_SERVER",
            Models.GroupIssuesByEnum? issueGrouping = Models.GroupIssuesByEnum.Events,
            Stream customTemplateFile = null)
            : base(
                jiraType)
        {
            this.IssueGrouping = issueGrouping;
            this.JiraUrl = jiraUrl;
            this.ProjectId = projectId;
            this.IssueType = issueType;
            this.Username = username;
            this.Password = password;
            this.CustomTemplateFile = customTemplateFile;
        }

        /// <summary>
        /// Gets or sets IssueGrouping.
        /// </summary>
        [JsonProperty("issueGrouping", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.GroupIssuesByEnum? IssueGrouping { get; set; }

        /// <summary>
        /// Gets or sets JiraUrl.
        /// </summary>
        [JsonProperty("jiraUrl")]
        public string JiraUrl { get; set; }

        /// <summary>
        /// Gets or sets ProjectId.
        /// </summary>
        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        /// <summary>
        /// Gets or sets IssueType.
        /// </summary>
        [JsonProperty("issueType")]
        public string IssueType { get; set; }

        /// <summary>
        /// Gets or sets Username.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets CustomTemplateFile.
        /// </summary>
        [JsonProperty("customTemplateFile", NullValueHandling = NullValueHandling.Ignore)]
        public Stream CustomTemplateFile { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"JIRASERVER : ({string.Join(", ", toStringOutput)})";
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

            return obj is JIRASERVER other &&
                ((this.IssueGrouping == null && other.IssueGrouping == null) || (this.IssueGrouping?.Equals(other.IssueGrouping) == true)) &&
                ((this.JiraUrl == null && other.JiraUrl == null) || (this.JiraUrl?.Equals(other.JiraUrl) == true)) &&
                ((this.ProjectId == null && other.ProjectId == null) || (this.ProjectId?.Equals(other.ProjectId) == true)) &&
                ((this.IssueType == null && other.IssueType == null) || (this.IssueType?.Equals(other.IssueType) == true)) &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true)) &&
                ((this.CustomTemplateFile == null && other.CustomTemplateFile == null) || (this.CustomTemplateFile?.Equals(other.CustomTemplateFile) == true)) &&
                base.Equals(obj);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IssueGrouping = {(this.IssueGrouping == null ? "null" : this.IssueGrouping.ToString())}");
            toStringOutput.Add($"this.JiraUrl = {(this.JiraUrl == null ? "null" : this.JiraUrl == string.Empty ? "" : this.JiraUrl)}");
            toStringOutput.Add($"this.ProjectId = {(this.ProjectId == null ? "null" : this.ProjectId == string.Empty ? "" : this.ProjectId)}");
            toStringOutput.Add($"this.IssueType = {(this.IssueType == null ? "null" : this.IssueType == string.Empty ? "" : this.IssueType)}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username == string.Empty ? "" : this.Username)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password == string.Empty ? "" : this.Password)}");
            toStringOutput.Add($"this.CustomTemplateFile = {(this.CustomTemplateFile == null ? "null" : this.CustomTemplateFile.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}