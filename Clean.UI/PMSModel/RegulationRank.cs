using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class RegulationRank
    {
        public RegulationRank()
        {
            Result = new HashSet<Result>();
        }

        public int Id { get; set; }
        public int RankId { get; set; }
        public int RegulationId { get; set; }
        public decimal Salary { get; set; }
        public decimal? Factor { get; set; }
        public int? EducationDegreeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short SalaryTypeId { get; set; }
        public int StatusId { get; set; }
        public short ServiceLimitation { get; set; }
        public short AgeLimitation { get; set; }
        public int? OrganizationId { get; set; }
        public decimal? TermOfService { get; set; }
        public short? SalaryCycleId { get; set; }

        public virtual EducationDegree EducationDegree { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Rank Rank { get; set; }
        public virtual Regulation Regulation { get; set; }
        public virtual SalaryCycle SalaryCycle { get; set; }
        public virtual SalaryType SalaryType { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Result> Result { get; set; }
    }
}
