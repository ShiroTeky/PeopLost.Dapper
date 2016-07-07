using System.ComponentModel;
using System;
using System.Collections.Generic;
using PeopLost.Core.Domain.Pictures;

namespace PeopLost.Core.Domain.Members
{
    public partial class Member:BaseEntity
    {
        public Member()
        {
            this.MemberGuid = Guid.NewGuid();
        }


        /// <summary>
        /// Gets or sets the Member Guid
        /// </summary>
        public Guid MemberGuid { get; set; }

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
        /// Gets or sets the Status of Member:Admin or Not
        /// </summary>
        public bool isAdmin { get; set; }
        
        /// <summary>
        /// Gets or sets the Member picture
        /// </summary>
        public virtual Picture PictureAdmin
        {
            get;
            set;
        }

    }
}
