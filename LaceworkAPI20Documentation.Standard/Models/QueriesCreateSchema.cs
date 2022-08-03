// <copyright file="QueriesCreateSchema.cs" company="APIMatic">
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
    /// QueriesCreateSchema.
    /// </summary>
    public class QueriesCreateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueriesCreateSchema"/> class.
        /// </summary>
        public QueriesCreateSchema()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueriesCreateSchema"/> class.
        /// </summary>
        /// <param name="queryText">queryText.</param>
        /// <param name="evaluatorId">evaluatorId.</param>
        /// <param name="queryId">queryId.</param>
        public QueriesCreateSchema(
            string queryText,
            string evaluatorId,
            string queryId)
        {
            this.QueryText = queryText;
            this.EvaluatorId = evaluatorId;
            this.QueryId = queryId;
        }

        /// <summary>
        /// Gets or sets QueryText.
        /// </summary>
        [JsonProperty("queryText")]
        public string QueryText { get; set; }

        /// <summary>
        /// Identifier of the evaluator in which this policy is to be run
        /// </summary>
        [JsonProperty("evaluatorId")]
        public string EvaluatorId { get; set; }

        /// <summary>
        /// Gets or sets QueryId.
        /// </summary>
        [JsonProperty("queryId")]
        public string QueryId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QueriesCreateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is QueriesCreateSchema other &&
                ((this.QueryText == null && other.QueryText == null) || (this.QueryText?.Equals(other.QueryText) == true)) &&
                ((this.EvaluatorId == null && other.EvaluatorId == null) || (this.EvaluatorId?.Equals(other.EvaluatorId) == true)) &&
                ((this.QueryId == null && other.QueryId == null) || (this.QueryId?.Equals(other.QueryId) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.QueryText = {(this.QueryText == null ? "null" : this.QueryText == string.Empty ? "" : this.QueryText)}");
            toStringOutput.Add($"this.EvaluatorId = {(this.EvaluatorId == null ? "null" : this.EvaluatorId == string.Empty ? "" : this.EvaluatorId)}");
            toStringOutput.Add($"this.QueryId = {(this.QueryId == null ? "null" : this.QueryId == string.Empty ? "" : this.QueryId)}");
        }
    }
}