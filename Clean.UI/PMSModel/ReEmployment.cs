using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class ReEmployment
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int RankId { get; set; }
        public string DecreeNumber { get; set; }
        public DateTime ReemploymentDate { get; set; }
        public decimal MonthlySalary { get; set; }
        public DateTime ExpectedPensionDate { get; set; }
        public int OrganizationId { get; set; }
        public int DepartmentId { get; set; }
        public int ProvinceId { get; set; }

        public virtual Application Application { get; set; }
        public virtual Department Department { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Province Province { get; set; }
        public virtual Rank Rank { get; set; }
    }
}
