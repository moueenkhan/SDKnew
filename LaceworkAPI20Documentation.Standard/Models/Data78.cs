// <copyright file="Data78.cs" company="APIMatic">
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
    /// Data78.
    /// </summary>
    public class Data78
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data78"/> class.
        /// </summary>
        public Data78()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data78"/> class.
        /// </summary>
        /// <param name="accessKeyCredentials">accessKeyCredentials.</param>
        public Data78(
            Models.AccessKeyCredentials4 accessKeyCredentials = null)
        {
            this.AccessKeyCredentials = accessKeyCredentials;
        }

        /// <summary>
        /// Gets or sets AccessKeyCredentials.
        /// </summary>
        [JsonProperty("accessKeyCredentials", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccessKeyCredentials4 AccessKeyCredentials { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data78 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data78 other &&
                ((this.AccessKeyCredentials == null && other.AccessKeyCredentials == null) || (this.AccessKeyCredentials?.Equals(other.AccessKeyCredentials) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccessKeyCredentials = {(this.AccessKeyCredentials == null ? "null" : this.AccessKeyCredentials.ToString())}");
        }
    }
}