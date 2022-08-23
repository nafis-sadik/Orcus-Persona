namespace Models.Entities
{
    public partial class Referal
    {
        public Referal()
        {
            Rewards = new HashSet<Reward>();
        }

        public int ReferalId { get; set; }
        public string ReferalCode { get; set; } = null!;
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Reward> Rewards { get; set; }
    }
}
