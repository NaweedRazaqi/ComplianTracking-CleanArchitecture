using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class PaymentTypeInterval
    {
        public PaymentTypeInterval()
        {
            Batch = new HashSet<Batch>();
        }

        public short Id { get; set; }
        public string Identifier { get; set; }
        public string IdentifierDari { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int PaymentTypeId { get; set; }

        public virtual OccurrenceType PaymentType { get; set; }
        public virtual ICollection<Batch> Batch { get; set; }
    }
}
