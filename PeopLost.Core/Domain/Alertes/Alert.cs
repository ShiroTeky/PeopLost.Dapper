using PeopLost.Core.Domain.Comments;
using PeopLost.Core.Domain.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopLost.Core.Domain.Alertes
{
    public partial class Alert:BaseEntity
    {

        private ICollection<Comment> _comments;

        public Alert()
        {
        }

        /// <summary>
        /// Gets or sets the post
        /// </summary>
        public string Post { get; set; }

        /// <summary>
        /// Gets or sets the Date of Post
        /// </summary>
        public DateTime? DateAlert { get; set; }

        /// <summary>
        /// Gets or sets the User Id  
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Gets or sets the status of the alert: verified or not
        /// </summary>
        public bool ConcreteAlert { get; set; }

        /// <summary>
        /// Gets or sets the User
        /// </summary>
        public virtual Member Member { get; set; }

        /// <summary>
        /// Gets or sets the collection of the comments of member
        /// </summary>
        public ICollection<Comment> Comments
        {
            get { return _comments ?? (_comments = new List<Comment>()); }
            protected set { _comments = value; }
        }

    }
}
