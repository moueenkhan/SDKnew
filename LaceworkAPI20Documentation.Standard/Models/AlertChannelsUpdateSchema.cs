// <copyright file="AlertChannelsUpdateSchema.cs" company="APIMatic">
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
    /// AlertChannelsUpdateSchema.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsAwsS3UpdateSchema), "AwsS3")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsCiscoSparkWebhookUpdateSchema), "CiscoSparkWebhook")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsCloudwatchEbUpdateSchema), "CloudwatchEb")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsDatadogUpdateSchema), "Datadog")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsEmailUserUpdateSchema), "EmailUser")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsGcpPubsubUpdateSchema), "GcpPubsub")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsIbmQradarUpdateSchema), "IbmQradar")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsJiraUpdateSchema), "Jira")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsMicrosoftTeamsUpdateSchema), "MicrosoftTeams")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsNewRelicInsightsUpdateSchema), "NewRelicInsights")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsPagerDutyApiUpdateSchema), "PagerDutyApi")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsServiceNowRestUpdateSchema), "ServiceNowRest")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsSlackChannelUpdateSchema), "SlackChannel")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsSplunkHecUpdateSchema), "SplunkHec")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsVictorOpsUpdateSchema), "VictorOps")]
    [JsonSubtypes.KnownSubType(typeof(AlertChannelsWebhookUpdateSchema), "Webhook")]
    public class AlertChannelsUpdateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertChannelsUpdateSchema"/> class.
        /// </summary>
        public AlertChannelsUpdateSchema()
        {
            this.Type = "AlertChannels_Update_Schema";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertChannelsUpdateSchema"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        public AlertChannelsUpdateSchema(
            string type = "AlertChannels_Update_Schema")
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

            return $"AlertChannelsUpdateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is AlertChannelsUpdateSchema other &&
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