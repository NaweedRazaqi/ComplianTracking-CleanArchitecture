using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class PaymentCategory
    {
        public PaymentCategory()
        {
            OverPayment = new HashSet<OverPayment>();
        }

        public short Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<OverPayment> OverPayment { get; set; }
    }
}
