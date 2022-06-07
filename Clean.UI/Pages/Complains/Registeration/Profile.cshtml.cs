using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Application.Complains.Commands;
using App.Application.Complains.Models;
using App.Application.Complains.Queries;
using Clean.Application.Documents.Queries;
using Clean.Application.System.Queries;
using Clean.UI.Types;
using Clean.UI.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace Clean.UI.Pages.Complains.Registeration
{
    public class ProfileModel : BasePage
    {
        private ILogger<ProfileModel> Logger { get; }
        public string SubScreens { get; set; }
        private string htmlTemplate = @"
                         <li><a href='#' data='$id' data-id='$eid' page='$path' class='sidebar-items' action='subscreen'><i class='$icon'></i>$title</a></li>";
        public ProfileModel(ILogger<ProfileModel> logger)
        {
            Logger = logger;
        }
        public async Task OnGetAsync()
        {
            #region Subscreens
            // get list of subscreens
            string Screen = EncryptionHelper.Decrypt(HttpContext.Request.Query["p"]);
            int ScreenID = Convert.ToInt32(Screen);

            ListOfDocumentTypes = new List<SelectListItem>();
            var documentTypes = await Mediator.Send(new GetDocumentTypeQuery() { ScreenID = ScreenID, Catagory = "ID" });
            foreach (var documentType in documentTypes)
                ListOfDocumentTypes.Add(new SelectListItem() { Text = documentType.Name, Value = documentType.Id.ToString() });

            try
            {
                var screens = await Mediator.Send(new GetSubScreens() { ID = ScreenID });
                string listout = "";
                foreach (var s in screens)
                {
                    listout = listout + htmlTemplate.Replace("$path", "dv_" + s.DirectoryPath.Replace("/", "_")).Replace("$icon", s.Icon).Replace("$title", s.Title).Replace("$id", s.Id.ToString());
                }
                SubScreens = listout;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Error Loading Subscreens : ");
            }

            #endregion
        }

        #region Save
        public async Task<IActionResult> OnPostSave([FromBody] CreateProfileCommand command)
        {

            try
            {
                IEnumerable<SearchProfileModel> SaveResult = new List<SearchProfileModel>();
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
        public async Task<IActionResult> OnPostSearch([FromBody] ProfileSearchQuery query)
        {
            var result = new JsonResult(null);
            try
            {

                IEnumerable<SearchProfileModel> SaveResult = new List<SearchProfileModel>();

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
