using App.Application.Complains.Models;
using App.Persistence.Context;
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
    public class ProcessedApplicationSearchQuery : IRequest<List<ComplainProcessSearchModel>>
    {
        public int? Id { get; set; }
        public string? Code { get; set; }
    }

    public class ProcessedApplicationSearchQueryHandler : IRequestHandler<ProcessedApplicationSearchQuery, List<ComplainProcessSearchModel>>
    {
        private readonly AppDbContext context;
        private readonly PMSDbContext pmscontext;
        public ProcessedApplicationSearchQueryHandler(AppDbContext mContext, PMSDbContext pmscontext)
        {
            this.context = mContext;
            this.pmscontext = pmscontext;
        }

        public async Task<List<ComplainProcessSearchModel>> Handle(ProcessedApplicationSearchQuery request, CancellationToken cancellationToken)
        {
            List<ComplainProcessSearchModel> result = new List<ComplainProcessSearchModel>();
            var queryy = context.CaseRegister.AsQueryable();
            var query2 = pmscontext.Profiles.AsQueryable();
            if (request.Id != null)
            {
                var firstquery = queryy.Select(e => new ComplainProcessSearchModel
                {
                    Id = e.Id,
                    UnitId = e.UnitId,
                    ComplainTypeId = e.ComplainTypeId,
                    ComplainText = e.ComplainType.Name,
                    Discription = e.Discription,
                    UnitText = e.Unit.Name,
                    ProfileId = e.ProfileId,
                    IsLastStep = e.IsLastStep
                }).Where(e => e.Id == request.Id).ToList();

                firstquery.ForEach(t =>
                {

                    t.Code = pmscontext.Profiles.Where(p => p.Id == t.ProfileId).Select(i => i.Code).SingleOrDefault();
                    t.FatherName = pmscontext.Profiles.Where(p => p.Id == t.ProfileId).Select(f => f.FatherName).SingleOrDefault();
                    t.Name = pmscontext.Profiles.Where(p => p.Id == t.ProfileId).Select(f => f.FirstName).SingleOrDefault();
                    t.LastName = pmscontext.Profiles.Where(p => p.Id == t.ProfileId).Select(f => f.LastName).SingleOrDefault();
                    t.ProfileId = pmscontext.Profiles.Where(p => p.Id == t.ProfileId).Select(f => f.Id).SingleOrDefault();
                    result.Add(t);

                });
            }
            else if (!string.IsNullOrEmpty(request.Code))
            {
                var firstquery = query2.Select(e => new ComplainProcessSearchModel
                {
                    Code = e.Code,
                    Id = e.Id,
                    FatherName = e.FatherName,
                    Name = e.FirstName,
                    LastName = e.LastName,
                    ProfileId = e.Id,
                }).Where(e => e.Code == request.Code).ToList();
                firstquery.ForEach(t => {
                    t.Id = context.CaseRegister.Where(c => c.ProfileId == t.ProfileId).Select(p => p.Id).SingleOrDefault();
                    t.UnitId = context.CaseRegister.Where(c => c.ProfileId == t.ProfileId).Select(p => p.UnitId).SingleOrDefault();
                    t.ComplainTypeId = context.CaseRegister.Where(c => c.ProfileId == t.ProfileId).Select(p => p.ComplainTypeId).SingleOrDefault();
                    t.ComplainText = context.CaseRegister.Where(c => c.ProfileId == t.ProfileId).Select(p => p.ComplainType.Name).SingleOrDefault();
                    t.Discription = context.CaseRegister.Where(c => c.ProfileId == t.ProfileId).Select(p => p.Discription).SingleOrDefault();
                    t.UnitText = context.CaseRegister.Where(c => c.ProfileId == t.ProfileId).Select(p => p.Unit.Name).SingleOrDefault();
                    t.ProfileId = context.CaseRegister.Where(c => c.ProfileId == t.ProfileId).Select(p => p.ProfileId).SingleOrDefault();
                    t.IsLastStep = context.CaseRegister.Where(c => c.ProfileId == t.ProfileId).Select(p => p.IsLastStep).SingleOrDefault();


                    result.Add(t);

                });
            }
            else
            {

                var firstquery = queryy.Select(e => new ComplainProcessSearchModel
                {
                    Id = e.Id,
                    UnitId = e.UnitId,
                    ComplainTypeId = e.ComplainTypeId,
                    ComplainText = e.ComplainType.Name,
                    Discription = e.Discription,
                    UnitText = e.Unit.Name,
                    ProfileId = e.ProfileId,
                    IsLastStep = e.IsLastStep
                }).ToList();

                firstquery.ForEach(t => {

                    t.Code = pmscontext.Profiles.Where(p => p.Id == t.ProfileId).Select(i => i.Code).SingleOrDefault();
                    t.FatherName = pmscontext.Profiles.Where(p => p.Id == t.ProfileId).Select(f => f.FatherName).SingleOrDefault();
                    t.Name = pmscontext.Profiles.Where(p => p.Id == t.ProfileId).Select(f => f.FirstName).SingleOrDefault();
                    t.LastName = pmscontext.Profiles.Where(p => p.Id == t.ProfileId).Select(f => f.LastName).SingleOrDefault();
                    t.ProfileId = pmscontext.Profiles.Where(p => p.Id == t.ProfileId).Select(f => f.Id).SingleOrDefault();
                    result.Add(t);


                });
                
            }
            return result;
        }
        
    }
}
