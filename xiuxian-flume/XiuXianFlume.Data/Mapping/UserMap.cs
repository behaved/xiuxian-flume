using XiuXianFlume.Core.Domain;

namespace XiuXianFlume.Data.Mapping
{
    public partial class UserMap : XiuXianEntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.ToTable("User");
            this.HasKey(p => p.Id);
            this.Property(p => p.Name).IsRequired().HasMaxLength(50);
            this.Property(p => p.Password).IsRequired().HasMaxLength(50);
            this.Property(p => p.Phone).IsRequired().HasMaxLength(50);
            this.Property(p => p.Remark).IsRequired().HasMaxLength(400);
        }
    }
}