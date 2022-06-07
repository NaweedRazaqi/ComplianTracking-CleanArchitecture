using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Application.Complains.Commands.CreateCommand;
using App.Application.Complains.Models.SearchModel;
using App.Application.Complains.Queries.SearchQueries;
using App.Application.Lookup.Queries;
using Clean.Application.ProcessTrackings.Models;
using Clean.Application.ProcessTrackings.Queries;
using Clean.Application.System.Queries;
using Clean.UI.Types;
using Clean.UI.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Clean.UI.Pages.Complains.Registeration
{
    public class ComplainsRegisterModel : BasePage
    {
        public int ScreenID = 1;

        public string ScreenIDEncrypted { get; set; }

        public async Task OnGetAsync(int id)
        {
           
            ListOfUnits = new List<SelectListItem>();
            var unit = await Mediator.Send(new GetUnitListQuery());
            unit.ForEach(e => ListOfUnits.Add(new SelectListItem { Value = e.Id.ToString(), Text = e.Name }));
            ListOfComplainType = new List<SelectListItem>();
            var comp = await Mediator.Send(new GetComplainTypeList());
            comp.ForEach(e => ListOfComplainType.Add(new SelectListItem { Value = e.Id.ToString(), Text = e.Name }));

            ScreenIDEncrypted = EncryptionHelper.Encrypt(ScreenID.ToString());

            var scrList = await Mediator.Send(new GetScreens() { ID = ScreenID });
            var scr = scrList.Single();
            HttpContext.Session.SetInt32("ModuleID", scr.ModuleId);
        }

        #region Save
        public async Task<IActionResult> OnPostSave([FromBody] CreateComplainCommand command)
        {
            command.ModuleID = HttpContext.Session.GetInt32("ModuleID").Value;
            try
            {
                IEnumerable<ComplainSearchModel> SaveResult = new List<ComplainSearchModel>();
                SaveResult = await Mediator.Send(command);
                return new JsonResult(new UIResult()
                {
                    Data = new { list = SaveResult },
                    Status = UIStatus.Success,
                    Text = "شکایت موفقانه ثبت گردید",
                    Description = string.Empty
                });

            }
            catch (Exception ex)
            {
                return new JsonResult(CustomMessages.FabricateException(ex));
            }
        }
        #endregion


        #region Search
        public async Task<IActionResult> OnPostSearch([FromBody] ComplainSearchQuery query)
        {
            var result = new JsonResult(null);
            try
            {

                IEnumerable<ComplainSearchModel> SaveResult = new List<ComplainSearchModel>();

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
