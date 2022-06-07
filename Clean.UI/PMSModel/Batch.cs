using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Batch
    {
        public Batch()
        {
            AccountBatch = new HashSet<AccountBatch>();
            M16detail = new HashSet<M16detail>();
            PayGroupWise = new HashSet<PayGroupWise>();
            Payable = new HashSet<Payable>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Identifier { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public int? BatchTypeId { get; set; }
        public short? DataCategoryId { get; set; }
        public int FiscalYearId { get; set; }
        public int UserId { get; set; }
        public short BankId { get; set; }
        public int StatusId { get; set; }
        public short? CoA { get; set; }
        public int OccurrenceTypeId { get; set; }
        public short PaymentTypeIntervalId { get; set; }

        public virtual Banks Bank { get; set; }
        public virtual ChartOfAccount CoANavigation { get; set; }
        public virtual DataCategory DataCategory { get; set; }
        public virtual FiscalYear FiscalYear { get; set; }
        public virtual OccurrenceType OccurrenceType { get; set; }
        public virtual PaymentTypeInterval PaymentTypeInterval { get; set; }
        public virtual Status Status { get; set; }
        public virtual BatchDetail BatchDetail { get; set; }
        public virtual ICollection<AccountBatch> AccountBatch { get; set; }
        public virtual ICollection<M16detail> M16detail { get; set; }
        public virtual ICollection<PayGroupWise> PayGroupWise { get; set; }
        public virtual ICollection<Payable> Payable { get; set; }
    }
}
