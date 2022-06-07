using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Province
    {
        public Province()
        {
            AddressCurrentProvince = new HashSet<Address>();
            AddressProvince = new HashSet<Address>();
            ApplicationCardIssuancePlace = new HashSet<Application>();
            ApplicationProvince = new HashSet<Application>();
            AspNetUsers = new HashSet<AspNetUsers>();
            Profile = new HashSet<Profile>();
            ReEmployment = new HashSet<ReEmployment>();
        }

        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public string ProvinceNameDari { get; set; }
        public string ProvinceNamePashto { get; set; }
        public int? PaymentType { get; set; }
        public string Code { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Address> AddressCurrentProvince { get; set; }
        public virtual ICollection<Address> AddressProvince { get; set; }
        public virtual ICollection<Application> ApplicationCardIssuancePlace { get; set; }
        public virtual ICollection<Application> ApplicationProvince { get; set; }
        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
        public virtual ICollection<Profile> Profile { get; set; }
        public virtual ICollection<ReEmployment> ReEmployment { get; set; }
    }
}
