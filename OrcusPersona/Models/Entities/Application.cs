namespace Models.Entities
{
    public partial class Application
    {
        public Application()
        {
            RolePermissions = new HashSet<RolePermission>();
            Subscriptions = new HashSet<Subscription>();
        }

        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; } = null!;

        public virtual ICollection<RolePermission> RolePermissions { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
