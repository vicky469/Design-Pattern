using System.Collections.Generic;

namespace DesignPattern.Creational.Builder.Subscription
{
    /// <summary>
    /// The Product class represents a subscription plan with various features and settings
    /// </summary>
    public class SubscriptionPlan
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UserLimit { get; set; }
        public long StorageLimit { get; set; } // in GB
        public bool HasApiAccess { get; set; }
        public int ApiRequestLimit { get; set; }
        public List<string> Features { get; set; }
        public Dictionary<string, string> CustomSettings { get; set; }

        public override string ToString()
        {
            return $"{Name} Plan - ${Price}/month\n" +
                   $"Users: {UserLimit}\n" +
                   $"Storage: {StorageLimit}GB\n" +
                   $"API Access: {(HasApiAccess ? $"Yes ({ApiRequestLimit} requests/month)" : "No")}\n" +
                   $"Features: {string.Join(", ", Features ?? new List<string>())}";
        }
    }
}
