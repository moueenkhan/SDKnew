// <copyright file="AlertChannelsCreateSchema.cs" company="APIMatic">
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
    /// AlertChannelsCreateSchema.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsAwsS3CreateSchema), "AwsS3")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsCiscoSparkWebhookCreateSchema), "CiscoSparkWebhook")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsCloudwatchEbCreateSchema), "CloudwatchEb")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsDatadogCreateSchema), "Datadog")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsEmailUserCreateSchema), "EmailUser")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsGcpPubsubCreateSchema), "GcpPubsub")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsIbmQradarCreateSchema), "IbmQradar")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsJiraCreateSchema), "Jira")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsMicrosoftTeamsCreateSchema), "MicrosoftTeams")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsNewRelicInsightsCreateSchema), "NewRelicInsights")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsPagerDutyApiCreateSchema), "PagerDutyApi")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsServiceNowRestCreateSchema), "ServiceNowRest")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsSlackChannelCreateSchema), "SlackChannel")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsSplunkHecCreateSchema), "SplunkHec")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsVictorOpsCreateSchema), "VictorOps")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsWebhookCreateSchema), "Webhook")]
    public class AlertChannelsCreateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertChannelsCreateSchema"/> class.
        /// </summary>
        public AlertChannelsCreateSchema()
        {
            this.Type = "AlertChannels_Create_Schema";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertChannelsCreateSchema"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        public AlertChannelsCreateSchema(
            string type = "AlertChannels_Create_Schema")
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

            return $"AlertChannelsCreateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is AlertChannelsCreateSchema other &&
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