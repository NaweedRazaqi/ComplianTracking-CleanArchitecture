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
    public class ProfileSearchQuery : IRequest<List<SearchProfileModel>>
    {
        public int? Id { get; set; }
        public string Code { get; set; }
        public string AccountNumber { get; set; }
    }
    public class ProfileSearchQueryHandler : IRequestHandler<ProfileSearchQuery, List<SearchProfileModel>>
    {

        public PMSDbContext context;
        public ProfileSearchQueryHandler(PMSDbContext mContext)
        {
            context = mContext;
        }

        public async Task<List<SearchProfileModel>> Handle(ProfileSearchQuery request, CancellationToken cancellationToken)
        {
            List<SearchProfileModel> result = new List<SearchProfileModel>();
            var query = context.Profiles.AsQueryable();



            if (request.Id.HasValue)
            {
                result = await
            (from P in context.Profiles
             join A in context.BankAccount on P.Id equals A.ProfileId
             where P.Id == request.Id
             select
              new SearchProfileModel
              {
                  Id = P.Id,
                  FirstName = P.FirstName,
                  FatherName = P.FatherName,
                  LastName = P.LastName,
                  Code = P.Code,
                  AccountNumber = A.AccountNumber

              }).OrderBy(e => e.Id).ToListAsync();
            }
            else if (!string.IsNullOrEmpty(request.Code))
            {
                result = await
              (from P in context.Profiles
               join A in context.BankAccount on P.Id equals A.ProfileId
               where P.Code == request.Code
               select
                new SearchProfileModel
                {
                    Id = P.Id,
                    FirstName = P.FirstName,
                    FatherName = P.FatherName,
                    LastName = P.LastName,
                    Code = P.Code,
                    AccountNumber = A.AccountNumber

                }).OrderBy(e => e.Id).ToListAsync();
            }  
            
       else if (!string.IsNullOrEmpty(request.AccountNumber))
            {
                result = await
              (from P in context.Profiles
               join A in context.BankAccount on P.Id equals A.ProfileId
               where A.AccountNumber == request.AccountNumber
               select
                new SearchProfileModel
                   {
                       Id = P.Id,
                       FirstName = P.FirstName,
                       FatherName = P.FatherName,
                       LastName = P.LastName,
                       Code = P.Code,
                       AccountNumber = A.AccountNumber

                   }).OrderBy(e => e.Id).ToListAsync();

           
            }
            else
            {
                result = await 
               (from P in context.Profiles 
                    join A in context.BankAccount on P.Id equals A.ProfileId
                    where A.AccountNumber == request.AccountNumber
                    select
                    new SearchProfileModel
                  {
                Id = P.Id,
                FirstName = P.FirstName,
                FatherName = P.FatherName,
                LastName = P.LastName,
                Code = P.Code,
                AccountNumber = A.AccountNumber

            }).OrderBy(e=> e.Id).ToListAsync();
            }
            return result;
        }
    }
}

