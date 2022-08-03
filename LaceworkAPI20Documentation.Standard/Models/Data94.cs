// <copyright file="Data94.cs" company="APIMatic">
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
    /// Data94.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "registryType")]
    [JsonSubtypes.KnownSubType(typeof(AWSECRAWSKeyIDAccessKey), "AWS_ECR-AWS_ACCESS_KEY")]
    [JsonSubtypes.KnownSubType(typeof(AWSECRAWSKeyIDAccessKey2), "AWS_ECR-AWS_ACCESS_KEY")]
    [JsonSubtypes.KnownSubType(typeof(AWSECRAWSIAMRole), "AWS_ECR")]
    [JsonSubtypes.KnownSubType(typeof(AWSECRAWSIAMRole2), "AWS_ECR")]
    [JsonSubtypes.KnownSubType(typeof(DockerHub), "DOCKERHUB")]
    [JsonSubtypes.KnownSubType(typeof(DockerHub2), "DOCKERHUB")]
    [JsonSubtypes.KnownSubType(typeof(GoogleContainerRegistryGAR), "GCP_GAR")]
    [JsonSubtypes.KnownSubType(typeof(GoogleContainerRegistryGAR2), "GCP_GAR")]
    [JsonSubtypes.KnownSubType(typeof(GoogleContainerRegistryGCR), "GCP_GCR")]
    [JsonSubtypes.KnownSubType(typeof(GoogleContainerRegistryGCR3), "GCP_GCR")]
    [JsonSubtypes.KnownSubType(typeof(GithubContainerRegistry), "GHCR")]
    [JsonSubtypes.KnownSubType(typeof(GithubContainerRegistry2), "GHCR")]
    [JsonSubtypes.KnownSubType(typeof(InlineScanner), "INLINE_SCANNER")]
    [JsonSubtypes.KnownSubType(typeof(ProxyScanner), "PROXY_SCANNER")]
    [JsonSubtypes.KnownSubType(typeof(DockerV2Registry), "V2_REGISTRY")]
    [JsonSubtypes.KnownSubType(typeof(DockerV2Registry2), "V2_REGISTRY")]
    public class Data94
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data94"/> class.
        /// </summary>
        public Data94()
        {
            this.RegistryType = "Data94";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data94"/> class.
        /// </summary>
        /// <param name="registryType">registryType.</param>
        public Data94(
            string registryType = "Data94")
        {
            this.RegistryType = registryType;
        }

        /// <summary>
        /// Gets or sets RegistryType.
        /// </summary>
        [JsonProperty("registryType", NullValueHandling = NullValueHandling.Ignore)]
        public string RegistryType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data94 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data94 other &&
                ((this.RegistryType == null && other.RegistryType == null) || (this.RegistryType?.Equals(other.RegistryType) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RegistryType = {(this.RegistryType == null ? "null" : this.RegistryType == string.Empty ? "" : this.RegistryType)}");
        }
    }
}