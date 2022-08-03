// <copyright file="Type21Enum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace LaceworkAPI20Documentation.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using LaceworkAPI20Documentation.Standard;
    using LaceworkAPI20Documentation.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Type21Enum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type21Enum
    {
        /// <summary>
        /// AzureCfg.
        /// </summary>
        [EnumMember(Value = "AzureCfg")]
        AzureCfg
    }
}