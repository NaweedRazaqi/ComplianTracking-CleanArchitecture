using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Cadre
    {
        public Cadre()
        {
            Result = new HashSet<Result>();
        }

        public int Id { get; set; }
        public int RegulationId { get; set; }
        public short EducationRankId { get; set; }
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int StatusId { get; set; }
        public int? OrganizationId { get; set; }
        public short? SalaryTypeId { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual EducationRank EducationRank { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Regulation Regulation { get; set; }
        public virtual SalaryType SalaryType { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Result> Result { get; set; }
    }
}
