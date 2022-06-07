using System;
using System.Collections.Generic;
using System.Text;

namespace App.Application.Complains.Models.SearchModel
{
   public class ComplainSearchModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int ProfileId { get; set; }
        public int ComplainTypeId { get; set; }
        public int? UnitId { get; set; }
        public int? StatusId { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Discription { get; set; }
        public string CaseText { get; set; }
        public string UnitText { get; set; }
        public string StatusText { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedOnShamsi { get; set; }
        public string UserName { get; set; }
        public string ReturnDate { get; set; }
        public int Processtime { get; set; }
        public string PensionerCode { get; set; }
        public bool? IsLastStep { get; set; }

    }
}
