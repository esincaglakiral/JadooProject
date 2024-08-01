using AutoMapper;
using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Queries.DestinationQueries;
using JadooProject.Features.Mediator.Queries.TestimonialQueries;
using JadooProject.Features.Mediator.Results.DestinationResults;
using JadooProject.Features.Mediator.Results.TestimonialResult;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialForDashboardQueryHandler : IRequestHandler<GetTestimonialDashboardQuery, List<GetTestimonialForDashboardQueryResult>>
    {
        private readonly JadooContext _jadooContext;
        private readonly IMapper _mapper;

        public GetTestimonialForDashboardQueryHandler(JadooContext jadooContext, IMapper mapper)
        {
            _jadooContext = jadooContext;
            _mapper = mapper;
        }

        public async Task<List<GetTestimonialForDashboardQueryResult>> Handle(GetTestimonialDashboardQuery request, CancellationToken cancellationToken)
        {
            var values = await _jadooContext.Testimonials.ToListAsync();
            var mappedValue = _mapper.Map<List<GetTestimonialForDashboardQueryResult>>(values);
            return mappedValue;
        }
    }
}
