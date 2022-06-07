using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Application.Complains.Models;
using App.Application.Complains.Models.SearchModel;
using App.Application.Complains.Queries;
using App.Application.Complains.Queries.SearchQueries;
using App.Application.Lookup.Queries;
using Clean.Common.Exceptions;
using Clean.UI.Types;
using Clean.UI.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Clean.UI.Pages.Complains.Processes
{
    public class ComplainProcessModel : BasePage
    {
        public string ScreenIDEncrypted { get; set; }
        public async Task OnGetAsync(int id)
        {

            ListOfUnits = new List<SelectListItem>();
            var unit = await Mediator.Send(new GetUnitListQuery());
            unit.ForEach(e => ListOfUnits.Add(new SelectListItem { Value = e.Id.ToString(), Text = e.Name }));
            ListOfComplainType = new List<SelectListItem>();
            var comp = await Mediator.Send(new GetComplainTypeList());
            comp.ForEach(e => ListOfComplainType.Add(new SelectListItem { Value = e.Id.ToString(), Text = e.Name }));

            ScreenIDEncrypted = EncryptionHelper.Encrypt(id.ToString());
        }

        #region Search
        public async Task<IActionResult> OnPostSearch([FromBody] ComplainProcessSearchQuery query)
        {
            var result = new JsonResult(null);
           
            try
            {

                IEnumerable<ComplainProcessSearchModel> SaveResult = new List<ComplainProcessSearchModel>();

                SaveResult = await Mediator.Send(query);

                return new JsonResult(new UIResult()
                {
                    Data = new { list = SaveResult },
                    Status = UIStatus.Success,
                    Text = "",
                    Description = string.Empty
                });

            }
            catch (Exception ex)
            {

                result.Value = "ریکارد شما پیدا نشد";
                result.Value = new UIResult
                {
                    Status = UIStatus.Failure,
                    Text = CustomMessages.InternalSystemException,
                    Description = ex.Message + " \n StackTrace : " + ex.StackTrace,
                    Data = null
                };
            }
            return result;
        }

        #endregion
    }
}
