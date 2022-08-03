// <copyright file="ReportRulesUpdateSchema.cs" company="APIMatic">
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
    /// ReportRulesUpdateSchema.
    /// </summary>
    public class ReportRulesUpdateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRulesUpdateSchema"/> class.
        /// </summary>
        public ReportRulesUpdateSchema()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRulesUpdateSchema"/> class.
        /// </summary>
        /// <param name="filters">filters.</param>
        /// <param name="intgGuidList">intgGuidList.</param>
        /// <param name="reportNotificationTypes">reportNotificationTypes.</param>
        public ReportRulesUpdateSchema(
            Models.Filters9 filters = null,
            List<string> intgGuidList = null,
            Models.ReportNotificationTypes reportNotificationTypes = null)
        {
            this.Filters = filters;
            this.IntgGuidList = intgGuidList;
            this.ReportNotificationTypes = reportNotificationTypes;
        }

        /// <summary>
        /// Gets or sets Filters.
        /// </summary>
        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Filters9 Filters { get; set; }

        /// <summary>
        /// Gets or sets IntgGuidList.
        /// </summary>
        [JsonProperty("intgGuidList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IntgGuidList { get; set; }

        /// <summary>
        /// Gets or sets ReportNotificationTypes.
        /// </summary>
        [JsonProperty("reportNotificationTypes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReportNotificationTypes ReportNotificationTypes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReportRulesUpdateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is ReportRulesUpdateSchema other &&
                ((this.Filters == null && other.Filters == null) || (this.Filters?.Equals(other.Filters) == true)) &&
                ((this.IntgGuidList == null && other.IntgGuidList == null) || (this.IntgGuidList?.Equals(other.IntgGuidList) == true)) &&
                ((this.ReportNotificationTypes == null && other.ReportNotificationTypes == null) || (this.ReportNotificationTypes?.Equals(other.ReportNotificationTypes) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Filters = {(this.Filters == null ? "null" : this.Filters.ToString())}");
            toStringOutput.Add($"this.IntgGuidList = {(this.IntgGuidList == null ? "null" : $"[{string.Join(", ", this.IntgGuidList)} ]")}");
            toStringOutput.Add($"this.ReportNotificationTypes = {(this.ReportNotificationTypes == null ? "null" : this.ReportNotificationTypes.ToString())}");
        }
    }
}