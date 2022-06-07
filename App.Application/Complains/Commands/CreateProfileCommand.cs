using App.Application.Complains.Models;
using App.Application.Complains.Queries;
using App.Persistence.Context;
using Clean.Persistence.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Application.Complains.Commands
{
    public class CreateProfileCommand : IRequest<List<SearchProfileModel>>
    {
        public int? Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string LastName { get; set; }
    }
    public class CreateProfileCommandHandler : IRequestHandler<CreateProfileCommand, List<SearchProfileModel>>
    {

        private readonly AppDbContext context;
        private readonly IMediator mediator;

        public CreateProfileCommandHandler(AppDbContext context, IMediator mediator)
        {
            this.context = context;
            this.mediator = mediator;

        }

        public async Task<List<SearchProfileModel>> Handle(CreateProfileCommand request, CancellationToken cancellationToken)
        {
        IEnumerable<SearchProfileModel> result = new List<SearchProfileModel>();
        //    var profile = request.Id.HasValue ? context.Profiles.Where(e => e.Id == request.Id).Single() : new Domain.Entity.Complains.Profile();
        //    profile.Code = request.Code;
        //    profile.Name = request.Name;
        //    profile.LastName = request.LastName;
        //    profile.FatherName = request.FatherName;
        //    if (request.Id.HasValue)
        //    {
        //        profile.Code = request.Code;
        //        profile.Name = request.Name;
        //        profile.LastName = request.LastName;
        //        profile.FatherName = request.FatherName;
        //        context.Profiles.Update(profile);
        //    }
        //    else
        //    {

        //        context.Profiles.Add(profile);
        //    }
        //    await context.SaveChangesAsync();
        //    result = await mediator.Send(new ProfileSearchQuery() { Id = profile.Id });

         return result.ToList();
        }
    }
}