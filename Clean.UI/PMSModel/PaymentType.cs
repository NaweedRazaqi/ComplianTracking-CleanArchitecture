using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            BatchDetail = new HashSet<BatchDetail>();
            Due = new HashSet<Due>();
            Payable = new HashSet<Payable>();
            Result = new HashSet<Result>();
        }

        public short Id { get; set; }
        public string Identifier { get; set; }
        public string IdentifierDari { get; set; }

        public virtual ICollection<BatchDetail> BatchDetail { get; set; }
        public virtual ICollection<Due> Due { get; set; }
        public virtual ICollection<Payable> Payable { get; set; }
        public virtual ICollection<Result> Result { get; set; }
    }
}
