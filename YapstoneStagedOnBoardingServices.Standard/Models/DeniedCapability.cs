// <copyright file="DeniedCapability.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YapstoneStagedOnBoardingServices.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using YapstoneStagedOnBoardingServices.Standard;
    using YapstoneStagedOnBoardingServices.Standard.Utilities;

    /// <summary>
    /// DeniedCapability.
    /// </summary>
    public class DeniedCapability
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeniedCapability"/> class.
        /// </summary>
        public DeniedCapability()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeniedCapability"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="reasons">reasons.</param>
        /// <param name="requiredActions">requiredActions.</param>
        public DeniedCapability(
            string type,
            List<string> reasons = null,
            object requiredActions = null)
        {
            this.Type = type;
            this.Reasons = reasons;
            this.RequiredActions = requiredActions;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Reasons.
        /// </summary>
        [JsonProperty("reasons", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Reasons { get; set; }

        /// <summary>
        /// Gets or sets RequiredActions.
        /// </summary>
        [JsonProperty("requiredActions", NullValueHandling = NullValueHandling.Ignore)]
        public object RequiredActions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeniedCapability : ({string.Join(", ", toStringOutput)})";
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

            return obj is DeniedCapability other &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Reasons == null && other.Reasons == null) || (this.Reasons?.Equals(other.Reasons) == true)) &&
                ((this.RequiredActions == null && other.RequiredActions == null) || (this.RequiredActions?.Equals(other.RequiredActions) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Reasons = {(this.Reasons == null ? "null" : $"[{string.Join(", ", this.Reasons)} ]")}");
            toStringOutput.Add($"RequiredActions = {(this.RequiredActions == null ? "null" : this.RequiredActions.ToString())}");
        }
    }
}