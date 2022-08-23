namespace Models.Entities
{
    public partial class Reward
    {
        public int RewardId { get; set; }
        public int RewardTo { get; set; }
        public DateTime RewardDate { get; set; }
        public string RewardDescription { get; set; } = null!;
        public int ReferalId { get; set; }
        public double RewardAmount { get; set; }

        public virtual Referal Referal { get; set; } = null!;
        public virtual User RewardToNavigation { get; set; } = null!;
    }
}
