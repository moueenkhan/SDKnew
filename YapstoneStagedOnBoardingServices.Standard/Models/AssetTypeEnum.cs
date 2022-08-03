// <copyright file="AssetTypeEnum.cs" company="APIMatic">
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
    /// AssetTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AssetTypeEnum
    {
        /// <summary>
        /// PROPERTY.
        /// </summary>
        [EnumMember(Value = "PROPERTY")]
        PROPERTY
    }
}