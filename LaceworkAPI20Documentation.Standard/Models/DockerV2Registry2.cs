// <copyright file="DockerV2Registry2.cs" company="APIMatic">
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
    /// DockerV2Registry2.
    /// </summary>
    public class DockerV2Registry2 : Data94
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DockerV2Registry2"/> class.
        /// </summary>
        public DockerV2Registry2()
        {
            this.RegistryType = "V2_REGISTRY";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DockerV2Registry2"/> class.
        /// </summary>
        /// <param name="registryType">registryType.</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="registryDomain">registryDomain.</param>
        /// <param name="registryNotifications">registryNotifications.</param>
        /// <param name="limitByTag">limitByTag.</param>
        /// <param name="limitByLabel">limitByLabel.</param>
        public DockerV2Registry2(
            string registryType = "V2_REGISTRY",
            Models.Credentials32 credentials = null,
            string registryDomain = null,
            bool? registryNotifications = null,
            List<string> limitByTag = null,
            List<Models.LimitByLabelSOptional> limitByLabel = null)
            : base(
                registryType)
        {
            this.Credentials = credentials;
            this.RegistryDomain = registryDomain;
            this.RegistryNotifications = registryNotifications;
            this.LimitByTag = limitByTag;
            this.LimitByLabel = limitByLabel;
        }

        /// <summary>
        /// Gets or sets Credentials.
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Credentials32 Credentials { get; set; }

        /// <summary>
        /// Gets or sets RegistryDomain.
        /// </summary>
        [JsonProperty("registryDomain", NullValueHandling = NullValueHandling.Ignore)]
        public string RegistryDomain { get; set; }

        /// <summary>
        /// Gets or sets RegistryNotifications.
        /// </summary>
        [JsonProperty("registryNotifications", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RegistryNotifications { get; set; }

        /// <summary>
        /// Gets or sets LimitByTag.
        /// </summary>
        [JsonProperty("limitByTag", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LimitByTag { get; set; }

        /// <summary>
        /// Gets or sets LimitByLabel.
        /// </summary>
        [JsonProperty("limitByLabel", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LimitByLabelSOptional> LimitByLabel { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DockerV2Registry2 : ({string.Join(", ", toStringOutput)})";
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

            return obj is DockerV2Registry2 other &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true)) &&
                ((this.RegistryDomain == null && other.RegistryDomain == null) || (this.RegistryDomain?.Equals(other.RegistryDomain) == true)) &&
                ((this.RegistryNotifications == null && other.RegistryNotifications == null) || (this.RegistryNotifications?.Equals(other.RegistryNotifications) == true)) &&
                ((this.LimitByTag == null && other.LimitByTag == null) || (this.LimitByTag?.Equals(other.LimitByTag) == true)) &&
                ((this.LimitByLabel == null && other.LimitByLabel == null) || (this.LimitByLabel?.Equals(other.LimitByLabel) == true)) &&
                base.Equals(obj);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Credentials = {(this.Credentials == null ? "null" : this.Credentials.ToString())}");
            toStringOutput.Add($"this.RegistryDomain = {(this.RegistryDomain == null ? "null" : this.RegistryDomain == string.Empty ? "" : this.RegistryDomain)}");
            toStringOutput.Add($"this.RegistryNotifications = {(this.RegistryNotifications == null ? "null" : this.RegistryNotifications.ToString())}");
            toStringOutput.Add($"this.LimitByTag = {(this.LimitByTag == null ? "null" : $"[{string.Join(", ", this.LimitByTag)} ]")}");
            toStringOutput.Add($"this.LimitByLabel = {(this.LimitByLabel == null ? "null" : $"[{string.Join(", ", this.LimitByLabel)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}