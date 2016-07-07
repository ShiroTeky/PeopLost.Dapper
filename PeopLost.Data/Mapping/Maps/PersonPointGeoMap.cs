
using PeopLost.Core.Domain.Maps;
using PeopLost.Core.Domain.Members;
using System;

namespace PeopLost.Data.Mapping.Maps
{
    public partial class PersonPointGeoMap:PeopLostEntityTypeConfiguration<PersonPointGeo>
    {
        public PersonPointGeoMap()
        {
            this.ToTable("PersonPointGeos");
            this.HasKey(t => t.Id);
            this.Property(t => t.Latitude);
            this.Property(t => t.Longitude);

            this.HasRequired(pg => pg.Person)
                .WithMany()
                .HasForeignKey(p=>p.PersonId);

            this.Property(t => t.Town);
            this.Property(t => t.CurrentAddress);
            this.Property(t => t.DateMapping);

            this.HasRequired(pg => pg.Member)
                .WithMany()
                .HasForeignKey(m=> m.MemberId);

        }
    }
}
