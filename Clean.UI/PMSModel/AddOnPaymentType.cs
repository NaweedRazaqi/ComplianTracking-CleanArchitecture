using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class AddOnPaymentType
    {
        public AddOnPaymentType()
        {
            AddOn = new HashSet<AddOn>();
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AddOn> AddOn { get; set; }
    }
}
