using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class PensionCardTypes
    {
        public PensionCardTypes()
        {
            PensionCards = new HashSet<PensionCards>();
        }

        public short Id { get; set; }
        public string CardType { get; set; }

        public virtual ICollection<PensionCards> PensionCards { get; set; }
    }
}
