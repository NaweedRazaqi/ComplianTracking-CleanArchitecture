using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class M16
    {
        public M16()
        {
            M16detail = new HashSet<M16detail>();
        }

        public int Id { get; set; }
        public int StatusId { get; set; }
        public string SequenceNumber { get; set; }
        public string Code { get; set; }
        public DateTime? M12recievedDate { get; set; }
        public DateTime? M16issueDate { get; set; }
        public DateTime? M16submittedToMoFdate { get; set; }
        public DateTime? ChequeDate { get; set; }
        public DateTime? TransferDate { get; set; }
        public string ChequeNo { get; set; }
        public string Details { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<M16detail> M16detail { get; set; }
    }
}
