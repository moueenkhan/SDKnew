// <copyright file="ProxyScanner.cs" company="APIMatic">
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
    /// ProxyScanner.
    /// </summary>
    public class ProxyScanner : Data94
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyScanner"/> class.
        /// </summary>
        public ProxyScanner()
        {
            this.RegistryType = "PROXY_SCANNER";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyScanner"/> class.
        /// </summary>
        /// <param name="registryType">registryType.</param>
        /// <param name="limitNumImg">limitNumImg.</param>
        /// <param name="limitByRep">limitByRep.</param>
        /// <param name="limitByTag">limitByTag.</param>
        /// <param name="limitByLabel">limitByLabel.</param>
        public ProxyScanner(
            string registryType = "PROXY_SCANNER",
            Models.LimitNumberOfImagesPerRepoEnum? limitNumImg = Models.LimitNumberOfImagesPerRepoEnum.Enum5,
            List<string> limitByRep = null,
            List<string> limitByTag = null,
            List<Models.LimitByLabelSOptional> limitByLabel = null)
            : base(
                registryType)
        {
            this.LimitNumImg = limitNumImg;
            this.LimitByRep = limitByRep;
            this.LimitByTag = limitByTag;
            this.LimitByLabel = limitByLabel;
        }

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

            return $"ProxyScanner : ({string.Join(", ", toStringOutput)})";
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

            return obj is ProxyScanner other &&
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
            toStringOutput.Add($"this.LimitNumImg = {(this.LimitNumImg == null ? "null" : this.LimitNumImg.ToString())}");
            toStringOutput.Add($"this.LimitByRep = {(this.LimitByRep == null ? "null" : $"[{string.Join(", ", this.LimitByRep)} ]")}");
            toStringOutput.Add($"this.LimitByTag = {(this.LimitByTag == null ? "null" : $"[{string.Join(", ", this.LimitByTag)} ]")}");
            toStringOutput.Add($"this.LimitByLabel = {(this.LimitByLabel == null ? "null" : $"[{string.Join(", ", this.LimitByLabel)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}