// <copyright file="Data28.cs" company="APIMatic">
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
    /// Data28.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "jiraType")]
    [JsonSubtypes.KnownSubType(typeof(JIRACLOUD), "JIRA_CLOUD")]
    [JsonSubtypes.KnownSubType(typeof(JIRACLOUD2), "JIRA_CLOUD")]
    [JsonSubtypes.KnownSubType(typeof(JIRASERVER), "JIRA_SERVER")]
    [JsonSubtypes.KnownSubType(typeof(JIRASERVER2), "JIRA_SERVER")]
    public class Data28
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data28"/> class.
        /// </summary>
        public Data28()
        {
            this.JiraType = "Data28";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data28"/> class.
        /// </summary>
        /// <param name="jiraType">jiraType.</param>
        public Data28(
            string jiraType = "Data28")
        {
            this.JiraType = jiraType;
        }

        /// <summary>
        /// Gets or sets JiraType.
        /// </summary>
        [JsonProperty("jiraType", NullValueHandling = NullValueHandling.Ignore)]
        public string JiraType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data28 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data28 other &&
                ((this.JiraType == null && other.JiraType == null) || (this.JiraType?.Equals(other.JiraType) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.JiraType = {(this.JiraType == null ? "null" : this.JiraType == string.Empty ? "" : this.JiraType)}");
        }
    }
}