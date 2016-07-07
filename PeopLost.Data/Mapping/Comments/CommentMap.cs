

using PeopLost.Core.Domain.Comments;
namespace PeopLost.Data.Mapping.Comments
{
    public partial class CommentMap: PeopLostEntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            this.HasKey(t => t.Id);

            this.Property(t => t.Post);

            this.Property(t => t.DatePost);

            this.HasRequired(m => m.Member)
                .WithMany()
                .HasForeignKey(m => m.MemberId);

            this.HasRequired(m => m.Alert)
                .WithMany()
                .HasForeignKey(m => m.AlertId);
        }

        
    }
}
