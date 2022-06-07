using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class MaritalStatus
    {
        public MaritalStatus()
        {
            Survivor = new HashSet<Survivor>();
        }

        public short Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Survivor> Survivor { get; set; }
    }
}
