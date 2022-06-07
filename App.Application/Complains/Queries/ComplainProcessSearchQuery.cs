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

namespace App.Application.Complains.Queries
{
    public class ComplainProcessSearchQuery : IRequest<List<ComplainProcessSearchModel>>
    {
        public int? Id { get; set; }
        public string? Code { get; set; }
    }
    public class ComplainProcessSearchQueryHandler : IRequestHandler<ComplainProcessSearchQuery, List<ComplainProcessSearchModel>>
    {

        private readonly PMSDbContext context;
        private readonly AppDbContext apcontext;
        public ComplainProcessSearchQueryHandler(PMSDbContext mContext, AppDbContext apcontext)
        {
            this.context = mContext;
            this.apcontext = apcontext;
        }



        public async Task<List<ComplainProcessSearchModel>> Handle(ComplainProcessSearchQuery request, CancellationToken cancellationToken)
        {
           
            List<ComplainProcessSearchModel> result = new List<ComplainProcessSearchModel>();
            var queryy = apcontext.CaseRegister.AsQueryable();
            var query2 = context.Profiles.AsQueryable();

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
                }).Where(e=> e.Id == request.Id && e.IsLastStep == null).ToList();
                
                firstquery.ForEach(t =>
                {

                    t.Code = context.Profiles.Where(p => p.Id == t.ProfileId).Select(i => i.Code).SingleOrDefault();
                    t.FatherName = context.Profiles.Where(p => p.Id == t.ProfileId).Select(f => f.FatherName).SingleOrDefault();
                    t.Name = context.Profiles.Where(p => p.Id == t.ProfileId).Select(f => f.FirstName).SingleOrDefault();
                    t.LastName = context.Profiles.Where(p => p.Id == t.ProfileId).Select(f => f.LastName).SingleOrDefault();
                    t.ProfileId = context.Profiles.Where(p => p.Id == t.ProfileId).Select(f => f.Id).SingleOrDefault();
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
                }).Where(e=> e.Code == request.Code).ToList();
                firstquery.ForEach(t => {
                    t.Id = apcontext.CaseRegister.Where(c => c.ProfileId == t.ProfileId).Select(p => p.Id).SingleOrDefault();
                    t.UnitId = apcontext.CaseRegister.Where(c => c.ProfileId == t.ProfileId).Select(p => p.UnitId).SingleOrDefault();
                    t.ComplainTypeId = apcontext.CaseRegister.Where(c => c.ProfileId == t.ProfileId).Select(p => p.ComplainTypeId).SingleOrDefault();
                    t.ComplainText = apcontext.CaseRegister.Where(c => c.ProfileId == t.ProfileId).Select(p => p.ComplainType.Name).SingleOrDefault();
                    t.Discription = apcontext.CaseRegister.Where(c => c.ProfileId == t.ProfileId).Select(p => p.Discription).SingleOrDefault();
                    t.UnitText = apcontext.CaseRegister.Where(c => c.ProfileId == t.ProfileId).Select(p => p.Unit.Name).SingleOrDefault();
                    t.ProfileId = apcontext.CaseRegister.Where(c => c.ProfileId == t.ProfileId).Select(p => p.ProfileId).SingleOrDefault();
                    t.IsLastStep = apcontext.CaseRegister.Where(c => c.ProfileId == t.ProfileId).Select(p => p.IsLastStep).SingleOrDefault();
                    

                    result.Add(t);
                   
                });

                result = firstquery.Where(e => e.IsLastStep == null).ToList();
            }
            else
            {
                var firstquery = queryy.Select(e=>  new ComplainProcessSearchModel
                                {
                                    Id = e.Id,
                                    UnitId = e.UnitId,
                                    ComplainTypeId = e.ComplainTypeId,
                                    ComplainText = e.ComplainType.Name,
                                    Discription = e.Discription,
                                    UnitText = e.Unit.Name,
                                    ProfileId = e.ProfileId,
                                    IsLastStep = e.IsLastStep
                                }).Where(e=> e.IsLastStep == null).ToList();

                firstquery.ForEach(t => {

                    t.Code = context.Profiles.Where(p => p.Id == t.ProfileId).Select(i => i.Code).SingleOrDefault();
                    t.FatherName = context.Profiles.Where(p => p.Id == t.ProfileId).Select(f => f.FatherName).SingleOrDefault();
                    t.Name = context.Profiles.Where(p => p.Id == t.ProfileId).Select(f => f.FirstName).SingleOrDefault();
                    t.LastName = context.Profiles.Where(p => p.Id == t.ProfileId).Select(f => f.LastName).SingleOrDefault();
                    t.ProfileId = context.Profiles.Where(p => p.Id == t.ProfileId).Select(f => f.Id).SingleOrDefault();
                    result.Add(t);

                   
                });
              //  firstquery.Where(e => e.IsLastStep == null).ToList();
            }
            return result;
            
        }
    }
}
