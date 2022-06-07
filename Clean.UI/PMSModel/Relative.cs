using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Relative
    {
        public Relative()
        {
            Heir = new HashSet<Heir>();
            Survivor = new HashSet<Survivor>();
            UserDetails = new HashSet<UserDetails>();
        }

        public short RelativeId { get; set; }
        public string Identifier { get; set; }
        public string Category { get; set; }

        public virtual ICollection<Heir> Heir { get; set; }
        public virtual ICollection<Survivor> Survivor { get; set; }
        public virtual ICollection<UserDetails> UserDetails { get; set; }
    }
}
