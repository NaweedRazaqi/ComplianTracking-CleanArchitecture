using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Status
    {
        public Status()
        {
            AddOn = new HashSet<AddOn>();
            Application = new HashSet<Application>();
            ApplicationStatus = new HashSet<ApplicationStatus>();
            Batch = new HashSet<Batch>();
            BiometricCommittee = new HashSet<BiometricCommittee>();
            Cadre = new HashSet<Cadre>();
            DataCategory = new HashSet<DataCategory>();
            Document = new HashSet<Document>();
            M16 = new HashSet<M16>();
            PayGroupWiseQueue = new HashSet<PayGroupWiseQueue>();
            Professional = new HashSet<Professional>();
            Regulation = new HashSet<Regulation>();
            RegulationRank = new HashSet<RegulationRank>();
        }

        public int Id { get; set; }
        public string EnglishIdentifier { get; set; }
        public string Identifier { get; set; }
        public string SchemaName { get; set; }
        public string DbObject { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AddOn> AddOn { get; set; }
        public virtual ICollection<Application> Application { get; set; }
        public virtual ICollection<ApplicationStatus> ApplicationStatus { get; set; }
        public virtual ICollection<Batch> Batch { get; set; }
        public virtual ICollection<BiometricCommittee> BiometricCommittee { get; set; }
        public virtual ICollection<Cadre> Cadre { get; set; }
        public virtual ICollection<DataCategory> DataCategory { get; set; }
        public virtual ICollection<Document> Document { get; set; }
        public virtual ICollection<M16> M16 { get; set; }
        public virtual ICollection<PayGroupWiseQueue> PayGroupWiseQueue { get; set; }
        public virtual ICollection<Professional> Professional { get; set; }
        public virtual ICollection<Regulation> Regulation { get; set; }
        public virtual ICollection<RegulationRank> RegulationRank { get; set; }
    }
}
