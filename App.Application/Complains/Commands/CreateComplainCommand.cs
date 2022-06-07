using App.Application.Complains.Models.SearchModel;
using App.Application.Complains.Queries.SearchQueries;
using App.Persistence.Context;
using Clean.Common.Exceptions;
using Clean.Domain.Entity.prc;
using Clean.Persistence.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Application.Complains.Commands.CreateCommand
{
    public class CreateComplainCommand : IRequest<List<ComplainSearchModel>>
    {
        public int? Id { get; set; }
        public int ProfileId { get; set; }
        public int ComplainTypeId { get; set; }
        public int? UnitId { get; set; }
        public int? StatusId { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string? Phone { get; set; }
        public string Address { get; set; }
        public string Discription { get; set; }
        public int ModuleID { get; set;  }
    }

    public class CreateCaseCommandHandler : IRequestHandler<CreateComplainCommand, List<ComplainSearchModel>>
    {

        private readonly AppDbContext context;
        private readonly IMediator mediator;
        private readonly ICurrentUser currentUser;

        public CreateCaseCommandHandler(AppDbContext context, IMediator mediator, ICurrentUser currentUser)
        {
            this.context = context;
            this.mediator = mediator;
            this.currentUser = currentUser;

        }

        public async Task<List<ComplainSearchModel>> Handle(CreateComplainCommand request, CancellationToken cancellationToken)
        {
            // mobile number validation

            if (!string.IsNullOrEmpty(request.Phone))
            {
                bool mo = IsPhoneNumber(request.Phone.ToString());

                if (!mo)
                {
                    throw new BusinessRulesException("شماره  درست نیست! شماره با 07 شروع.باید 10 عدد باشد");
                }
            }

            IEnumerable<ComplainSearchModel> result = new List<ComplainSearchModel>();
            var caseregister = request.Id.HasValue? context.CaseRegister.Where(e => e.Id == request.Id).Single() : new Domain.Entity.Complains.Registeration();
            int CurrentUserId = await currentUser.GetUserId();


            caseregister.ComplainTypeId = request.ComplainTypeId;
            caseregister.UnitId = request.UnitId;
            caseregister.StatusId = 1;
            caseregister.Discription = request.Discription;
            caseregister.ProfileId = request.ProfileId;
            caseregister.Name = request.Name;
            caseregister.FatherName = request.FatherName;
            caseregister.Address = request.Address;
            caseregister.Phone = request.Phone;


            if (request.Id.HasValue)
            {
                
                caseregister.ComplainTypeId = request.ComplainTypeId;
                caseregister.UnitId = request.UnitId;
                caseregister.StatusId = 1;
                caseregister.Discription = request.Discription;
                caseregister.ProfileId = request.ProfileId;
                caseregister.Name = request.Name;
                caseregister.FatherName = request.FatherName;
                caseregister.Address = request.Address;
                caseregister.Phone = request.Phone;
                caseregister.ModifiedOn = DateTime.Now; ;
                caseregister.Modifiedby = "," + CurrentUserId;
                context.CaseRegister.Update(caseregister);

                await context.SaveChangesAsync();

            }
            else
            {

                caseregister.CreatedBy = (short)CurrentUserId;
                caseregister.CreatedOn = DateTime.Now;
                context.CaseRegister.Add(caseregister);

                await context.SaveChangesAsync();

               // var reg = context.CaseRegister.Where(e => e.ProfileId == request.ProfileId).Select(e => e.Id).SingleOrDefault();

                ProcessTracking track = new ProcessTracking()
                {

                    RecordId = caseregister.Id,
                    StatusId = 1,
                    ReferedProcessId = 0,
                    ProcessId = 60,
                    Remarks = "ثبت پذیریش",
                    CreatedOn = DateTime.Now,
                    UserId = CurrentUserId,
                    ModuleId = request.ModuleID
                };
                context.ProcessTracking.Add(track);
                await context.SaveChangesAsync();
            }
           

            result = await mediator.Send(new ComplainSearchQuery() { Id = caseregister.Id });

            return result.ToList();
        }

        public static bool IsPhoneNumber(string number)
        {

            return number[0] == '0' && number[1] == '7' && number.Length == 10 && IsDigit(number);

        }
        static bool IsDigit(string Input)
        {
            foreach (char c in Input)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}