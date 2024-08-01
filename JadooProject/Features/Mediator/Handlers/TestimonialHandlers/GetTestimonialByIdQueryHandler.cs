using AutoMapper;
using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Queries.TestimonialQueries;
using JadooProject.Features.Mediator.Results.ServiceResult;
using JadooProject.Features.Mediator.Results.TestimonialResult;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
    {
        private readonly IMapper _mapper;
        private readonly JadooContext _context;

        public GetTestimonialByIdQueryHandler(IMapper mapper, JadooContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Services.FindAsync(request.Id);
            return _mapper.Map<GetTestimonialByIdQueryResult>(value);
        }
    }
}
