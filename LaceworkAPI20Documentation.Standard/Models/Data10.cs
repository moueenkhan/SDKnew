// <copyright file="Data10.cs" company="APIMatic">
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
    /// Data10.
    /// </summary>
    public class Data10
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data10"/> class.
        /// </summary>
        public Data10()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data10"/> class.
        /// </summary>
        /// <param name="userName">userName.</param>
        /// <param name="password">password.</param>
        /// <param name="instanceUrl">instanceUrl.</param>
        /// <param name="issueGrouping">issueGrouping.</param>
        /// <param name="customTemplateFile">customTemplateFile.</param>
        public Data10(
            string userName,
            string password,
            string instanceUrl,
            Models.GroupIssuesByEnum? issueGrouping = Models.GroupIssuesByEnum.Events,
            Stream customTemplateFile = null)
        {
            this.IssueGrouping = issueGrouping;
            this.UserName = userName;
            this.Password = password;
            this.InstanceUrl = instanceUrl;
            this.CustomTemplateFile = customTemplateFile;
        }

        /// <summary>
        /// Gets or sets IssueGrouping.
        /// </summary>
        [JsonProperty("issueGrouping", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.GroupIssuesByEnum? IssueGrouping { get; set; }

        /// <summary>
        /// Gets or sets UserName.
        /// </summary>
        [JsonProperty("userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets InstanceUrl.
        /// </summary>
        [JsonProperty("instanceUrl")]
        public string InstanceUrl { get; set; }

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

            return $"Data10 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data10 other &&
                ((this.IssueGrouping == null && other.IssueGrouping == null) || (this.IssueGrouping?.Equals(other.IssueGrouping) == true)) &&
                ((this.UserName == null && other.UserName == null) || (this.UserName?.Equals(other.UserName) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true)) &&
                ((this.InstanceUrl == null && other.InstanceUrl == null) || (this.InstanceUrl?.Equals(other.InstanceUrl) == true)) &&
                ((this.CustomTemplateFile == null && other.CustomTemplateFile == null) || (this.CustomTemplateFile?.Equals(other.CustomTemplateFile) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IssueGrouping = {(this.IssueGrouping == null ? "null" : this.IssueGrouping.ToString())}");
            toStringOutput.Add($"this.UserName = {(this.UserName == null ? "null" : this.UserName == string.Empty ? "" : this.UserName)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password == string.Empty ? "" : this.Password)}");
            toStringOutput.Add($"this.InstanceUrl = {(this.InstanceUrl == null ? "null" : this.InstanceUrl == string.Empty ? "" : this.InstanceUrl)}");
            toStringOutput.Add($"this.CustomTemplateFile = {(this.CustomTemplateFile == null ? "null" : this.CustomTemplateFile.ToString())}");
        }
    }
}