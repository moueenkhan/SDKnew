// <copyright file="AlertRulesUpdateSchema.cs" company="APIMatic">
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
    /// AlertRulesUpdateSchema.
    /// </summary>
    public class AlertRulesUpdateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertRulesUpdateSchema"/> class.
        /// </summary>
        public AlertRulesUpdateSchema()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertRulesUpdateSchema"/> class.
        /// </summary>
        /// <param name="filters">filters.</param>
        /// <param name="intgGuidList">intgGuidList.</param>
        public AlertRulesUpdateSchema(
            Models.Filters3 filters = null,
            List<string> intgGuidList = null)
        {
            this.Filters = filters;
            this.IntgGuidList = intgGuidList;
        }

        /// <summary>
        /// Gets or sets Filters.
        /// </summary>
        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Filters3 Filters { get; set; }

        /// <summary>
        /// Gets or sets IntgGuidList.
        /// </summary>
        [JsonProperty("intgGuidList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IntgGuidList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AlertRulesUpdateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is AlertRulesUpdateSchema other &&
                ((this.Filters == null && other.Filters == null) || (this.Filters?.Equals(other.Filters) == true)) &&
                ((this.IntgGuidList == null && other.IntgGuidList == null) || (this.IntgGuidList?.Equals(other.IntgGuidList) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Filters = {(this.Filters == null ? "null" : this.Filters.ToString())}");
            toStringOutput.Add($"this.IntgGuidList = {(this.IntgGuidList == null ? "null" : $"[{string.Join(", ", this.IntgGuidList)} ]")}");
        }
    }
}