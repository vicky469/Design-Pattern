namespace DesignPattern.Creational.Builder.Subscription
{
    /// <summary>
    /// The Director class defines the order in which to execute the building steps, while the
    /// builder provides the implementation for those steps
    /// </summary>
    public class SubscriptionPlanDirector
    {
        private readonly ISubscriptionPlanBuilder _builder;

        public SubscriptionPlanDirector(ISubscriptionPlanBuilder builder)
        {
            _builder = builder;
        }

        public SubscriptionPlan CreateFreePlan()
        {
            return _builder
                .SetName("Free")
                .SetPrice(0)
                .SetUserLimit(5)
                .SetStorageLimit(10)
                .AddFeature("Basic Support")
                .AddFeature("Core Features")
                .Build();
        }

        public SubscriptionPlan CreateTeamPlan()
        {
            return _builder
                .SetName("Team")
                .SetPrice(49.99m)
                .SetUserLimit(25)
                .SetStorageLimit(100)
                .EnableApiAccess(10000)
                .AddFeature("Priority Support")
                .AddFeature("Advanced Features")
                .AddFeature("Team Collaboration")
                .AddFeature("Analytics")
                .Build();
        }

        public SubscriptionPlan CreateEnterprisePlan()
        {
            return _builder
                .SetName("Enterprise")
                .SetPrice(199.99m)
                .SetUserLimit(100)
                .SetStorageLimit(1000)
                .EnableApiAccess(1000000)
                .AddFeature("24/7 Support")
                .AddFeature("All Features")
                .AddFeature("Custom Integrations")
                .AddFeature("Advanced Security")
                .AddFeature("SLA Guarantee")
                .Build();
        }
    }
}
