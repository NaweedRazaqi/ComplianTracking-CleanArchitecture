using App.Domain.Entity.PMSEntity.prf;
using System;
using System.Collections.Generic;

namespace App.Domain.Entity.PMSEntity.look
{
    public partial class BankBranches
    {
        public BankBranches()
        {
            BankAccount = new HashSet<BankAccount>();
        }

        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public short BankId { get; set; }
        public bool Active { get; set; }
        public int? ProvinceId { get; set; }
        public string Address { get; set; }

        public virtual Banks Bank { get; set; }
        public virtual ICollection<BankAccount> BankAccount { get; set; }
    }
}
