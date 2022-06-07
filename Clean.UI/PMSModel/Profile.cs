using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Profile
    {
        public Profile()
        {
            Address = new HashSet<Address>();
            Application = new HashSet<Application>();
            BankAccount = new HashSet<BankAccount>();
            BiometricCommittee = new HashSet<BiometricCommittee>();
            BiometricHistory = new HashSet<BiometricHistory>();
            Heir = new HashSet<Heir>();
            MultiplePension = new HashSet<MultiplePension>();
            OverPayment = new HashSet<OverPayment>();
            PensionDisability = new HashSet<PensionDisability>();
            Referral = new HashSet<Referral>();
            ServiceDetail = new HashSet<ServiceDetail>();
            ServiceRecord = new HashSet<ServiceRecord>();
            Survivor = new HashSet<Survivor>();
        }

        public int Id { get; set; }
        public string HashKey { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string Nid { get; set; }
        public short GenderId { get; set; }
        public DateTime DoB { get; set; }
        public string GrandFatherName { get; set; }
        public short DocumentTypeId { get; set; }
        public int BirthLocationId { get; set; }
        public int EducationDegreeId { get; set; }
        public int? OrganizationId { get; set; }
        public int DistrictId { get; set; }
        public int? CensusId { get; set; }
        public int? BiometricId { get; set; }
        public bool IsLife { get; set; }

        public virtual BiometricHistory Biometric { get; set; }
        public virtual Province BirthLocation { get; set; }
        public virtual District District { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual EducationDegree EducationDegree { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<Application> Application { get; set; }
        public virtual ICollection<BankAccount> BankAccount { get; set; }
        public virtual ICollection<BiometricCommittee> BiometricCommittee { get; set; }
        public virtual ICollection<BiometricHistory> BiometricHistory { get; set; }
        public virtual ICollection<Heir> Heir { get; set; }
        public virtual ICollection<MultiplePension> MultiplePension { get; set; }
        public virtual ICollection<OverPayment> OverPayment { get; set; }
        public virtual ICollection<PensionDisability> PensionDisability { get; set; }
        public virtual ICollection<Referral> Referral { get; set; }
        public virtual ICollection<ServiceDetail> ServiceDetail { get; set; }
        public virtual ICollection<ServiceRecord> ServiceRecord { get; set; }
        public virtual ICollection<Survivor> Survivor { get; set; }
    }
}
