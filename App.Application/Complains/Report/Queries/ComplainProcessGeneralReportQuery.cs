using App.Application.Complains.Report.Models;
using App.Persistence.Context;
using Clean.Common.Dates;
using Clean.Common.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Application.Complains.Report.Queries
{
   public class ComplainProcessGeneralReportQuery : IRequest<List<CPGRSearchModel>>
    {
        public int? Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ComplainTypeId { get; set; }
    }

    public class ComplainProcessGeneralReportQueryHandler : IRequestHandler<ComplainProcessGeneralReportQuery, List<CPGRSearchModel>>
    {
        private readonly AppDbContext context;
        public ComplainProcessGeneralReportQueryHandler(AppDbContext mContext)
        {
            context = mContext;
        }

        public  async Task <List<CPGRSearchModel>> Handle(ComplainProcessGeneralReportQuery request, CancellationToken cancellationToken)
        {

            List<CPGRSearchModel> result = new List<CPGRSearchModel>();
            var queryy = context.CaseRegister.AsQueryable();
            var query = context.ComplainTypes.AsQueryable();
            if (request.StartDate == null && request.EndDate == null && request.Id == null && request.ComplainTypeId == null)
            {
                throw new BusinessRulesException("لطفا تاریخ آغاز و تاریخ ختم را انتخاب نمایید");
            }
            //if (request.ComplainTypeId.HasValue && request.StartDate == null && request.EndDate == null)
            //{
            //    result = queryy.Where(ct => ct.ComplainTypeId == request.ComplainTypeId).Select(e => new CPGRSearchModel
            //    {
            //        Id = e.ComplainTypeId,
            //        ComplainText = e.ComplainType.Name,
            //        StartDate = (DateTime)e.CreatedOn,
            //        EndDate = (DateTime)e.CreatedOn,
            //        CreatedOn = (DateTime)e.CreatedOn,

            //    }).ToList();
            //}
            if (request.Id.HasValue && request.StartDate == null && request.EndDate == null && request.ComplainTypeId == null)
            {


                result = queryy.Where(ct => ct.ComplainTypeId == request.Id).Select(e=> new CPGRSearchModel
                {
                    Id = e.ComplainTypeId,
                    ComplainText = e.ComplainType.Name,
                    StartDate = (DateTime)e.CreatedOn,
                    EndDate = (DateTime)e.CreatedOn,
                    CreatedOn = (DateTime)e.CreatedOn,

                }).ToList();
            }
            else
            {
                var list = context.ComplainTypes.ToList();

                var x = DateTime.Now.Date;
                
                result = list.Select(e => new CPGRSearchModel
                {
                    Id = e.Id,
                    ComplainText = e.Name,
                    StartDate = (DateTime)request.StartDate,
                    EndDate = (DateTime)request.EndDate,
                    complaintypecount = context.CaseRegister.Where(a => a.ComplainTypeId == e.Id && a.CreatedOn.Value.Date >= request.StartDate.Value.Date && a.CreatedOn.Value.Date <= request.EndDate.Value.Date && request.ComplainTypeId == null).Count()
                    
                }).Where(e=> e.complaintypecount > 0).ToList();


                result.ForEach(e => {

                    var x = context.Process.Where(a=> a.ComplainTypeId == e.Id).OrderByDescending(a=>a.Id).FirstOrDefault();
                    e.TotalProcessedComplainCount = context.ProcessTracking.Where(a => a.ProcessId == x.Id && a.StatusId == 1).Count();

                    e.TotalUnProcessedComplainCount = e.complaintypecount - e.TotalProcessedComplainCount;
                    var processtime = context.ComplainTypes.Where(c => c.Id == e.Id).Select(i => i.ProcessTime / 24).SingleOrDefault();
                    
                    var totalProcessTime = e.CreatedOn.Date.AddDays((double)processtime);

                   e.TotalExpireComplainCount = context.CaseRegister.Where(a => a.ComplainTypeId == e.Id && DateTime.Now.Date > a.CreatedOn.Value.Date.AddDays((double)processtime) && a.IsLastStep != true).Count();



                });
            }

            return result;
        }

       
    }
}
