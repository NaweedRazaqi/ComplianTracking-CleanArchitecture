using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Gender
    {
        public Gender()
        {
            Heir = new HashSet<Heir>();
            Profile = new HashSet<Profile>();
        }

        public short GenderId { get; set; }
        public string GenderName { get; set; }
        public string GenderNameDari { get; set; }

        public virtual ICollection<Heir> Heir { get; set; }
        public virtual ICollection<Profile> Profile { get; set; }
    }
}
