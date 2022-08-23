namespace Models.Entities
{
    public partial class Subscription
    {
        public Subscription()
        {
            UserSubscriptions = new HashSet<UserSubscription>();
        }

        public int SubscriptionId { get; set; }
        public string SubscriptionName { get; set; } = null!;
        public int ApplicationId { get; set; }
        public double Price { get; set; }

        public virtual Application Application { get; set; } = null!;
        public virtual ICollection<UserSubscription> UserSubscriptions { get; set; }
    }
}
