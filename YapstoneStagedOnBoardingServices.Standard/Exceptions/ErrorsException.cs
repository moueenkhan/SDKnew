// <copyright file="ErrorsException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YapstoneStagedOnBoardingServices.Standard.Exceptions
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
    using YapstoneStagedOnBoardingServices.Standard.Http.Client;
    using YapstoneStagedOnBoardingServices.Standard.Models;
    using YapstoneStagedOnBoardingServices.Standard.Utilities;

    /// <summary>
    /// ErrorsException.
    /// </summary>
    public class ErrorsException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorsException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public ErrorsException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets ErrorsProp.
        /// </summary>
        [JsonProperty("errors")]
        public List<Models.Errors1> ErrorsProp { get; set; }
    }
}