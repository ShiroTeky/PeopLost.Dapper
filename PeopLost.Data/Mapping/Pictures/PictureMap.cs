using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using PeopLost.Core.Domain.Pictures;

namespace PeopLost.Data.Mapping.Pictures
{
    public partial class PictureMap:PeopLostEntityTypeConfiguration<Picture>
    {

        public PictureMap()
        {
            this.HasKey(t => t.Id);
            this.Property(t => t.Binary);
            this.Property(t => t.MimeType);
            ToTable("Pictures");
        }
    }
}
