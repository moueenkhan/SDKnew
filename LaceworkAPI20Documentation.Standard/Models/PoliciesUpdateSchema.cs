// <copyright file="PoliciesUpdateSchema.cs" company="APIMatic">
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
    /// PoliciesUpdateSchema.
    /// </summary>
    public class PoliciesUpdateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PoliciesUpdateSchema"/> class.
        /// </summary>
        public PoliciesUpdateSchema()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PoliciesUpdateSchema"/> class.
        /// </summary>
        /// <param name="policyType">policyType.</param>
        /// <param name="queryId">queryId.</param>
        /// <param name="title">title.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="description">description.</param>
        /// <param name="remediation">remediation.</param>
        /// <param name="severity">severity.</param>
        /// <param name="limit">limit.</param>
        /// <param name="alertEnabled">alertEnabled.</param>
        /// <param name="alertProfile">alertProfile.</param>
        /// <param name="paramInfo">paramInfo.</param>
        public PoliciesUpdateSchema(
            string policyType = null,
            string queryId = null,
            string title = null,
            bool? enabled = null,
            string description = null,
            string remediation = null,
            string severity = null,
            double? limit = null,
            bool? alertEnabled = null,
            string alertProfile = null,
            object paramInfo = null)
        {
            this.PolicyType = policyType;
            this.QueryId = queryId;
            this.Title = title;
            this.Enabled = enabled;
            this.Description = description;
            this.Remediation = remediation;
            this.Severity = severity;
            this.Limit = limit;
            this.AlertEnabled = alertEnabled;
            this.AlertProfile = alertProfile;
            this.ParamInfo = paramInfo;
        }

        /// <summary>
        /// Gets or sets PolicyType.
        /// </summary>
        [JsonProperty("policyType", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyType { get; set; }

        /// <summary>
        /// Gets or sets QueryId.
        /// </summary>
        [JsonProperty("queryId", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryId { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Enabled.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Remediation.
        /// </summary>
        [JsonProperty("remediation", NullValueHandling = NullValueHandling.Ignore)]
        public string Remediation { get; set; }

        /// <summary>
        /// Gets or sets Severity.
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets Limit.
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// Gets or sets AlertEnabled.
        /// </summary>
        [JsonProperty("alertEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlertEnabled { get; set; }

        /// <summary>
        /// Gets or sets AlertProfile.
        /// </summary>
        [JsonProperty("alertProfile", NullValueHandling = NullValueHandling.Ignore)]
        public string AlertProfile { get; set; }

        /// <summary>
        /// Gets or sets ParamInfo.
        /// </summary>
        [JsonProperty("paramInfo", NullValueHandling = NullValueHandling.Ignore)]
        public object ParamInfo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PoliciesUpdateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is PoliciesUpdateSchema other &&
                ((this.PolicyType == null && other.PolicyType == null) || (this.PolicyType?.Equals(other.PolicyType) == true)) &&
                ((this.QueryId == null && other.QueryId == null) || (this.QueryId?.Equals(other.QueryId) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Enabled == null && other.Enabled == null) || (this.Enabled?.Equals(other.Enabled) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Remediation == null && other.Remediation == null) || (this.Remediation?.Equals(other.Remediation) == true)) &&
                ((this.Severity == null && other.Severity == null) || (this.Severity?.Equals(other.Severity) == true)) &&
                ((this.Limit == null && other.Limit == null) || (this.Limit?.Equals(other.Limit) == true)) &&
                ((this.AlertEnabled == null && other.AlertEnabled == null) || (this.AlertEnabled?.Equals(other.AlertEnabled) == true)) &&
                ((this.AlertProfile == null && other.AlertProfile == null) || (this.AlertProfile?.Equals(other.AlertProfile) == true)) &&
                ((this.ParamInfo == null && other.ParamInfo == null) || (this.ParamInfo?.Equals(other.ParamInfo) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PolicyType = {(this.PolicyType == null ? "null" : this.PolicyType == string.Empty ? "" : this.PolicyType)}");
            toStringOutput.Add($"this.QueryId = {(this.QueryId == null ? "null" : this.QueryId == string.Empty ? "" : this.QueryId)}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title == string.Empty ? "" : this.Title)}");
            toStringOutput.Add($"this.Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Remediation = {(this.Remediation == null ? "null" : this.Remediation == string.Empty ? "" : this.Remediation)}");
            toStringOutput.Add($"this.Severity = {(this.Severity == null ? "null" : this.Severity == string.Empty ? "" : this.Severity)}");
            toStringOutput.Add($"this.Limit = {(this.Limit == null ? "null" : this.Limit.ToString())}");
            toStringOutput.Add($"this.AlertEnabled = {(this.AlertEnabled == null ? "null" : this.AlertEnabled.ToString())}");
            toStringOutput.Add($"this.AlertProfile = {(this.AlertProfile == null ? "null" : this.AlertProfile == string.Empty ? "" : this.AlertProfile)}");
            toStringOutput.Add($"ParamInfo = {(this.ParamInfo == null ? "null" : this.ParamInfo.ToString())}");
        }
    }
}