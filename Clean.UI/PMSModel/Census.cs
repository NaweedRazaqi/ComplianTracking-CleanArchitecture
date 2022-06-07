using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Census
    {
        public int Pensionercensusid { get; set; }
        public string Pid { get; set; }
        public string Name { get; set; }
        public string Fathername { get; set; }
        public string Retirementreason { get; set; }
        public string Placeofbirth { get; set; }
        public DateTime? Dateofbirth { get; set; }
        public DateTime? Censusdate { get; set; }
        public DateTime? Retirementdate { get; set; }
        public DateTime? Dateofworkstart { get; set; }
        public string Pensionbookno { get; set; }
        public string Taskraid { get; set; }
        public string Picture { get; set; }
        public string Maritalstatus { get; set; }
        public string Pensionerno { get; set; }
        public int? Organizationid { get; set; }
        public int? Gradid { get; set; }
        public string Scheme { get; set; }
        public decimal? Totalservicelength { get; set; }
        public string Kindofbenefit { get; set; }
        public string Lawofretirement { get; set; }
        public string Pensionbeneficiary { get; set; }
        public int? Placeofwork { get; set; }
        public bool? Transfertoprovince { get; set; }
        public int? Transfertoprovinceid { get; set; }
        public int? Bankid { get; set; }
        public string Accountname { get; set; }
        public string Accountnumber { get; set; }
        public int? Mem12number { get; set; }
        public decimal? Loansdebts { get; set; }
        public decimal? Totalamount { get; set; }
        public decimal? Monthlytotal { get; set; }
        public DateTime? Dateofassignment { get; set; }
        public DateTime? Enddateofassignment { get; set; }
        public decimal Firstbenefit { get; set; }
        public decimal? Monthlybenefit { get; set; }
        public decimal? Yearlybenefit { get; set; }
        public string Benname { get; set; }
        public string Benfathername { get; set; }
        public int? Relationid { get; set; }
        public string Job { get; set; }
        public string Fingerprint { get; set; }
        public string Signature { get; set; }
        public string Chequeno { get; set; }
        public DateTime? Paydate { get; set; }
        public decimal? Payamount { get; set; }
        public DateTime? Adjustmentdate { get; set; }
        public string Scannedimg { get; set; }
        public decimal? Paymentamount { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Datemodified { get; set; }
        public int? Createuser { get; set; }
        public int? Lastmodifyuser { get; set; }
        public string Applang { get; set; }
        public bool? Isexported { get; set; }
        public int Formid2 { get; set; }
        public int? Rejectcount { get; set; }
        public bool? Rejected { get; set; }
        public string Gfathername { get; set; }
        public string Wakalatnumber { get; set; }
        public bool? Paidmoreyears { get; set; }
        public bool? Hasmorewakeel { get; set; }
        public bool? Issurvivor { get; set; }
        public int? Bankbranchid1 { get; set; }
        public int Id { get; set; }
    }
}
