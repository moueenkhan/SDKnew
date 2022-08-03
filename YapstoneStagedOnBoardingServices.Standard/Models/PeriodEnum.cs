// <copyright file="PeriodEnum.cs" company="APIMatic">
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
    /// PeriodEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PeriodEnum
    {
        /// <summary>
        /// DAILY.
        /// </summary>
        [EnumMember(Value = "DAILY")]
        DAILY,

        /// <summary>
        /// WEEKLY.
        /// </summary>
        [EnumMember(Value = "WEEKLY")]
        WEEKLY,

        /// <summary>
        /// MONTHLY.
        /// </summary>
        [EnumMember(Value = "MONTHLY")]
        MONTHLY,

        /// <summary>
        /// YEARLY.
        /// </summary>
        [EnumMember(Value = "YEARLY")]
        YEARLY
    }
}