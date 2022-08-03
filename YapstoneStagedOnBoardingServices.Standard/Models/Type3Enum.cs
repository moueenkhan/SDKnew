// <copyright file="Type3Enum.cs" company="APIMatic">
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
    /// Type3Enum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type3Enum
    {
        /// <summary>
        /// MARKETPLACE.
        /// </summary>
        [EnumMember(Value = "MARKETPLACE")]
        MARKETPLACE,

        /// <summary>
        /// MERCHANT.
        /// </summary>
        [EnumMember(Value = "MERCHANT")]
        MERCHANT,

        /// <summary>
        /// SUBMERCHANT.
        /// </summary>
        [EnumMember(Value = "SUB_MERCHANT")]
        SUBMERCHANT,

        /// <summary>
        /// CUSTOMER.
        /// </summary>
        [EnumMember(Value = "CUSTOMER")]
        CUSTOMER,

        /// <summary>
        /// PAYEE.
        /// </summary>
        [EnumMember(Value = "PAYEE")]
        PAYEE
    }
}