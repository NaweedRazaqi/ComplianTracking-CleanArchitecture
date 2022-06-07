using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class FiscalYear
    {
        public FiscalYear()
        {
            ApplicationPayment = new HashSet<ApplicationPayment>();
            Batch = new HashSet<Batch>();
            BiometricHistory = new HashSet<BiometricHistory>();
            OrganizationOrder = new HashSet<OrganizationOrder>();
            PayableDueFiscalYear = new HashSet<Payable>();
            PayableFiscalYear = new HashSet<Payable>();
        }

        public int Id { get; set; }
        public int ShamsiYear { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCurrentYear { get; set; }

        public virtual ICollection<ApplicationPayment> ApplicationPayment { get; set; }
        public virtual ICollection<Batch> Batch { get; set; }
        public virtual ICollection<BiometricHistory> BiometricHistory { get; set; }
        public virtual ICollection<OrganizationOrder> OrganizationOrder { get; set; }
        public virtual ICollection<Payable> PayableDueFiscalYear { get; set; }
        public virtual ICollection<Payable> PayableFiscalYear { get; set; }
    }
}
