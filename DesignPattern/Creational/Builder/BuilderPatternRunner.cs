using System;
using DesignPattern.Core;
using DesignPattern.Creational.Builder.Subscription;
using DesignPattern.Creational.Builder.EmailCampaign;

namespace DesignPattern.Creational.Builder
{
    public class BuilderPatternRunner : DesignPatternRunner
    {
        public override DesignPatternType PatternType => DesignPatternType.Builder;

        protected override void RunPattern()
        {
            // Demonstrate Subscription Plan Builder
            Console.WriteLine("Subscription Plan Builder Demo:\n");
            DemonstrateSubscriptionBuilder();

            Console.WriteLine("\n-------------------\n");

            // Demonstrate Email Campaign Builder
            Console.WriteLine("Email Campaign Builder Demo:\n");
            DemonstrateEmailCampaignBuilder();
        }

        private void DemonstrateSubscriptionBuilder()
        {
            var planBuilder = new SubscriptionPlanBuilder();
            var director = new SubscriptionPlanDirector(planBuilder);

            // Create predefined plans using director
            var freePlan = director.CreateFreePlan();
            Console.WriteLine("Free Plan:");
            Console.WriteLine(freePlan);

            Console.WriteLine();

            var teamPlan = director.CreateTeamPlan();
            Console.WriteLine("Team Plan:");
            Console.WriteLine(teamPlan);

            Console.WriteLine();

            // Create custom plan using builder directly
            var customPlan = new SubscriptionPlanBuilder()
                .SetName("Custom")
                .SetPrice(299.99m)
                .SetUserLimit(50)
                .SetStorageLimit(500)
                .EnableApiAccess(50000)
                .AddFeature("Custom Support")
                .AddFeature("White Labeling")
                .AddCustomSetting("customDomain", "true")
                .Build();

            Console.WriteLine("Custom Plan:");
            Console.WriteLine(customPlan);
        }

        private void DemonstrateEmailCampaignBuilder()
        {
            var campaignBuilder = new EmailCampaignBuilder();
            var director = new EmailCampaignDirector(campaignBuilder);

            // Create predefined campaigns using director
            var welcomeEmail = director.CreateWelcomeEmail();
            Console.WriteLine("Welcome Email Campaign:");
            Console.WriteLine(welcomeEmail);

            Console.WriteLine();

            var newsletter = director.CreateNewsletterCampaign();
            Console.WriteLine("Newsletter Campaign:");
            Console.WriteLine(newsletter);

            Console.WriteLine();

            // Create promotional campaign using director
            var promoEmail = director.CreatePromotionalCampaign("SUMMER2025");
            Console.WriteLine("Promotional Campaign:");
            Console.WriteLine(promoEmail);

            Console.WriteLine();

            // Create custom campaign using builder directly
            var customCampaign = new EmailCampaignBuilder()
                .SetName("Product Launch")
                .SetSubject("Introducing Our New Product!")
                .SetSender("product@company.com", "Product Team")
                .SetTemplate("<h1>Big News!</h1><p>Check out our latest product...</p>")
                .AddRecipient("user1@example.com")
                .AddRecipient("user2@example.com")
                .AddPersonalization("productName", "{{productName}}")
                .EnableTracking()
                .Schedule(DateTime.Now.AddDays(7))
                .Build();

            Console.WriteLine("Custom Campaign:");
            Console.WriteLine(customCampaign);
        }
    }
}
