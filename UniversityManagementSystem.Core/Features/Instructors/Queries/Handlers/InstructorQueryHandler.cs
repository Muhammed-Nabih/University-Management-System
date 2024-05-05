using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using UniversityManagementSystem.Core.Bases;
using UniversityManagementSystem.Core.Features.Instructors.Queries.Models;
using UniversityManagementSystem.Core.Resources;
using UniversityManagementSystem.Service.Abstracts;

namespace UniversityManagementSystem.Core.Features.Instructors.Queries.Handlers
{
    public class InstructorQueryHandler : ResponseHandler,
                   IRequestHandler<GetSummationSalaryOfInstructorQuery, Response<decimal>>
    {

        // Fileds
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        private readonly IInstructorService _instructorService;
        /*******************************************************************************************/
        // Constructors
        public InstructorQueryHandler(IStringLocalizer<SharedResources> stringLocalizer,
                                      IMapper mapper,
                                      IInstructorService instructorService) : base(stringLocalizer)
        {
            _mapper = mapper;
            _stringLocalizer = stringLocalizer;
            _instructorService = instructorService;
        }

        /*******************************************************************************************/
        // Handle Functions
        public async Task<Response<decimal>> Handle(GetSummationSalaryOfInstructorQuery request, CancellationToken cancellationToken)
        {
            var result = await _instructorService.GetSalarySummationOfInstructor();
            return Success(result);
        }
        /*******************************************************************************************/
    }
}
