

using PeopLost.Core.Domain.Members;
namespace PeopLost.Data.Mapping.Members
{
    public partial class MemberMap:PeopLostEntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            this.HasKey(t => t.Id);
            this.Property(t => t.FirstName).HasMaxLength(30);
            this.Property(t => t.LastName).HasMaxLength(30);
            this.Property(t => t.Gender).HasMaxLength(1);
            this.Property(t => t.Email).HasMaxLength(30);
            this.Property(t => t.Phone).HasMaxLength(30);
            this.Property(t => t.isAdmin);

            this.HasRequired(t => t.PictureAdmin)
                .WithMany()
                .HasForeignKey(t => t.Id);

        }


        

    }
}
