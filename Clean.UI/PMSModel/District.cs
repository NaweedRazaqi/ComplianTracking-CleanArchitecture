using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class District
    {
        public District()
        {
            AddressCurrentDistrict = new HashSet<Address>();
            AddressDistrict = new HashSet<Address>();
            Application = new HashSet<Application>();
            Profile = new HashSet<Profile>();
        }

        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string DistrictNameDari { get; set; }
        public string DistrictNamePashto { get; set; }
        public string Code { get; set; }
        public int? ProvinceId { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Address> AddressCurrentDistrict { get; set; }
        public virtual ICollection<Address> AddressDistrict { get; set; }
        public virtual ICollection<Application> Application { get; set; }
        public virtual ICollection<Profile> Profile { get; set; }
    }
}
