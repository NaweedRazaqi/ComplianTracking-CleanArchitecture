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

    public class GetComplainTypeList : IRequest<List<ComplainTypeModel>>
    {

        public int? Id { get; set; }
    }

    public class GetComplainTypeListHandler : IRequestHandler<GetComplainTypeList, List<ComplainTypeModel>>
    {
        private AppDbContext Context { get; set; }
        public GetComplainTypeListHandler(AppDbContext context)
        {
            Context = context;
        }

        public async Task<List<ComplainTypeModel>> Handle(GetComplainTypeList request, CancellationToken cancellationToken)
        {
            List<ComplainTypeModel> list = new List<ComplainTypeModel>();
            var query = Context.ComplainTypes.AsQueryable();

            if (request.Id.HasValue)
            {
                query = query.Where(o => o.Id == request.Id);
            }

            list = await (from o in query
                          select new ComplainTypeModel
                          {
                              Id = o.Id,
                              Name = o.Name,
                              ProcessTime = o.ProcessTime
                          }).OrderByDescending(o => o.Id).ToListAsync();
            return list;
        }
    }
}

