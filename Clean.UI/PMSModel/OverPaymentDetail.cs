using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class OverPaymentDetail
    {
        public int Id { get; set; }
        public long PayableId { get; set; }
        public int OverPaymentId { get; set; }
        public decimal Amount { get; set; }

        public virtual OverPayment OverPayment { get; set; }
        public virtual Payable Payable { get; set; }
    }
}
