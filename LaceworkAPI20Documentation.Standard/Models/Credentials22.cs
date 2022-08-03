// <copyright file="Credentials22.cs" company="APIMatic">
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
    /// Credentials22.
    /// </summary>
    public class Credentials22
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Credentials22"/> class.
        /// </summary>
        public Credentials22()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Credentials22"/> class.
        /// </summary>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="ssl">ssl.</param>
        public Credentials22(
            string username,
            string password,
            bool? ssl = null)
        {
            this.Username = username;
            this.Password = password;
            this.Ssl = ssl;
        }

        /// <summary>
        /// Gets or sets Username.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets Ssl.
        /// </summary>
        [JsonProperty("ssl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ssl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Credentials22 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Credentials22 other &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true)) &&
                ((this.Ssl == null && other.Ssl == null) || (this.Ssl?.Equals(other.Ssl) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username == string.Empty ? "" : this.Username)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password == string.Empty ? "" : this.Password)}");
            toStringOutput.Add($"this.Ssl = {(this.Ssl == null ? "null" : this.Ssl.ToString())}");
        }
    }
}