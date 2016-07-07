using PeopLost.Core.Domain.Pictures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopLost.Core.Domain.Administrators
{
    public partial class Administrator:BaseEntity
    {

        public Administrator()
        {
            this.AdminGuid = Guid.NewGuid();
        }

        /// <summary>
        /// Gets or sets the customer Guid
        /// </summary>
        public Guid AdminGuid { get; set; }


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
        /// Gets or sets the Member Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the Member Contact
        /// </summary>
        public string Phone { get; set; }

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
        /// Gets or sets the admin picture
        /// </summary>
        public virtual Picture PictureAdmin
        {
            get;
            set;
        }
    }
}
