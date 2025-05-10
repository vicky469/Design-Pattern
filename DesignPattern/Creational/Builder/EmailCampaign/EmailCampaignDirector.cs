using System;

namespace DesignPattern.Creational.Builder.EmailCampaign
{
    /// <summary>
    /// The Director class defines the order in which to execute the building steps, while the
    /// builder provides the implementation for those steps
    /// </summary>
    public class EmailCampaignDirector
    {
        private readonly IEmailCampaignBuilder _builder;

        public EmailCampaignDirector(IEmailCampaignBuilder builder)
        {
            _builder = builder;
        }

        public EmailCampaign CreateWelcomeEmail()
        {
            return _builder
                .SetName("Welcome Campaign")
                .SetSubject("Welcome to Our Service!")
                .SetSender("welcome@company.com", "Company Name")
                .SetTemplate("<h1>Welcome!</h1><p>Thank you for joining us...</p>")
                .AddPersonalization("firstName", "{{firstName}}")
                .EnableTracking()
                .Build();
        }

        public EmailCampaign CreateNewsletterCampaign()
        {
            return _builder
                .SetName("Monthly Newsletter")
                .SetSubject("Your Monthly Update")
                .SetSender("news@company.com", "Company Newsletter")
                .SetTemplate("<h1>Monthly Newsletter</h1><p>Here's what's new...</p>")
                .EnableTracking()
                .Schedule(DateTime.Now.AddDays(1))
                .Build();
        }

        public EmailCampaign CreatePromotionalCampaign(string promoCode)
        {
            return _builder
                .SetName("Special Offer")
                .SetSubject("Limited Time Offer Inside!")
                .SetSender("promotions@company.com", "Special Offers")
                .SetTemplate($"<h1>Special Offer</h1><p>Use code {promoCode} for 20% off!</p>")
                .AddPersonalization("promoCode", promoCode)
                .EnableTracking(true, true)
                .AddHeader("X-Campaign-Type", "promotional")
                .Schedule(DateTime.Now.AddHours(2))
                .Build();
        }
    }
}
