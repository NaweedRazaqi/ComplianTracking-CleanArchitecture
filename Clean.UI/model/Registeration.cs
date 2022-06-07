using System;
using System.Collections.Generic;

namespace Clean.UI.model
{
    public partial class Registeration
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public int? UnitId { get; set; }
        public int? StatusId { get; set; }
        public string Discription { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string Modifiedby { get; set; }

        public virtual Case Case { get; set; }
        public virtual Status Status { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
