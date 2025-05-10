using System.Collections.Generic;

namespace DesignPattern.Creational.Builder.Subscription
{
    /// <summary>
    /// The Concrete Builder implements the Builder interface and provides
    /// specific implementations for the building steps
    /// </summary>
    public class SubscriptionPlanBuilder : ISubscriptionPlanBuilder
    {
        private readonly SubscriptionPlan _plan = new();

        public ISubscriptionPlanBuilder SetName(string name)
        {
            _plan.Name = name;
            return this;
        }

        public ISubscriptionPlanBuilder SetPrice(decimal price)
        {
            _plan.Price = price;
            return this;
        }

        public ISubscriptionPlanBuilder SetUserLimit(int limit)
        {
            _plan.UserLimit = limit;
            return this;
        }

        public ISubscriptionPlanBuilder SetStorageLimit(long gigabytes)
        {
            _plan.StorageLimit = gigabytes;
            return this;
        }

        public ISubscriptionPlanBuilder EnableApiAccess(int requestLimit)
        {
            _plan.HasApiAccess = true;
            _plan.ApiRequestLimit = requestLimit;
            return this;
        }

        public ISubscriptionPlanBuilder AddFeature(string feature)
        {
            _plan.Features ??= new List<string>();
            _plan.Features.Add(feature);
            return this;
        }

        public ISubscriptionPlanBuilder AddCustomSetting(string key, string value)
        {
            _plan.CustomSettings ??= new Dictionary<string, string>();
            _plan.CustomSettings[key] = value;
            return this;
        }

        public SubscriptionPlan Build() => _plan;
    }
}
