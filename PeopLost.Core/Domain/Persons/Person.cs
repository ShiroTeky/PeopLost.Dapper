using System.ComponentModel;
using System;
using System.Collections.Generic;
using PeopLost.Core.Domain.Pictures;
using PeopLost.Core.Domain.Maps;


namespace PeopLost.Core.Domain.Persons
{
    public partial class Person:BaseEntity
    {
        private ICollection<Picture> _personPictures;
        private ICollection<PersonPointGeo> _personPointGeos;

        public Person()
        {
            this.PersonGuid = Guid.NewGuid();

        }
        /// <summary>
        /// Gets or sets the Person Guid
        /// </summary>
        public Guid PersonGuid { get; set; }

        /// <summary>
        /// Gets or sets the firstname
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the lastname
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the day disappear
        /// </summary>
        public DateTime DayDisappear { get; set; }

        /// <summary>
        /// Gets or sets the address where he disappear
        /// </summary>
        public string LooserAddress { get; set; }

        /// <summary>
        /// Gets or sets the country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the year old
        /// </summary>
        public int YearsOld { get; set; }

        /// <summary>
        /// Gets or sets the caracteristics
        /// </summary>
        public string Caracteristics { get; set; }

        /// <summary>
        /// Gets or sets the gallery of picture load by member 
        /// </summary>
        public ICollection<Picture> PersonPictures
        {
            get { return _personPictures ?? (_personPictures = new List<Picture>()); }
            protected set { _personPictures= value; }
        }

        /// <summary>
        /// Gets or sets the collection of the different locations of this people
        /// </summary>
        public globalGeo GlobalGeo {
            get;set;
             
        }
    }
}
