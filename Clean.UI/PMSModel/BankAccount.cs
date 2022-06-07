using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class BankAccount
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public int BranchId { get; set; }
        public short AccountHolderTypeId { get; set; }
        public int ProfileId { get; set; }
        public bool IsActive { get; set; }

        public virtual AccountHolderType AccountHolderType { get; set; }
        public virtual BankBranches Branch { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
