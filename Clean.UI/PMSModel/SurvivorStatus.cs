using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class SurvivorStatus
    {
        public SurvivorStatus()
        {
            Survivor = new HashSet<Survivor>();
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Survivor> Survivor { get; set; }
    }
}
