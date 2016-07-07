using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using PeopLost.Core.Domain.Persons;


namespace PeopLost.Data.Mapping.Persons
{
    public partial class PersonMap:PeopLostEntityTypeConfiguration<Person>
    {

        public PersonMap()
        {
            this.ToTable("Persons");
            this.HasKey(t => t.Id);
            this.Property(t => t.FirstName).HasMaxLength(30);
            this.Property(t => t.LastName).HasMaxLength(30);
            this.Property(t => t.Gender).HasMaxLength(1);
            this.Property(t => t.Country).HasMaxLength(30);
            this.Property(t => t.City).HasMaxLength(30);
            this.Property(t => t.LooserAddress).HasMaxLength(50);
            this.Property(t => t.YearsOld).IsOptional();
            this.Property(t => t.Caracteristics).HasMaxLength(200);
            this.Property(t => t.DayDisappear);

        }

    }
}
