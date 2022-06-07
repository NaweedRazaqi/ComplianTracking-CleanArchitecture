using App.Domain.Entity.PMSEntity.prf;
using System;
using System.Collections.Generic;

namespace App.Domain.Entity.PMSEntity.look
{
    public partial class AccountHolderType
    {
        public AccountHolderType()
        {
          //  Address = new HashSet<Address>();
            BankAccount = new HashSet<BankAccount>();
        }

        public short Id { get; set; }
        public string Identifier { get; set; }

      //  public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<BankAccount> BankAccount { get; set; }
    }
}
