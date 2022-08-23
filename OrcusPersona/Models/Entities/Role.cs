namespace Models.Entities
{
    public partial class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;

        public virtual RolePermission RolePermission { get; set; } = null!;
    }
}
