// <copyright file="PoliciesCreateSchema.cs" company="APIMatic">
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
    /// PoliciesCreateSchema.
    /// </summary>
    public class PoliciesCreateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PoliciesCreateSchema"/> class.
        /// </summary>
        public PoliciesCreateSchema()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PoliciesCreateSchema"/> class.
        /// </summary>
        /// <param name="policyType">policyType.</param>
        /// <param name="queryId">queryId.</param>
        /// <param name="title">title.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="description">description.</param>
        /// <param name="remediation">remediation.</param>
        /// <param name="severity">severity.</param>
        /// <param name="alertEnabled">alertEnabled.</param>
        /// <param name="alertProfile">alertProfile.</param>
        /// <param name="evaluatorId">evaluatorId.</param>
        /// <param name="limit">limit.</param>
        /// <param name="paramInfo">paramInfo.</param>
        public PoliciesCreateSchema(
            string policyType,
            string queryId,
            string title,
            bool enabled,
            string description,
            string remediation,
            string severity,
            bool alertEnabled,
            string alertProfile,
            string evaluatorId,
            double? limit = null,
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
            this.EvaluatorId = evaluatorId;
        }

        /// <summary>
        /// Gets or sets PolicyType.
        /// </summary>
        [JsonProperty("policyType")]
        public string PolicyType { get; set; }

        /// <summary>
        /// Gets or sets QueryId.
        /// </summary>
        [JsonProperty("queryId")]
        public string QueryId { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Remediation.
        /// </summary>
        [JsonProperty("remediation")]
        public string Remediation { get; set; }

        /// <summary>
        /// Gets or sets Severity.
        /// </summary>
        [JsonProperty("severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets Limit.
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// Gets or sets AlertEnabled.
        /// </summary>
        [JsonProperty("alertEnabled")]
        public bool AlertEnabled { get; set; }

        /// <summary>
        /// Gets or sets AlertProfile.
        /// </summary>
        [JsonProperty("alertProfile")]
        public string AlertProfile { get; set; }

        /// <summary>
        /// Gets or sets ParamInfo.
        /// </summary>
        [JsonProperty("paramInfo", NullValueHandling = NullValueHandling.Ignore)]
        public object ParamInfo { get; set; }

        /// <summary>
        /// Identifier of the evaluator in which this policy is to be run
        /// </summary>
        [JsonProperty("evaluatorId")]
        public string EvaluatorId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PoliciesCreateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is PoliciesCreateSchema other &&
                ((this.PolicyType == null && other.PolicyType == null) || (this.PolicyType?.Equals(other.PolicyType) == true)) &&
                ((this.QueryId == null && other.QueryId == null) || (this.QueryId?.Equals(other.QueryId) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                this.Enabled.Equals(other.Enabled) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Remediation == null && other.Remediation == null) || (this.Remediation?.Equals(other.Remediation) == true)) &&
                ((this.Severity == null && other.Severity == null) || (this.Severity?.Equals(other.Severity) == true)) &&
                ((this.Limit == null && other.Limit == null) || (this.Limit?.Equals(other.Limit) == true)) &&
                this.AlertEnabled.Equals(other.AlertEnabled) &&
                ((this.AlertProfile == null && other.AlertProfile == null) || (this.AlertProfile?.Equals(other.AlertProfile) == true)) &&
                ((this.ParamInfo == null && other.ParamInfo == null) || (this.ParamInfo?.Equals(other.ParamInfo) == true)) &&
                ((this.EvaluatorId == null && other.EvaluatorId == null) || (this.EvaluatorId?.Equals(other.EvaluatorId) == true));
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
            toStringOutput.Add($"this.Enabled = {this.Enabled}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Remediation = {(this.Remediation == null ? "null" : this.Remediation == string.Empty ? "" : this.Remediation)}");
            toStringOutput.Add($"this.Severity = {(this.Severity == null ? "null" : this.Severity == string.Empty ? "" : this.Severity)}");
            toStringOutput.Add($"this.Limit = {(this.Limit == null ? "null" : this.Limit.ToString())}");
            toStringOutput.Add($"this.AlertEnabled = {this.AlertEnabled}");
            toStringOutput.Add($"this.AlertProfile = {(this.AlertProfile == null ? "null" : this.AlertProfile == string.Empty ? "" : this.AlertProfile)}");
            toStringOutput.Add($"ParamInfo = {(this.ParamInfo == null ? "null" : this.ParamInfo.ToString())}");
            toStringOutput.Add($"this.EvaluatorId = {(this.EvaluatorId == null ? "null" : this.EvaluatorId == string.Empty ? "" : this.EvaluatorId)}");
        }
    }
}