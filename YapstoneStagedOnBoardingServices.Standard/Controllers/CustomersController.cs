// <copyright file="CustomersController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YapstoneStagedOnBoardingServices.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Converters;
    using YapstoneStagedOnBoardingServices.Standard;
    using YapstoneStagedOnBoardingServices.Standard.Authentication;
    using YapstoneStagedOnBoardingServices.Standard.Exceptions;
    using YapstoneStagedOnBoardingServices.Standard.Http.Client;
    using YapstoneStagedOnBoardingServices.Standard.Http.Request;
    using YapstoneStagedOnBoardingServices.Standard.Http.Request.Configuration;
    using YapstoneStagedOnBoardingServices.Standard.Http.Response;
    using YapstoneStagedOnBoardingServices.Standard.Utilities;

    /// <summary>
    /// CustomersController.
    /// </summary>
    public class CustomersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal CustomersController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Retrieve all Customers.
        /// </summary>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is `0`..</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve..</param>
        /// <param name="correlationRefLabel">Optional parameter: Filter by `correlationRef.label`..</param>
        /// <param name="correlationRefValue">Optional parameter: Filter by `correlationRef.value`..</param>
        /// <param name="marketplaceId">Optional parameter: Filter by `marketplaceId`..</param>
        /// <param name="merchantId">Optional parameter: Filter by `merchantId`..</param>
        /// <param name="internalUseOnly">Optional parameter: Indicates that internal-use-only fields should be returned..</param>
        /// <returns>Returns the Models.CustomerPage response from the API call.</returns>
        public Models.CustomerPage GetCustomers(
                int? offset = 0,
                int? limit = 20,
                string correlationRefLabel = null,
                string correlationRefValue = null,
                string marketplaceId = null,
                string merchantId = null,
                bool? internalUseOnly = false)
        {
            Task<Models.CustomerPage> t = this.GetCustomersAsync(offset, limit, correlationRefLabel, correlationRefValue, marketplaceId, merchantId, internalUseOnly);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve all Customers.
        /// </summary>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is `0`..</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve..</param>
        /// <param name="correlationRefLabel">Optional parameter: Filter by `correlationRef.label`..</param>
        /// <param name="correlationRefValue">Optional parameter: Filter by `correlationRef.value`..</param>
        /// <param name="marketplaceId">Optional parameter: Filter by `marketplaceId`..</param>
        /// <param name="merchantId">Optional parameter: Filter by `merchantId`..</param>
        /// <param name="internalUseOnly">Optional parameter: Indicates that internal-use-only fields should be returned..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CustomerPage response from the API call.</returns>
        public async Task<Models.CustomerPage> GetCustomersAsync(
                int? offset = 0,
                int? limit = 20,
                string correlationRefLabel = null,
                string correlationRefValue = null,
                string marketplaceId = null,
                string merchantId = null,
                bool? internalUseOnly = false,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "offset", (offset != null) ? offset : 0 },
                { "limit", (limit != null) ? limit : 20 },
                { "correlationRefLabel", correlationRefLabel },
                { "correlationRefValue", correlationRefValue },
                { "marketplaceId", marketplaceId },
                { "merchantId", merchantId },
                { "internalUseOnly", (internalUseOnly != null) ? internalUseOnly : false },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.CustomerPage>(response.Body);
        }

        /// <summary>
        /// Create a Customer.
        /// </summary>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="xYapStoneIdempotentKey">Optional parameter: Example: .</param>
        /// <param name="internalUseOnly">Optional parameter: Indicates that internal-use-only fields should be returned..</param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public Models.Customer CreateCustomer(
                Models.CreateCustomerRequest request,
                string xYapStoneIdempotentKey = null,
                bool? internalUseOnly = false)
        {
            Task<Models.Customer> t = this.CreateCustomerAsync(request, xYapStoneIdempotentKey, internalUseOnly);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a Customer.
        /// </summary>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="xYapStoneIdempotentKey">Optional parameter: Example: .</param>
        /// <param name="internalUseOnly">Optional parameter: Indicates that internal-use-only fields should be returned..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public async Task<Models.Customer> CreateCustomerAsync(
                Models.CreateCustomerRequest request,
                string xYapStoneIdempotentKey = null,
                bool? internalUseOnly = false,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "internalUseOnly", (internalUseOnly != null) ? internalUseOnly : false },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "X-YapStone-IdempotentKey", xYapStoneIdempotentKey },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(request);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            if (response.StatusCode == 409)
            {
                throw new ErrorsException("Conflict", context);
            }

            if (response.StatusCode == 422)
            {
                throw new ErrorsException("Unprocessable Entity", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.Customer>(response.Body);
        }

        /// <summary>
        /// Retrieve a Customer by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="internalUseOnly">Optional parameter: Indicates that internal-use-only fields should be returned..</param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public Models.Customer GetCustomer(
                string id,
                bool? internalUseOnly = false)
        {
            Task<Models.Customer> t = this.GetCustomerAsync(id, internalUseOnly);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a Customer by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="internalUseOnly">Optional parameter: Indicates that internal-use-only fields should be returned..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public async Task<Models.Customer> GetCustomerAsync(
                string id,
                bool? internalUseOnly = false,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "id", id },
            });

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "internalUseOnly", (internalUseOnly != null) ? internalUseOnly : false },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            if (response.StatusCode == 404)
            {
                throw new ErrorsException("Not Found", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.Customer>(response.Body);
        }

        /// <summary>
        /// Update a Customer by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="xYapStoneIdempotentKey">Optional parameter: Example: .</param>
        /// <param name="internalUseOnly">Optional parameter: Indicates that internal-use-only fields should be returned..</param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public Models.Customer UpdateCustomer(
                string id,
                Models.UpdateCustomerRequest request,
                string xYapStoneIdempotentKey = null,
                bool? internalUseOnly = false)
        {
            Task<Models.Customer> t = this.UpdateCustomerAsync(id, request, xYapStoneIdempotentKey, internalUseOnly);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update a Customer by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="xYapStoneIdempotentKey">Optional parameter: Example: .</param>
        /// <param name="internalUseOnly">Optional parameter: Indicates that internal-use-only fields should be returned..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public async Task<Models.Customer> UpdateCustomerAsync(
                string id,
                Models.UpdateCustomerRequest request,
                string xYapStoneIdempotentKey = null,
                bool? internalUseOnly = false,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "id", id },
            });

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "internalUseOnly", (internalUseOnly != null) ? internalUseOnly : false },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "X-YapStone-IdempotentKey", xYapStoneIdempotentKey },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(request);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PutBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            if (response.StatusCode == 404)
            {
                throw new ErrorsException("Not Found", context);
            }

            if (response.StatusCode == 409)
            {
                throw new ErrorsException("Conflict", context);
            }

            if (response.StatusCode == 422)
            {
                throw new ErrorsException("Unprocessable Entity", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.Customer>(response.Body);
        }

        /// <summary>
        /// Delete a Customer by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public Models.Customer DeleteCustomer(
                string id)
        {
            Task<Models.Customer> t = this.DeleteCustomerAsync(id);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Delete a Customer by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public async Task<Models.Customer> DeleteCustomerAsync(
                string id,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "id", id },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Delete(queryBuilder.ToString(), headers, null);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            if (response.StatusCode == 404)
            {
                throw new ErrorsException("Not Found", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.Customer>(response.Body);
        }

        /// <summary>
        /// Perform verification of a Customers supplied details.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public Models.Customer VerifyCustomer(
                string id)
        {
            Task<Models.Customer> t = this.VerifyCustomerAsync(id);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Perform verification of a Customers supplied details.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public async Task<Models.Customer> VerifyCustomerAsync(
                string id,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{id}/verification");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "id", id },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, null);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.Customer>(response.Body);
        }
    }
}