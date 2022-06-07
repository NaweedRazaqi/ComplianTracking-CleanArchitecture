using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class AddOnRegulation
    {
        public int AddOnId { get; set; }
        public int RegulationId { get; set; }

        public virtual AddOn AddOn { get; set; }
        public virtual Regulation Regulation { get; set; }
    }
}
