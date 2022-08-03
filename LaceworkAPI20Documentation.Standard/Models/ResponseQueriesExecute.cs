// <copyright file="ResponseQueriesExecute.cs" company="APIMatic">
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
    /// ResponseQueriesExecute.
    /// </summary>
    public class ResponseQueriesExecute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseQueriesExecute"/> class.
        /// </summary>
        public ResponseQueriesExecute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseQueriesExecute"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public ResponseQueriesExecute(
            object data = null)
        {
            this.Data = data;
        }

        /// <summary>
        /// Result data (free-form object)
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public object Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseQueriesExecute : ({string.Join(", ", toStringOutput)})";
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

            return obj is ResponseQueriesExecute other &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}