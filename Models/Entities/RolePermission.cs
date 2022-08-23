namespace Models.Entities
{
    public partial class RolePermission
    {
        public int PermissionId { get; set; }
        public int RoleId { get; set; }
        public string Route { get; set; } = null!;
        public int ApplicationId { get; set; }

        public virtual Application Application { get; set; } = null!;
        public virtual Role Permission { get; set; } = null!;
    }
}
