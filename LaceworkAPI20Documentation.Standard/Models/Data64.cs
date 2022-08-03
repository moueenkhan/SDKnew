// <copyright file="Data64.cs" company="APIMatic">
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
    /// Data64.
    /// </summary>
    public class Data64
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data64"/> class.
        /// </summary>
        public Data64()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data64"/> class.
        /// </summary>
        /// <param name="accessKeyCredentials">accessKeyCredentials.</param>
        public Data64(
            Models.AccessKeyCredentials accessKeyCredentials)
        {
            this.AccessKeyCredentials = accessKeyCredentials;
        }

        /// <summary>
        /// Gets or sets AccessKeyCredentials.
        /// </summary>
        [JsonProperty("accessKeyCredentials")]
        public Models.AccessKeyCredentials AccessKeyCredentials { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data64 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data64 other &&
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