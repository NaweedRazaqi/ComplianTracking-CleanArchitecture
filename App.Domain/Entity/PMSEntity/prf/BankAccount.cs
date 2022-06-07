using App.Domain.Entity.PMSEntity.look;
using System;
using System.Collections.Generic;

namespace App.Domain.Entity.PMSEntity.prf
{
    public partial class BankAccount
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public int BranchId { get; set; }
        public short AccountHolderTypeId { get; set; }
        public int ProfileId { get; set; }
        public bool IsActive { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual AccountHolderType AccountHolderType { get; set; }
        public virtual BankBranches Branch { get; set; }
    }
}
