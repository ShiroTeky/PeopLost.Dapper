using PeopLost.Core.Domain.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopLost.Core.Domain.Maps
{
    public partial class globalGeo:BaseEntity
    {
        private ICollection<PersonPointGeo> _personPointGeos;

        public int PersonId { get; set; }

        public virtual Person Person { get; set; }

        public virtual ICollection<PersonPointGeo> PersonPointGeos
        {
            get { return _personPointGeos ?? (_personPointGeos = new List<PersonPointGeo>()); }
            protected set { _personPointGeos = value; }
        }

    }
}
