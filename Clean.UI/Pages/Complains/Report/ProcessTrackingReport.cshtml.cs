using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Application.Complains.Models;
using App.Application.Complains.Queries;
using App.Application.Complains.Report.Queries;
using Clean.Application.ProcessTrackings.Models;
using Clean.Application.ProcessTrackings.Queries;
using Clean.Persistence.Services;
using Clean.UI.Types;
using Clean.UI.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Clean.UI.Pages.Complains.Report
{
    public class ProcessTrackingReportModel : BasePage
    {
        [BindProperty]
        public string ScreenID { get; set; }


        public ICurrentUser CurrentUSer { get; set; }
        IConfiguration Configuration { get; set; }
        public async Task OnGet()
        {
            //get screen id
            ScreenID = "1";// EncryptionHelper.Encrypt("1003");
            int SID = Convert.ToInt32(EncryptionHelper.Decrypt(EncryptionHelper.Encrypt(ScreenID)));
            List<SearchedProcess> Processes = await Mediator.Send(new GetProcess() { ScreenId = SID });
            if (Processes.Any())
            {
                HttpContext.Session.SetInt32("ModuleID", Processes.FirstOrDefault().ModuleId);
                HttpContext.Session.SetInt32("ProcessID", Processes.FirstOrDefault().Id);
            }
        }

        public ProcessTrackingReportModel(ICurrentUser currentUser, IConfiguration configuration)
        {
            CurrentUSer = currentUser;
            Configuration = configuration;
        }

        public async Task<IActionResult> OnPostSearch([FromBody] ProcessedApplicationSearchQuery query)
        {
            try
            {
                List<ComplainProcessSearchModel> result = new List<ComplainProcessSearchModel>();
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
