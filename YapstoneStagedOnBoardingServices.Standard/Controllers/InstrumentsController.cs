// <copyright file="InstrumentsController.cs" company="APIMatic">
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
    /// InstrumentsController.
    /// </summary>
    public class InstrumentsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentsController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal InstrumentsController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Retrieve all Instruments.
        /// </summary>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is `0`..</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve..</param>
        /// <param name="marketplaceId">Optional parameter: Filter by `marketplaceId`..</param>
        /// <param name="merchantId">Optional parameter: Filter by `merchantId`..</param>
        /// <param name="customerId">Optional parameter: Filter by `customerId`..</param>
        /// <param name="correlationRefLabel">Optional parameter: Filter by `correlationRef.label`..</param>
        /// <param name="correlationRefValue">Optional parameter: Filter by `correlationRef.value`..</param>
        /// <param name="internalUseOnly">Optional parameter: Indicates that internal-use-only fields should be returned..</param>
        /// <returns>Returns the Models.InstrumentPage response from the API call.</returns>
        public Models.InstrumentPage GetInstruments(
                int? offset = 0,
                int? limit = 20,
                string marketplaceId = null,
                string merchantId = null,
                string customerId = null,
                string correlationRefLabel = null,
                string correlationRefValue = null,
                bool? internalUseOnly = false)
        {
            Task<Models.InstrumentPage> t = this.GetInstrumentsAsync(offset, limit, marketplaceId, merchantId, customerId, correlationRefLabel, correlationRefValue, internalUseOnly);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve all Instruments.
        /// </summary>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is `0`..</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve..</param>
        /// <param name="marketplaceId">Optional parameter: Filter by `marketplaceId`..</param>
        /// <param name="merchantId">Optional parameter: Filter by `merchantId`..</param>
        /// <param name="customerId">Optional parameter: Filter by `customerId`..</param>
        /// <param name="correlationRefLabel">Optional parameter: Filter by `correlationRef.label`..</param>
        /// <param name="correlationRefValue">Optional parameter: Filter by `correlationRef.value`..</param>
        /// <param name="internalUseOnly">Optional parameter: Indicates that internal-use-only fields should be returned..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InstrumentPage response from the API call.</returns>
        public async Task<Models.InstrumentPage> GetInstrumentsAsync(
                int? offset = 0,
                int? limit = 20,
                string marketplaceId = null,
                string merchantId = null,
                string customerId = null,
                string correlationRefLabel = null,
                string correlationRefValue = null,
                bool? internalUseOnly = false,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/instruments");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "offset", (offset != null) ? offset : 0 },
                { "limit", (limit != null) ? limit : 20 },
                { "marketplaceId", marketplaceId },
                { "merchantId", merchantId },
                { "customerId", customerId },
                { "correlationRefLabel", correlationRefLabel },
                { "correlationRefValue", correlationRefValue },
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

            if (response.StatusCode == 400)
            {
                throw new ErrorsException("Bad Request", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.InstrumentPage>(response.Body);
        }

        /// <summary>
        /// Create an Instrument.
        /// </summary>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="xYapStoneIdempotentKey">Optional parameter: Example: .</param>
        /// <param name="internalUseOnly">Optional parameter: Indicates that internal-use-only fields should be returned..</param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public Models.Instrument CreateInstrument(
                Models.CreateInstrumentRequest request,
                string xYapStoneIdempotentKey = null,
                bool? internalUseOnly = false)
        {
            Task<Models.Instrument> t = this.CreateInstrumentAsync(request, xYapStoneIdempotentKey, internalUseOnly);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create an Instrument.
        /// </summary>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="xYapStoneIdempotentKey">Optional parameter: Example: .</param>
        /// <param name="internalUseOnly">Optional parameter: Indicates that internal-use-only fields should be returned..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public async Task<Models.Instrument> CreateInstrumentAsync(
                Models.CreateInstrumentRequest request,
                string xYapStoneIdempotentKey = null,
                bool? internalUseOnly = false,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/instruments");

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

            return ApiHelper.JsonDeserialize<Models.Instrument>(response.Body);
        }

        /// <summary>
        /// Retrieve an Instrument by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="internalUseOnly">Optional parameter: Indicates that internal-use-only fields should be returned..</param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public Models.Instrument GetInstrument(
                string id,
                bool? internalUseOnly = false)
        {
            Task<Models.Instrument> t = this.GetInstrumentAsync(id, internalUseOnly);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve an Instrument by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="internalUseOnly">Optional parameter: Indicates that internal-use-only fields should be returned..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public async Task<Models.Instrument> GetInstrumentAsync(
                string id,
                bool? internalUseOnly = false,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/instruments/{id}");

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

            return ApiHelper.JsonDeserialize<Models.Instrument>(response.Body);
        }

        /// <summary>
        /// Update an Instrument by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="xYapStoneIdempotentKey">Optional parameter: Example: .</param>
        /// <param name="internalUseOnly">Optional parameter: Indicates that internal-use-only fields should be returned..</param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public Models.Instrument UpdateInstrument(
                string id,
                Models.UpdateInstrumentRequest request,
                string xYapStoneIdempotentKey = null,
                bool? internalUseOnly = false)
        {
            Task<Models.Instrument> t = this.UpdateInstrumentAsync(id, request, xYapStoneIdempotentKey, internalUseOnly);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update an Instrument by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="xYapStoneIdempotentKey">Optional parameter: Example: .</param>
        /// <param name="internalUseOnly">Optional parameter: Indicates that internal-use-only fields should be returned..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public async Task<Models.Instrument> UpdateInstrumentAsync(
                string id,
                Models.UpdateInstrumentRequest request,
                string xYapStoneIdempotentKey = null,
                bool? internalUseOnly = false,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/instruments/{id}");

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

            return ApiHelper.JsonDeserialize<Models.Instrument>(response.Body);
        }

        /// <summary>
        /// Delete an Instrument by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public Models.Instrument DeleteInstrument(
                string id)
        {
            Task<Models.Instrument> t = this.DeleteInstrumentAsync(id);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Delete an Instrument by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public async Task<Models.Instrument> DeleteInstrumentAsync(
                string id,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/instruments/{id}");

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

            return ApiHelper.JsonDeserialize<Models.Instrument>(response.Body);
        }

        /// <summary>
        /// Request verification of an Instrument by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public Models.Instrument VerifyInstrument(
                string id,
                Models.VerifyInstrumentRequest request)
        {
            Task<Models.Instrument> t = this.VerifyInstrumentAsync(id, request);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Request verification of an Instrument by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public async Task<Models.Instrument> VerifyInstrumentAsync(
                string id,
                Models.VerifyInstrumentRequest request,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/instruments/{id}/verification");

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
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(request);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

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

            return ApiHelper.JsonDeserialize<Models.Instrument>(response.Body);
        }
    }
}