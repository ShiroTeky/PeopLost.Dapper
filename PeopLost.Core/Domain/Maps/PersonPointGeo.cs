
using PeopLost.Core.Domain.Members;
using PeopLost.Core.Domain.Persons;
using System;
namespace PeopLost.Core.Domain.Maps
{
    public partial class PersonPointGeo:BaseEntity
    {
        /// <summary>
        /// Gets or sets the people id
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Gets or sets the Member id
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// Gets or sets the current address where user sees him
        /// </summary>
        public string CurrentAddress { get; set; }

        /// <summary>
        /// Gets or sets the longitude
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets the latitude
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the town
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Gets or sets the dateMapping
        /// </summary>
        public DateTime? DateMapping { get; set; }

        /// <summary>
        /// Gets or sets the User
        /// </summary>
        public virtual Member Member { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }
    }
}
