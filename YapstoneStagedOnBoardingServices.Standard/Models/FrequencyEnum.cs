// <copyright file="FrequencyEnum.cs" company="APIMatic">
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
    /// FrequencyEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FrequencyEnum
    {
        /// <summary>
        /// WEEKLY.
        /// </summary>
        [EnumMember(Value = "WEEKLY")]
        WEEKLY,

        /// <summary>
        /// MONTHLY.
        /// </summary>
        [EnumMember(Value = "MONTHLY")]
        MONTHLY
    }
}