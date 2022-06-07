using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class OverPaymentType
    {
        public OverPaymentType()
        {
            OverPayment = new HashSet<OverPayment>();
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OverPayment> OverPayment { get; set; }
    }
}
