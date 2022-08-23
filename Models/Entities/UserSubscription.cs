namespace Models.Entities
{
    public partial class UserSubscription
    {
        public int UserId { get; set; }
        public int SubscriptionId { get; set; }
        public int UserSubscriptionId { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public DateTime ExpireDate { get; set; }

        public virtual Subscription Subscription { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
