// <copyright file="Consent.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YapstoneStagedOnBoardingServices.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using YapstoneStagedOnBoardingServices.Standard;
    using YapstoneStagedOnBoardingServices.Standard.Utilities;

    /// <summary>
    /// Consent.
    /// </summary>
    public class Consent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Consent"/> class.
        /// </summary>
        public Consent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Consent"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="timeOfConsent">timeOfConsent.</param>
        /// <param name="version">version.</param>
        public Consent(
            Models.Type1Enum type,
            DateTime timeOfConsent,
            int version)
        {
            this.Type = type;
            this.TimeOfConsent = timeOfConsent;
            this.Version = version;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter))]
        public Models.Type1Enum Type { get; set; }

        /// <summary>
        /// Gets or sets TimeOfConsent.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("timeOfConsent")]
        public DateTime TimeOfConsent { get; set; }

        /// <summary>
        /// Gets or sets Version.
        /// </summary>
        [JsonProperty("version")]
        public int Version { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Consent : ({string.Join(", ", toStringOutput)})";
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

            return obj is Consent other &&
                this.Type.Equals(other.Type) &&
                this.TimeOfConsent.Equals(other.TimeOfConsent) &&
                this.Version.Equals(other.Version);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.TimeOfConsent = {this.TimeOfConsent}");
            toStringOutput.Add($"this.Version = {this.Version}");
        }
    }
}