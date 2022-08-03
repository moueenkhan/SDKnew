// <copyright file="StateEnum.cs" company="APIMatic">
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
    /// StateEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateEnum
    {
        /// <summary>
        /// INVALID.
        /// </summary>
        [EnumMember(Value = "INVALID")]
        INVALID,

        /// <summary>
        /// VALID.
        /// </summary>
        [EnumMember(Value = "VALID")]
        VALID
    }
}