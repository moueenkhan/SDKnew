// <copyright file="AlertChannelsResponseSchema.cs" company="APIMatic">
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
    /// AlertChannelsResponseSchema.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsAwsS3ResponseSchema), "AwsS3")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsCiscoSparkWebhookResponseSchema), "CiscoSparkWebhook")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsCloudwatchEbResponseSchema), "CloudwatchEb")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsDatadogResponseSchema), "Datadog")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsEmailUserResponseSchema), "EmailUser")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsGcpPubsubResponseSchema), "GcpPubsub")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsIbmQradarResponseSchema), "IbmQradar")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsJiraResponseSchema), "Jira")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsMicrosoftTeamsResponseSchema), "MicrosoftTeams")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsNewRelicInsightsResponseSchema), "NewRelicInsights")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsPagerDutyApiResponseSchema), "PagerDutyApi")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsServiceNowRestResponseSchema), "ServiceNowRest")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsSlackChannelResponseSchema), "SlackChannel")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsSplunkHecResponseSchema), "SplunkHec")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsVictorOpsResponseSchema), "VictorOps")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsWebhookResponseSchema), "Webhook")]
    public class AlertChannelsResponseSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertChannelsResponseSchema"/> class.
        /// </summary>
        public AlertChannelsResponseSchema()
        {
            this.Type = "AlertChannels_Response_Schema";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertChannelsResponseSchema"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        public AlertChannelsResponseSchema(
            string type = "AlertChannels_Response_Schema")
        {
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AlertChannelsResponseSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is AlertChannelsResponseSchema other &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
        }
    }
}