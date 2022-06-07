using App.Application.Complains.Models.SearchModel;
using App.Persistence.Context;
using Clean.Common.Dates;
using Clean.Persistence.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Application.Complains.Queries.SearchQueries
{
    public class ComplainSearchQuery : IRequest<List<ComplainSearchModel>>
    {
        public int? Id { get; set; }
        public int? ComplainTypeId { get; set; }
        public int ProfileId { get; set; }
        public int? UnitId { get; set; }
        public int? StatusId { get; set; }
        public string Discription { get; set; }
    }
    public class GetCaseListQueryHandler : IRequestHandler<ComplainSearchQuery, List<ComplainSearchModel>>
    {

        private readonly PMSDbContext _context;
        private readonly AppDbContext _apcontext;
        UserManager<AppUser> _userManager;
       
        public GetCaseListQueryHandler(PMSDbContext context, UserManager<AppUser> userManager, AppDbContext apcontext)
        {
             _context = context;
            _userManager = userManager;
            _apcontext = apcontext;
        }
        public async Task<List<ComplainSearchModel>> Handle(ComplainSearchQuery request, CancellationToken cancellationToken)
        {
            List<ComplainSearchModel> result = new List<ComplainSearchModel>();
            var query = _apcontext.CaseRegister.AsQueryable();

            if (request.Id.HasValue)
            {
                query = query.Where(r => r.Id == request.Id);
            }
            if(request.ProfileId!= 0)
            {
                query = query.Where(r => r.ProfileId == request.ProfileId);
            }
                
           var  firstquery = query.Select(e => new ComplainSearchModel
         {
             Id = e.Id,
             Name = e.Name,
             FatherName = e.FatherName,
             ProfileId = e.ProfileId,
             Address = e.Address,
             Phone = e.Phone,
             ComplainTypeId = e.ComplainTypeId,
             UnitId = e.UnitId,
             StatusId = e.StatusId,
             Discription = e.Discription,
             CaseText = e.ComplainType.Name,
             UnitText = e.Unit.Name,
             StatusText = e.Status.Name,
             CreatedOn = e.CreatedOn,
             CreatedBy = e.CreatedBy,
             CreatedOnShamsi = PersianDate.GetFormatedString(e.CreatedOn),
             UserName = _userManager.FindByIdAsync(e.CreatedBy.ToString()).Result.FirstName + " " +" " + _userManager.FindByIdAsync(e.CreatedBy.ToString()).Result.LastName,
             Processtime = (int)_apcontext.ComplainTypes.Where(c => c.Id == e.ComplainTypeId).Select(c => c.ProcessTime).Single(),
         }).ToList();

            firstquery.ForEach(e =>
            {
                 e.PensionerCode = _context.Profiles.Where(p => p.Id == e.ProfileId).Select(p => p.Code).SingleOrDefault();
                result.Add(e);
            });
            return result;
        }
    }
}
