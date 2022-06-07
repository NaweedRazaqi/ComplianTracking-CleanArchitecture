using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Address
    {
        public int ProfileId { get; set; }
        public int ProvinceId { get; set; }
        public int? DistrictId { get; set; }
        public string Village { get; set; }
        public int CurrentProvinceId { get; set; }
        public int CurrentDistrictId { get; set; }
        public string CurrentVillage { get; set; }
        public string TelephonNo { get; set; }
        public string Email { get; set; }
        public string RelativeTelephoneNo { get; set; }
        public int Id { get; set; }
        public short HolderTypeId { get; set; }

        public virtual District CurrentDistrict { get; set; }
        public virtual Province CurrentProvince { get; set; }
        public virtual District District { get; set; }
        public virtual AccountHolderType HolderType { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Province Province { get; set; }
    }
}
