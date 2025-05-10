using System;
using System.Collections.Generic;

namespace DesignPattern.Creational.Builder.EmailCampaign
{
    /// <summary>
    /// The Product class represents an email campaign with various settings and configurations
    /// </summary>
    public class EmailCampaign
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public string FromEmail { get; set; }
        public string FromName { get; set; }
        public string TemplateHtml { get; set; }
        public List<string> Recipients { get; set; }
        public Dictionary<string, string> Personalization { get; set; }
        public DateTime ScheduledTime { get; set; }
        public bool TrackOpens { get; set; }
        public bool TrackClicks { get; set; }
        public Dictionary<string, string> Headers { get; set; }

        public override string ToString()
        {
            return $"Campaign: {Name}\n" +
                   $"Subject: {Subject}\n" +
                   $"From: {FromName} <{FromEmail}>\n" +
                   $"Recipients: {Recipients?.Count ?? 0}\n" +
                   $"Scheduled: {ScheduledTime:g}\n" +
                   $"Tracking: Opens={TrackOpens}, Clicks={TrackClicks}";
        }
    }
}
