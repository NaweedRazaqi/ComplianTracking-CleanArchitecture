using App.Application.Complains.Report.Models;
using App.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Application.Complains.Report.Queries
{
    public class ComplainTotalSearchQuery : IRequest<List<CPGRSearchModel>>
    {
        public int ComplainTypeId { get; set; }
    }

    public class ComplainTotalSearchQueryHandler : IRequestHandler<ComplainTotalSearchQuery, List<CPGRSearchModel>>
    {
        private readonly AppDbContext context;
        public ComplainTotalSearchQueryHandler(AppDbContext mContext)
        {
            context = mContext;
        }

        public async Task<List<CPGRSearchModel>> Handle(ComplainTotalSearchQuery request, CancellationToken cancellationToken)
        {
            List<CPGRSearchModel> result = new List<CPGRSearchModel>();
            var query =  context.Process.Where(p => p.ComplainTypeId == request.ComplainTypeId).AsQueryable();

            result =  query.Select(cur => new CPGRSearchModel
            {
                ProcessedCount = context.ProcessTracking.Where(e => e.ProcessId == cur.Id && e.StatusId == 2).Count(),
                InProcessCount = context.ProcessTracking.Where(e=> e.ProcessId == cur.Id && e.StatusId == 1).Count(),
                ProcessText = cur.Name,
                Id = cur.Id

            }).ToList();

            return result;
        }
       
    }
}
