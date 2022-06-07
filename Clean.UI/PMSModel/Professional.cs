using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Professional
    {
        public Professional()
        {
            Result = new HashSet<Result>();
        }

        public int Id { get; set; }
        public int RegulationId { get; set; }
        public int EducationDegreeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int StatusId { get; set; }

        public virtual EducationDegree EducationDegree { get; set; }
        public virtual Regulation Regulation { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Result> Result { get; set; }
    }
}
