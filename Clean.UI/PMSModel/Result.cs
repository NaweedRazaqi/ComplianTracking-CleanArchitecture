using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Result
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public DateTime RetirementStartDate { get; set; }
        public DateTime CalculationDate { get; set; }
        public int RegulationRankId { get; set; }
        public int? ProfessionalId { get; set; }
        public int? CadreId { get; set; }
        public string TotalService { get; set; }
        public int CalculatedService { get; set; }
        public int MonthlyDue { get; set; }
        public decimal CalculatedPercentage { get; set; }
        public short PaymentTypeId { get; set; }
        public decimal TotalPaymentMonth { get; set; }
        public short TotalPaymentDay { get; set; }
        public int TotalPayment { get; set; }
        public short CalculationTypeId { get; set; }
        public string Formula { get; set; }
        public short? NumberOfSurvivor { get; set; }
        public int? AddOnId { get; set; }

        public virtual AddOn AddOn { get; set; }
        public virtual Application Application { get; set; }
        public virtual Cadre Cadre { get; set; }
        public virtual CalculationType CalculationType { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual Professional Professional { get; set; }
        public virtual RegulationRank RegulationRank { get; set; }
    }
}
