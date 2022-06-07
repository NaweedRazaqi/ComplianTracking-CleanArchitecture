using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Country
    {
        public Country()
        {
            Heir = new HashSet<Heir>();
        }

        public int Id { get; set; }
        public string TitleEn { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Heir> Heir { get; set; }
    }
}
