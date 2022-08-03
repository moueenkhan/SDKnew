// <copyright file="ICustomHeaderAuthenticationCredentials.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YapstoneStagedOnBoardingServices.Standard.Authentication
{
    using System;

    public interface ICustomHeaderAuthenticationCredentials
    {
        /// <summary>
        /// Gets string value for authorization.
        /// </summary>
        string Authorization { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="authorization"> The string value for credentials.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string authorization);
    }
}