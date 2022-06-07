using App.Application.Complains.Report.Models;
using App.Persistence.Context;
using Clean.Common.Dates;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Application.Complains.Report.Queries
{
    public class ComplainsProcessStatusQuery : IRequest<List<ComplainProcessStatusModel>>
    {

        public int ProcessId { get; set; }
    }

    public class ComplainsProcessStatusQueryHandler : IRequestHandler<ComplainsProcessStatusQuery, List<ComplainProcessStatusModel>>
    {
        public  PMSDbContext context;
        public  AppDbContext apcontext;
        public ComplainsProcessStatusQueryHandler(PMSDbContext mContext, AppDbContext apcontext)
        {
            this.context = mContext;
            this.apcontext = apcontext;
        }

        public async Task<List<ComplainProcessStatusModel>> Handle(ComplainsProcessStatusQuery request, CancellationToken cancellationToken)
        {
            List<ComplainProcessStatusModel> result = new List<ComplainProcessStatusModel>();
            var query = apcontext.ProcessTracking.Where(p => p.ProcessId == request.ProcessId).Select(p => p.RecordId).ToList();

          
            
            query.ForEach(e =>
            {
                ComplainProcessStatusModel rec = new ComplainProcessStatusModel();
                var cur = apcontext.CaseRegister.Where(ae => ae.Id == e).SingleOrDefault();
                var curPro = context.Profiles.Where(b => b.Id == cur.ProfileId).SingleOrDefault();

                rec.Id = cur.Id;
                rec.Name = curPro.FirstName;
                rec.LastName = curPro.LastName;
                rec.ProfileId = curPro.Id;
                rec.FatherName = curPro.FatherName;
                rec.ComplainTypeId = cur.ComplainTypeId;
                rec.ComplainText = apcontext.ComplainTypes.Where(e=> e.Id == cur.ComplainTypeId).Select(s=> s.Name).SingleOrDefault();
                rec.CreatedOnShamsi = PersianDate.GetFormatedString(cur.CreatedOn);
                rec.ProcessedCount = apcontext.ProcessTracking.Where(e => e.ProcessId == request.ProcessId &&  e.RecordId == cur.Id && e.StatusId == 2).Count();
                rec.InProcessCount = apcontext.ProcessTracking.Where(e => e.ProcessId == request.ProcessId && e.RecordId == cur.Id && e.StatusId == 1).Count();
                result.Add(rec);
                

            });

            return  result;
        }

    }
        
}


