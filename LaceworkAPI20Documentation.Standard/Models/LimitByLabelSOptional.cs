// <copyright file="LimitByLabelSOptional.cs" company="APIMatic">
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
    /// LimitByLabelSOptional.
    /// </summary>
    public class LimitByLabelSOptional
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitByLabelSOptional"/> class.
        /// </summary>
        public LimitByLabelSOptional()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitByLabelSOptional"/> class.
        /// </summary>
        /// <param name="a">A.+.</param>
        public LimitByLabelSOptional(
            string a = null)
        {
            this.A = a;
        }

        /// <summary>
        /// Gets or sets A.
        /// </summary>
        [JsonProperty("A.+", NullValueHandling = NullValueHandling.Ignore)]
        public string A { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LimitByLabelSOptional : ({string.Join(", ", toStringOutput)})";
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

            return obj is LimitByLabelSOptional other &&
                ((this.A == null && other.A == null) || (this.A?.Equals(other.A) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.A = {(this.A == null ? "null" : this.A == string.Empty ? "" : this.A)}");
        }
    }
}