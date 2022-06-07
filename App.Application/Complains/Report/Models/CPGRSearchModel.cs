using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Complains.Report.Models
{
  public  class CPGRSearchModel
    {
        public int? Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int ComplainTypeId { get; set; }
        public int? UnitId { get; set; }
        public string ComplainText { get; set; }
        public string ProcessText { get; set; }
        public string UnitText { get; set; }
        public DateTime CreatedOn { get; set; }
       // public string createdonshamsi { get; set; }
        public int complaintypecount { get; set; }
        public int ProcessID { get; set; }
        public string Identifier { get; set; }
        public int ProcessedCount { get; set; }
        public int InProcessCount { get; set; }
        public int RejectedCount { get; set; }
        
        
        public int recordnumber { get; set; }

        public int TotalComplainCount { get; set; }
        public int TotalProcessedComplainCount { get; set; }
        public int TotalUnProcessedComplainCount { get; set; }
        public int TotalExpireComplainCount { get; set; }

    }
}
