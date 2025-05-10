using System;

namespace DesignPattern.Creational.Builder.EmailCampaign
{
    /// <summary>
    /// The Builder interface declares all possible ways to configure an email campaign
    /// </summary>
    public interface IEmailCampaignBuilder
    {
        IEmailCampaignBuilder SetName(string name);
        IEmailCampaignBuilder SetSubject(string subject);
        IEmailCampaignBuilder SetSender(string email, string name);
        IEmailCampaignBuilder SetTemplate(string html);
        IEmailCampaignBuilder AddRecipient(string email);
        IEmailCampaignBuilder AddPersonalization(string key, string value);
        IEmailCampaignBuilder Schedule(DateTime time);
        IEmailCampaignBuilder EnableTracking(bool opens = true, bool clicks = true);
        IEmailCampaignBuilder AddHeader(string key, string value);
        EmailCampaign Build();
    }
}
