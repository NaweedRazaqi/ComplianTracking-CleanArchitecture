using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class HeirType
    {
        public HeirType()
        {
            Heir = new HashSet<Heir>();
        }

        public short HeirTypeId { get; set; }
        public string HeirName { get; set; }

        public virtual ICollection<Heir> Heir { get; set; }
    }
}
