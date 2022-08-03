// <copyright file="VerificationStateEnum.cs" company="APIMatic">
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
    /// VerificationStateEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VerificationStateEnum
    {
        /// <summary>
        /// UNVERIFIED.
        /// </summary>
        [EnumMember(Value = "UNVERIFIED")]
        UNVERIFIED,

        /// <summary>
        /// INPROGRESS.
        /// </summary>
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS,

        /// <summary>
        /// ACTIONREQUIRED.
        /// </summary>
        [EnumMember(Value = "ACTION_REQUIRED")]
        ACTIONREQUIRED,

        /// <summary>
        /// VERIFIED.
        /// </summary>
        [EnumMember(Value = "VERIFIED")]
        VERIFIED,

        /// <summary>
        /// DECLINED.
        /// </summary>
        [EnumMember(Value = "DECLINED")]
        DECLINED
    }
}