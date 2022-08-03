// <copyright file="QueriesUpdateSchema.cs" company="APIMatic">
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
    /// QueriesUpdateSchema.
    /// </summary>
    public class QueriesUpdateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueriesUpdateSchema"/> class.
        /// </summary>
        public QueriesUpdateSchema()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueriesUpdateSchema"/> class.
        /// </summary>
        /// <param name="queryText">queryText.</param>
        public QueriesUpdateSchema(
            string queryText = null)
        {
            this.QueryText = queryText;
        }

        /// <summary>
        /// Gets or sets QueryText.
        /// </summary>
        [JsonProperty("queryText", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryText { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QueriesUpdateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is QueriesUpdateSchema other &&
                ((this.QueryText == null && other.QueryText == null) || (this.QueryText?.Equals(other.QueryText) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.QueryText = {(this.QueryText == null ? "null" : this.QueryText == string.Empty ? "" : this.QueryText)}");
        }
    }
}