// <copyright file="Data42.cs" company="APIMatic">
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
    /// Data42.
    /// </summary>
    public class Data42
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data42"/> class.
        /// </summary>
        public Data42()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data42"/> class.
        /// </summary>
        /// <param name="issueGrouping">issueGrouping.</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="projectId">projectId.</param>
        /// <param name="topicId">topicId.</param>
        public Data42(
            Models.GroupIssuesByEnum? issueGrouping = Models.GroupIssuesByEnum.Events,
            Models.Credentials3 credentials = null,
            string projectId = null,
            string topicId = null)
        {
            this.IssueGrouping = issueGrouping;
            this.Credentials = credentials;
            this.ProjectId = projectId;
            this.TopicId = topicId;
        }

        /// <summary>
        /// Gets or sets IssueGrouping.
        /// </summary>
        [JsonProperty("issueGrouping", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.GroupIssuesByEnum? IssueGrouping { get; set; }

        /// <summary>
        /// Gets or sets Credentials.
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Credentials3 Credentials { get; set; }

        /// <summary>
        /// Gets or sets ProjectId.
        /// </summary>
        [JsonProperty("projectId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Gets or sets TopicId.
        /// </summary>
        [JsonProperty("topicId", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data42 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data42 other &&
                ((this.IssueGrouping == null && other.IssueGrouping == null) || (this.IssueGrouping?.Equals(other.IssueGrouping) == true)) &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true)) &&
                ((this.ProjectId == null && other.ProjectId == null) || (this.ProjectId?.Equals(other.ProjectId) == true)) &&
                ((this.TopicId == null && other.TopicId == null) || (this.TopicId?.Equals(other.TopicId) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IssueGrouping = {(this.IssueGrouping == null ? "null" : this.IssueGrouping.ToString())}");
            toStringOutput.Add($"this.Credentials = {(this.Credentials == null ? "null" : this.Credentials.ToString())}");
            toStringOutput.Add($"this.ProjectId = {(this.ProjectId == null ? "null" : this.ProjectId == string.Empty ? "" : this.ProjectId)}");
            toStringOutput.Add($"this.TopicId = {(this.TopicId == null ? "null" : this.TopicId == string.Empty ? "" : this.TopicId)}");
        }
    }
}