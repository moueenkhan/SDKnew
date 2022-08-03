// <copyright file="Type2Enum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YapstoneStagedOnBoardingServices.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using YapstoneStagedOnBoardingServices.Standard;
    using YapstoneStagedOnBoardingServices.Standard.Utilities;

    /// <summary>
    /// Type2Enum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type2Enum
    {
        /// <summary>
        /// AUTHORIZATIONHEADER.
        /// </summary>
        [EnumMember(Value = "AUTHORIZATION_HEADER")]
        AUTHORIZATIONHEADER,

        /// <summary>
        /// TLSCLIENTAUTHENTICATION.
        /// </summary>
        [EnumMember(Value = "TLS_CLIENT_AUTHENTICATION")]
        TLSCLIENTAUTHENTICATION
    }
}