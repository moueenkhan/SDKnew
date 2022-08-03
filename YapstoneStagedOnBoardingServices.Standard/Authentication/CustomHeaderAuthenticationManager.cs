// <copyright file="CustomHeaderAuthenticationManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YapstoneStagedOnBoardingServices.Standard.Authentication
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using YapstoneStagedOnBoardingServices.Standard.Http.Request;

    /// <summary>
    /// CustomHeaderAuthenticationManager Class.
    /// </summary>
    internal class CustomHeaderAuthenticationManager : ICustomHeaderAuthenticationCredentials, IAuthManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomHeaderAuthenticationManager"/> class.
        /// </summary>
        /// <param name="authorization">Authorization.</param>
        public CustomHeaderAuthenticationManager(string authorization)
        {
            this.Authorization = authorization;
        }

        /// <summary>
        /// Gets string value for authorization.
        /// </summary>
        public string Authorization { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="authorization"> The string value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string authorization)
        {
            return authorization.Equals(this.Authorization);
        }

        /// <summary>
        /// Adds authentication to the given HttpRequest.
        /// </summary>
        /// <param name="httpRequest">Http Request.</param>
        /// <returns>Returns the httpRequest after adding authentication.</returns>
        public HttpRequest Apply(HttpRequest httpRequest)
        {
            httpRequest.AddHeaders(new Dictionary<string, string>
            {
                { "Authorization", this.Authorization },
            });
            return httpRequest;
        }

        /// <summary>
        /// Adds authentication to the given HttpRequest.
        /// </summary>
        /// <param name="httpRequest">Http Request.</param>
        /// <returns>Returns the httpRequest after adding authentication.</returns>
        public Task<HttpRequest> ApplyAsync(HttpRequest httpRequest)
        {
            return Task.FromResult(this.Apply(httpRequest));
        }
    }
}