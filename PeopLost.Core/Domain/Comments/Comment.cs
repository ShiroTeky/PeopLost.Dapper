using PeopLost.Core.Domain.Alertes;
using PeopLost.Core.Domain.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopLost.Core.Domain.Comments
{
    public partial class Comment:BaseEntity
    {
        public Comment()
        {
        }

        /// <summary>
        /// Gets or sets the post
        /// </summary>
        public string Post { get; set; }

        /// <summary>
        /// Gets or sets the Date of Post
        /// </summary>
        public DateTime? DatePost { get; set; }

        /// <summary>
        /// Gets or sets the Alert Id
        /// </summary>
        public int AlertId { get; set; }

        /// <summary>
        /// Gets or sets the Member Id
        /// </summary>
        public int MemberId { get; set; }
        // Add the Alert Here ; public virtual Alerte
        public virtual Alert Alert { get; set; } 

        // Add the Member Here; public virtual Member
        public virtual Member Member { get; set; }
    }
}
