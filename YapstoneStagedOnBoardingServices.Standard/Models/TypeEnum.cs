// <copyright file="TypeEnum.cs" company="APIMatic">
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
    /// TypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// FACEBOOK.
        /// </summary>
        [EnumMember(Value = "FACEBOOK")]
        FACEBOOK,

        /// <summary>
        /// TWITTER.
        /// </summary>
        [EnumMember(Value = "TWITTER")]
        TWITTER,

        /// <summary>
        /// GOOGLEPLUS.
        /// </summary>
        [EnumMember(Value = "GOOGLE_PLUS")]
        GOOGLEPLUS,

        /// <summary>
        /// LINKEDIN.
        /// </summary>
        [EnumMember(Value = "LINKEDIN")]
        LINKEDIN,

        /// <summary>
        /// PINTEREST.
        /// </summary>
        [EnumMember(Value = "PINTEREST")]
        PINTEREST,

        /// <summary>
        /// INSTAGRAM.
        /// </summary>
        [EnumMember(Value = "INSTAGRAM")]
        INSTAGRAM,

        /// <summary>
        /// SNAPCHAT.
        /// </summary>
        [EnumMember(Value = "SNAPCHAT")]
        SNAPCHAT
    }
}