using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class ServiceRecord
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int ProfileId { get; set; }
        public string Job { get; set; }
        public int RankId { get; set; }
        public int PositionTypeId { get; set; }
        public DateTime FirstDayOfEmployment { get; set; }
        public DateTime LastDayOfEmployment { get; set; }
        public int ServiceTypeId { get; set; }
        public decimal ActualMonthlySalary { get; set; }
        public short WorkTypeId { get; set; }
        public short SalaryTypeId { get; set; }
        public bool? LastServiceRecord { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual Rank PositionType { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Rank Rank { get; set; }
        public virtual SalaryType SalaryType { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual WorkType WorkType { get; set; }
        public virtual ServiceCadre ServiceCadre { get; set; }
        public virtual ServiceProfessional ServiceProfessional { get; set; }
    }
}
