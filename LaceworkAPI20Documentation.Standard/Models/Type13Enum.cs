// <copyright file="Type13Enum.cs" company="APIMatic">
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
    /// Type13Enum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type13Enum
    {
        /// <summary>
        /// SplunkHec.
        /// </summary>
        [EnumMember(Value = "SplunkHec")]
        SplunkHec
    }
}