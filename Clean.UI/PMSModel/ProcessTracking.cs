using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class ProcessTracking
    {
        public int Id { get; set; }
        public int RecordId { get; set; }
        public int ProcessId { get; set; }
        public int ReferedProcessId { get; set; }
        public short StatusId { get; set; }
        public string Remarks { get; set; }
        public short ModuleId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int UserId { get; set; }
        public int? ToUserId { get; set; }

        public virtual Module Module { get; set; }
        public virtual Process Process { get; set; }
        public virtual Status1 Status { get; set; }
    }
}
