// <copyright file="Props12.cs" company="APIMatic">
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
    /// Props12.
    /// </summary>
    public class Props12
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Props12"/> class.
        /// </summary>
        public Props12()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Props12"/> class.
        /// </summary>
        /// <param name="containerLabels">containerLabels.</param>
        /// <param name="containerTags">containerTags.</param>
        /// <param name="description">description.</param>
        public Props12(
            List<Models.FormatKey1Value1Key2Value2> containerLabels,
            List<string> containerTags,
            string description = null)
        {
            this.Description = description;
            this.ContainerLabels = containerLabels;
            this.ContainerTags = containerTags;
        }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets ContainerLabels.
        /// </summary>
        [JsonProperty("containerLabels")]
        public List<Models.FormatKey1Value1Key2Value2> ContainerLabels { get; set; }

        /// <summary>
        /// Gets or sets ContainerTags.
        /// </summary>
        [JsonProperty("containerTags")]
        public List<string> ContainerTags { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Props12 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Props12 other &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.ContainerLabels == null && other.ContainerLabels == null) || (this.ContainerLabels?.Equals(other.ContainerLabels) == true)) &&
                ((this.ContainerTags == null && other.ContainerTags == null) || (this.ContainerTags?.Equals(other.ContainerTags) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.ContainerLabels = {(this.ContainerLabels == null ? "null" : $"[{string.Join(", ", this.ContainerLabels)} ]")}");
            toStringOutput.Add($"this.ContainerTags = {(this.ContainerTags == null ? "null" : $"[{string.Join(", ", this.ContainerTags)} ]")}");
        }
    }
}