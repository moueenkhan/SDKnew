// <copyright file="InlineScanner.cs" company="APIMatic">
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
    /// InlineScanner.
    /// </summary>
    public class InlineScanner : Data94
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineScanner"/> class.
        /// </summary>
        public InlineScanner()
        {
            this.RegistryType = "INLINE_SCANNER";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineScanner"/> class.
        /// </summary>
        /// <param name="registryType">registryType.</param>
        /// <param name="limitNumScan">limitNumScan.</param>
        /// <param name="identifierTag">identifierTag.</param>
        public InlineScanner(
            string registryType = "INLINE_SCANNER",
            Models.LimitNumberOfScansForThisIntegrationEnum? limitNumScan = Models.LimitNumberOfScansForThisIntegrationEnum.Enum15,
            List<Models.IdentifierTagSForScan> identifierTag = null)
            : base(
                registryType)
        {
            this.LimitNumScan = limitNumScan;
            this.IdentifierTag = identifierTag;
        }

        /// <summary>
        /// Gets or sets LimitNumScan.
        /// </summary>
        [JsonProperty("limitNumScan", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LimitNumberOfScansForThisIntegrationEnum? LimitNumScan { get; set; }

        /// <summary>
        /// Gets or sets IdentifierTag.
        /// </summary>
        [JsonProperty("identifierTag", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.IdentifierTagSForScan> IdentifierTag { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InlineScanner : ({string.Join(", ", toStringOutput)})";
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

            return obj is InlineScanner other &&
                ((this.LimitNumScan == null && other.LimitNumScan == null) || (this.LimitNumScan?.Equals(other.LimitNumScan) == true)) &&
                ((this.IdentifierTag == null && other.IdentifierTag == null) || (this.IdentifierTag?.Equals(other.IdentifierTag) == true)) &&
                base.Equals(obj);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LimitNumScan = {(this.LimitNumScan == null ? "null" : this.LimitNumScan.ToString())}");
            toStringOutput.Add($"this.IdentifierTag = {(this.IdentifierTag == null ? "null" : $"[{string.Join(", ", this.IdentifierTag)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}