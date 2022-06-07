using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class ApplicationStatus
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public string Details { get; set; }
        public int? StatusId { get; set; }

        public virtual Application Application { get; set; }
        public virtual Status Status { get; set; }
    }
}
