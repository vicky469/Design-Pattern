using System;
using System.Collections.Generic;

namespace DesignPattern.Creational.Builder.EmailCampaign
{
    /// <summary>
    /// The Concrete Builder implements the Builder interface and provides
    /// specific implementations for the building steps
    /// </summary>
    public class EmailCampaignBuilder : IEmailCampaignBuilder
    {
        private readonly EmailCampaign _campaign = new();

        public IEmailCampaignBuilder SetName(string name)
        {
            _campaign.Name = name;
            return this;
        }

        public IEmailCampaignBuilder SetSubject(string subject)
        {
            _campaign.Subject = subject;
            return this;
        }

        public IEmailCampaignBuilder SetSender(string email, string name)
        {
            _campaign.FromEmail = email;
            _campaign.FromName = name;
            return this;
        }

        public IEmailCampaignBuilder SetTemplate(string html)
        {
            _campaign.TemplateHtml = html;
            return this;
        }

        public IEmailCampaignBuilder AddRecipient(string email)
        {
            _campaign.Recipients ??= new List<string>();
            _campaign.Recipients.Add(email);
            return this;
        }

        public IEmailCampaignBuilder AddPersonalization(string key, string value)
        {
            _campaign.Personalization ??= new Dictionary<string, string>();
            _campaign.Personalization[key] = value;
            return this;
        }

        public IEmailCampaignBuilder Schedule(DateTime time)
        {
            _campaign.ScheduledTime = time;
            return this;
        }

        public IEmailCampaignBuilder EnableTracking(bool opens = true, bool clicks = true)
        {
            _campaign.TrackOpens = opens;
            _campaign.TrackClicks = clicks;
            return this;
        }

        public IEmailCampaignBuilder AddHeader(string key, string value)
        {
            _campaign.Headers ??= new Dictionary<string, string>();
            _campaign.Headers[key] = value;
            return this;
        }

        public EmailCampaign Build() => _campaign;
    }
}
