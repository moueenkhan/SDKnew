// <copyright file="Data25.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace LaceworkAPI20Documentation.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using LaceworkAPI20Documentation.Standard;
    using LaceworkAPI20Documentation.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Data25.
    /// </summary>
    public class Data25
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data25"/> class.
        /// </summary>
        public Data25()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data25"/> class.
        /// </summary>
        /// <param name="channelProps">channelProps.</param>
        public Data25(
            Models.ChannelProps channelProps = null)
        {
            this.ChannelProps = channelProps;
        }

        /// <summary>
        /// Gets or sets ChannelProps.
        /// </summary>
        [JsonProperty("channelProps", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChannelProps ChannelProps { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data25 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is Data25 other &&
                ((this.ChannelProps == null && other.ChannelProps == null) || (this.ChannelProps?.Equals(other.ChannelProps) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ChannelProps = {(this.ChannelProps == null ? "null" : this.ChannelProps.ToString())}");
        }
    }
}