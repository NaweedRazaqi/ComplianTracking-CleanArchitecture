using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class OverPayment
    {
        public OverPayment()
        {
            OverPaymentDetail = new HashSet<OverPaymentDetail>();
        }

        public int ProfileId { get; set; }
        public decimal OverPaidAmount { get; set; }
        public short? OverPaymentTypeId { get; set; }
        public decimal? PaidAmount { get; set; }
        public bool IsPaid { get; set; }
        public int ApplicationId { get; set; }
        public short PaymentCategoryId { get; set; }
        public int Id { get; set; }

        public virtual Application Application { get; set; }
        public virtual OverPaymentType OverPaymentType { get; set; }
        public virtual PaymentCategory PaymentCategory { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual ICollection<OverPaymentDetail> OverPaymentDetail { get; set; }
    }
}
