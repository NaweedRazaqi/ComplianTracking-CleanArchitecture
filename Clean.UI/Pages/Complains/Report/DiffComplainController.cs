using App.Application.Complains.Report.Models;
using App.Application.Complains.Report.Queries;
using Clean.UI.Types;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.UI.Pages.Complains.Report
{
    public class DiffComplainController : Controller
    {
        private IMediator _mediator;

        public DiffComplainController(IMediator mediator)
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

        [Route("Complains/Report/DiffComplain/Search")]
        [HttpPost]
        public async Task<IActionResult> Search([FromBody] ComplainsProcessStatusQuery command)
        {
            try
            {
                List<ComplainProcessStatusModel> QueryResult = new List<ComplainProcessStatusModel>();
                QueryResult = await Mediator.Send(command);
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
