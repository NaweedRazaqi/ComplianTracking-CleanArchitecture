
using Clean.Application.ProcessTrackings.Models;
using Clean.UI.Types;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.UI.Pages.Complains.Report
{
    public class ProcessTrackingReportControll : Controller
    {
        private IMediator _mediator;

        public ProcessTrackingReportControll(IMediator mediator)
        {
            _mediator = mediator;
        }
        protected IMediator Mediator
        {
            get
            {
                return _mediator;
            }
        }

        [Route("Complains/Report/ProcessTracking/Search")]
        [HttpPost]
        public async Task<IActionResult> Search([FromBody] SearchProcessTrackQuery query)
        {
            try
            {
                List<SearchedProcessTracks> QueryResult = new List<SearchedProcessTracks>();
                //query.ModuleId = Convert.ToInt16(HttpContext.Session.GetInt32("ModuleId").Value);
                query.ModuleId = 1;
                QueryResult = await Mediator.Send(query);
                return new JsonResult(new UIResult()
                {
                    Data = new { list = QueryResult },
                    Status = UIStatus.Success,
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