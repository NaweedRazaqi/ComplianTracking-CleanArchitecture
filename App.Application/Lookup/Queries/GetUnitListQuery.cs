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

    public class GetUnitListQuery : IRequest<List<UnitModel>>
    {
        public int? Id { get; set; }
    }

    public class GetUnitListQueryHandler : IRequestHandler<GetUnitListQuery, List<UnitModel>>
    {
        private AppDbContext Context { get; set; }
        public GetUnitListQueryHandler(AppDbContext context)
        {
            Context = context;
        }

        public async Task<List<UnitModel>> Handle(GetUnitListQuery request, CancellationToken cancellationToken)
        {
            List<UnitModel> list = new List<UnitModel>();
            var query = Context.Units.AsQueryable();
            if (request.Id != null)
            {
                query = query.Where(o => o.Id == request.Id);
            }

            list = await(from o in query
                         select new UnitModel
                         {
                             Id = o.Id,
                             Name = o.Name
                         }).ToListAsync(cancellationToken);
            return list;
        }
    }
}
