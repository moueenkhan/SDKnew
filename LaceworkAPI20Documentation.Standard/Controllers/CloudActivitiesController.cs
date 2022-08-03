// <copyright file="CloudActivitiesController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace LaceworkAPI20Documentation.Standard.Controllers
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
    using LaceworkAPI20Documentation.Standard;
    using LaceworkAPI20Documentation.Standard.Authentication;
    using LaceworkAPI20Documentation.Standard.Exceptions;
    using LaceworkAPI20Documentation.Standard.Http.Client;
    using LaceworkAPI20Documentation.Standard.Http.Request;
    using LaceworkAPI20Documentation.Standard.Http.Request.Configuration;
    using LaceworkAPI20Documentation.Standard.Http.Response;
    using LaceworkAPI20Documentation.Standard.Utilities;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CloudActivitiesController.
    /// </summary>
    public class CloudActivitiesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudActivitiesController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal CloudActivitiesController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Get cloud activities details by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/CloudActivities` .
        ///  Optionally filter by specifying the `startTime` and `endTime` of a time range using the following formats:.
        ///   * `yyyy-MM-dd` for example, `2020-12-18` .
        ///   * `yyyy-MM-ddTHH` for example, `2020-12-18T08` .
        ///   * `yyyy-MM-ddTHH:mm:ssZ` for example, `2020-12-18T08:00:00Z` .
        ///   * `yyyy-MM-ddTHH:mm:ss.SSSZ` for example, `2020-12-18T08:00:00.000Z` .
        ///   Here is an example invocation: .
        ///   > `GET https://YourLacework.lacework.net/api/v2/CloudActivities?startTime=2020-12-11T08:00:00Z&endTime=2020-12-18T08:00:00Z`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="startTime">Optional parameter: Start time.</param>
        /// <param name="endTime">Optional parameter: End time.</param>
        /// <returns>Returns the Models.ResponseCloudActivitiesList response from the API call.</returns>
        public Models.ResponseCloudActivitiesList CloudActivities(
                string authorization,
                string contentType,
                string startTime = null,
                string endTime = null)
        {
            Task<Models.ResponseCloudActivitiesList> t = this.CloudActivitiesAsync(authorization, contentType, startTime, endTime);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get cloud activities details by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/CloudActivities` .
        ///  Optionally filter by specifying the `startTime` and `endTime` of a time range using the following formats:.
        ///   * `yyyy-MM-dd` for example, `2020-12-18` .
        ///   * `yyyy-MM-ddTHH` for example, `2020-12-18T08` .
        ///   * `yyyy-MM-ddTHH:mm:ssZ` for example, `2020-12-18T08:00:00Z` .
        ///   * `yyyy-MM-ddTHH:mm:ss.SSSZ` for example, `2020-12-18T08:00:00.000Z` .
        ///   Here is an example invocation: .
        ///   > `GET https://YourLacework.lacework.net/api/v2/CloudActivities?startTime=2020-12-11T08:00:00Z&endTime=2020-12-18T08:00:00Z`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="startTime">Optional parameter: Start time.</param>
        /// <param name="endTime">Optional parameter: End time.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseCloudActivitiesList response from the API call.</returns>
        public async Task<Models.ResponseCloudActivitiesList> CloudActivitiesAsync(
                string authorization,
                string contentType,
                string startTime = null,
                string endTime = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/CloudActivities");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "startTime", startTime },
                { "endTime", endTime },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Authorization", authorization },
                { "Content-Type", contentType },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            if (response.StatusCode == 400)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 401)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 402)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 403)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 404)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 405)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 406)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 407)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 408)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 409)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 410)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 411)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 412)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 413)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 414)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 415)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 416)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 417)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 418)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 419)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 420)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 421)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 422)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 423)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 424)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 425)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 426)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 427)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 428)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 429)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 430)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 431)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 432)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 433)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 434)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 435)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 436)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 437)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 438)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 439)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 440)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 441)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 442)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 443)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 444)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 445)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 446)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 447)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 448)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 449)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 450)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 451)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 452)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 453)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 454)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 455)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 456)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 457)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 458)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 459)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 460)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 461)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 462)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 463)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 464)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 465)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 466)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 467)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 468)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 469)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 470)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 471)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 472)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 473)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 474)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 475)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 476)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 477)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 478)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 479)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 480)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 481)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 482)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 483)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 484)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 485)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 486)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 487)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 488)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 489)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 490)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 491)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 492)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 493)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 494)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 495)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 496)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 497)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 498)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 499)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 501)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 502)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 503)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 504)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 505)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 506)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 507)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 508)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 509)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 510)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 511)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 512)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 513)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 514)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 515)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 516)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 517)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 518)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 519)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 520)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 521)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 522)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 523)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 524)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 525)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 526)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 527)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 528)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 529)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 530)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 531)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 532)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 533)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 534)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 535)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 536)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 537)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 538)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 539)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 540)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 541)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 542)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 543)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 544)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 545)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 546)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 547)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 548)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 549)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 550)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 551)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 552)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 553)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 554)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 555)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 556)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 557)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 558)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 559)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 560)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 561)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 562)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 563)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 564)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 565)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 566)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 567)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 568)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 569)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 570)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 571)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 572)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 573)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 574)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 575)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 576)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 577)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 578)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 579)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 580)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 581)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 582)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 583)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 584)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 585)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 586)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 587)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 588)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 589)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 590)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 591)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 592)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 593)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 594)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 595)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 596)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 597)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 598)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 599)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ResponseCloudActivitiesList>(response.Body);
        }

        /// <summary>
        /// Search cloud activities by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/CloudActivities/search` .
        ///   Filters can be optionally specified in the request body. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).
        ///   For the `timeFilter` filter, these are the supported time formats:.
        ///   * `yyyy-MM-dd` for example, `2020-12-18` .
        ///   * `yyyy-MM-ddTHH` for example, `2020-12-18T08` .
        ///   * `yyyy-MM-ddTHH:mm:ssZ` for example, `2020-12-18T08:00:00Z` .
        ///   * `yyyy-MM-ddTHH:mm:ss.SSSZ` for example, `2020-12-18T08:00:00.000Z`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseCloudActivitiesList response from the API call.</returns>
        public Models.ResponseCloudActivitiesList SearchCloudActivities(
                string authorization,
                Models.GETDATAREQUESTBODYTIMEFILTERS body)
        {
            Task<Models.ResponseCloudActivitiesList> t = this.SearchCloudActivitiesAsync(authorization, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Search cloud activities by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/CloudActivities/search` .
        ///   Filters can be optionally specified in the request body. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).
        ///   For the `timeFilter` filter, these are the supported time formats:.
        ///   * `yyyy-MM-dd` for example, `2020-12-18` .
        ///   * `yyyy-MM-ddTHH` for example, `2020-12-18T08` .
        ///   * `yyyy-MM-ddTHH:mm:ssZ` for example, `2020-12-18T08:00:00Z` .
        ///   * `yyyy-MM-ddTHH:mm:ss.SSSZ` for example, `2020-12-18T08:00:00.000Z`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseCloudActivitiesList response from the API call.</returns>
        public async Task<Models.ResponseCloudActivitiesList> SearchCloudActivitiesAsync(
                string authorization,
                Models.GETDATAREQUESTBODYTIMEFILTERS body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/CloudActivities/search");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Authorization", authorization },
                { "Content-Type", "application/json" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            if (response.StatusCode == 400)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 401)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 402)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 403)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 404)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 405)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 406)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 407)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 408)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 409)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 410)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 411)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 412)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 413)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 414)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 415)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 416)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 417)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 418)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 419)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 420)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 421)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 422)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 423)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 424)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 425)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 426)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 427)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 428)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 429)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 430)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 431)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 432)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 433)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 434)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 435)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 436)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 437)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 438)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 439)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 440)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 441)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 442)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 443)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 444)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 445)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 446)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 447)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 448)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 449)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 450)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 451)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 452)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 453)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 454)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 455)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 456)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 457)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 458)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 459)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 460)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 461)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 462)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 463)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 464)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 465)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 466)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 467)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 468)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 469)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 470)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 471)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 472)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 473)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 474)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 475)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 476)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 477)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 478)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 479)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 480)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 481)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 482)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 483)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 484)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 485)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 486)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 487)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 488)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 489)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 490)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 491)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 492)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 493)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 494)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 495)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 496)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 497)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 498)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 499)
            {
                throw new Response4XXException("Client Error", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 501)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 502)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 503)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 504)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 505)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 506)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 507)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 508)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 509)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 510)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 511)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 512)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 513)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 514)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 515)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 516)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 517)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 518)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 519)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 520)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 521)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 522)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 523)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 524)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 525)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 526)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 527)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 528)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 529)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 530)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 531)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 532)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 533)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 534)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 535)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 536)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 537)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 538)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 539)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 540)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 541)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 542)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 543)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 544)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 545)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 546)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 547)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 548)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 549)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 550)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 551)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 552)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 553)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 554)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 555)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 556)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 557)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 558)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 559)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 560)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 561)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 562)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 563)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 564)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 565)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 566)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 567)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 568)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 569)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 570)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 571)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 572)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 573)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 574)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 575)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 576)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 577)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 578)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 579)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 580)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 581)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 582)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 583)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 584)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 585)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 586)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 587)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 588)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 589)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 590)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 591)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 592)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 593)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 594)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 595)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 596)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 597)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 598)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            if (response.StatusCode == 599)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ResponseCloudActivitiesList>(response.Body);
        }
    }
}