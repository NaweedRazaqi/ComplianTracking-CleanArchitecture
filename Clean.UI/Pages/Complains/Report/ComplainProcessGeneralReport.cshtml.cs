using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Application.Complains.Models;
using App.Application.Complains.Report.Models;
using App.Application.Complains.Report.Queries;
using App.Application.Lookup.Queries;
using Clean.UI.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Clean.UI.Pages.Complains.Report
{
    public class ComplainProcessGeneralReportModel : BasePage
    {
        public async Task OnGetAsync()
        {
            ListOfComplainType = new List<SelectListItem>();
            var comp = await Mediator.Send(new GetComplainTypeList());
            comp.ForEach(e => ListOfComplainType.Add(new SelectListItem { Value = e.Id.ToString(), Text = e.Name }));
        }

        public async Task<IActionResult> OnPostSearch([FromBody] ComplainProcessGeneralReportQuery query)
        {
            try
            {
                List<CPGRSearchModel> result = new List<CPGRSearchModel>();
                result = await Mediator.Send(query);
                return new JsonResult(new UIResult()
                {
                    Data = new { list = result },
                    Status = UIStatus.SuccessWithoutMessage,
                    Text = string.Empty,
                    Description = string.Empty
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(CustomMessages.FabricateException(ex));
            }
        }

    }
}

