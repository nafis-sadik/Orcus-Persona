namespace Models.Entities
{
    public partial class User
    {
        public User()
        {
            Referals = new HashSet<Referal>();
            Rewards = new HashSet<Reward>();
            UserSubscriptions = new HashSet<UserSubscription>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public double CreditAmount { get; set; }

        public virtual ICollection<Referal> Referals { get; set; }
        public virtual ICollection<Reward> Rewards { get; set; }
        public virtual ICollection<UserSubscription> UserSubscriptions { get; set; }
    }
}
