using App.Application.Lookup.Models;
using App.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Application.Lookup.Queries
{

    public class GetCaseStatusList : IRequest<List<CaseStatusModel>>
    {
        public int? Id { get; set; }
    }

    public class GetCaseStatusListHandler : IRequestHandler<GetCaseStatusList, List<CaseStatusModel>>
    {
        private AppDbContext Context { get; set; }
        public GetCaseStatusListHandler(AppDbContext context)
        {
            Context = context;
        }

        public async Task<List<CaseStatusModel>> Handle(GetCaseStatusList request, CancellationToken cancellationToken)
        {
            List<CaseStatusModel> list = new List<CaseStatusModel>();
            var query = Context.CaseStatus.AsQueryable();
            if (request.Id.HasValue)
            {
                query = query.Where(o => o.Id == request.Id);
            }

            list = await(from o in query
                         select new CaseStatusModel
                         {
                             Id = o.Id,
                             Name = o.Name
                         }).ToListAsync(cancellationToken);
            return list;
        }
    }
}
