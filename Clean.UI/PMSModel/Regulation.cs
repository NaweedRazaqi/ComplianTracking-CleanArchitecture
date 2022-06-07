using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Regulation
    {
        public Regulation()
        {
            AddOnRegulation = new HashSet<AddOnRegulation>();
            Application = new HashSet<Application>();
            Cadre = new HashSet<Cadre>();
            InverseParent = new HashSet<Regulation>();
            Professional = new HashSet<Professional>();
            RegulationRank = new HashSet<RegulationRank>();
            ServiceDetail = new HashSet<ServiceDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int StatusId { get; set; }
        public int? ParentId { get; set; }
        public string Abbreviation { get; set; }
        public short EmployeeTypeId { get; set; }
        public int ServiceTypeId { get; set; }

        public virtual EmployeeType EmployeeType { get; set; }
        public virtual Regulation Parent { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<AddOnRegulation> AddOnRegulation { get; set; }
        public virtual ICollection<Application> Application { get; set; }
        public virtual ICollection<Cadre> Cadre { get; set; }
        public virtual ICollection<Regulation> InverseParent { get; set; }
        public virtual ICollection<Professional> Professional { get; set; }
        public virtual ICollection<RegulationRank> RegulationRank { get; set; }
        public virtual ICollection<ServiceDetail> ServiceDetail { get; set; }
    }
}
