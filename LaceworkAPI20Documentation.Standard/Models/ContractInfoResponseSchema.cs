// <copyright file="ContractInfoResponseSchema.cs" company="APIMatic">
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
    /// ContractInfoResponseSchema.
    /// </summary>
    public class ContractInfoResponseSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractInfoResponseSchema"/> class.
        /// </summary>
        public ContractInfoResponseSchema()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractInfoResponseSchema"/> class.
        /// </summary>
        /// <param name="objName">objName.</param>
        /// <param name="props">props.</param>
        public ContractInfoResponseSchema(
            string objName = null,
            object props = null)
        {
            this.ObjName = objName;
            this.Props = props;
        }

        /// <summary>
        /// Gets or sets ObjName.
        /// </summary>
        [JsonProperty("objName", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjName { get; set; }

        /// <summary>
        /// Gets or sets Props.
        /// </summary>
        [JsonProperty("props", NullValueHandling = NullValueHandling.Ignore)]
        public object Props { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContractInfoResponseSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is ContractInfoResponseSchema other &&
                ((this.ObjName == null && other.ObjName == null) || (this.ObjName?.Equals(other.ObjName) == true)) &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ObjName = {(this.ObjName == null ? "null" : this.ObjName == string.Empty ? "" : this.ObjName)}");
            toStringOutput.Add($"Props = {(this.Props == null ? "null" : this.Props.ToString())}");
        }
    }
}