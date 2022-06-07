using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Application.Complains.Queries;
using App.Application.Complains.Queries.SearchQueries;
using Clean.Common.Dates;
using Clean.UI.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clean.UI.Pages.Student.ResultSheet.Prints
{
    public class IndexModel : BasePage
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
        public string createdOnShamsi { get; set; }
        public string userName { get; set; }
        public string Returndate { get; set; }
        public int Processtime { get; set; }
        public string finalreturn { get; set; }
        public string finalretrundateshamsi { get; set; }
        public string PensionerCode { get; set; }
        public async Task OnGet([FromQuery] long recordId)
        {

            var result = await this.Mediator.Send(new ComplainSearchQuery { Id = (int)recordId });
            var cur = result.FirstOrDefault();

            if (!result.Any())
            {
                userName = "معلومات موجود نیست";
                createdOnShamsi = "معلومات موجود نیست";
                CaseText = "معلومات موجود نیست";
                UnitText = "معلومات موجود نیست";
              
            }

            if (result.Any())
            {
                Id = cur.Id;
                CaseText = cur.CaseText;
                CreatedOn = cur.CreatedOn;
                createdOnShamsi = cur.CreatedOnShamsi;
                userName = cur.UserName;
                ComplainTypeId = cur.ComplainTypeId;
                Processtime = cur.Processtime / 24;
                var finalreturn = DateTime.Now.AddDays(Processtime);
                finalretrundateshamsi = PersianDate.GetFormatedString(finalreturn);
                PensionerCode = cur.PensionerCode == null ? "درج نگردیده است" : cur.PensionerCode;
                UnitText = cur.UnitText;
            }
           
        }
    }
}