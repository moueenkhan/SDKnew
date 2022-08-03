// <copyright file="PaymentMethodSpecification.cs" company="APIMatic">
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
    /// PaymentMethodSpecification.
    /// </summary>
    public class PaymentMethodSpecification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodSpecification"/> class.
        /// </summary>
        public PaymentMethodSpecification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodSpecification"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="supportedCountries">supportedCountries.</param>
        /// <param name="supportedCurrencies">supportedCurrencies.</param>
        /// <param name="requiredFields">requiredFields.</param>
        /// <param name="details">details.</param>
        /// <param name="actions">actions.</param>
        /// <param name="supportedInstrumentTypes">supportedInstrumentTypes.</param>
        /// <param name="requiresInstrument">requiresInstrument.</param>
        public PaymentMethodSpecification(
            string name = null,
            string displayName = null,
            List<string> supportedCountries = null,
            List<string> supportedCurrencies = null,
            List<string> requiredFields = null,
            List<Models.FieldSpecification> details = null,
            List<Models.FieldSpecification> actions = null,
            List<string> supportedInstrumentTypes = null,
            bool? requiresInstrument = null)
        {
            this.Name = name;
            this.DisplayName = displayName;
            this.SupportedCountries = supportedCountries;
            this.SupportedCurrencies = supportedCurrencies;
            this.RequiredFields = requiredFields;
            this.Details = details;
            this.Actions = actions;
            this.SupportedInstrumentTypes = supportedInstrumentTypes;
            this.RequiresInstrument = requiresInstrument;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 or alpha-3 country code.
        /// </summary>
        [JsonProperty("supportedCountries", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportedCountries { get; set; }

        /// <summary>
        /// ISO 4217 currency code.
        /// </summary>
        [JsonProperty("supportedCurrencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportedCurrencies { get; set; }

        /// <summary>
        /// Gets or sets RequiredFields.
        /// </summary>
        [JsonProperty("requiredFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RequiredFields { get; set; }

        /// <summary>
        /// Describes payment method specific details, accepted in the payment request.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FieldSpecification> Details { get; set; }

        /// <summary>
        /// Describes action fields returned in the payment response.
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FieldSpecification> Actions { get; set; }

        /// <summary>
        /// Describes the supported instrument type that can be used with this payment method.
        /// </summary>
        [JsonProperty("supportedInstrumentTypes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportedInstrumentTypes { get; set; }

        /// <summary>
        /// Indicates if this payment method requires one of the supported instrument types to be supplied.
        /// </summary>
        [JsonProperty("requiresInstrument", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequiresInstrument { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentMethodSpecification : ({string.Join(", ", toStringOutput)})";
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

            return obj is PaymentMethodSpecification other &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.SupportedCountries == null && other.SupportedCountries == null) || (this.SupportedCountries?.Equals(other.SupportedCountries) == true)) &&
                ((this.SupportedCurrencies == null && other.SupportedCurrencies == null) || (this.SupportedCurrencies?.Equals(other.SupportedCurrencies) == true)) &&
                ((this.RequiredFields == null && other.RequiredFields == null) || (this.RequiredFields?.Equals(other.RequiredFields) == true)) &&
                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true)) &&
                ((this.Actions == null && other.Actions == null) || (this.Actions?.Equals(other.Actions) == true)) &&
                ((this.SupportedInstrumentTypes == null && other.SupportedInstrumentTypes == null) || (this.SupportedInstrumentTypes?.Equals(other.SupportedInstrumentTypes) == true)) &&
                ((this.RequiresInstrument == null && other.RequiresInstrument == null) || (this.RequiresInstrument?.Equals(other.RequiresInstrument) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName == string.Empty ? "" : this.DisplayName)}");
            toStringOutput.Add($"this.SupportedCountries = {(this.SupportedCountries == null ? "null" : $"[{string.Join(", ", this.SupportedCountries)} ]")}");
            toStringOutput.Add($"this.SupportedCurrencies = {(this.SupportedCurrencies == null ? "null" : $"[{string.Join(", ", this.SupportedCurrencies)} ]")}");
            toStringOutput.Add($"this.RequiredFields = {(this.RequiredFields == null ? "null" : $"[{string.Join(", ", this.RequiredFields)} ]")}");
            toStringOutput.Add($"this.Details = {(this.Details == null ? "null" : $"[{string.Join(", ", this.Details)} ]")}");
            toStringOutput.Add($"this.Actions = {(this.Actions == null ? "null" : $"[{string.Join(", ", this.Actions)} ]")}");
            toStringOutput.Add($"this.SupportedInstrumentTypes = {(this.SupportedInstrumentTypes == null ? "null" : $"[{string.Join(", ", this.SupportedInstrumentTypes)} ]")}");
            toStringOutput.Add($"this.RequiresInstrument = {(this.RequiresInstrument == null ? "null" : this.RequiresInstrument.ToString())}");
        }
    }
}