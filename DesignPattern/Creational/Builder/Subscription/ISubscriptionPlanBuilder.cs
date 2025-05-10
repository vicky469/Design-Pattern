namespace DesignPattern.Creational.Builder.Subscription
{
    /// <summary>
    /// The Builder interface declares all possible ways to configure a subscription plan
    /// </summary>
    public interface ISubscriptionPlanBuilder
    {
        ISubscriptionPlanBuilder SetName(string name);
        ISubscriptionPlanBuilder SetPrice(decimal price);
        ISubscriptionPlanBuilder SetUserLimit(int limit);
        ISubscriptionPlanBuilder SetStorageLimit(long gigabytes);
        ISubscriptionPlanBuilder EnableApiAccess(int requestLimit);
        ISubscriptionPlanBuilder AddFeature(string feature);
        ISubscriptionPlanBuilder AddCustomSetting(string key, string value);
        SubscriptionPlan Build();
    }
}
