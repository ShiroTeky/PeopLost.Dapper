

using PeopLost.Core.Domain.Maps;
namespace PeopLost.Data.Mapping.Maps
{
    public partial class globalGeoMap: PeopLostEntityTypeConfiguration<globalGeo>
    {
        public globalGeoMap()
        {
            this.ToTable("GlobalGeos");
            this.HasKey(t => t.Id);

            this.HasMany(p => p.PersonPointGeos);

            this.HasRequired(g => g.Person)
                .WithMany()
                .HasForeignKey(g => g.PersonId);
        }
    }
}
