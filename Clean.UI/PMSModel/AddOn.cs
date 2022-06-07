using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class AddOn
    {
        public AddOn()
        {
            AddOnRegulation = new HashSet<AddOnRegulation>();
            AddOnSalaryType = new HashSet<AddOnSalaryType>();
            DueLog = new HashSet<DueLog>();
            Result = new HashSet<Result>();
        }

        public int Id { get; set; }
        public short AddOnPaymentTypeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; }
        public int StatusId { get; set; }
        public int? OrganizationId { get; set; }
        public int? RankId { get; set; }
        public string Name { get; set; }

        public virtual AddOnPaymentType AddOnPaymentType { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Rank Rank { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<AddOnRegulation> AddOnRegulation { get; set; }
        public virtual ICollection<AddOnSalaryType> AddOnSalaryType { get; set; }
        public virtual ICollection<DueLog> DueLog { get; set; }
        public virtual ICollection<Result> Result { get; set; }
    }
}
