using System;
using System.Collections.Generic;

namespace App.Domain.Entity.PMSEntity.prf
{
    public partial class BankAccountQueue
    {
        public int ProfileId { get; set; }
        public bool AddedToBatch { get; set; }
    }
}
