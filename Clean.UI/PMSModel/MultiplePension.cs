using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class MultiplePension
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int HeirId { get; set; }
        public bool SelfPension { get; set; }

        public virtual Heir Heir { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
