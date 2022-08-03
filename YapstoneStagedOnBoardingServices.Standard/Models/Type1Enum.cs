// <copyright file="Type1Enum.cs" company="APIMatic">
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
    /// Type1Enum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type1Enum
    {
        /// <summary>
        /// TERMSOFSERVICE.
        /// </summary>
        [EnumMember(Value = "TERMS_OF_SERVICE")]
        TERMSOFSERVICE,

        /// <summary>
        /// DIRECTDEBIT.
        /// </summary>
        [EnumMember(Value = "DIRECT_DEBIT")]
        DIRECTDEBIT
    }
}