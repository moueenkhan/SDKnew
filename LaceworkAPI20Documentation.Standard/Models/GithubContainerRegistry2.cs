// <copyright file="GithubContainerRegistry2.cs" company="APIMatic">
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
    /// GithubContainerRegistry2.
    /// </summary>
    public class GithubContainerRegistry2 : Data94
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GithubContainerRegistry2"/> class.
        /// </summary>
        public GithubContainerRegistry2()
        {
            this.RegistryType = "GHCR";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GithubContainerRegistry2"/> class.
        /// </summary>
        /// <param name="registryType">registryType.</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="registryDomain">registryDomain.</param>
        /// <param name="registryNotifications">registryNotifications.</param>
        /// <param name="limitNumImg">limitNumImg.</param>
        /// <param name="limitByRep">limitByRep.</param>
        /// <param name="limitByTag">limitByTag.</param>
        /// <param name="limitByLabel">limitByLabel.</param>
        public GithubContainerRegistry2(
            string registryType = "GHCR",
            Models.Credentials32 credentials = null,
            Models.RegistryDomain6Enum? registryDomain = Models.RegistryDomain6Enum.EnumGhcrio,
            bool? registryNotifications = null,
            Models.LimitNumberOfImagesPerRepoEnum? limitNumImg = Models.LimitNumberOfImagesPerRepoEnum.Enum5,
            List<string> limitByRep = null,
            List<string> limitByTag = null,
            List<Models.LimitByLabelSOptional> limitByLabel = null)
            : base(
                registryType)
        {
            this.Credentials = credentials;
            this.RegistryDomain = registryDomain;
            this.RegistryNotifications = registryNotifications;
            this.LimitNumImg = limitNumImg;
            this.LimitByRep = limitByRep;
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
        [JsonProperty("registryDomain", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.RegistryDomain6Enum? RegistryDomain { get; set; }

        /// <summary>
        /// Gets or sets RegistryNotifications.
        /// </summary>
        [JsonProperty("registryNotifications", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RegistryNotifications { get; set; }

        /// <summary>
        /// Gets or sets LimitNumImg.
        /// </summary>
        [JsonProperty("limitNumImg", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LimitNumberOfImagesPerRepoEnum? LimitNumImg { get; set; }

        /// <summary>
        /// Gets or sets LimitByRep.
        /// </summary>
        [JsonProperty("limitByRep", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LimitByRep { get; set; }

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

            return $"GithubContainerRegistry2 : ({string.Join(", ", toStringOutput)})";
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

            return obj is GithubContainerRegistry2 other &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true)) &&
                ((this.RegistryDomain == null && other.RegistryDomain == null) || (this.RegistryDomain?.Equals(other.RegistryDomain) == true)) &&
                ((this.RegistryNotifications == null && other.RegistryNotifications == null) || (this.RegistryNotifications?.Equals(other.RegistryNotifications) == true)) &&
                ((this.LimitNumImg == null && other.LimitNumImg == null) || (this.LimitNumImg?.Equals(other.LimitNumImg) == true)) &&
                ((this.LimitByRep == null && other.LimitByRep == null) || (this.LimitByRep?.Equals(other.LimitByRep) == true)) &&
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
            toStringOutput.Add($"this.RegistryDomain = {(this.RegistryDomain == null ? "null" : this.RegistryDomain.ToString())}");
            toStringOutput.Add($"this.RegistryNotifications = {(this.RegistryNotifications == null ? "null" : this.RegistryNotifications.ToString())}");
            toStringOutput.Add($"this.LimitNumImg = {(this.LimitNumImg == null ? "null" : this.LimitNumImg.ToString())}");
            toStringOutput.Add($"this.LimitByRep = {(this.LimitByRep == null ? "null" : $"[{string.Join(", ", this.LimitByRep)} ]")}");
            toStringOutput.Add($"this.LimitByTag = {(this.LimitByTag == null ? "null" : $"[{string.Join(", ", this.LimitByTag)} ]")}");
            toStringOutput.Add($"this.LimitByLabel = {(this.LimitByLabel == null ? "null" : $"[{string.Join(", ", this.LimitByLabel)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}