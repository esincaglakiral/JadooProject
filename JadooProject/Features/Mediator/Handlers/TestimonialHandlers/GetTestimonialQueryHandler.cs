using AutoMapper;
using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Queries.TestimonialQueries;
using JadooProject.Features.Mediator.Results.TestimonialResult;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly IMapper _mapper;
        private readonly JadooContext _context;

        public GetTestimonialQueryHandler(IMapper mapper, JadooContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Testimonials.ToListAsync();
            var mappedValue = _mapper.Map<List<GetTestimonialQueryResult>>(values);
            return mappedValue;
        }
    }
}
