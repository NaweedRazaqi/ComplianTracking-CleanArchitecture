using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Banks
    {
        public Banks()
        {
            BankBranches = new HashSet<BankBranches>();
            Batch = new HashSet<Batch>();
        }

        public short BankId { get; set; }
        public string BankName { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<BankBranches> BankBranches { get; set; }
        public virtual ICollection<Batch> Batch { get; set; }
    }
}
