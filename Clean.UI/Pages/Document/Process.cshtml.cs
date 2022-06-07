using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Persistence.Context;
using Clean.Application.ProcessTrackings.Commands;
using Clean.Application.ProcessTrackings.Models;
using Clean.Application.ProcessTrackings.Queries;
using Clean.Persistence.Context;
using Clean.Persistence.Services;
using Clean.UI.Types;
using Clean.UI.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Clean.UI.Pages.Document
{
    public class ProcessModel : BasePage
    {
        [BindProperty]
        public string LogicID { get; set; }
        public string ScreenIDEncrypted { get; set; }
        public string ScreenID { get; set; }
        private readonly AppDbContext context;

        public ProcessModel(AppDbContext context)
        {
            this.context = context;
        }
 

         public async Task<IActionResult> OnGetAsync([FromQuery] int? recordid = null)
        {

            try
            {

                ListOfProcessesConnection = new List<SelectListItem>();
                ListOfFilteredComplain = new List<SelectListItem>();
                ScreenID = "7";// EncryptionHelper.Encrypt("1");
                int SID = Convert.ToInt32(EncryptionHelper.Decrypt(EncryptionHelper.Encrypt(ScreenID)));
                List<SearchedProcess> Processes = await Mediator.Send(new GetProcess() { ScreenId = SID });

                var comId = context.CaseRegister.Where(e => e.Id == recordid).Select(e => e.ComplainTypeId).SingleOrDefault();

                var ProcessList = context.Process.Where(e => e.ComplainTypeId == comId).OrderBy(e=> e.Sorter).ToList();

                foreach (var PL in ProcessList)
                {
                    ListOfFilteredComplain.Add(new SelectListItem(PL.Name, PL.Id.ToString()));
                }

                var ProcessConnections = await Mediator.Send(new GetProcessConnection() { ScreenId = SID });
                if (ProcessConnections.Any())
                {
                    foreach (var PC in ProcessConnections)
                    {
                        ListOfProcessesConnection.Add(new SelectListItem(PC.ConnectionText, PC.ConnectionId.ToString()));
                    }
                    if (Processes.Any())
                    {
                        var first = Processes.FirstOrDefault();
                        HttpContext.Session.SetInt32("ModuleId", first.ModuleId);
                        HttpContext.Session.SetInt32("ProcessId", first.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(CustomMessages.FabricateException(ex));
            }

            return Page();

        }

        public async Task<IActionResult> OnPostSave([FromBody] SaveProcessTracksCommand command)
        {
            try
            {
                var QueryResult = await Mediator.Send(new SearchProcessTrackQuery() { RecordId = command.RecordId, ModuleId = Convert.ToInt16(HttpContext.Session.GetInt32("ModuleId").Value) });
                var CurrentProcess = QueryResult.FirstOrDefault();
                //var processID = HttpContext.Session.GetInt32("ProcessId");
                var processID = CurrentProcess.ProcessId;

                var rec = context.ProcessTracking.Where(e => e.RecordId == command.RecordId && e.ProcessId == command.ReferedProcessId).SingleOrDefault();
              
               if(CurrentProcess.ProcessId != 60)
                {
                    var connectedID = context.ProcessConnection.Where(e => e.ProcessId == CurrentProcess.ProcessId).Select(p => p.ConnectedTo).SingleOrDefault();

                    if(connectedID != command.ReferedProcessId)
                    {
                        return new JsonResult(new UIResult()
                        {
                            Data = null,
                            Status = UIStatus.Failure,
                            Text = "کوشش خلاف اصول",
                            Description = "شما اجازه ارسال این سند را به مراحل انتخاب شده ندارید. لطفا مرحله قبلی   را انتخاب نمایید  "
                        });
                    }
                    else
                    {
                        if (command.Id == CurrentProcess.Id && rec == null)
                        {
                            command.ModuleId = CurrentProcess.ModuleId;
                            QueryResult = await Mediator.Send(command);
                            return new JsonResult(new UIResult()
                            {
                                Data = new { list = QueryResult },
                                Status = UIStatus.Success,
                                Text = "اسناد موفقانه ارسال گردید",
                                Description = "اسناد انتخاب شده، موفقانه به مرحله تعیین شده ارسال گردید"
                            });
                        }

                        else
                        {
                            return new JsonResult(new UIResult()
                            {
                                Data = null,
                                Status = UIStatus.Failure,
                                Text = "کوشش خلاف اصول",
                                Description = "شما اجازه ارسال این سند را به مراحل انتخاب شده ندارید. سند مذکور خارج از حدود صلاحیت این مرحله میباشد"
                            });
                        }
                    }

                }
                          
                else{
                    var comId = context.CaseRegister.Where(e => e.Id == command.RecordId).Select(e => e.ComplainTypeId).SingleOrDefault();

                    var firstProcess = context.Process.Where(e => e.ComplainTypeId == comId).OrderBy(e => e.Sorter).FirstOrDefault();

                    if(command.ReferedProcessId != firstProcess.Id)
                    {
                         return new JsonResult(new UIResult()
                        {
                           
                            Data = null,
                            Status = UIStatus.Failure,
                            Text = "کوشش خلاف اصول",
                            Description = "شما اجازه ارسال این سند را به مراحل انتخاب شده ندارید. لطفا اولین مرحله را انتخاب نمایید"
                        });
                    }
                    else
                    {

                   

                    if (command.Id == CurrentProcess.Id && rec == null)
                    {
                        command.ModuleId = CurrentProcess.ModuleId;
                        QueryResult = await Mediator.Send(command);
                        return new JsonResult(new UIResult()
                        {
                            Data = new { list = QueryResult },
                            Status = UIStatus.Success,
                            Text = "اسناد موفقانه ارسال گردید",
                            Description = "اسناد انتخاب شده، موفقانه به مرحله تعیین شده ارسال گردید"  
                        });
                    }

                    else
                    {
                        return new JsonResult(new UIResult()
                        {
                            Data = null,
                            Status = UIStatus.Failure,
                            Text = "کوشش خلاف اصول",
                            Description = "شما اجازه ارسال این سند را به مراحل انتخاب شده ندارید.   سند مذکور خارج از حدود صلاحیت این مرحله میباشد"
                        });
                    }
                    }
                }            
            
            }
            catch (Exception ex)
            {
                return new JsonResult(CustomMessages.FabricateException(ex));
            }
        }


        public async Task<IActionResult> OnPostSearch([FromBody] SearchProcessTrackQuery query)
        {
            try
            {
                query.ModuleId = Convert.ToInt16(HttpContext.Session.GetInt32("ModuleId").Value);
                var QueryResult = await Mediator.Send(query);
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