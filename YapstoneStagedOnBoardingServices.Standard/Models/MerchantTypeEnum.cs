// <copyright file="MerchantTypeEnum.cs" company="APIMatic">
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
    /// MerchantTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MerchantTypeEnum
    {
        /// <summary>
        /// MERCHANT.
        /// </summary>
        [EnumMember(Value = "MERCHANT")]
        MERCHANT,

        /// <summary>
        /// SUBMERCHANT.
        /// </summary>
        [EnumMember(Value = "SUB_MERCHANT")]
        SUBMERCHANT
    }
}