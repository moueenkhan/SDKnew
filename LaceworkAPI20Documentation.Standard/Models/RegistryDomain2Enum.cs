// <copyright file="RegistryDomain2Enum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace LaceworkAPI20Documentation.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using LaceworkAPI20Documentation.Standard;
    using LaceworkAPI20Documentation.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// RegistryDomain2Enum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RegistryDomain2Enum
    {
        /// <summary>
        /// EnumNorthamericanortheast1dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "northamerica-northeast1-docker.pkg.dev")]
        EnumNorthamericanortheast1dockerpkgdev,

        /// <summary>
        /// EnumUscentral1dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "us-central1-docker.pkg.dev")]
        EnumUscentral1dockerpkgdev,

        /// <summary>
        /// EnumUseast1dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "us-east1-docker.pkg.dev")]
        EnumUseast1dockerpkgdev,

        /// <summary>
        /// EnumUseast4dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "us-east4-docker.pkg.dev")]
        EnumUseast4dockerpkgdev,

        /// <summary>
        /// EnumUswest1dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "us-west1-docker.pkg.dev")]
        EnumUswest1dockerpkgdev,

        /// <summary>
        /// EnumUswest2dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "us-west2-docker.pkg.dev")]
        EnumUswest2dockerpkgdev,

        /// <summary>
        /// EnumUswest3dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "us-west3-docker.pkg.dev")]
        EnumUswest3dockerpkgdev,

        /// <summary>
        /// EnumUswest4dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "us-west4-docker.pkg.dev")]
        EnumUswest4dockerpkgdev,

        /// <summary>
        /// EnumSouthamericaeast1dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "southamerica-east1-docker.pkg.dev")]
        EnumSouthamericaeast1dockerpkgdev,

        /// <summary>
        /// EnumEuropenorth1dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "europe-north1-docker.pkg.dev")]
        EnumEuropenorth1dockerpkgdev,

        /// <summary>
        /// EnumEuropewest1dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "europe-west1-docker.pkg.dev")]
        EnumEuropewest1dockerpkgdev,

        /// <summary>
        /// EnumEuropewest2dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "europe-west2-docker.pkg.dev")]
        EnumEuropewest2dockerpkgdev,

        /// <summary>
        /// EnumEuropewest3dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "europe-west3-docker.pkg.dev")]
        EnumEuropewest3dockerpkgdev,

        /// <summary>
        /// EnumEuropewest4dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "europe-west4-docker.pkg.dev")]
        EnumEuropewest4dockerpkgdev,

        /// <summary>
        /// EnumEuropewest6dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "europe-west6-docker.pkg.dev")]
        EnumEuropewest6dockerpkgdev,

        /// <summary>
        /// EnumAsiaeast1dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "asia-east1-docker.pkg.dev")]
        EnumAsiaeast1dockerpkgdev,

        /// <summary>
        /// EnumAsiaeast2dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "asia-east2-docker.pkg.dev")]
        EnumAsiaeast2dockerpkgdev,

        /// <summary>
        /// EnumAsianortheast1dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "asia-northeast1-docker.pkg.dev")]
        EnumAsianortheast1dockerpkgdev,

        /// <summary>
        /// EnumAsianortheast2dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "asia-northeast2-docker.pkg.dev")]
        EnumAsianortheast2dockerpkgdev,

        /// <summary>
        /// EnumAsianortheast3dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "asia-northeast3-docker.pkg.dev")]
        EnumAsianortheast3dockerpkgdev,

        /// <summary>
        /// EnumAsiasouth1dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "asia-south1-docker.pkg.dev")]
        EnumAsiasouth1dockerpkgdev,

        /// <summary>
        /// EnumAsiasoutheast1dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "asia-southeast1-docker.pkg.dev")]
        EnumAsiasoutheast1dockerpkgdev,

        /// <summary>
        /// EnumAsiasoutheast2dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "asia-southeast2-docker.pkg.dev")]
        EnumAsiasoutheast2dockerpkgdev,

        /// <summary>
        /// EnumAustraliasoutheast1dockerpkgdev.
        /// </summary>
        [EnumMember(Value = "australia-southeast1-docker.pkg.dev")]
        EnumAustraliasoutheast1dockerpkgdev,

        /// <summary>
        /// EnumAsiadockerpkgdev.
        /// </summary>
        [EnumMember(Value = "asia-docker.pkg.dev")]
        EnumAsiadockerpkgdev,

        /// <summary>
        /// EnumEuropedockerpkgdev.
        /// </summary>
        [EnumMember(Value = "europe-docker.pkg.dev")]
        EnumEuropedockerpkgdev,

        /// <summary>
        /// EnumUsdockerpkgdev.
        /// </summary>
        [EnumMember(Value = "us-docker.pkg.dev")]
        EnumUsdockerpkgdev
    }
}