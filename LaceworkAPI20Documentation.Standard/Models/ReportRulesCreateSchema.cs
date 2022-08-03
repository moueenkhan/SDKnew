// <copyright file="ReportRulesCreateSchema.cs" company="APIMatic">
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
    /// ReportRulesCreateSchema.
    /// </summary>
    public class ReportRulesCreateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRulesCreateSchema"/> class.
        /// </summary>
        public ReportRulesCreateSchema()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRulesCreateSchema"/> class.
        /// </summary>
        /// <param name="filters">filters.</param>
        /// <param name="intgGuidList">intgGuidList.</param>
        /// <param name="reportNotificationTypes">reportNotificationTypes.</param>
        /// <param name="type">type.</param>
        public ReportRulesCreateSchema(
            Models.Filters6 filters,
            List<string> intgGuidList,
            Models.ReportNotificationTypes reportNotificationTypes,
            string type)
        {
            this.Filters = filters;
            this.IntgGuidList = intgGuidList;
            this.ReportNotificationTypes = reportNotificationTypes;
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets Filters.
        /// </summary>
        [JsonProperty("filters")]
        public Models.Filters6 Filters { get; set; }

        /// <summary>
        /// Gets or sets IntgGuidList.
        /// </summary>
        [JsonProperty("intgGuidList")]
        public List<string> IntgGuidList { get; set; }

        /// <summary>
        /// Gets or sets ReportNotificationTypes.
        /// </summary>
        [JsonProperty("reportNotificationTypes")]
        public Models.ReportNotificationTypes ReportNotificationTypes { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReportRulesCreateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is ReportRulesCreateSchema other &&
                ((this.Filters == null && other.Filters == null) || (this.Filters?.Equals(other.Filters) == true)) &&
                ((this.IntgGuidList == null && other.IntgGuidList == null) || (this.IntgGuidList?.Equals(other.IntgGuidList) == true)) &&
                ((this.ReportNotificationTypes == null && other.ReportNotificationTypes == null) || (this.ReportNotificationTypes?.Equals(other.ReportNotificationTypes) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
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
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
        }
    }
}