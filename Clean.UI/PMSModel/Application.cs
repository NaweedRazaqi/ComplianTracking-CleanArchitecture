using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Application
    {
        public Application()
        {
            AccountBatch = new HashSet<AccountBatch>();
            ApplicationPayment = new HashSet<ApplicationPayment>();
            ApplicationStatus = new HashSet<ApplicationStatus>();
            DueLog = new HashSet<DueLog>();
            OverPayment = new HashSet<OverPayment>();
            Payable = new HashSet<Payable>();
            PensionCards = new HashSet<PensionCards>();
            ReEmployment = new HashSet<ReEmployment>();
            Result = new HashSet<Result>();
        }

        public int Id { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime LastDayOfEmployment { get; set; }
        public int RegulationId { get; set; }
        public string DecreeNo { get; set; }
        public DateTime DecreeDate { get; set; }
        public DateTime RetirmentStartDate { get; set; }
        public int ProvinceId { get; set; }
        public int ProfileId { get; set; }
        public string PhotoPath { get; set; }
        public int DistrictId { get; set; }
        public int Status { get; set; }
        public int? CurrentProcess { get; set; }
        public short? DataCategoryId { get; set; }
        public DateTime CalCulationStartDate { get; set; }
        public short ApplicationTypeId { get; set; }
        public int CardIssuancePlaceId { get; set; }

        public virtual ApplicationType ApplicationType { get; set; }
        public virtual Province CardIssuancePlace { get; set; }
        public virtual DataCategory DataCategory { get; set; }
        public virtual District District { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Province Province { get; set; }
        public virtual Regulation Regulation { get; set; }
        public virtual Status StatusNavigation { get; set; }
        public virtual Due Due { get; set; }
        public virtual ICollection<AccountBatch> AccountBatch { get; set; }
        public virtual ICollection<ApplicationPayment> ApplicationPayment { get; set; }
        public virtual ICollection<ApplicationStatus> ApplicationStatus { get; set; }
        public virtual ICollection<DueLog> DueLog { get; set; }
        public virtual ICollection<OverPayment> OverPayment { get; set; }
        public virtual ICollection<Payable> Payable { get; set; }
        public virtual ICollection<PensionCards> PensionCards { get; set; }
        public virtual ICollection<ReEmployment> ReEmployment { get; set; }
        public virtual ICollection<Result> Result { get; set; }
    }
}
