// <copyright file="BusinessLegalEntity.cs" company="APIMatic">
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
    /// BusinessLegalEntity.
    /// </summary>
    public class BusinessLegalEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLegalEntity"/> class.
        /// </summary>
        public BusinessLegalEntity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLegalEntity"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="id">id.</param>
        /// <param name="address">address.</param>
        /// <param name="phone">phone.</param>
        /// <param name="email">email.</param>
        /// <param name="website">website.</param>
        /// <param name="socialNetworks">socialNetworks.</param>
        /// <param name="digitalCurrencyAddresses">digitalCurrencyAddresses.</param>
        /// <param name="additional">additional.</param>
        /// <param name="name">name.</param>
        /// <param name="businessType">businessType.</param>
        /// <param name="dba">dba.</param>
        /// <param name="primaryContact">primaryContact.</param>
        /// <param name="principalOwner">principalOwner.</param>
        /// <param name="additionalOwners">additionalOwners.</param>
        /// <param name="identityDocuments">identityDocuments.</param>
        /// <param name="registration">registration.</param>
        public BusinessLegalEntity(
            Models.LegalEntityTypeEnum type,
            string id = null,
            Models.Address address = null,
            Models.Phone phone = null,
            string email = null,
            string website = null,
            List<Models.SocialNetwork> socialNetworks = null,
            List<string> digitalCurrencyAddresses = null,
            Dictionary<string, string> additional = null,
            string name = null,
            Models.BusinessTypeEnum? businessType = null,
            List<string> dba = null,
            Models.IndividualLegalEntity primaryContact = null,
            Models.LegalEntity principalOwner = null,
            List<Models.LegalEntity> additionalOwners = null,
            List<Models.IdentityDocument> identityDocuments = null,
            Models.BusinessRegistration registration = null)
        {
            this.Id = id;
            this.Type = type;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Website = website;
            this.SocialNetworks = socialNetworks;
            this.DigitalCurrencyAddresses = digitalCurrencyAddresses;
            this.Additional = additional;
            this.Name = name;
            this.BusinessType = businessType;
            this.Dba = dba;
            this.PrimaryContact = primaryContact;
            this.PrincipalOwner = principalOwner;
            this.AdditionalOwners = additionalOwners;
            this.IdentityDocuments = identityDocuments;
            this.Registration = registration;
        }

        /// <summary>
        /// The Party ID of the Customer, for internal use only. Should not appear in user facing documentation.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// the second description of type parameter
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter))]
        public Models.LegalEntityTypeEnum Type { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address Address { get; set; }

        /// <summary>
        /// Gets or sets Phone.
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Phone Phone { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// The website hostname.
        /// </summary>
        [JsonProperty("website", NullValueHandling = NullValueHandling.Ignore)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or sets SocialNetworks.
        /// </summary>
        [JsonProperty("socialNetworks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SocialNetwork> SocialNetworks { get; set; }

        /// <summary>
        /// Gets or sets DigitalCurrencyAddresses.
        /// </summary>
        [JsonProperty("digitalCurrencyAddresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DigitalCurrencyAddresses { get; set; }

        /// <summary>
        /// Gets or sets Additional.
        /// </summary>
        [JsonProperty("additional", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Additional { get; set; }

        /// <summary>
        /// The business's legal name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets BusinessType.
        /// </summary>
        [JsonProperty("businessType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.BusinessTypeEnum? BusinessType { get; set; }

        /// <summary>
        /// Doing Busines As
        /// </summary>
        [JsonProperty("dba", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Dba { get; set; }

        /// <summary>
        /// Gets or sets PrimaryContact.
        /// </summary>
        [JsonProperty("primaryContact", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IndividualLegalEntity PrimaryContact { get; set; }

        /// <summary>
        /// **Important !** Depending on the value of the `type` parameter, the `LegalEntity` model is extended with either [`IndividualLegalEntity`]($m/IndividualLegalEntity) or [`BusinessLegalEntity`]($m/BusinessLegalEntity)
        /// </summary>
        [JsonProperty("principalOwner", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LegalEntity PrincipalOwner { get; set; }

        /// <summary>
        /// An array of any owners with at least 25% ownership of the company, excluding the principal owner responsible for the account.
        /// </summary>
        [JsonProperty("additionalOwners", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LegalEntity> AdditionalOwners { get; set; }

        /// <summary>
        /// Gets or sets IdentityDocuments.
        /// </summary>
        [JsonProperty("identityDocuments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.IdentityDocument> IdentityDocuments { get; set; }

        /// <summary>
        /// Gets or sets Registration.
        /// </summary>
        [JsonProperty("registration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BusinessRegistration Registration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BusinessLegalEntity : ({string.Join(", ", toStringOutput)})";
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

            return obj is BusinessLegalEntity other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.Type.Equals(other.Type) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Website == null && other.Website == null) || (this.Website?.Equals(other.Website) == true)) &&
                ((this.SocialNetworks == null && other.SocialNetworks == null) || (this.SocialNetworks?.Equals(other.SocialNetworks) == true)) &&
                ((this.DigitalCurrencyAddresses == null && other.DigitalCurrencyAddresses == null) || (this.DigitalCurrencyAddresses?.Equals(other.DigitalCurrencyAddresses) == true)) &&
                ((this.Additional == null && other.Additional == null) || (this.Additional?.Equals(other.Additional) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.BusinessType == null && other.BusinessType == null) || (this.BusinessType?.Equals(other.BusinessType) == true)) &&
                ((this.Dba == null && other.Dba == null) || (this.Dba?.Equals(other.Dba) == true)) &&
                ((this.PrimaryContact == null && other.PrimaryContact == null) || (this.PrimaryContact?.Equals(other.PrimaryContact) == true)) &&
                ((this.PrincipalOwner == null && other.PrincipalOwner == null) || (this.PrincipalOwner?.Equals(other.PrincipalOwner) == true)) &&
                ((this.AdditionalOwners == null && other.AdditionalOwners == null) || (this.AdditionalOwners?.Equals(other.AdditionalOwners) == true)) &&
                ((this.IdentityDocuments == null && other.IdentityDocuments == null) || (this.IdentityDocuments?.Equals(other.IdentityDocuments) == true)) &&
                ((this.Registration == null && other.Registration == null) || (this.Registration?.Equals(other.Registration) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.Phone = {(this.Phone == null ? "null" : this.Phone.ToString())}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email == string.Empty ? "" : this.Email)}");
            toStringOutput.Add($"this.Website = {(this.Website == null ? "null" : this.Website == string.Empty ? "" : this.Website)}");
            toStringOutput.Add($"this.SocialNetworks = {(this.SocialNetworks == null ? "null" : $"[{string.Join(", ", this.SocialNetworks)} ]")}");
            toStringOutput.Add($"this.DigitalCurrencyAddresses = {(this.DigitalCurrencyAddresses == null ? "null" : $"[{string.Join(", ", this.DigitalCurrencyAddresses)} ]")}");
            toStringOutput.Add($"Additional = {(this.Additional == null ? "null" : this.Additional.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.BusinessType = {(this.BusinessType == null ? "null" : this.BusinessType.ToString())}");
            toStringOutput.Add($"this.Dba = {(this.Dba == null ? "null" : $"[{string.Join(", ", this.Dba)} ]")}");
            toStringOutput.Add($"this.PrimaryContact = {(this.PrimaryContact == null ? "null" : this.PrimaryContact.ToString())}");
            toStringOutput.Add($"this.PrincipalOwner = {(this.PrincipalOwner == null ? "null" : this.PrincipalOwner.ToString())}");
            toStringOutput.Add($"this.AdditionalOwners = {(this.AdditionalOwners == null ? "null" : $"[{string.Join(", ", this.AdditionalOwners)} ]")}");
            toStringOutput.Add($"this.IdentityDocuments = {(this.IdentityDocuments == null ? "null" : $"[{string.Join(", ", this.IdentityDocuments)} ]")}");
            toStringOutput.Add($"this.Registration = {(this.Registration == null ? "null" : this.Registration.ToString())}");
        }
    }
}